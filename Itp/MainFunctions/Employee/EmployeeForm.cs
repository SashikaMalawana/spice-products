using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using System.Configuration;
using System.Data.SqlClient;
using System.IO;


namespace Itp.MainFunctions.Employee
{
    public partial class EmployeeForm : Form
    {
        public EmployeeForm()
        {
            InitializeComponent();

            //the line below loads the position names to combobox directly from db 
            new DBAccess().ComboBoxLoad("empPosition", erComboBoxAddPosition, "SELECT * FROM TableStdSalary");

            //the lines below set min max for datetime picker
            erDatePickerBirthday.MinDate = DateTime.Today.AddYears(-50);
            erDatePickerBirthday.MaxDate = DateTime.Today.AddYears(-18);

            EmpTableLoad();
            DeletedEmpTableLoad();

            var materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(Primary.Gray, Primary.Gray, Primary.Gray, Accent.WindowsBlue, TextShade.BLACK);
        }

        string Gender; //declare string to be used in insert query for radio button

        public void EmpTableLoad()
        {
            //load emp details table to data grid view 

            try
            {
                DBAccess empTableLoad = new DBAccess();

                DataSet ds = empTableLoad.tableLoad("SELECT * FROM TableEmpDetails");

                //rename the column names when loading the table
                ds.Tables["load"].Columns[0].ColumnName = "Card ID";
                ds.Tables["load"].Columns[1].ColumnName = "NIC";
                ds.Tables["load"].Columns[2].ColumnName = "First Name";
                ds.Tables["load"].Columns[3].ColumnName = "Surname";
                ds.Tables["load"].Columns[4].ColumnName = "Position";
                ds.Tables["load"].Columns[5].ColumnName = "Phone";
                ds.Tables["load"].Columns[6].ColumnName = "Address";
                ds.Tables["load"].Columns[7].ColumnName = "Date of Birth";
                ds.Tables["load"].Columns[8].ColumnName = "Sex";

                edDataGridViewTable.Columns.Clear(); //clears inicially added columns names
                edDataGridViewTable.DataSource = ds.Tables["load"].DefaultView;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        public void DeletedEmpTableLoad()
        {
            //load deleted emp details table to data grid view 

            try
            {
                DBAccess delEmpTableLoad = new DBAccess();

                DataSet ds = delEmpTableLoad.tableLoad("SELECT * FROM TableDeletedEmpDetails");

                //rename the column names when loading the table
                ds.Tables["load"].Columns[0].ColumnName = "Card ID";
                ds.Tables["load"].Columns[1].ColumnName = "NIC";
                ds.Tables["load"].Columns[2].ColumnName = "First Name";
                ds.Tables["load"].Columns[3].ColumnName = "Surname";
                ds.Tables["load"].Columns[4].ColumnName = "Position";
                ds.Tables["load"].Columns[5].ColumnName = "Phone";
                ds.Tables["load"].Columns[6].ColumnName = "Address";
                ds.Tables["load"].Columns[7].ColumnName = "Date of Birth";
                ds.Tables["load"].Columns[8].ColumnName = "Sex";

                deDataGridViewDelEmpTable.Columns.Clear(); //clears inicially added columns names
                deDataGridViewDelEmpTable.DataSource = ds.Tables["load"].DefaultView;
            }
            catch (Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
        }

        private void registerTab_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void tabSalaryCalculation_Click(object sender, EventArgs e)
        {

        }

        private void tabRecordAttendance_Click(object sender, EventArgs e)
        {

        }

        private void erButtonAddEmp_Click(object sender, EventArgs e)
        {
            //below is to get the image file path and convert it to binary

            byte[] imageByte = null;
            FileStream fileStream = new FileStream(erTextBoxAddImagePath.Text, FileMode.Open, FileAccess.Read);
            BinaryReader binaryReader = new BinaryReader(fileStream);
            imageByte = binaryReader.ReadBytes((int)fileStream.Length);

            //button click action to add emp details to table

            DBAccess addEmpAndImage = new DBAccess();

            string cid = erTextBoxAddCardid.Text;
            string nic = erTextBoxAddNic.Text;
            string fname = erTextBoxAddFname.Text;
            string lname = erTextBoxAddLname.Text;
            string position = erComboBoxAddPosition.Text;
            string phone = erTextBoxAddPhone.Text;
            string address = erTextBoxAddAddress.Text;
            string birthday = erDatePickerBirthday.Text;
            string salary = erTextBoxAddRate.Text;

            addEmpAndImage.insertImage("INSERT into TableEmpDetails(empCardid, empNIC, empFName, empLName, empPosition, empPhone, empAddress, empBirthday, empSex, empImage, empSalary)" +

                          "values('" + cid + "', '" + nic + "', '" + fname + "', '" + lname + "', '" + position + "', '" + phone + "', '" + address + "', '" + birthday + "', '" + Gender + "', @IMG, '"+ salary +"')", imageByte);

            MessageBox.Show("Employee Details Added");

            EmpTableLoad();

        }

        private void erComboBoxAddPosition_SelectedIndexChanged(object sender, EventArgs e)
        {
            //display salary in textbox when position is selected

            DBAccess displaysal = new DBAccess();

            erTextBoxAddRate.Text = displaysal.getString("SELECT empRate FROM TableStdSalary WHERE empPosition = '" + erComboBoxAddPosition.Text + "'");
        }

        private void erRadioButtonAddMale_CheckedChanged(object sender, EventArgs e)
        {
            //add name of radio button to gender as male
            Gender = "Male";
        }

        private void erRadioButtonAddFemale_CheckedChanged(object sender, EventArgs e)
        {
            //add name of radio button to gender as male
            Gender = "Female";
        }

        private void erButtonClear_Click(object sender, EventArgs e)
        {
            //clears details in add emp tab

            erTextBoxAddCardid.Text = "";
            erTextBoxAddNic.Text = "";
            erTextBoxAddFname.Text = "";
            erTextBoxAddLname.Text = "";
            erTextBoxAddRate.Text = "";
            erComboBoxAddPosition.SelectedIndex = -1;
            erTextBoxAddPhone.Text = "";
            erTextBoxAddAddress.Text = "";
            erRadioButtonAddFemale.Checked = false;
            erRadioButtonAddMale.Checked = false;
            erTextBoxAddImagePath.Text = "";
            erPictureBox.Image = null;
        }

        private void edButtonClear_Click(object sender, EventArgs e)
        {
            //clear textboxes in emp details tab

            edComboBoxChangePosition.SelectedIndex = -1;
            edTextBoxChangePhone.Text = "";
            edTextBoxChangeAddress.Text = "";
            edLabelCardid.Text = "";
        }

        private void edButtonUpdate_Click(object sender, EventArgs e)
        {
            //button click action to update emp details
            try
            {
                DBAccess updatemp = new DBAccess();

                string cardid = edLabelCardid.Text;
                string position = edComboBoxChangePosition.Text;
                string phone = edTextBoxChangePhone.Text;
                string address = edTextBoxChangeAddress.Text;

                updatemp.modify("UPDATE TableEmpDetails SET empPosition = '" + position + "', empPhone = " + phone + ", empAddress = '" + address + "' WHERE empCardid = " + cardid + " ");

                MessageBox.Show("Saved");

                EmpTableLoad();
            }
            catch(Exception e1)
            {
                MessageBox.Show(e1.ToString());
            }
         }


        private void edTextBoxSearchCardid_TextChanged(object sender, EventArgs e)
        {
            //search card id here in emp details table

            DBAccess empTableLoad = new DBAccess();

            DataSet ds = empTableLoad.tableLoad("SELECT * FROM TableEmpDetails WHERE empCardid LIKE '" + edTextBoxSearchCardid.Text + "%'");

            edDataGridViewTable.DataSource = ds.Tables["load"].DefaultView;
        }

        private void edTextBoxSearchFname_TextChanged(object sender, EventArgs e)
        {
            //search first name here in emp details table

            DBAccess empTableLoad = new DBAccess();

            DataSet ds = empTableLoad.tableLoad("SELECT * FROM TableEmpDetails WHERE empFName LIKE '" + edTextBoxSearchFname.Text + "%'");

            edDataGridViewTable.DataSource = ds.Tables["load"].DefaultView;
        }

        private void edTextBoxSearchLname_TextChanged(object sender, EventArgs e)
        {
            //search last name here in emp details table

            DBAccess empTableLoad = new DBAccess();

            DataSet ds = empTableLoad.tableLoad("SELECT * FROM TableEmpDetails WHERE empLName LIKE '" + edTextBoxSearchLname.Text + "%'");

            edDataGridViewTable.DataSource = ds.Tables["load"].DefaultView;
        }

        private void edDataGridViewTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //values are displayed in text boxes on button click on table row

            if (e.RowIndex >= 0)
            {
                //the below are to display values used for update button

                DataGridViewRow row = this.edDataGridViewTable.Rows[e.RowIndex];

                edLabelCardid.Text = row.Cells["Card ID"].Value.ToString();
                edComboBoxChangePosition.Text = row.Cells["Position"].Value.ToString();
                edTextBoxChangePhone.Text = row.Cells["Phone"].Value.ToString();
                edTextBoxChangeAddress.Text = row.Cells["Address"].Value.ToString();

                //the below are to display values on lables used for delete button
                
                edLabelGetCardid.Text = row.Cells["Card ID"].Value.ToString();
                edLabelGetNic.Text = row.Cells["NIC"].Value.ToString();
                edLabelGetFname.Text = row.Cells["First Name"].Value.ToString();
                edLabelGetLname.Text = row.Cells["Surname"].Value.ToString();
                edLabelGetPosition.Text = row.Cells["Position"].Value.ToString();
                edLabelGetPhone.Text = row.Cells["Phone"].Value.ToString();
                edLabelGetAddress.Text = row.Cells["Address"].Value.ToString();
                edLabelGetBirthday.Text = row.Cells["Date of Birth"].Value.ToString();
                edLabelGetGender.Text = row.Cells["Sex"].Value.ToString();
            }
        }

        private void edButtonDelete_Click(object sender, EventArgs e)
        {
            //button click action to deleted emp details from table and add them to deleted emp table

            DBAccess addEmpToDelTable = new DBAccess();
            DBAccess deleteEmp = new DBAccess();

            string cid = edLabelGetCardid.Text;
            string nic = edLabelGetNic.Text;
            string fname = edLabelGetFname.Text;
            string lname = edLabelGetLname.Text;
            string position = edLabelGetPosition.Text;
            string phone = edLabelGetPhone.Text;
            string address = edLabelGetAddress.Text;
            string birthday = edLabelGetBirthday.Text;
            string gender = edLabelGetGender.Text;

            addEmpToDelTable.modify("INSERT into TableDeletedEmpDetails(empCardid, empNIC, empFName, empLName, empPosition, empPhone, empAddress, empBirthday, empSex)" +

                          "values('" + cid + "', '" + nic + "', '" + fname + "', '" + lname + "', '" + position + "', '" + phone + "', '" + address + "', '" + birthday + "', '" + gender + "')");

            DeletedEmpTableLoad(); //refresh deleted emp table

            deleteEmp.modify("DELETE FROM TableEmpDetails WHERE empCardid = '" + cid +"'");

            EmpTableLoad(); //refresh emp table

            MessageBox.Show("Employee Deleted!");
        }

        private void deTextBoxSearchCardid_TextChanged(object sender, EventArgs e)
        {
            //search card id here in deleted emp details table

            DBAccess delEmpTableLoad = new DBAccess();

            DataSet ds = delEmpTableLoad.tableLoad("SELECT * FROM TableDeletedEmpDetails WHERE empCardid LIKE '" + deTextBoxSearchCardid.Text + "%'");

            deDataGridViewDelEmpTable.DataSource = ds.Tables["load"].DefaultView;
        }

        private void deButtonAddEmpAgain_Click(object sender, EventArgs e)
        {
            //button click event to add deleted emp back to current emp table

            DBAccess addEmpToEmpTable = new DBAccess();
            DBAccess deleteEmpFromTable = new DBAccess();

            string cid = deLabelGetCardid.Text;
            string nic = deLabelGetNic.Text;
            string fname = deLabelGetFname.Text;
            string lname = deLabelGetLname.Text;
            string position = deLabelGetPosition.Text;
            string phone = deLabelGetPhone.Text;
            string address = deLabelGetAddress.Text;
            string birthday = deLabelGetBirthday.Text;
            string gender = deLabelGetGender.Text;

            addEmpToEmpTable.modify("INSERT into TableEmpDetails(empCardid, empNIC, empFName, empLName, empPosition, empPhone, empAddress, empBirthday, empSex)" +

                          "values('" + cid + "', '" + nic + "', '" + fname + "', '" + lname + "', '" + position + "', '" + phone + "', '" + address + "', '" + birthday + "', '" + gender + "')");

            EmpTableLoad(); //refresh emp table

            deleteEmpFromTable.modify("DELETE FROM TableDeletedEmpDetails WHERE empCardid = '" + cid + "'");

            DeletedEmpTableLoad(); //refresh deleted emp table

            MessageBox.Show("Employee Added!");
        }

        private void deDataGridViewDelEmpTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = this.deDataGridViewDelEmpTable.Rows[e.RowIndex];

                //the below are to display values on lables used for add deleted emp again button

                deLabelGetCardid.Text = row.Cells["Card ID"].Value.ToString();
                deLabelGetNic.Text = row.Cells["NIC"].Value.ToString();
                deLabelGetFname.Text = row.Cells["First Name"].Value.ToString();
                deLabelGetLname.Text = row.Cells["Surname"].Value.ToString();
                deLabelGetPosition.Text = row.Cells["Position"].Value.ToString();
                deLabelGetPhone.Text = row.Cells["Phone"].Value.ToString();
                deLabelGetAddress.Text = row.Cells["Address"].Value.ToString();
                deLabelGetBirthday.Text = row.Cells["Date of Birth"].Value.ToString();
                deLabelGetGender.Text = row.Cells["Sex"].Value.ToString();
            }
        }

