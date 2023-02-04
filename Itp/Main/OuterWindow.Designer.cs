namespace Itp.Main
{
    partial class OuterWindow
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OuterWindow));
            this.panelControlBar = new System.Windows.Forms.Panel();
            this.timeLabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.checkBoxRememberPassword = new System.Windows.Forms.CheckBox();
            this.textBoxPass = new System.Windows.Forms.TextBox();
            this.ButtonLogin = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label5 = new System.Windows.Forms.Label();
            this.textBoxUserName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.controlButton1 = new Itp.Gaphics.ControlButton();
            this.panelControlBar.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panelLogin.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControlBar
            // 
            this.panelControlBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(209)))), ((int)(((byte)(209)))), ((int)(((byte)(209)))));
            this.panelControlBar.Controls.Add(this.timeLabel);
            this.panelControlBar.Controls.Add(this.panel3);
            this.panelControlBar.Controls.Add(this.label1);
            this.panelControlBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControlBar.Location = new System.Drawing.Point(0, 0);
            this.panelControlBar.Name = "panelControlBar";
            this.panelControlBar.Size = new System.Drawing.Size(1350, 32);
            this.panelControlBar.TabIndex = 1;
            // 
            // timeLabel
            // 
            this.timeLabel.Dock = System.Windows.Forms.DockStyle.Right;
            this.timeLabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.DimGray;
            this.timeLabel.Location = new System.Drawing.Point(1021, 0);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.timeLabel.Size = new System.Drawing.Size(236, 32);
            this.timeLabel.TabIndex = 3;
            this.timeLabel.Text = "ITP System";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.button2);
            this.panel3.Controls.Add(this.controlButton1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel3.Location = new System.Drawing.Point(1257, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(93, 32);
            this.panel3.TabIndex = 2;
            // 
            // button2
            // 
            this.button2.Dock = System.Windows.Forms.DockStyle.Left;
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(167)))), ((int)(((byte)(170)))), ((int)(((byte)(181)))));
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(194)))), ((int)(((byte)(194)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button2.Image = ((System.Drawing.Image)(resources.GetObject("button2.Image")));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 32);
            this.button2.TabIndex = 4;
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(5, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(297, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mangala Products Management System";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel5);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 716);
            this.panel2.TabIndex = 2;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.panelLogin);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1350, 716);
            this.panel5.TabIndex = 1;
            // 
            // panelLogin
            // 
            this.panelLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.panelLogin.Controls.Add(this.panel6);
            this.panelLogin.Controls.Add(this.label4);
            this.panelLogin.Location = new System.Drawing.Point(468, 90);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(430, 561);
            this.panelLogin.TabIndex = 0;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.panel6.Controls.Add(this.checkBoxRememberPassword);
            this.panel6.Controls.Add(this.textBoxPass);
            this.panel6.Controls.Add(this.ButtonLogin);
            this.panel6.Controls.Add(this.label5);
            this.panel6.Controls.Add(this.textBoxUserName);
            this.panel6.Controls.Add(this.label3);
            this.panel6.Controls.Add(this.label2);
            this.panel6.Location = new System.Drawing.Point(34, 146);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(355, 392);
            this.panel6.TabIndex = 27;
            // 
            // checkBoxRememberPassword
            // 
            this.checkBoxRememberPassword.AutoSize = true;
            this.checkBoxRememberPassword.Font = new System.Drawing.Font("Segoe UI", 14.25F);
            this.checkBoxRememberPassword.Location = new System.Drawing.Point(134, 269);
            this.checkBoxRememberPassword.Name = "checkBoxRememberPassword";
            this.checkBoxRememberPassword.Size = new System.Drawing.Size(205, 29);
            this.checkBoxRememberPassword.TabIndex = 28;
            this.checkBoxRememberPassword.Text = "Remember Password";
            this.checkBoxRememberPassword.UseVisualStyleBackColor = true;
            // 
            // textBoxPass
            // 
            this.textBoxPass.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxPass.Location = new System.Drawing.Point(21, 234);
            this.textBoxPass.Name = "textBoxPass";
            this.textBoxPass.PasswordChar = '*';
            this.textBoxPass.Size = new System.Drawing.Size(318, 29);
            this.textBoxPass.TabIndex = 25;
            this.textBoxPass.Text = "123";
            // 
            // ButtonLogin
            // 
            this.ButtonLogin.ActiveBorderThickness = 1;
            this.ButtonLogin.ActiveCornerRadius = 20;
            this.ButtonLogin.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ButtonLogin.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonLogin.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonLogin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.ButtonLogin.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonLogin.BackgroundImage")));
            this.ButtonLogin.ButtonText = "Login";
            this.ButtonLogin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonLogin.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonLogin.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonLogin.IdleBorderThickness = 1;
            this.ButtonLogin.IdleCornerRadius = 20;
            this.ButtonLogin.IdleFillColor = System.Drawing.Color.White;
            this.ButtonLogin.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.ButtonLogin.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonLogin.Location = new System.Drawing.Point(97, 333);
            this.ButtonLogin.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ButtonLogin.Name = "ButtonLogin";
            this.ButtonLogin.Size = new System.Drawing.Size(163, 43);
            this.ButtonLogin.TabIndex = 26;
            this.ButtonLogin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonLogin.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.label5.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(17, 201);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(100, 25);
            this.label5.TabIndex = 24;
            this.label5.Text = "Password :";
            // 
            // textBoxUserName
            // 
            this.textBoxUserName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxUserName.Location = new System.Drawing.Point(21, 140);
            this.textBoxUserName.Name = "textBoxUserName";
            this.textBoxUserName.Size = new System.Drawing.Size(318, 29);
            this.textBoxUserName.TabIndex = 23;
            this.textBoxUserName.Text = "admin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(17, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 25);
            this.label3.TabIndex = 22;
            this.label3.Text = "Username :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(149)))), ((int)(((byte)(232)))), ((int)(((byte)(220)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.label2.Location = new System.Drawing.Point(93, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 30);
            this.label2.TabIndex = 21;
            this.label2.Text = "Login to System";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(97)))), ((int)(((byte)(212)))), ((int)(((byte)(195)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(82)))), ((int)(((byte)(77)))));
            this.label4.Location = new System.Drawing.Point(13, 26);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(402, 60);
            this.label4.TabIndex = 20;
            this.label4.Text = "Welcome to \r\nMangala Products Management System";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // controlButton1
            // 
            this.controlButton1.Dock = System.Windows.Forms.DockStyle.Right;
            this.controlButton1.FlatAppearance.BorderSize = 0;
            this.controlButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.controlButton1.HoverImage = ((System.Drawing.Image)(resources.GetObject("controlButton1.HoverImage")));
            this.controlButton1.Image = ((System.Drawing.Image)(resources.GetObject("controlButton1.Image")));
            this.controlButton1.Location = new System.Drawing.Point(47, 0);
            this.controlButton1.Name = "controlButton1";
            this.controlButton1.PlainImage = ((System.Drawing.Image)(resources.GetObject("controlButton1.PlainImage")));
            this.controlButton1.PressedImage = ((System.Drawing.Image)(resources.GetObject("controlButton1.PressedImage")));
            this.controlButton1.Size = new System.Drawing.Size(46, 32);
            this.controlButton1.TabIndex = 2;
            this.controlButton1.UseVisualStyleBackColor = true;
            // 
            // OuterWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(115)))), ((int)(((byte)(107)))));
            this.ClientSize = new System.Drawing.Size(1350, 748);
            this.ControlBox = false;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelControlBar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OuterWindow";
            this.Text = "OuterWindow";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.OuterWindow_KeyDown);
            this.panelControlBar.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panel6.ResumeLayout(false);
            this.panel6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelControlBar;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button button2;
        private Gaphics.ControlButton controlButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBoxPass;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBoxUserName;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonLogin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.CheckBox checkBoxRememberPassword;
    }
}