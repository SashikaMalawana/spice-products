namespace Itp.MainFunctions.Employee
{
    partial class EmployeeForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeForm));
            this.materialTabSelector1 = new MaterialSkin.Controls.MaterialTabSelector();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.tabEmpDetails = new System.Windows.Forms.TabPage();
            this.edLabelGetGender = new System.Windows.Forms.Label();
            this.edLabelGetBirthday = new System.Windows.Forms.Label();
            this.edLabelGetAddress = new System.Windows.Forms.Label();
            this.edLabelGetPhone = new System.Windows.Forms.Label();
            this.edLabelGetPosition = new System.Windows.Forms.Label();
            this.edLabelGetLname = new System.Windows.Forms.Label();
            this.edLabelGetFname = new System.Windows.Forms.Label();
            this.edLabelGetNic = new System.Windows.Forms.Label();
            this.edLabelGetCardid = new System.Windows.Forms.Label();
            this.edTextBoxSearchLname = new System.Windows.Forms.TextBox();
            this.edLabelSearchLname = new System.Windows.Forms.Label();
            this.edLabelSearchFname = new System.Windows.Forms.Label();
            this.edLabelSearchCardid = new System.Windows.Forms.Label();
            this.edTextBoxSearchCardid = new System.Windows.Forms.TextBox();
            this.edTextBoxSearchFname = new System.Windows.Forms.TextBox();
            this.edDataGridViewTable = new System.Windows.Forms.DataGridView();
            this.edColumnEmpDetailsCardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsNic = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edColumnEmpDetailsGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.edGroupBoxChangebleDetails = new System.Windows.Forms.GroupBox();
            this.edLabelCardid = new System.Windows.Forms.Label();
            this.edLabelShowCardid = new System.Windows.Forms.Label();
            this.edPanelButtons = new System.Windows.Forms.Panel();
            this.edButtonClear = new System.Windows.Forms.Button();
            this.edButtonDelete = new System.Windows.Forms.Button();
            this.edButtonUpdate = new System.Windows.Forms.Button();
            this.edTextBoxChangePhone = new System.Windows.Forms.TextBox();
            this.edLabelChangePhone = new System.Windows.Forms.Label();
            this.edTextBoxChangeAddress = new System.Windows.Forms.TextBox();
            this.edLabelChangeAddress = new System.Windows.Forms.Label();
            this.edComboBoxChangePosition = new System.Windows.Forms.ComboBox();
            this.edLabelChangePosition = new System.Windows.Forms.Label();
            this.tabRecordAttendance = new System.Windows.Forms.TabPage();
            this.raPanelClearButton = new System.Windows.Forms.Panel();
            this.raButtonClear = new System.Windows.Forms.Button();
            this.raPictureBox = new System.Windows.Forms.PictureBox();
            this.raGroupBoxEmpPhoto = new System.Windows.Forms.GroupBox();
            this.raPictureBoxEmpPhoto = new System.Windows.Forms.PictureBox();
            this.raGroupBoxAttendanceCheck = new System.Windows.Forms.GroupBox();
            this.raTextBoxOutTime = new System.Windows.Forms.TextBox();
            this.raLabelOutTime = new System.Windows.Forms.Label();
            this.raTextBoxInTime = new System.Windows.Forms.TextBox();
            this.raLabelInTime = new System.Windows.Forms.Label();
            this.raTextBoxLname = new System.Windows.Forms.TextBox();
            this.raLabelCardid = new System.Windows.Forms.Label();
            this.raLabelLname = new System.Windows.Forms.Label();
            this.raTextBoxFname = new System.Windows.Forms.TextBox();
            this.raTextBoxCardid = new System.Windows.Forms.TextBox();
            this.raLabelFname = new System.Windows.Forms.Label();
            this.raMonthCalendar = new System.Windows.Forms.MonthCalendar();
            this.tabAttendanceDetails = new System.Windows.Forms.TabPage();
            this.adPanelUpdateButton = new System.Windows.Forms.Panel();
            this.adButtonUpdate = new System.Windows.Forms.Button();
            this.adGroupBoxAttendanceDetails = new System.Windows.Forms.GroupBox();
            this.adDataGridViewAttendanceDetails = new System.Windows.Forms.DataGridView();
            this.adColumn1Cardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adColumn1Fname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adColumn1Position = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adColumn1DaysAttended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabSalaryCalculation = new System.Windows.Forms.TabPage();
            this.scPanelButtons = new System.Windows.Forms.Panel();
            this.scButtonCalculateSalary = new System.Windows.Forms.Button();
            this.scButtonPrintReport = new System.Windows.Forms.Button();
            this.scButtonClear = new System.Windows.Forms.Button();
            this.scGroupBoxEmpDetails = new System.Windows.Forms.GroupBox();
            this.scDataGridViewTableEmpDetails = new System.Windows.Forms.DataGridView();
            this.scColumnEmployeeId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scColumnFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scColumnLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scColumnPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scGroupBoxSalaryDetails = new System.Windows.Forms.GroupBox();
            this.scDataGridViewTableSalary = new System.Windows.Forms.DataGridView();
            this.scColumnEmpId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scColumnRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scColumnDaysAttended = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scColumnSalary = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.scGroupBoxCalculateSalary = new System.Windows.Forms.GroupBox();
            this.scTextBoxInsertRate = new System.Windows.Forms.TextBox();
            this.scTextBoxInsertLname = new System.Windows.Forms.TextBox();
            this.scTextBoxInsertFname = new System.Windows.Forms.TextBox();
            this.scLabelRate = new System.Windows.Forms.Label();
            this.scLabelLname = new System.Windows.Forms.Label();
            this.scTextBoxInsertid = new System.Windows.Forms.TextBox();
            this.scLabelFname = new System.Windows.Forms.Label();
            this.scLabelInsertid = new System.Windows.Forms.Label();
            this.tabDeletedEmp = new System.Windows.Forms.TabPage();
            this.deLabelGetGender = new System.Windows.Forms.Label();
            this.deLabelGetBirthday = new System.Windows.Forms.Label();
            this.deLabelGetAddress = new System.Windows.Forms.Label();
            this.deLabelGetPhone = new System.Windows.Forms.Label();
            this.deLabelGetPosition = new System.Windows.Forms.Label();
            this.deLabelGetLname = new System.Windows.Forms.Label();
            this.deLabelGetFname = new System.Windows.Forms.Label();
            this.deLabelGetNic = new System.Windows.Forms.Label();
            this.deLabelGetCardid = new System.Windows.Forms.Label();
            this.deLabelSearchCardid = new System.Windows.Forms.Label();
            this.deTextBoxSearchCardid = new System.Windows.Forms.TextBox();
            this.delPanelButton = new System.Windows.Forms.Panel();
            this.deButtonAddEmpAgain = new System.Windows.Forms.Button();
            this.deDataGridViewDelEmpTable = new System.Windows.Forms.DataGridView();
            this.delColumnEmpDetailsCardid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpNIC = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpFname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpLname = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpPosition = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpPhone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpBirthday = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.delColumnDelEmpGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabAddEmp = new System.Windows.Forms.TabPage();
            this.erButtonLoadImage = new System.Windows.Forms.Button();
            this.erPictureBox = new System.Windows.Forms.PictureBox();
            this.erPanelButtons = new System.Windows.Forms.Panel();
            this.erButtonAddEmp = new System.Windows.Forms.Button();
            this.erButtonClear = new System.Windows.Forms.Button();
            this.erGroupBoxSalaryRates = new System.Windows.Forms.GroupBox();
            this.erTextBoxAddRate = new System.Windows.Forms.TextBox();
            this.erLabelSalPerMonth = new System.Windows.Forms.Label();
            this.erGroupBoxContactDetails = new System.Windows.Forms.GroupBox();
            this.erTextBoxAddPhone = new System.Windows.Forms.TextBox();
            this.erTextBoxAddAddress = new System.Windows.Forms.TextBox();
            this.erLabelAddPhone = new System.Windows.Forms.Label();
            this.erLabelAddAddress = new System.Windows.Forms.Label();
            this.erGroupBoxGeneralDetails = new System.Windows.Forms.GroupBox();
            this.erTextBoxAddImagePath = new System.Windows.Forms.TextBox();
            this.erComboBoxAddPosition = new System.Windows.Forms.ComboBox();
            this.erRadioButtonAddFemale = new System.Windows.Forms.RadioButton();
            this.erRadioButtonAddMale = new System.Windows.Forms.RadioButton();
            this.erDatePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.erTextBoxAddCardid = new System.Windows.Forms.TextBox();
            this.erTextBoxAddNic = new System.Windows.Forms.TextBox();
            this.erTextBoxAddLname = new System.Windows.Forms.TextBox();
            this.erTextBoxAddFname = new System.Windows.Forms.TextBox();
            this.erLabelCardid = new System.Windows.Forms.Label();
            this.erLabelPosition = new System.Windows.Forms.Label();
            this.erLabelGender = new System.Windows.Forms.Label();
            this.erLabelBirthday = new System.Windows.Forms.Label();
            this.erLableNic = new System.Windows.Forms.Label();
            this.erLableLname = new System.Windows.Forms.Label();
            this.erLableFname = new System.Windows.Forms.Label();
            this.materialTabControl1.SuspendLayout();
            this.tabEmpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDataGridViewTable)).BeginInit();
            this.edGroupBoxChangebleDetails.SuspendLayout();
            this.edPanelButtons.SuspendLayout();
            this.tabRecordAttendance.SuspendLayout();
            this.raPanelClearButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raPictureBox)).BeginInit();
            this.raGroupBoxEmpPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.raPictureBoxEmpPhoto)).BeginInit();
            this.raGroupBoxAttendanceCheck.SuspendLayout();
            this.tabAttendanceDetails.SuspendLayout();
            this.adPanelUpdateButton.SuspendLayout();
            this.adGroupBoxAttendanceDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.adDataGridViewAttendanceDetails)).BeginInit();
            this.tabSalaryCalculation.SuspendLayout();
            this.scPanelButtons.SuspendLayout();
            this.scGroupBoxEmpDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridViewTableEmpDetails)).BeginInit();
            this.scGroupBoxSalaryDetails.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridViewTableSalary)).BeginInit();
            this.scGroupBoxCalculateSalary.SuspendLayout();
            this.tabDeletedEmp.SuspendLayout();
            this.delPanelButton.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.deDataGridViewDelEmpTable)).BeginInit();
            this.tabAddEmp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.erPictureBox)).BeginInit();
            this.erPanelButtons.SuspendLayout();
            this.erGroupBoxSalaryRates.SuspendLayout();
            this.erGroupBoxContactDetails.SuspendLayout();
            this.erGroupBoxGeneralDetails.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabSelector1
            // 
            this.materialTabSelector1.BaseTabControl = this.materialTabControl1;
            this.materialTabSelector1.Depth = 0;
            this.materialTabSelector1.Dock = System.Windows.Forms.DockStyle.Top;
            this.materialTabSelector1.Location = new System.Drawing.Point(0, 0);
            this.materialTabSelector1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabSelector1.Name = "materialTabSelector1";
            this.materialTabSelector1.Size = new System.Drawing.Size(957, 35);
            this.materialTabSelector1.TabIndex = 11;
            this.materialTabSelector1.Text = "materialTabSelector1";
            this.materialTabSelector1.Click += new System.EventHandler(this.registerTab_Click);
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.tabRecordAttendance);
            this.materialTabControl1.Controls.Add(this.tabAttendanceDetails);
            this.materialTabControl1.Controls.Add(this.tabSalaryCalculation);
            this.materialTabControl1.Controls.Add(this.tabDeletedEmp);
            this.materialTabControl1.Controls.Add(this.tabAddEmp);
            this.materialTabControl1.Controls.Add(this.tabEmpDetails);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.ItemSize = new System.Drawing.Size(60, 30);
            this.materialTabControl1.Location = new System.Drawing.Point(0, 0);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(957, 588);
            this.materialTabControl1.TabIndex = 10;
            // 
            // tabEmpDetails
            // 
            this.tabEmpDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.tabEmpDetails.Controls.Add(this.edLabelGetGender);
            this.tabEmpDetails.Controls.Add(this.edLabelGetBirthday);
            this.tabEmpDetails.Controls.Add(this.edLabelGetAddress);
            this.tabEmpDetails.Controls.Add(this.edLabelGetPhone);
            this.tabEmpDetails.Controls.Add(this.edLabelGetPosition);
            this.tabEmpDetails.Controls.Add(this.edLabelGetLname);
            this.tabEmpDetails.Controls.Add(this.edLabelGetFname);
            this.tabEmpDetails.Controls.Add(this.edLabelGetNic);
            this.tabEmpDetails.Controls.Add(this.edLabelGetCardid);
            this.tabEmpDetails.Controls.Add(this.edTextBoxSearchLname);
            this.tabEmpDetails.Controls.Add(this.edLabelSearchLname);
            this.tabEmpDetails.Controls.Add(this.edLabelSearchFname);
            this.tabEmpDetails.Controls.Add(this.edLabelSearchCardid);
            this.tabEmpDetails.Controls.Add(this.edTextBoxSearchCardid);
            this.tabEmpDetails.Controls.Add(this.edTextBoxSearchFname);
            this.tabEmpDetails.Controls.Add(this.edDataGridViewTable);
            this.tabEmpDetails.Controls.Add(this.edGroupBoxChangebleDetails);
            this.tabEmpDetails.Location = new System.Drawing.Point(4, 34);
            this.tabEmpDetails.Name = "tabEmpDetails";
            this.tabEmpDetails.Padding = new System.Windows.Forms.Padding(3);
            this.tabEmpDetails.Size = new System.Drawing.Size(949, 550);
            this.tabEmpDetails.TabIndex = 1;
            this.tabEmpDetails.Text = "Employee Details";
            // 
            // edLabelGetGender
            // 
            this.edLabelGetGender.AutoSize = true;
            this.edLabelGetGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetGender.Location = new System.Drawing.Point(847, 469);
            this.edLabelGetGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetGender.Name = "edLabelGetGender";
            this.edLabelGetGender.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetGender.TabIndex = 34;
            this.edLabelGetGender.Text = "label9";
            // 
            // edLabelGetBirthday
            // 
            this.edLabelGetBirthday.AutoSize = true;
            this.edLabelGetBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetBirthday.Location = new System.Drawing.Point(847, 435);
            this.edLabelGetBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetBirthday.Name = "edLabelGetBirthday";
            this.edLabelGetBirthday.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetBirthday.TabIndex = 33;
            this.edLabelGetBirthday.Text = "label8";
            // 
            // edLabelGetAddress
            // 
            this.edLabelGetAddress.AutoSize = true;
            this.edLabelGetAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetAddress.Location = new System.Drawing.Point(847, 398);
            this.edLabelGetAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetAddress.Name = "edLabelGetAddress";
            this.edLabelGetAddress.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetAddress.TabIndex = 32;
            this.edLabelGetAddress.Text = "label7";
            // 
            // edLabelGetPhone
            // 
            this.edLabelGetPhone.AutoSize = true;
            this.edLabelGetPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetPhone.Location = new System.Drawing.Point(847, 367);
            this.edLabelGetPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetPhone.Name = "edLabelGetPhone";
            this.edLabelGetPhone.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetPhone.TabIndex = 31;
            this.edLabelGetPhone.Text = "label6";
            // 
            // edLabelGetPosition
            // 
            this.edLabelGetPosition.AutoSize = true;
            this.edLabelGetPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetPosition.Location = new System.Drawing.Point(847, 335);
            this.edLabelGetPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetPosition.Name = "edLabelGetPosition";
            this.edLabelGetPosition.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetPosition.TabIndex = 30;
            this.edLabelGetPosition.Text = "label5";
            // 
            // edLabelGetLname
            // 
            this.edLabelGetLname.AutoSize = true;
            this.edLabelGetLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetLname.Location = new System.Drawing.Point(847, 302);
            this.edLabelGetLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetLname.Name = "edLabelGetLname";
            this.edLabelGetLname.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetLname.TabIndex = 29;
            this.edLabelGetLname.Text = "label4";
            // 
            // edLabelGetFname
            // 
            this.edLabelGetFname.AutoSize = true;
            this.edLabelGetFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetFname.Location = new System.Drawing.Point(847, 271);
            this.edLabelGetFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetFname.Name = "edLabelGetFname";
            this.edLabelGetFname.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetFname.TabIndex = 28;
            this.edLabelGetFname.Text = "label3";
            // 
            // edLabelGetNic
            // 
            this.edLabelGetNic.AutoSize = true;
            this.edLabelGetNic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetNic.Location = new System.Drawing.Point(847, 235);
            this.edLabelGetNic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetNic.Name = "edLabelGetNic";
            this.edLabelGetNic.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetNic.TabIndex = 27;
            this.edLabelGetNic.Text = "label2";
            // 
            // edLabelGetCardid
            // 
            this.edLabelGetCardid.AutoSize = true;
            this.edLabelGetCardid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.edLabelGetCardid.Location = new System.Drawing.Point(847, 197);
            this.edLabelGetCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelGetCardid.Name = "edLabelGetCardid";
            this.edLabelGetCardid.Size = new System.Drawing.Size(35, 13);
            this.edLabelGetCardid.TabIndex = 26;
            this.edLabelGetCardid.Text = "label1";
            // 
            // edTextBoxSearchLname
            // 
            this.edTextBoxSearchLname.BackColor = System.Drawing.Color.Gainsboro;
            this.edTextBoxSearchLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edTextBoxSearchLname.Location = new System.Drawing.Point(691, 85);
            this.edTextBoxSearchLname.Margin = new System.Windows.Forms.Padding(2);
            this.edTextBoxSearchLname.Name = "edTextBoxSearchLname";
            this.edTextBoxSearchLname.Size = new System.Drawing.Size(120, 28);
            this.edTextBoxSearchLname.TabIndex = 25;
            this.edTextBoxSearchLname.TextChanged += new System.EventHandler(this.edTextBoxSearchLname_TextChanged);
            // 
            // edLabelSearchLname
            // 
            this.edLabelSearchLname.AutoSize = true;
            this.edLabelSearchLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelSearchLname.Location = new System.Drawing.Point(545, 90);
            this.edLabelSearchLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelSearchLname.Name = "edLabelSearchLname";
            this.edLabelSearchLname.Size = new System.Drawing.Size(149, 20);
            this.edLabelSearchLname.TabIndex = 24;
            this.edLabelSearchLname.Text = "Search Last Name :";
            // 
            // edLabelSearchFname
            // 
            this.edLabelSearchFname.AutoSize = true;
            this.edLabelSearchFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelSearchFname.Location = new System.Drawing.Point(269, 90);
            this.edLabelSearchFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelSearchFname.Name = "edLabelSearchFname";
            this.edLabelSearchFname.Size = new System.Drawing.Size(149, 20);
            this.edLabelSearchFname.TabIndex = 23;
            this.edLabelSearchFname.Text = "Search First Name :";
            // 
            // edLabelSearchCardid
            // 
            this.edLabelSearchCardid.AutoSize = true;
            this.edLabelSearchCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelSearchCardid.Location = new System.Drawing.Point(11, 89);
            this.edLabelSearchCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelSearchCardid.Name = "edLabelSearchCardid";
            this.edLabelSearchCardid.Size = new System.Drawing.Size(127, 20);
            this.edLabelSearchCardid.TabIndex = 22;
            this.edLabelSearchCardid.Text = "Search Card ID :";
            // 
            // edTextBoxSearchCardid
            // 
            this.edTextBoxSearchCardid.BackColor = System.Drawing.Color.Gainsboro;
            this.edTextBoxSearchCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edTextBoxSearchCardid.Location = new System.Drawing.Point(140, 85);
            this.edTextBoxSearchCardid.Margin = new System.Windows.Forms.Padding(2);
            this.edTextBoxSearchCardid.Name = "edTextBoxSearchCardid";
            this.edTextBoxSearchCardid.Size = new System.Drawing.Size(120, 28);
            this.edTextBoxSearchCardid.TabIndex = 5;
            this.edTextBoxSearchCardid.TextChanged += new System.EventHandler(this.edTextBoxSearchCardid_TextChanged);
            // 
            // edTextBoxSearchFname
            // 
            this.edTextBoxSearchFname.BackColor = System.Drawing.Color.Gainsboro;
            this.edTextBoxSearchFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edTextBoxSearchFname.Location = new System.Drawing.Point(428, 85);
            this.edTextBoxSearchFname.Margin = new System.Windows.Forms.Padding(2);
            this.edTextBoxSearchFname.Name = "edTextBoxSearchFname";
            this.edTextBoxSearchFname.Size = new System.Drawing.Size(117, 28);
            this.edTextBoxSearchFname.TabIndex = 4;
            this.edTextBoxSearchFname.TextChanged += new System.EventHandler(this.edTextBoxSearchFname_TextChanged);
            // 
            // edDataGridViewTable
            // 
            this.edDataGridViewTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.edDataGridViewTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.edDataGridViewTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.edColumnEmpDetailsCardid,
            this.edColumnEmpDetailsNic,
            this.edColumnEmpDetailsFname,
            this.edColumnEmpDetailsLname,
            this.edColumnEmpDetailsPosition,
            this.edColumnEmpDetailsPhone,
            this.edColumnEmpDetailsAddress,
            this.edColumnEmpDetailsBirthday,
            this.edColumnEmpDetailsGender});
            this.edDataGridViewTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.edDataGridViewTable.Location = new System.Drawing.Point(15, 301);
            this.edDataGridViewTable.Margin = new System.Windows.Forms.Padding(2);
            this.edDataGridViewTable.Name = "edDataGridViewTable";
            this.edDataGridViewTable.RowTemplate.Height = 24;
            this.edDataGridViewTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.edDataGridViewTable.Size = new System.Drawing.Size(792, 244);
            this.edDataGridViewTable.TabIndex = 2;
            this.edDataGridViewTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.edDataGridViewTable_CellClick);
            // 
            // edColumnEmpDetailsCardid
            // 
            this.edColumnEmpDetailsCardid.HeaderText = "Card ID";
            this.edColumnEmpDetailsCardid.Name = "edColumnEmpDetailsCardid";
            // 
            // edColumnEmpDetailsNic
            // 
            this.edColumnEmpDetailsNic.HeaderText = "NIC";
            this.edColumnEmpDetailsNic.Name = "edColumnEmpDetailsNic";
            // 
            // edColumnEmpDetailsFname
            // 
            this.edColumnEmpDetailsFname.HeaderText = "First Name";
            this.edColumnEmpDetailsFname.Name = "edColumnEmpDetailsFname";
            // 
            // edColumnEmpDetailsLname
            // 
            this.edColumnEmpDetailsLname.HeaderText = "Last Name";
            this.edColumnEmpDetailsLname.Name = "edColumnEmpDetailsLname";
            // 
            // edColumnEmpDetailsPosition
            // 
            this.edColumnEmpDetailsPosition.HeaderText = "Position";
            this.edColumnEmpDetailsPosition.Name = "edColumnEmpDetailsPosition";
            // 
            // edColumnEmpDetailsPhone
            // 
            this.edColumnEmpDetailsPhone.HeaderText = "Phone";
            this.edColumnEmpDetailsPhone.Name = "edColumnEmpDetailsPhone";
            // 
            // edColumnEmpDetailsAddress
            // 
            this.edColumnEmpDetailsAddress.HeaderText = "Address";
            this.edColumnEmpDetailsAddress.Name = "edColumnEmpDetailsAddress";
            // 
            // edColumnEmpDetailsBirthday
            // 
            this.edColumnEmpDetailsBirthday.HeaderText = "Birthday";
            this.edColumnEmpDetailsBirthday.Name = "edColumnEmpDetailsBirthday";
            // 
            // edColumnEmpDetailsGender
            // 
            this.edColumnEmpDetailsGender.HeaderText = "Gender";
            this.edColumnEmpDetailsGender.Name = "edColumnEmpDetailsGender";
            // 
            // edGroupBoxChangebleDetails
            // 
            this.edGroupBoxChangebleDetails.Controls.Add(this.edLabelCardid);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edLabelShowCardid);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edPanelButtons);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edTextBoxChangePhone);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edLabelChangePhone);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edTextBoxChangeAddress);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edLabelChangeAddress);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edComboBoxChangePosition);
            this.edGroupBoxChangebleDetails.Controls.Add(this.edLabelChangePosition);
            this.edGroupBoxChangebleDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edGroupBoxChangebleDetails.Location = new System.Drawing.Point(15, 126);
            this.edGroupBoxChangebleDetails.Margin = new System.Windows.Forms.Padding(2);
            this.edGroupBoxChangebleDetails.Name = "edGroupBoxChangebleDetails";
            this.edGroupBoxChangebleDetails.Padding = new System.Windows.Forms.Padding(2);
            this.edGroupBoxChangebleDetails.Size = new System.Drawing.Size(792, 167);
            this.edGroupBoxChangebleDetails.TabIndex = 1;
            this.edGroupBoxChangebleDetails.TabStop = false;
            this.edGroupBoxChangebleDetails.Text = "Changable Details";
            // 
            // edLabelCardid
            // 
            this.edLabelCardid.AutoSize = true;
            this.edLabelCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelCardid.Location = new System.Drawing.Point(86, 39);
            this.edLabelCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelCardid.Name = "edLabelCardid";
            this.edLabelCardid.Size = new System.Drawing.Size(0, 20);
            this.edLabelCardid.TabIndex = 23;
            // 
            // edLabelShowCardid
            // 
            this.edLabelShowCardid.AutoSize = true;
            this.edLabelShowCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelShowCardid.ForeColor = System.Drawing.SystemColors.ControlText;
            this.edLabelShowCardid.Location = new System.Drawing.Point(14, 39);
            this.edLabelShowCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelShowCardid.Name = "edLabelShowCardid";
            this.edLabelShowCardid.Size = new System.Drawing.Size(72, 20);
            this.edLabelShowCardid.TabIndex = 22;
            this.edLabelShowCardid.Text = "Card ID :";
            // 
            // edPanelButtons
            // 
            this.edPanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.edPanelButtons.Controls.Add(this.edButtonClear);
            this.edPanelButtons.Controls.Add(this.edButtonDelete);
            this.edPanelButtons.Controls.Add(this.edButtonUpdate);
            this.edPanelButtons.Location = new System.Drawing.Point(369, 84);
            this.edPanelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.edPanelButtons.Name = "edPanelButtons";
            this.edPanelButtons.Size = new System.Drawing.Size(394, 63);
            this.edPanelButtons.TabIndex = 21;
            // 
            // edButtonClear
            // 
            this.edButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("edButtonClear.Image")));
            this.edButtonClear.Location = new System.Drawing.Point(272, 11);
            this.edButtonClear.Margin = new System.Windows.Forms.Padding(2);
            this.edButtonClear.Name = "edButtonClear";
            this.edButtonClear.Size = new System.Drawing.Size(104, 40);
            this.edButtonClear.TabIndex = 2;
            this.edButtonClear.Text = "Clear";
            this.edButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edButtonClear.UseVisualStyleBackColor = true;
            this.edButtonClear.Click += new System.EventHandler(this.edButtonClear_Click);
            // 
            // edButtonDelete
            // 
            this.edButtonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edButtonDelete.Image = ((System.Drawing.Image)(resources.GetObject("edButtonDelete.Image")));
            this.edButtonDelete.Location = new System.Drawing.Point(147, 11);
            this.edButtonDelete.Margin = new System.Windows.Forms.Padding(2);
            this.edButtonDelete.Name = "edButtonDelete";
            this.edButtonDelete.Size = new System.Drawing.Size(104, 40);
            this.edButtonDelete.TabIndex = 1;
            this.edButtonDelete.Text = "Delete";
            this.edButtonDelete.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edButtonDelete.UseVisualStyleBackColor = true;
            this.edButtonDelete.Click += new System.EventHandler(this.edButtonDelete_Click);
            // 
            // edButtonUpdate
            // 
            this.edButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("edButtonUpdate.Image")));
            this.edButtonUpdate.Location = new System.Drawing.Point(13, 11);
            this.edButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.edButtonUpdate.Name = "edButtonUpdate";
            this.edButtonUpdate.Size = new System.Drawing.Size(104, 40);
            this.edButtonUpdate.TabIndex = 0;
            this.edButtonUpdate.Text = "Update";
            this.edButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.edButtonUpdate.UseVisualStyleBackColor = true;
            this.edButtonUpdate.Click += new System.EventHandler(this.edButtonUpdate_Click);
            // 
            // edTextBoxChangePhone
            // 
            this.edTextBoxChangePhone.BackColor = System.Drawing.Color.Gainsboro;
            this.edTextBoxChangePhone.Location = new System.Drawing.Point(88, 124);
            this.edTextBoxChangePhone.Margin = new System.Windows.Forms.Padding(2);
            this.edTextBoxChangePhone.Name = "edTextBoxChangePhone";
            this.edTextBoxChangePhone.Size = new System.Drawing.Size(193, 26);
            this.edTextBoxChangePhone.TabIndex = 20;
            this.edTextBoxChangePhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edLabelChangePhone
            // 
            this.edLabelChangePhone.AutoSize = true;
            this.edLabelChangePhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelChangePhone.Location = new System.Drawing.Point(23, 127);
            this.edLabelChangePhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelChangePhone.Name = "edLabelChangePhone";
            this.edLabelChangePhone.Size = new System.Drawing.Size(63, 20);
            this.edLabelChangePhone.TabIndex = 19;
            this.edLabelChangePhone.Text = "Phone :";
            // 
            // edTextBoxChangeAddress
            // 
            this.edTextBoxChangeAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.edTextBoxChangeAddress.Location = new System.Drawing.Point(508, 32);
            this.edTextBoxChangeAddress.Margin = new System.Windows.Forms.Padding(2);
            this.edTextBoxChangeAddress.Name = "edTextBoxChangeAddress";
            this.edTextBoxChangeAddress.Size = new System.Drawing.Size(193, 26);
            this.edTextBoxChangeAddress.TabIndex = 18;
            this.edTextBoxChangeAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // edLabelChangeAddress
            // 
            this.edLabelChangeAddress.AutoSize = true;
            this.edLabelChangeAddress.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelChangeAddress.Location = new System.Drawing.Point(432, 34);
            this.edLabelChangeAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelChangeAddress.Name = "edLabelChangeAddress";
            this.edLabelChangeAddress.Size = new System.Drawing.Size(76, 20);
            this.edLabelChangeAddress.TabIndex = 17;
            this.edLabelChangeAddress.Text = "Address :";
            // 
            // edComboBoxChangePosition
            // 
            this.edComboBoxChangePosition.BackColor = System.Drawing.Color.Gainsboro;
            this.edComboBoxChangePosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.edComboBoxChangePosition.FormattingEnabled = true;
            this.edComboBoxChangePosition.Items.AddRange(new object[] {
            "Accountant",
            "Assistant Manager",
            "Cleaner",
            "Driver",
            "Item Packager",
            "Manager",
            "Mechanic"});
            this.edComboBoxChangePosition.Location = new System.Drawing.Point(88, 80);
            this.edComboBoxChangePosition.Margin = new System.Windows.Forms.Padding(2);
            this.edComboBoxChangePosition.Name = "edComboBoxChangePosition";
            this.edComboBoxChangePosition.Size = new System.Drawing.Size(193, 28);
            this.edComboBoxChangePosition.Sorted = true;
            this.edComboBoxChangePosition.TabIndex = 16;
            // 
            // edLabelChangePosition
            // 
            this.edLabelChangePosition.AutoSize = true;
            this.edLabelChangePosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.edLabelChangePosition.Location = new System.Drawing.Point(14, 83);
            this.edLabelChangePosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.edLabelChangePosition.Name = "edLabelChangePosition";
            this.edLabelChangePosition.Size = new System.Drawing.Size(73, 20);
            this.edLabelChangePosition.TabIndex = 6;
            this.edLabelChangePosition.Text = "Position :";
            // 
            // tabRecordAttendance
            // 
            this.tabRecordAttendance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.tabRecordAttendance.Controls.Add(this.raPanelClearButton);
            this.tabRecordAttendance.Controls.Add(this.raPictureBox);
            this.tabRecordAttendance.Controls.Add(this.raGroupBoxEmpPhoto);
            this.tabRecordAttendance.Controls.Add(this.raGroupBoxAttendanceCheck);
            this.tabRecordAttendance.Controls.Add(this.raMonthCalendar);
            this.tabRecordAttendance.Location = new System.Drawing.Point(4, 34);
            this.tabRecordAttendance.Margin = new System.Windows.Forms.Padding(2);
            this.tabRecordAttendance.Name = "tabRecordAttendance";
            this.tabRecordAttendance.Size = new System.Drawing.Size(949, 550);
            this.tabRecordAttendance.TabIndex = 2;
            this.tabRecordAttendance.Text = "Record Attendance";
            this.tabRecordAttendance.Click += new System.EventHandler(this.tabRecordAttendance_Click);
            // 
            // raPanelClearButton
            // 
            this.raPanelClearButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.raPanelClearButton.Controls.Add(this.raButtonClear);
            this.raPanelClearButton.Location = new System.Drawing.Point(141, 430);
            this.raPanelClearButton.Margin = new System.Windows.Forms.Padding(2);
            this.raPanelClearButton.Name = "raPanelClearButton";
            this.raPanelClearButton.Size = new System.Drawing.Size(113, 67);
            this.raPanelClearButton.TabIndex = 32;
            // 
            // raButtonClear
            // 
            this.raButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("raButtonClear.Image")));
            this.raButtonClear.Location = new System.Drawing.Point(12, 15);
            this.raButtonClear.Margin = new System.Windows.Forms.Padding(2);
            this.raButtonClear.Name = "raButtonClear";
            this.raButtonClear.Size = new System.Drawing.Size(88, 37);
            this.raButtonClear.TabIndex = 2;
            this.raButtonClear.Text = "Clear";
            this.raButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.raButtonClear.UseVisualStyleBackColor = true;
            // 
            // raPictureBox
            // 
            this.raPictureBox.Image = ((System.Drawing.Image)(resources.GetObject("raPictureBox.Image")));
            this.raPictureBox.Location = new System.Drawing.Point(399, 293);
            this.raPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.raPictureBox.Name = "raPictureBox";
            this.raPictureBox.Size = new System.Drawing.Size(543, 227);
            this.raPictureBox.TabIndex = 31;
            this.raPictureBox.TabStop = false;
            // 
            // raGroupBoxEmpPhoto
            // 
            this.raGroupBoxEmpPhoto.Controls.Add(this.raPictureBoxEmpPhoto);
            this.raGroupBoxEmpPhoto.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raGroupBoxEmpPhoto.Location = new System.Drawing.Point(392, 61);
            this.raGroupBoxEmpPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.raGroupBoxEmpPhoto.Name = "raGroupBoxEmpPhoto";
            this.raGroupBoxEmpPhoto.Padding = new System.Windows.Forms.Padding(2);
            this.raGroupBoxEmpPhoto.Size = new System.Drawing.Size(188, 214);
            this.raGroupBoxEmpPhoto.TabIndex = 29;
            this.raGroupBoxEmpPhoto.TabStop = false;
            this.raGroupBoxEmpPhoto.Text = "Employee Photo";
            // 
            // raPictureBoxEmpPhoto
            // 
            this.raPictureBoxEmpPhoto.Location = new System.Drawing.Point(20, 35);
            this.raPictureBoxEmpPhoto.Margin = new System.Windows.Forms.Padding(2);
            this.raPictureBoxEmpPhoto.Name = "raPictureBoxEmpPhoto";
            this.raPictureBoxEmpPhoto.Size = new System.Drawing.Size(150, 162);
            this.raPictureBoxEmpPhoto.TabIndex = 23;
            this.raPictureBoxEmpPhoto.TabStop = false;
            // 
            // raGroupBoxAttendanceCheck
            // 
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raTextBoxOutTime);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raLabelOutTime);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raTextBoxInTime);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raLabelInTime);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raTextBoxLname);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raLabelCardid);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raLabelLname);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raTextBoxFname);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raTextBoxCardid);
            this.raGroupBoxAttendanceCheck.Controls.Add(this.raLabelFname);
            this.raGroupBoxAttendanceCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raGroupBoxAttendanceCheck.Location = new System.Drawing.Point(28, 61);
            this.raGroupBoxAttendanceCheck.Margin = new System.Windows.Forms.Padding(2);
            this.raGroupBoxAttendanceCheck.Name = "raGroupBoxAttendanceCheck";
            this.raGroupBoxAttendanceCheck.Padding = new System.Windows.Forms.Padding(2);
            this.raGroupBoxAttendanceCheck.Size = new System.Drawing.Size(338, 348);
            this.raGroupBoxAttendanceCheck.TabIndex = 28;
            this.raGroupBoxAttendanceCheck.TabStop = false;
            this.raGroupBoxAttendanceCheck.Text = "Attendance Check";
            // 
            // raTextBoxOutTime
            // 
            this.raTextBoxOutTime.BackColor = System.Drawing.Color.Gainsboro;
            this.raTextBoxOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raTextBoxOutTime.Location = new System.Drawing.Point(104, 293);
            this.raTextBoxOutTime.Margin = new System.Windows.Forms.Padding(2);
            this.raTextBoxOutTime.Name = "raTextBoxOutTime";
            this.raTextBoxOutTime.Size = new System.Drawing.Size(203, 26);
            this.raTextBoxOutTime.TabIndex = 32;
            this.raTextBoxOutTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raLabelOutTime
            // 
            this.raLabelOutTime.AutoSize = true;
            this.raLabelOutTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raLabelOutTime.Location = new System.Drawing.Point(17, 296);
            this.raLabelOutTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raLabelOutTime.Name = "raLabelOutTime";
            this.raLabelOutTime.Size = new System.Drawing.Size(81, 20);
            this.raLabelOutTime.TabIndex = 31;
            this.raLabelOutTime.Text = "Out Time :";
            // 
            // raTextBoxInTime
            // 
            this.raTextBoxInTime.BackColor = System.Drawing.Color.Gainsboro;
            this.raTextBoxInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raTextBoxInTime.Location = new System.Drawing.Point(104, 248);
            this.raTextBoxInTime.Margin = new System.Windows.Forms.Padding(2);
            this.raTextBoxInTime.Name = "raTextBoxInTime";
            this.raTextBoxInTime.Size = new System.Drawing.Size(203, 26);
            this.raTextBoxInTime.TabIndex = 30;
            this.raTextBoxInTime.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raLabelInTime
            // 
            this.raLabelInTime.AutoSize = true;
            this.raLabelInTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raLabelInTime.Location = new System.Drawing.Point(29, 250);
            this.raLabelInTime.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raLabelInTime.Name = "raLabelInTime";
            this.raLabelInTime.Size = new System.Drawing.Size(69, 20);
            this.raLabelInTime.TabIndex = 29;
            this.raLabelInTime.Text = "In Time :";
            // 
            // raTextBoxLname
            // 
            this.raTextBoxLname.BackColor = System.Drawing.Color.Gainsboro;
            this.raTextBoxLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raTextBoxLname.Location = new System.Drawing.Point(104, 153);
            this.raTextBoxLname.Margin = new System.Windows.Forms.Padding(2);
            this.raTextBoxLname.Name = "raTextBoxLname";
            this.raTextBoxLname.Size = new System.Drawing.Size(203, 26);
            this.raTextBoxLname.TabIndex = 27;
            this.raTextBoxLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raLabelCardid
            // 
            this.raLabelCardid.AutoSize = true;
            this.raLabelCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raLabelCardid.Location = new System.Drawing.Point(32, 58);
            this.raLabelCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raLabelCardid.Name = "raLabelCardid";
            this.raLabelCardid.Size = new System.Drawing.Size(72, 20);
            this.raLabelCardid.TabIndex = 17;
            this.raLabelCardid.Text = "Card ID :";
            // 
            // raLabelLname
            // 
            this.raLabelLname.AutoSize = true;
            this.raLabelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raLabelLname.Location = new System.Drawing.Point(12, 155);
            this.raLabelLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raLabelLname.Name = "raLabelLname";
            this.raLabelLname.Size = new System.Drawing.Size(94, 20);
            this.raLabelLname.TabIndex = 26;
            this.raLabelLname.Text = "Last Name :";
            // 
            // raTextBoxFname
            // 
            this.raTextBoxFname.BackColor = System.Drawing.Color.Gainsboro;
            this.raTextBoxFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raTextBoxFname.Location = new System.Drawing.Point(104, 103);
            this.raTextBoxFname.Margin = new System.Windows.Forms.Padding(2);
            this.raTextBoxFname.Name = "raTextBoxFname";
            this.raTextBoxFname.Size = new System.Drawing.Size(203, 26);
            this.raTextBoxFname.TabIndex = 25;
            this.raTextBoxFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // raTextBoxCardid
            // 
            this.raTextBoxCardid.BackColor = System.Drawing.Color.Gainsboro;
            this.raTextBoxCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raTextBoxCardid.Location = new System.Drawing.Point(104, 56);
            this.raTextBoxCardid.Margin = new System.Windows.Forms.Padding(2);
            this.raTextBoxCardid.Name = "raTextBoxCardid";
            this.raTextBoxCardid.Size = new System.Drawing.Size(203, 26);
            this.raTextBoxCardid.TabIndex = 19;
            this.raTextBoxCardid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.raTextBoxCardid.TextChanged += new System.EventHandler(this.raTextBoxCardid_TextChanged);
            // 
            // raLabelFname
            // 
            this.raLabelFname.AutoSize = true;
            this.raLabelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raLabelFname.Location = new System.Drawing.Point(12, 106);
            this.raLabelFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.raLabelFname.Name = "raLabelFname";
            this.raLabelFname.Size = new System.Drawing.Size(94, 20);
            this.raLabelFname.TabIndex = 24;
            this.raLabelFname.Text = "First Name :";
            // 
            // raMonthCalendar
            // 
            this.raMonthCalendar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.raMonthCalendar.Location = new System.Drawing.Point(589, 69);
            this.raMonthCalendar.Margin = new System.Windows.Forms.Padding(7);
            this.raMonthCalendar.Name = "raMonthCalendar";
            this.raMonthCalendar.TabIndex = 0;
            // 
            // tabAttendanceDetails
            // 
            this.tabAttendanceDetails.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.tabAttendanceDetails.Controls.Add(this.adPanelUpdateButton);
            this.tabAttendanceDetails.Controls.Add(this.adGroupBoxAttendanceDetails);
            this.tabAttendanceDetails.Location = new System.Drawing.Point(4, 34);
            this.tabAttendanceDetails.Margin = new System.Windows.Forms.Padding(2);
            this.tabAttendanceDetails.Name = "tabAttendanceDetails";
            this.tabAttendanceDetails.Size = new System.Drawing.Size(949, 550);
            this.tabAttendanceDetails.TabIndex = 3;
            this.tabAttendanceDetails.Text = "Attendance Details";
            // 
            // adPanelUpdateButton
            // 
            this.adPanelUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.adPanelUpdateButton.Controls.Add(this.adButtonUpdate);
            this.adPanelUpdateButton.Location = new System.Drawing.Point(323, 456);
            this.adPanelUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.adPanelUpdateButton.Name = "adPanelUpdateButton";
            this.adPanelUpdateButton.Size = new System.Drawing.Size(143, 74);
            this.adPanelUpdateButton.TabIndex = 2;
            // 
            // adButtonUpdate
            // 
            this.adButtonUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adButtonUpdate.Image = ((System.Drawing.Image)(resources.GetObject("adButtonUpdate.Image")));
            this.adButtonUpdate.Location = new System.Drawing.Point(21, 18);
            this.adButtonUpdate.Margin = new System.Windows.Forms.Padding(2);
            this.adButtonUpdate.Name = "adButtonUpdate";
            this.adButtonUpdate.Size = new System.Drawing.Size(104, 40);
            this.adButtonUpdate.TabIndex = 1;
            this.adButtonUpdate.Text = "Update";
            this.adButtonUpdate.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.adButtonUpdate.UseVisualStyleBackColor = true;
            // 
            // adGroupBoxAttendanceDetails
            // 
            this.adGroupBoxAttendanceDetails.Controls.Add(this.adDataGridViewAttendanceDetails);
            this.adGroupBoxAttendanceDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adGroupBoxAttendanceDetails.Location = new System.Drawing.Point(32, 77);
            this.adGroupBoxAttendanceDetails.Margin = new System.Windows.Forms.Padding(2);
            this.adGroupBoxAttendanceDetails.Name = "adGroupBoxAttendanceDetails";
            this.adGroupBoxAttendanceDetails.Padding = new System.Windows.Forms.Padding(2);
            this.adGroupBoxAttendanceDetails.Size = new System.Drawing.Size(755, 343);
            this.adGroupBoxAttendanceDetails.TabIndex = 0;
            this.adGroupBoxAttendanceDetails.TabStop = false;
            this.adGroupBoxAttendanceDetails.Text = "Employee Details";
            // 
            // adDataGridViewAttendanceDetails
            // 
            this.adDataGridViewAttendanceDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.adDataGridViewAttendanceDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.adDataGridViewAttendanceDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.adColumn1Cardid,
            this.adColumn1Fname,
            this.adColumn1Position,
            this.adColumn1DaysAttended});
            this.adDataGridViewAttendanceDetails.Location = new System.Drawing.Point(18, 36);
            this.adDataGridViewAttendanceDetails.Margin = new System.Windows.Forms.Padding(2);
            this.adDataGridViewAttendanceDetails.Name = "adDataGridViewAttendanceDetails";
            this.adDataGridViewAttendanceDetails.RowTemplate.Height = 24;
            this.adDataGridViewAttendanceDetails.Size = new System.Drawing.Size(724, 293);
            this.adDataGridViewAttendanceDetails.TabIndex = 0;
            // 
            // adColumn1Cardid
            // 
            this.adColumn1Cardid.HeaderText = "Card ID";
            this.adColumn1Cardid.Name = "adColumn1Cardid";
            // 
            // adColumn1Fname
            // 
            this.adColumn1Fname.HeaderText = "First Name";
            this.adColumn1Fname.Name = "adColumn1Fname";
            // 
            // adColumn1Position
            // 
            this.adColumn1Position.HeaderText = "Position";
            this.adColumn1Position.Name = "adColumn1Position";
            // 
            // adColumn1DaysAttended
            // 
            this.adColumn1DaysAttended.HeaderText = "Days Attended";
            this.adColumn1DaysAttended.Name = "adColumn1DaysAttended";
            // 
            // tabSalaryCalculation
            // 
            this.tabSalaryCalculation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.tabSalaryCalculation.Controls.Add(this.scPanelButtons);
            this.tabSalaryCalculation.Controls.Add(this.scGroupBoxEmpDetails);
            this.tabSalaryCalculation.Controls.Add(this.scGroupBoxSalaryDetails);
            this.tabSalaryCalculation.Controls.Add(this.scGroupBoxCalculateSalary);
            this.tabSalaryCalculation.Location = new System.Drawing.Point(4, 34);
            this.tabSalaryCalculation.Margin = new System.Windows.Forms.Padding(2);
            this.tabSalaryCalculation.Name = "tabSalaryCalculation";
            this.tabSalaryCalculation.Size = new System.Drawing.Size(949, 550);
            this.tabSalaryCalculation.TabIndex = 4;
            this.tabSalaryCalculation.Text = "Salary Calculation";
            this.tabSalaryCalculation.Click += new System.EventHandler(this.tabSalaryCalculation_Click);
            // 
            // scPanelButtons
            // 
            this.scPanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.scPanelButtons.Controls.Add(this.scButtonCalculateSalary);
            this.scPanelButtons.Controls.Add(this.scButtonPrintReport);
            this.scPanelButtons.Controls.Add(this.scButtonClear);
            this.scPanelButtons.Location = new System.Drawing.Point(275, 72);
            this.scPanelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.scPanelButtons.Name = "scPanelButtons";
            this.scPanelButtons.Size = new System.Drawing.Size(146, 202);
            this.scPanelButtons.TabIndex = 8;
            // 
            // scButtonCalculateSalary
            // 
            this.scButtonCalculateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scButtonCalculateSalary.Image = ((System.Drawing.Image)(resources.GetObject("scButtonCalculateSalary.Image")));
            this.scButtonCalculateSalary.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scButtonCalculateSalary.Location = new System.Drawing.Point(14, 72);
            this.scButtonCalculateSalary.Margin = new System.Windows.Forms.Padding(2);
            this.scButtonCalculateSalary.Name = "scButtonCalculateSalary";
            this.scButtonCalculateSalary.Size = new System.Drawing.Size(120, 48);
            this.scButtonCalculateSalary.TabIndex = 6;
            this.scButtonCalculateSalary.Text = "Calculate Salary";
            this.scButtonCalculateSalary.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scButtonCalculateSalary.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scButtonCalculateSalary.UseVisualStyleBackColor = true;
            // 
            // scButtonPrintReport
            // 
            this.scButtonPrintReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scButtonPrintReport.Image = ((System.Drawing.Image)(resources.GetObject("scButtonPrintReport.Image")));
            this.scButtonPrintReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scButtonPrintReport.Location = new System.Drawing.Point(14, 133);
            this.scButtonPrintReport.Margin = new System.Windows.Forms.Padding(2);
            this.scButtonPrintReport.Name = "scButtonPrintReport";
            this.scButtonPrintReport.Size = new System.Drawing.Size(120, 54);
            this.scButtonPrintReport.TabIndex = 7;
            this.scButtonPrintReport.Text = "Print Report";
            this.scButtonPrintReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scButtonPrintReport.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scButtonPrintReport.UseVisualStyleBackColor = true;
            // 
            // scButtonClear
            // 
            this.scButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("scButtonClear.Image")));
            this.scButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.scButtonClear.Location = new System.Drawing.Point(14, 16);
            this.scButtonClear.Margin = new System.Windows.Forms.Padding(2);
            this.scButtonClear.Name = "scButtonClear";
            this.scButtonClear.Size = new System.Drawing.Size(120, 41);
            this.scButtonClear.TabIndex = 5;
            this.scButtonClear.Text = "Clear";
            this.scButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.scButtonClear.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.scButtonClear.UseVisualStyleBackColor = true;
            // 
            // scGroupBoxEmpDetails
            // 
            this.scGroupBoxEmpDetails.Controls.Add(this.scDataGridViewTableEmpDetails);
            this.scGroupBoxEmpDetails.Location = new System.Drawing.Point(425, 62);
            this.scGroupBoxEmpDetails.Margin = new System.Windows.Forms.Padding(2);
            this.scGroupBoxEmpDetails.Name = "scGroupBoxEmpDetails";
            this.scGroupBoxEmpDetails.Padding = new System.Windows.Forms.Padding(2);
            this.scGroupBoxEmpDetails.Size = new System.Drawing.Size(377, 216);
            this.scGroupBoxEmpDetails.TabIndex = 4;
            this.scGroupBoxEmpDetails.TabStop = false;
            this.scGroupBoxEmpDetails.Text = "Employee Details";
            // 
            // scDataGridViewTableEmpDetails
            // 
            this.scDataGridViewTableEmpDetails.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scDataGridViewTableEmpDetails.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scDataGridViewTableEmpDetails.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scColumnEmployeeId,
            this.scColumnFname,
            this.scColumnLname,
            this.scColumnPosition});
            this.scDataGridViewTableEmpDetails.Location = new System.Drawing.Point(4, 17);
            this.scDataGridViewTableEmpDetails.Margin = new System.Windows.Forms.Padding(2);
            this.scDataGridViewTableEmpDetails.Name = "scDataGridViewTableEmpDetails";
            this.scDataGridViewTableEmpDetails.RowTemplate.Height = 24;
            this.scDataGridViewTableEmpDetails.Size = new System.Drawing.Size(368, 194);
            this.scDataGridViewTableEmpDetails.TabIndex = 0;
            // 
            // scColumnEmployeeId
            // 
            this.scColumnEmployeeId.HeaderText = "Employee ID";
            this.scColumnEmployeeId.Name = "scColumnEmployeeId";
            // 
            // scColumnFname
            // 
            this.scColumnFname.HeaderText = "First Name";
            this.scColumnFname.Name = "scColumnFname";
            // 
            // scColumnLname
            // 
            this.scColumnLname.HeaderText = "Last Name";
            this.scColumnLname.Name = "scColumnLname";
            // 
            // scColumnPosition
            // 
            this.scColumnPosition.HeaderText = "Position";
            this.scColumnPosition.Name = "scColumnPosition";
            // 
            // scGroupBoxSalaryDetails
            // 
            this.scGroupBoxSalaryDetails.Controls.Add(this.scDataGridViewTableSalary);
            this.scGroupBoxSalaryDetails.Location = new System.Drawing.Point(6, 283);
            this.scGroupBoxSalaryDetails.Margin = new System.Windows.Forms.Padding(2);
            this.scGroupBoxSalaryDetails.Name = "scGroupBoxSalaryDetails";
            this.scGroupBoxSalaryDetails.Padding = new System.Windows.Forms.Padding(2);
            this.scGroupBoxSalaryDetails.Size = new System.Drawing.Size(801, 240);
            this.scGroupBoxSalaryDetails.TabIndex = 3;
            this.scGroupBoxSalaryDetails.TabStop = false;
            this.scGroupBoxSalaryDetails.Text = "Salary Details";
            // 
            // scDataGridViewTableSalary
            // 
            this.scDataGridViewTableSalary.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.scDataGridViewTableSalary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.scDataGridViewTableSalary.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.scColumnEmpId,
            this.scColumnRate,
            this.scColumnDaysAttended,
            this.scColumnSalary});
            this.scDataGridViewTableSalary.Location = new System.Drawing.Point(4, 17);
            this.scDataGridViewTableSalary.Margin = new System.Windows.Forms.Padding(2);
            this.scDataGridViewTableSalary.Name = "scDataGridViewTableSalary";
            this.scDataGridViewTableSalary.RowTemplate.Height = 24;
            this.scDataGridViewTableSalary.Size = new System.Drawing.Size(792, 218);
            this.scDataGridViewTableSalary.TabIndex = 0;
            // 
            // scColumnEmpId
            // 
            this.scColumnEmpId.HeaderText = "Employee ID";
            this.scColumnEmpId.Name = "scColumnEmpId";
            // 
            // scColumnRate
            // 
            this.scColumnRate.HeaderText = "Rate";
            this.scColumnRate.Name = "scColumnRate";
            // 
            // scColumnDaysAttended
            // 
            this.scColumnDaysAttended.HeaderText = "Days Attended";
            this.scColumnDaysAttended.Name = "scColumnDaysAttended";
            // 
            // scColumnSalary
            // 
            this.scColumnSalary.HeaderText = "Salary";
            this.scColumnSalary.Name = "scColumnSalary";
            // 
            // scGroupBoxCalculateSalary
            // 
            this.scGroupBoxCalculateSalary.Controls.Add(this.scTextBoxInsertRate);
            this.scGroupBoxCalculateSalary.Controls.Add(this.scTextBoxInsertLname);
            this.scGroupBoxCalculateSalary.Controls.Add(this.scTextBoxInsertFname);
            this.scGroupBoxCalculateSalary.Controls.Add(this.scLabelRate);
            this.scGroupBoxCalculateSalary.Controls.Add(this.scLabelLname);
            this.scGroupBoxCalculateSalary.Controls.Add(this.scTextBoxInsertid);
            this.scGroupBoxCalculateSalary.Controls.Add(this.scLabelFname);
            this.scGroupBoxCalculateSalary.Controls.Add(this.scLabelInsertid);
            this.scGroupBoxCalculateSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scGroupBoxCalculateSalary.Location = new System.Drawing.Point(6, 62);
            this.scGroupBoxCalculateSalary.Margin = new System.Windows.Forms.Padding(2);
            this.scGroupBoxCalculateSalary.Name = "scGroupBoxCalculateSalary";
            this.scGroupBoxCalculateSalary.Padding = new System.Windows.Forms.Padding(2);
            this.scGroupBoxCalculateSalary.Size = new System.Drawing.Size(263, 216);
            this.scGroupBoxCalculateSalary.TabIndex = 2;
            this.scGroupBoxCalculateSalary.TabStop = false;
            // 
            // scTextBoxInsertRate
            // 
            this.scTextBoxInsertRate.BackColor = System.Drawing.Color.Gainsboro;
            this.scTextBoxInsertRate.Location = new System.Drawing.Point(117, 168);
            this.scTextBoxInsertRate.Margin = new System.Windows.Forms.Padding(2);
            this.scTextBoxInsertRate.Name = "scTextBoxInsertRate";
            this.scTextBoxInsertRate.Size = new System.Drawing.Size(138, 26);
            this.scTextBoxInsertRate.TabIndex = 13;
            this.scTextBoxInsertRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scTextBoxInsertLname
            // 
            this.scTextBoxInsertLname.BackColor = System.Drawing.Color.Gainsboro;
            this.scTextBoxInsertLname.Location = new System.Drawing.Point(117, 119);
            this.scTextBoxInsertLname.Margin = new System.Windows.Forms.Padding(2);
            this.scTextBoxInsertLname.Name = "scTextBoxInsertLname";
            this.scTextBoxInsertLname.Size = new System.Drawing.Size(138, 26);
            this.scTextBoxInsertLname.TabIndex = 12;
            this.scTextBoxInsertLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scTextBoxInsertFname
            // 
            this.scTextBoxInsertFname.BackColor = System.Drawing.Color.Gainsboro;
            this.scTextBoxInsertFname.Location = new System.Drawing.Point(117, 69);
            this.scTextBoxInsertFname.Margin = new System.Windows.Forms.Padding(2);
            this.scTextBoxInsertFname.Name = "scTextBoxInsertFname";
            this.scTextBoxInsertFname.Size = new System.Drawing.Size(138, 26);
            this.scTextBoxInsertFname.TabIndex = 11;
            this.scTextBoxInsertFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scLabelRate
            // 
            this.scLabelRate.AutoSize = true;
            this.scLabelRate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scLabelRate.Location = new System.Drawing.Point(4, 171);
            this.scLabelRate.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scLabelRate.Name = "scLabelRate";
            this.scLabelRate.Size = new System.Drawing.Size(119, 20);
            this.scLabelRate.TabIndex = 10;
            this.scLabelRate.Text = "Rate Per Hour :";
            // 
            // scLabelLname
            // 
            this.scLabelLname.AutoSize = true;
            this.scLabelLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scLabelLname.Location = new System.Drawing.Point(26, 122);
            this.scLabelLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scLabelLname.Name = "scLabelLname";
            this.scLabelLname.Size = new System.Drawing.Size(94, 20);
            this.scLabelLname.TabIndex = 9;
            this.scLabelLname.Text = "Last Name :";
            // 
            // scTextBoxInsertid
            // 
            this.scTextBoxInsertid.BackColor = System.Drawing.Color.Gainsboro;
            this.scTextBoxInsertid.Location = new System.Drawing.Point(117, 24);
            this.scTextBoxInsertid.Margin = new System.Windows.Forms.Padding(2);
            this.scTextBoxInsertid.Name = "scTextBoxInsertid";
            this.scTextBoxInsertid.Size = new System.Drawing.Size(138, 26);
            this.scTextBoxInsertid.TabIndex = 8;
            this.scTextBoxInsertid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // scLabelFname
            // 
            this.scLabelFname.AutoSize = true;
            this.scLabelFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scLabelFname.Location = new System.Drawing.Point(26, 73);
            this.scLabelFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scLabelFname.Name = "scLabelFname";
            this.scLabelFname.Size = new System.Drawing.Size(94, 20);
            this.scLabelFname.TabIndex = 6;
            this.scLabelFname.Text = "First Name :";
            // 
            // scLabelInsertid
            // 
            this.scLabelInsertid.AutoSize = true;
            this.scLabelInsertid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scLabelInsertid.Location = new System.Drawing.Point(81, 24);
            this.scLabelInsertid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.scLabelInsertid.Name = "scLabelInsertid";
            this.scLabelInsertid.Size = new System.Drawing.Size(34, 20);
            this.scLabelInsertid.TabIndex = 0;
            this.scLabelInsertid.Text = "ID :";
            // 
            // tabDeletedEmp
            // 
            this.tabDeletedEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.tabDeletedEmp.Controls.Add(this.deLabelGetGender);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetBirthday);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetAddress);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetPhone);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetPosition);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetLname);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetFname);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetNic);
            this.tabDeletedEmp.Controls.Add(this.deLabelGetCardid);
            this.tabDeletedEmp.Controls.Add(this.deLabelSearchCardid);
            this.tabDeletedEmp.Controls.Add(this.deTextBoxSearchCardid);
            this.tabDeletedEmp.Controls.Add(this.delPanelButton);
            this.tabDeletedEmp.Controls.Add(this.deDataGridViewDelEmpTable);
            this.tabDeletedEmp.Location = new System.Drawing.Point(4, 34);
            this.tabDeletedEmp.Margin = new System.Windows.Forms.Padding(2);
            this.tabDeletedEmp.Name = "tabDeletedEmp";
            this.tabDeletedEmp.Size = new System.Drawing.Size(949, 550);
            this.tabDeletedEmp.TabIndex = 5;
            this.tabDeletedEmp.Text = "Deleted Employees";
            // 
            // deLabelGetGender
            // 
            this.deLabelGetGender.AutoSize = true;
            this.deLabelGetGender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetGender.Location = new System.Drawing.Point(838, 412);
            this.deLabelGetGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetGender.Name = "deLabelGetGender";
            this.deLabelGetGender.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetGender.TabIndex = 43;
            this.deLabelGetGender.Text = "label9";
            // 
            // deLabelGetBirthday
            // 
            this.deLabelGetBirthday.AutoSize = true;
            this.deLabelGetBirthday.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetBirthday.Location = new System.Drawing.Point(838, 378);
            this.deLabelGetBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetBirthday.Name = "deLabelGetBirthday";
            this.deLabelGetBirthday.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetBirthday.TabIndex = 42;
            this.deLabelGetBirthday.Text = "label8";
            // 
            // deLabelGetAddress
            // 
            this.deLabelGetAddress.AutoSize = true;
            this.deLabelGetAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetAddress.Location = new System.Drawing.Point(838, 341);
            this.deLabelGetAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetAddress.Name = "deLabelGetAddress";
            this.deLabelGetAddress.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetAddress.TabIndex = 41;
            this.deLabelGetAddress.Text = "label7";
            // 
            // deLabelGetPhone
            // 
            this.deLabelGetPhone.AutoSize = true;
            this.deLabelGetPhone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetPhone.Location = new System.Drawing.Point(838, 310);
            this.deLabelGetPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetPhone.Name = "deLabelGetPhone";
            this.deLabelGetPhone.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetPhone.TabIndex = 40;
            this.deLabelGetPhone.Text = "label6";
            // 
            // deLabelGetPosition
            // 
            this.deLabelGetPosition.AutoSize = true;
            this.deLabelGetPosition.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetPosition.Location = new System.Drawing.Point(838, 278);
            this.deLabelGetPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetPosition.Name = "deLabelGetPosition";
            this.deLabelGetPosition.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetPosition.TabIndex = 39;
            this.deLabelGetPosition.Text = "label5";
            // 
            // deLabelGetLname
            // 
            this.deLabelGetLname.AutoSize = true;
            this.deLabelGetLname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetLname.Location = new System.Drawing.Point(838, 245);
            this.deLabelGetLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetLname.Name = "deLabelGetLname";
            this.deLabelGetLname.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetLname.TabIndex = 38;
            this.deLabelGetLname.Text = "label4";
            // 
            // deLabelGetFname
            // 
            this.deLabelGetFname.AutoSize = true;
            this.deLabelGetFname.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetFname.Location = new System.Drawing.Point(838, 214);
            this.deLabelGetFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetFname.Name = "deLabelGetFname";
            this.deLabelGetFname.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetFname.TabIndex = 37;
            this.deLabelGetFname.Text = "label3";
            // 
            // deLabelGetNic
            // 
            this.deLabelGetNic.AutoSize = true;
            this.deLabelGetNic.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetNic.Location = new System.Drawing.Point(838, 178);
            this.deLabelGetNic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetNic.Name = "deLabelGetNic";
            this.deLabelGetNic.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetNic.TabIndex = 36;
            this.deLabelGetNic.Text = "label2";
            // 
            // deLabelGetCardid
            // 
            this.deLabelGetCardid.AutoSize = true;
            this.deLabelGetCardid.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.deLabelGetCardid.Location = new System.Drawing.Point(838, 141);
            this.deLabelGetCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelGetCardid.Name = "deLabelGetCardid";
            this.deLabelGetCardid.Size = new System.Drawing.Size(35, 13);
            this.deLabelGetCardid.TabIndex = 35;
            this.deLabelGetCardid.Text = "label1";
            // 
            // deLabelSearchCardid
            // 
            this.deLabelSearchCardid.AutoSize = true;
            this.deLabelSearchCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deLabelSearchCardid.Location = new System.Drawing.Point(6, 73);
            this.deLabelSearchCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.deLabelSearchCardid.Name = "deLabelSearchCardid";
            this.deLabelSearchCardid.Size = new System.Drawing.Size(127, 20);
            this.deLabelSearchCardid.TabIndex = 24;
            this.deLabelSearchCardid.Text = "Search Card ID :";
            // 
            // deTextBoxSearchCardid
            // 
            this.deTextBoxSearchCardid.BackColor = System.Drawing.Color.Gainsboro;
            this.deTextBoxSearchCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deTextBoxSearchCardid.Location = new System.Drawing.Point(135, 70);
            this.deTextBoxSearchCardid.Margin = new System.Windows.Forms.Padding(2);
            this.deTextBoxSearchCardid.Name = "deTextBoxSearchCardid";
            this.deTextBoxSearchCardid.Size = new System.Drawing.Size(120, 28);
            this.deTextBoxSearchCardid.TabIndex = 23;
            this.deTextBoxSearchCardid.TextChanged += new System.EventHandler(this.deTextBoxSearchCardid_TextChanged);
            // 
            // delPanelButton
            // 
            this.delPanelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.delPanelButton.Controls.Add(this.deButtonAddEmpAgain);
            this.delPanelButton.Location = new System.Drawing.Point(267, 434);
            this.delPanelButton.Margin = new System.Windows.Forms.Padding(2);
            this.delPanelButton.Name = "delPanelButton";
            this.delPanelButton.Size = new System.Drawing.Size(236, 102);
            this.delPanelButton.TabIndex = 6;
            // 
            // deButtonAddEmpAgain
            // 
            this.deButtonAddEmpAgain.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deButtonAddEmpAgain.Image = ((System.Drawing.Image)(resources.GetObject("deButtonAddEmpAgain.Image")));
            this.deButtonAddEmpAgain.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deButtonAddEmpAgain.Location = new System.Drawing.Point(22, 36);
            this.deButtonAddEmpAgain.Margin = new System.Windows.Forms.Padding(2);
            this.deButtonAddEmpAgain.Name = "deButtonAddEmpAgain";
            this.deButtonAddEmpAgain.Size = new System.Drawing.Size(194, 33);
            this.deButtonAddEmpAgain.TabIndex = 4;
            this.deButtonAddEmpAgain.Text = "Add Employee Again";
            this.deButtonAddEmpAgain.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deButtonAddEmpAgain.UseVisualStyleBackColor = true;
            this.deButtonAddEmpAgain.Click += new System.EventHandler(this.deButtonAddEmpAgain_Click);
            // 
            // deDataGridViewDelEmpTable
            // 
            this.deDataGridViewDelEmpTable.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.deDataGridViewDelEmpTable.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.deDataGridViewDelEmpTable.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.delColumnEmpDetailsCardid,
            this.delColumnDelEmpNIC,
            this.delColumnDelEmpFname,
            this.delColumnDelEmpLname,
            this.delColumnDelEmpPosition,
            this.delColumnDelEmpPhone,
            this.delColumnDelEmpAddress,
            this.delColumnDelEmpBirthday,
            this.delColumnDelEmpGender});
            this.deDataGridViewDelEmpTable.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.deDataGridViewDelEmpTable.Location = new System.Drawing.Point(6, 131);
            this.deDataGridViewDelEmpTable.Margin = new System.Windows.Forms.Padding(2);
            this.deDataGridViewDelEmpTable.Name = "deDataGridViewDelEmpTable";
            this.deDataGridViewDelEmpTable.RowTemplate.Height = 24;
            this.deDataGridViewDelEmpTable.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.deDataGridViewDelEmpTable.Size = new System.Drawing.Size(792, 290);
            this.deDataGridViewDelEmpTable.TabIndex = 3;
            this.deDataGridViewDelEmpTable.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.deDataGridViewDelEmpTable_CellClick);
            // 
            // delColumnEmpDetailsCardid
            // 
            this.delColumnEmpDetailsCardid.HeaderText = "Card ID";
            this.delColumnEmpDetailsCardid.Name = "delColumnEmpDetailsCardid";
            // 
            // delColumnDelEmpNIC
            // 
            this.delColumnDelEmpNIC.HeaderText = "NIC";
            this.delColumnDelEmpNIC.Name = "delColumnDelEmpNIC";
            // 
            // delColumnDelEmpFname
            // 
            this.delColumnDelEmpFname.HeaderText = "First Name";
            this.delColumnDelEmpFname.Name = "delColumnDelEmpFname";
            // 
            // delColumnDelEmpLname
            // 
            this.delColumnDelEmpLname.HeaderText = "Last Name";
            this.delColumnDelEmpLname.Name = "delColumnDelEmpLname";
            // 
            // delColumnDelEmpPosition
            // 
            this.delColumnDelEmpPosition.HeaderText = "Position";
            this.delColumnDelEmpPosition.Name = "delColumnDelEmpPosition";
            // 
            // delColumnDelEmpPhone
            // 
            this.delColumnDelEmpPhone.HeaderText = "Phone";
            this.delColumnDelEmpPhone.Name = "delColumnDelEmpPhone";
            // 
            // delColumnDelEmpAddress
            // 
            this.delColumnDelEmpAddress.HeaderText = "Address";
            this.delColumnDelEmpAddress.Name = "delColumnDelEmpAddress";
            // 
            // delColumnDelEmpBirthday
            // 
            this.delColumnDelEmpBirthday.HeaderText = "Birthday";
            this.delColumnDelEmpBirthday.Name = "delColumnDelEmpBirthday";
            // 
            // delColumnDelEmpGender
            // 
            this.delColumnDelEmpGender.HeaderText = "Gender";
            this.delColumnDelEmpGender.Name = "delColumnDelEmpGender";
            // 
            // tabAddEmp
            // 
            this.tabAddEmp.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.tabAddEmp.Controls.Add(this.erButtonLoadImage);
            this.tabAddEmp.Controls.Add(this.erPictureBox);
            this.tabAddEmp.Controls.Add(this.erPanelButtons);
            this.tabAddEmp.Controls.Add(this.erGroupBoxSalaryRates);
            this.tabAddEmp.Controls.Add(this.erGroupBoxContactDetails);
            this.tabAddEmp.Controls.Add(this.erGroupBoxGeneralDetails);
            this.tabAddEmp.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.tabAddEmp.Location = new System.Drawing.Point(4, 34);
            this.tabAddEmp.Name = "tabAddEmp";
            this.tabAddEmp.Padding = new System.Windows.Forms.Padding(3);
            this.tabAddEmp.Size = new System.Drawing.Size(949, 550);
            this.tabAddEmp.TabIndex = 0;
            this.tabAddEmp.Text = "Employee Registraion";
            this.tabAddEmp.Click += new System.EventHandler(this.registerTab_Click);
            // 
            // erButtonLoadImage
            // 
            this.erButtonLoadImage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erButtonLoadImage.Image = ((System.Drawing.Image)(resources.GetObject("erButtonLoadImage.Image")));
            this.erButtonLoadImage.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.erButtonLoadImage.Location = new System.Drawing.Point(431, 479);
            this.erButtonLoadImage.Margin = new System.Windows.Forms.Padding(2);
            this.erButtonLoadImage.Name = "erButtonLoadImage";
            this.erButtonLoadImage.Size = new System.Drawing.Size(131, 33);
            this.erButtonLoadImage.TabIndex = 5;
            this.erButtonLoadImage.Text = "Load Image";
            this.erButtonLoadImage.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.erButtonLoadImage.UseVisualStyleBackColor = true;
            this.erButtonLoadImage.Click += new System.EventHandler(this.erButtonLoadImage_Click);
            // 
            // erPictureBox
            // 
            this.erPictureBox.Location = new System.Drawing.Point(423, 310);
            this.erPictureBox.Margin = new System.Windows.Forms.Padding(2);
            this.erPictureBox.Name = "erPictureBox";
            this.erPictureBox.Size = new System.Drawing.Size(150, 162);
            this.erPictureBox.TabIndex = 6;
            this.erPictureBox.TabStop = false;
            // 
            // erPanelButtons
            // 
            this.erPanelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(153)))), ((int)(((byte)(229)))), ((int)(((byte)(218)))));
            this.erPanelButtons.Controls.Add(this.erButtonAddEmp);
            this.erPanelButtons.Controls.Add(this.erButtonClear);
            this.erPanelButtons.Location = new System.Drawing.Point(590, 339);
            this.erPanelButtons.Margin = new System.Windows.Forms.Padding(2);
            this.erPanelButtons.Name = "erPanelButtons";
            this.erPanelButtons.Size = new System.Drawing.Size(201, 114);
            this.erPanelButtons.TabIndex = 5;
            // 
            // erButtonAddEmp
            // 
            this.erButtonAddEmp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erButtonAddEmp.Image = ((System.Drawing.Image)(resources.GetObject("erButtonAddEmp.Image")));
            this.erButtonAddEmp.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.erButtonAddEmp.Location = new System.Drawing.Point(10, 10);
            this.erButtonAddEmp.Margin = new System.Windows.Forms.Padding(2);
            this.erButtonAddEmp.Name = "erButtonAddEmp";
            this.erButtonAddEmp.Size = new System.Drawing.Size(180, 33);
            this.erButtonAddEmp.TabIndex = 3;
            this.erButtonAddEmp.Text = "Add New Employee";
            this.erButtonAddEmp.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.erButtonAddEmp.UseVisualStyleBackColor = true;
            this.erButtonAddEmp.Click += new System.EventHandler(this.erButtonAddEmp_Click);
            // 
            // erButtonClear
            // 
            this.erButtonClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erButtonClear.Image = ((System.Drawing.Image)(resources.GetObject("erButtonClear.Image")));
            this.erButtonClear.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.erButtonClear.Location = new System.Drawing.Point(56, 58);
            this.erButtonClear.Margin = new System.Windows.Forms.Padding(2);
            this.erButtonClear.Name = "erButtonClear";
            this.erButtonClear.Size = new System.Drawing.Size(88, 33);
            this.erButtonClear.TabIndex = 4;
            this.erButtonClear.Text = "Clear";
            this.erButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.erButtonClear.UseVisualStyleBackColor = true;
            this.erButtonClear.Click += new System.EventHandler(this.erButtonClear_Click);
            // 
            // erGroupBoxSalaryRates
            // 
            this.erGroupBoxSalaryRates.Controls.Add(this.erTextBoxAddRate);
            this.erGroupBoxSalaryRates.Controls.Add(this.erLabelSalPerMonth);
            this.erGroupBoxSalaryRates.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erGroupBoxSalaryRates.Location = new System.Drawing.Point(445, 207);
            this.erGroupBoxSalaryRates.Margin = new System.Windows.Forms.Padding(2);
            this.erGroupBoxSalaryRates.Name = "erGroupBoxSalaryRates";
            this.erGroupBoxSalaryRates.Padding = new System.Windows.Forms.Padding(2);
            this.erGroupBoxSalaryRates.Size = new System.Drawing.Size(346, 97);
            this.erGroupBoxSalaryRates.TabIndex = 2;
            this.erGroupBoxSalaryRates.TabStop = false;
            this.erGroupBoxSalaryRates.Text = "Salary Rates";
            // 
            // erTextBoxAddRate
            // 
            this.erTextBoxAddRate.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddRate.Location = new System.Drawing.Point(172, 41);
            this.erTextBoxAddRate.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddRate.Name = "erTextBoxAddRate";
            this.erTextBoxAddRate.Size = new System.Drawing.Size(162, 28);
            this.erTextBoxAddRate.TabIndex = 19;
            this.erTextBoxAddRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erLabelSalPerMonth
            // 
            this.erLabelSalPerMonth.AutoSize = true;
            this.erLabelSalPerMonth.Location = new System.Drawing.Point(13, 44);
            this.erLabelSalPerMonth.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLabelSalPerMonth.Name = "erLabelSalPerMonth";
            this.erLabelSalPerMonth.Size = new System.Drawing.Size(162, 24);
            this.erLabelSalPerMonth.TabIndex = 0;
            this.erLabelSalPerMonth.Text = "Salary per Month :";
            // 
            // erGroupBoxContactDetails
            // 
            this.erGroupBoxContactDetails.Controls.Add(this.erTextBoxAddPhone);
            this.erGroupBoxContactDetails.Controls.Add(this.erTextBoxAddAddress);
            this.erGroupBoxContactDetails.Controls.Add(this.erLabelAddPhone);
            this.erGroupBoxContactDetails.Controls.Add(this.erLabelAddAddress);
            this.erGroupBoxContactDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erGroupBoxContactDetails.Location = new System.Drawing.Point(445, 62);
            this.erGroupBoxContactDetails.Margin = new System.Windows.Forms.Padding(2);
            this.erGroupBoxContactDetails.Name = "erGroupBoxContactDetails";
            this.erGroupBoxContactDetails.Padding = new System.Windows.Forms.Padding(2);
            this.erGroupBoxContactDetails.Size = new System.Drawing.Size(346, 133);
            this.erGroupBoxContactDetails.TabIndex = 1;
            this.erGroupBoxContactDetails.TabStop = false;
            this.erGroupBoxContactDetails.Text = "Contact Details";
            // 
            // erTextBoxAddPhone
            // 
            this.erTextBoxAddPhone.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddPhone.Location = new System.Drawing.Point(122, 87);
            this.erTextBoxAddPhone.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddPhone.Name = "erTextBoxAddPhone";
            this.erTextBoxAddPhone.Size = new System.Drawing.Size(193, 28);
            this.erTextBoxAddPhone.TabIndex = 18;
            this.erTextBoxAddPhone.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erTextBoxAddAddress
            // 
            this.erTextBoxAddAddress.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddAddress.Location = new System.Drawing.Point(122, 37);
            this.erTextBoxAddAddress.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddAddress.Name = "erTextBoxAddAddress";
            this.erTextBoxAddAddress.Size = new System.Drawing.Size(193, 28);
            this.erTextBoxAddAddress.TabIndex = 17;
            this.erTextBoxAddAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erLabelAddPhone
            // 
            this.erLabelAddPhone.AutoSize = true;
            this.erLabelAddPhone.Location = new System.Drawing.Point(32, 89);
            this.erLabelAddPhone.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLabelAddPhone.Name = "erLabelAddPhone";
            this.erLabelAddPhone.Size = new System.Drawing.Size(76, 24);
            this.erLabelAddPhone.TabIndex = 1;
            this.erLabelAddPhone.Text = "Phone :";
            // 
            // erLabelAddAddress
            // 
            this.erLabelAddAddress.AutoSize = true;
            this.erLabelAddAddress.Location = new System.Drawing.Point(18, 41);
            this.erLabelAddAddress.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLabelAddAddress.Name = "erLabelAddAddress";
            this.erLabelAddAddress.Size = new System.Drawing.Size(90, 24);
            this.erLabelAddAddress.TabIndex = 0;
            this.erLabelAddAddress.Text = "Address :";
            // 
            // erGroupBoxGeneralDetails
            // 
            this.erGroupBoxGeneralDetails.Controls.Add(this.erTextBoxAddImagePath);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erComboBoxAddPosition);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erRadioButtonAddFemale);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erRadioButtonAddMale);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erDatePickerBirthday);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erTextBoxAddCardid);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erTextBoxAddNic);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erTextBoxAddLname);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erTextBoxAddFname);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erLabelCardid);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erLabelPosition);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erLabelGender);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erLabelBirthday);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erLableNic);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erLableLname);
            this.erGroupBoxGeneralDetails.Controls.Add(this.erLableFname);
            this.erGroupBoxGeneralDetails.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erGroupBoxGeneralDetails.Location = new System.Drawing.Point(48, 62);
            this.erGroupBoxGeneralDetails.Margin = new System.Windows.Forms.Padding(2);
            this.erGroupBoxGeneralDetails.Name = "erGroupBoxGeneralDetails";
            this.erGroupBoxGeneralDetails.Padding = new System.Windows.Forms.Padding(2);
            this.erGroupBoxGeneralDetails.Size = new System.Drawing.Size(358, 451);
            this.erGroupBoxGeneralDetails.TabIndex = 0;
            this.erGroupBoxGeneralDetails.TabStop = false;
            this.erGroupBoxGeneralDetails.Text = "General Details";
            // 
            // erTextBoxAddImagePath
            // 
            this.erTextBoxAddImagePath.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddImagePath.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erTextBoxAddImagePath.Location = new System.Drawing.Point(22, 402);
            this.erTextBoxAddImagePath.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddImagePath.Name = "erTextBoxAddImagePath";
            this.erTextBoxAddImagePath.Size = new System.Drawing.Size(312, 23);
            this.erTextBoxAddImagePath.TabIndex = 18;
            this.erTextBoxAddImagePath.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erComboBoxAddPosition
            // 
            this.erComboBoxAddPosition.BackColor = System.Drawing.Color.Gainsboro;
            this.erComboBoxAddPosition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.erComboBoxAddPosition.FormattingEnabled = true;
            this.erComboBoxAddPosition.Location = new System.Drawing.Point(131, 343);
            this.erComboBoxAddPosition.Margin = new System.Windows.Forms.Padding(2);
            this.erComboBoxAddPosition.Name = "erComboBoxAddPosition";
            this.erComboBoxAddPosition.Size = new System.Drawing.Size(193, 30);
            this.erComboBoxAddPosition.Sorted = true;
            this.erComboBoxAddPosition.TabIndex = 16;
            this.erComboBoxAddPosition.SelectedIndexChanged += new System.EventHandler(this.erComboBoxAddPosition_SelectedIndexChanged);
            // 
            // erRadioButtonAddFemale
            // 
            this.erRadioButtonAddFemale.AutoSize = true;
            this.erRadioButtonAddFemale.Location = new System.Drawing.Point(236, 295);
            this.erRadioButtonAddFemale.Margin = new System.Windows.Forms.Padding(2);
            this.erRadioButtonAddFemale.Name = "erRadioButtonAddFemale";
            this.erRadioButtonAddFemale.Size = new System.Drawing.Size(92, 28);
            this.erRadioButtonAddFemale.TabIndex = 15;
            this.erRadioButtonAddFemale.TabStop = true;
            this.erRadioButtonAddFemale.Text = "Female";
            this.erRadioButtonAddFemale.UseVisualStyleBackColor = true;
            this.erRadioButtonAddFemale.CheckedChanged += new System.EventHandler(this.erRadioButtonAddFemale_CheckedChanged);
            // 
            // erRadioButtonAddMale
            // 
            this.erRadioButtonAddMale.AutoSize = true;
            this.erRadioButtonAddMale.Location = new System.Drawing.Point(131, 295);
            this.erRadioButtonAddMale.Margin = new System.Windows.Forms.Padding(2);
            this.erRadioButtonAddMale.Name = "erRadioButtonAddMale";
            this.erRadioButtonAddMale.Size = new System.Drawing.Size(69, 28);
            this.erRadioButtonAddMale.TabIndex = 14;
            this.erRadioButtonAddMale.TabStop = true;
            this.erRadioButtonAddMale.Text = "Male";
            this.erRadioButtonAddMale.UseVisualStyleBackColor = true;
            this.erRadioButtonAddMale.CheckedChanged += new System.EventHandler(this.erRadioButtonAddMale_CheckedChanged);
            // 
            // erDatePickerBirthday
            // 
            this.erDatePickerBirthday.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erDatePickerBirthday.CalendarMonthBackground = System.Drawing.Color.Turquoise;
            this.erDatePickerBirthday.CalendarTitleBackColor = System.Drawing.Color.Gainsboro;
            this.erDatePickerBirthday.CustomFormat = "yyyy-MM-dd";
            this.erDatePickerBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erDatePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.erDatePickerBirthday.Location = new System.Drawing.Point(131, 252);
            this.erDatePickerBirthday.Margin = new System.Windows.Forms.Padding(2);
            this.erDatePickerBirthday.MaxDate = new System.DateTime(1996, 12, 31, 0, 0, 0, 0);
            this.erDatePickerBirthday.Name = "erDatePickerBirthday";
            this.erDatePickerBirthday.Size = new System.Drawing.Size(193, 21);
            this.erDatePickerBirthday.TabIndex = 13;
            this.erDatePickerBirthday.Value = new System.DateTime(1996, 12, 31, 0, 0, 0, 0);
            // 
            // erTextBoxAddCardid
            // 
            this.erTextBoxAddCardid.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddCardid.Location = new System.Drawing.Point(131, 42);
            this.erTextBoxAddCardid.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddCardid.Name = "erTextBoxAddCardid";
            this.erTextBoxAddCardid.Size = new System.Drawing.Size(193, 28);
            this.erTextBoxAddCardid.TabIndex = 12;
            this.erTextBoxAddCardid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erTextBoxAddNic
            // 
            this.erTextBoxAddNic.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddNic.Location = new System.Drawing.Point(131, 198);
            this.erTextBoxAddNic.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddNic.Name = "erTextBoxAddNic";
            this.erTextBoxAddNic.Size = new System.Drawing.Size(193, 28);
            this.erTextBoxAddNic.TabIndex = 11;
            this.erTextBoxAddNic.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erTextBoxAddLname
            // 
            this.erTextBoxAddLname.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddLname.Location = new System.Drawing.Point(131, 145);
            this.erTextBoxAddLname.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddLname.Name = "erTextBoxAddLname";
            this.erTextBoxAddLname.Size = new System.Drawing.Size(193, 28);
            this.erTextBoxAddLname.TabIndex = 10;
            this.erTextBoxAddLname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erTextBoxAddFname
            // 
            this.erTextBoxAddFname.BackColor = System.Drawing.Color.Gainsboro;
            this.erTextBoxAddFname.Location = new System.Drawing.Point(131, 91);
            this.erTextBoxAddFname.Margin = new System.Windows.Forms.Padding(2);
            this.erTextBoxAddFname.Name = "erTextBoxAddFname";
            this.erTextBoxAddFname.Size = new System.Drawing.Size(193, 28);
            this.erTextBoxAddFname.TabIndex = 9;
            this.erTextBoxAddFname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // erLabelCardid
            // 
            this.erLabelCardid.AutoSize = true;
            this.erLabelCardid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erLabelCardid.Location = new System.Drawing.Point(40, 47);
            this.erLabelCardid.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLabelCardid.Name = "erLabelCardid";
            this.erLabelCardid.Size = new System.Drawing.Size(72, 20);
            this.erLabelCardid.TabIndex = 7;
            this.erLabelCardid.Text = "Card ID :";
            // 
            // erLabelPosition
            // 
            this.erLabelPosition.AutoSize = true;
            this.erLabelPosition.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erLabelPosition.Location = new System.Drawing.Point(38, 349);
            this.erLabelPosition.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLabelPosition.Name = "erLabelPosition";
            this.erLabelPosition.Size = new System.Drawing.Size(73, 20);
            this.erLabelPosition.TabIndex = 6;
            this.erLabelPosition.Text = "Position :";
            // 
            // erLabelGender
            // 
            this.erLabelGender.AutoSize = true;
            this.erLabelGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erLabelGender.Location = new System.Drawing.Point(41, 298);
            this.erLabelGender.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLabelGender.Name = "erLabelGender";
            this.erLabelGender.Size = new System.Drawing.Size(71, 20);
            this.erLabelGender.TabIndex = 5;
            this.erLabelGender.Text = "Gender :";
            // 
            // erLabelBirthday
            // 
            this.erLabelBirthday.AutoSize = true;
            this.erLabelBirthday.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erLabelBirthday.Location = new System.Drawing.Point(37, 252);
            this.erLabelBirthday.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLabelBirthday.Name = "erLabelBirthday";
            this.erLabelBirthday.Size = new System.Drawing.Size(82, 20);
            this.erLabelBirthday.TabIndex = 4;
            this.erLabelBirthday.Text = "Birthdate :";
            // 
            // erLableNic
            // 
            this.erLableNic.AutoSize = true;
            this.erLableNic.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erLableNic.Location = new System.Drawing.Point(65, 204);
            this.erLableNic.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLableNic.Name = "erLableNic";
            this.erLableNic.Size = new System.Drawing.Size(44, 20);
            this.erLableNic.TabIndex = 3;
            this.erLableNic.Text = "NIC :";
            // 
            // erLableLname
            // 
            this.erLableLname.AutoSize = true;
            this.erLableLname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erLableLname.Location = new System.Drawing.Point(19, 150);
            this.erLableLname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLableLname.Name = "erLableLname";
            this.erLableLname.Size = new System.Drawing.Size(94, 20);
            this.erLableLname.TabIndex = 2;
            this.erLableLname.Text = "Last Name :";
            // 
            // erLableFname
            // 
            this.erLableFname.AutoSize = true;
            this.erLableFname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.erLableFname.Location = new System.Drawing.Point(19, 96);
            this.erLableFname.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.erLableFname.Name = "erLableFname";
            this.erLableFname.Size = new System.Drawing.Size(94, 20);
            this.erLableFname.TabIndex = 1;
            this.erLableFname.Text = "First Name :";
            // 
            // EmployeeForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(957, 588);
            this.Controls.Add(this.materialTabSelector1);
            this.Controls.Add(this.materialTabControl1);
            this.Name = "EmployeeForm";
            this.Text = "EmployeeForm";
            this.materialTabControl1.ResumeLayout(false);
            this.tabEmpDetails.ResumeLayout(false);
            this.tabEmpDetails.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.edDataGridViewTable)).EndInit();
            this.edGroupBoxChangebleDetails.ResumeLayout(false);
            this.edGroupBoxChangebleDetails.PerformLayout();
            this.edPanelButtons.ResumeLayout(false);
            this.tabRecordAttendance.ResumeLayout(false);
            this.raPanelClearButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raPictureBox)).EndInit();
            this.raGroupBoxEmpPhoto.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.raPictureBoxEmpPhoto)).EndInit();
            this.raGroupBoxAttendanceCheck.ResumeLayout(false);
            this.raGroupBoxAttendanceCheck.PerformLayout();
            this.tabAttendanceDetails.ResumeLayout(false);
            this.adPanelUpdateButton.ResumeLayout(false);
            this.adGroupBoxAttendanceDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.adDataGridViewAttendanceDetails)).EndInit();
            this.tabSalaryCalculation.ResumeLayout(false);
            this.scPanelButtons.ResumeLayout(false);
            this.scGroupBoxEmpDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridViewTableEmpDetails)).EndInit();
            this.scGroupBoxSalaryDetails.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.scDataGridViewTableSalary)).EndInit();
            this.scGroupBoxCalculateSalary.ResumeLayout(false);
            this.scGroupBoxCalculateSalary.PerformLayout();
            this.tabDeletedEmp.ResumeLayout(false);
            this.tabDeletedEmp.PerformLayout();
            this.delPanelButton.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.deDataGridViewDelEmpTable)).EndInit();
            this.tabAddEmp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.erPictureBox)).EndInit();
            this.erPanelButtons.ResumeLayout(false);
            this.erGroupBoxSalaryRates.ResumeLayout(false);
            this.erGroupBoxSalaryRates.PerformLayout();
            this.erGroupBoxContactDetails.ResumeLayout(false);
            this.erGroupBoxContactDetails.PerformLayout();
            this.erGroupBoxGeneralDetails.ResumeLayout(false);
            this.erGroupBoxGeneralDetails.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabSelector materialTabSelector1;
        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage tabAddEmp;
        private System.Windows.Forms.TabPage tabEmpDetails;
        private System.Windows.Forms.TabPage tabRecordAttendance;
        private System.Windows.Forms.GroupBox erGroupBoxSalaryRates;
        private System.Windows.Forms.GroupBox erGroupBoxContactDetails;
        private System.Windows.Forms.GroupBox erGroupBoxGeneralDetails;
        private System.Windows.Forms.TabPage tabAttendanceDetails;
        private System.Windows.Forms.TabPage tabSalaryCalculation;
        private System.Windows.Forms.Button erButtonAddEmp;
        private System.Windows.Forms.Label erLabelCardid;
        private System.Windows.Forms.Label erLabelPosition;
        private System.Windows.Forms.Label erLabelGender;
        private System.Windows.Forms.Label erLabelBirthday;
        private System.Windows.Forms.Label erLableNic;
        private System.Windows.Forms.Label erLableLname;
        private System.Windows.Forms.Label erLableFname;
        private System.Windows.Forms.TextBox erTextBoxAddFname;
        private System.Windows.Forms.DateTimePicker erDatePickerBirthday;
        private System.Windows.Forms.TextBox erTextBoxAddCardid;
        private System.Windows.Forms.TextBox erTextBoxAddNic;
        private System.Windows.Forms.TextBox erTextBoxAddLname;
        private System.Windows.Forms.ComboBox erComboBoxAddPosition;
        private System.Windows.Forms.RadioButton erRadioButtonAddFemale;
        private System.Windows.Forms.RadioButton erRadioButtonAddMale;
        private System.Windows.Forms.TextBox erTextBoxAddRate;
        private System.Windows.Forms.Label erLabelSalPerMonth;
        private System.Windows.Forms.TextBox erTextBoxAddPhone;
        private System.Windows.Forms.TextBox erTextBoxAddAddress;
        private System.Windows.Forms.Label erLabelAddPhone;
        private System.Windows.Forms.Label erLabelAddAddress;
        private System.Windows.Forms.Button erButtonClear;
        private System.Windows.Forms.GroupBox edGroupBoxChangebleDetails;
        private System.Windows.Forms.ComboBox edComboBoxChangePosition;
        private System.Windows.Forms.Label edLabelChangePosition;
        private System.Windows.Forms.Button edButtonClear;
        private System.Windows.Forms.Button edButtonDelete;
        private System.Windows.Forms.Button edButtonUpdate;
        private System.Windows.Forms.DataGridView edDataGridViewTable;
        private System.Windows.Forms.TextBox edTextBoxChangePhone;
        private System.Windows.Forms.Label edLabelChangePhone;
        private System.Windows.Forms.TextBox edTextBoxChangeAddress;
        private System.Windows.Forms.Label edLabelChangeAddress;
        private System.Windows.Forms.TextBox edTextBoxSearchFname;
        private System.Windows.Forms.GroupBox scGroupBoxEmpDetails;
        private System.Windows.Forms.DataGridView scDataGridViewTableEmpDetails;
        private System.Windows.Forms.GroupBox scGroupBoxSalaryDetails;
        private System.Windows.Forms.DataGridView scDataGridViewTableSalary;
        private System.Windows.Forms.GroupBox scGroupBoxCalculateSalary;
        private System.Windows.Forms.TextBox scTextBoxInsertRate;
        private System.Windows.Forms.TextBox scTextBoxInsertLname;
        private System.Windows.Forms.TextBox scTextBoxInsertFname;
        private System.Windows.Forms.Label scLabelRate;
        private System.Windows.Forms.Label scLabelLname;
        private System.Windows.Forms.TextBox scTextBoxInsertid;
        private System.Windows.Forms.Label scLabelFname;
        private System.Windows.Forms.Label scLabelInsertid;
        private System.Windows.Forms.Button scButtonPrintReport;
        private System.Windows.Forms.Button scButtonCalculateSalary;
        private System.Windows.Forms.Button scButtonClear;
        private System.Windows.Forms.MonthCalendar raMonthCalendar;
        private System.Windows.Forms.GroupBox raGroupBoxAttendanceCheck;
        private System.Windows.Forms.TextBox raTextBoxLname;
        private System.Windows.Forms.Label raLabelCardid;
        private System.Windows.Forms.Label raLabelLname;
        private System.Windows.Forms.TextBox raTextBoxFname;
        private System.Windows.Forms.TextBox raTextBoxCardid;
        private System.Windows.Forms.Label raLabelFname;
        private System.Windows.Forms.PictureBox raPictureBoxEmpPhoto;
        private System.Windows.Forms.GroupBox raGroupBoxEmpPhoto;
        private System.Windows.Forms.Button raButtonClear;
        private System.Windows.Forms.PictureBox raPictureBox;
        private System.Windows.Forms.GroupBox adGroupBoxAttendanceDetails;
        private System.Windows.Forms.DataGridView adDataGridViewAttendanceDetails;
        private System.Windows.Forms.Panel erPanelButtons;
        private System.Windows.Forms.Panel edPanelButtons;
        private System.Windows.Forms.Panel raPanelClearButton;
        private System.Windows.Forms.Panel adPanelUpdateButton;
        private System.Windows.Forms.Button adButtonUpdate;
        private System.Windows.Forms.Panel scPanelButtons;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnEmployeeId;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnPosition;
        private System.Windows.Forms.TextBox raTextBoxOutTime;
        private System.Windows.Forms.Label raLabelOutTime;
        private System.Windows.Forms.TextBox raTextBoxInTime;
        private System.Windows.Forms.Label raLabelInTime;
        private System.Windows.Forms.Label edLabelSearchLname;
        private System.Windows.Forms.Label edLabelSearchFname;
        private System.Windows.Forms.Label edLabelSearchCardid;
        private System.Windows.Forms.TextBox edTextBoxSearchCardid;
        private System.Windows.Forms.TextBox edTextBoxSearchLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsCardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsNic;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn edColumnEmpDetailsGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn1Cardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn1Fname;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn1Position;
        private System.Windows.Forms.DataGridViewTextBoxColumn adColumn1DaysAttended;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnEmpId;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnDaysAttended;
        private System.Windows.Forms.DataGridViewTextBoxColumn scColumnSalary;
        private System.Windows.Forms.Label edLabelCardid;
        private System.Windows.Forms.Label edLabelShowCardid;
        private System.Windows.Forms.TabPage tabDeletedEmp;
        private System.Windows.Forms.Panel delPanelButton;
        private System.Windows.Forms.Button deButtonAddEmpAgain;
        private System.Windows.Forms.DataGridView deDataGridViewDelEmpTable;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnEmpDetailsCardid;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpNIC;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpFname;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpLname;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpPosition;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpPhone;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpBirthday;
        private System.Windows.Forms.DataGridViewTextBoxColumn delColumnDelEmpGender;
        private System.Windows.Forms.Label edLabelGetGender;
        private System.Windows.Forms.Label edLabelGetBirthday;
        private System.Windows.Forms.Label edLabelGetAddress;
        private System.Windows.Forms.Label edLabelGetPhone;
        private System.Windows.Forms.Label edLabelGetPosition;
        private System.Windows.Forms.Label edLabelGetLname;
        private System.Windows.Forms.Label edLabelGetFname;
        private System.Windows.Forms.Label edLabelGetNic;
        private System.Windows.Forms.Label edLabelGetCardid;
        private System.Windows.Forms.Label deLabelSearchCardid;
        private System.Windows.Forms.TextBox deTextBoxSearchCardid;
        private System.Windows.Forms.Label deLabelGetGender;
        private System.Windows.Forms.Label deLabelGetBirthday;
        private System.Windows.Forms.Label deLabelGetAddress;
        private System.Windows.Forms.Label deLabelGetPhone;
        private System.Windows.Forms.Label deLabelGetPosition;
        private System.Windows.Forms.Label deLabelGetLname;
        private System.Windows.Forms.Label deLabelGetFname;
        private System.Windows.Forms.Label deLabelGetNic;
        private System.Windows.Forms.Label deLabelGetCardid;
        private System.Windows.Forms.Button erButtonLoadImage;
        private System.Windows.Forms.PictureBox erPictureBox;
        private System.Windows.Forms.TextBox erTextBoxAddImagePath;
    }
}