        private void erButtonLoadImage_Click(object sender, EventArgs e)
        {
            //open image picker to select image and load it to the picture box

            OpenFileDialog dialog = new OpenFileDialog();

            dialog.Filter = "JPG Files(*.jpg)|*.jpg|PNG Files(*.png)|*.png|All Files(*.*)|*.*";

            if(dialog.ShowDialog() == DialogResult.OK)
            {
                string picPath = dialog.FileName.ToString();
                erTextBoxAddImagePath.Text = picPath;
                erPictureBox.ImageLocation = picPath;
            }
        }

        private void raTextBoxCardid_TextChanged(object sender, EventArgs e)
        {
           //display first name and last name when cardid is inserted

            DBAccess displayFname = new DBAccess();
            DBAccess displayLname = new DBAccess();

            raTextBoxFname.Text = displayFname.getString("SELECT empFName FROM TableEmpDetails WHERE empCardid = '" + raTextBoxCardid.Text + "'");
            raTextBoxLname.Text = displayLname.getString("SELECT empFLame FROM TableEmpDetails WHERE empCardid = '" + raTextBoxCardid.Text + "'");

            DBAccess displayImage = new DBAccess();

            displayImage.getImage("SELECT empImage FROM TableEmpDetails WHERE empCardid = '"+ raTextBoxCardid.Text +"'", raPictureBoxEmpPhoto, "empImage");
        }
    }
}
