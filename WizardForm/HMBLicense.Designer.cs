namespace System.Windows.Forms.Wizard
{
    partial class HMBLicense
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HMBLicense));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblValidityPeriod = new System.Windows.Forms.Label();
            this.lblLicenseStatus = new System.Windows.Forms.Label();
            this.lblPlsContact = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.grpLicenseRegistration = new System.Windows.Forms.GroupBox();
            this.btnCancel = new System.Windows.Forms.Button();
            this.cbNoOfMonths = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtValidUntil = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.lblHardwareInfo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnActivate = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.btnSetupLicenseRegistration = new System.Windows.Forms.Button();
            this.btnRenew = new System.Windows.Forms.Button();
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtLastRunningDate = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.grpLicenseRegistration.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblValidityPeriod);
            this.groupBox1.Controls.Add(this.lblLicenseStatus);
            this.groupBox1.Controls.Add(this.lblPlsContact);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.grpLicenseRegistration);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.lblNote);
            this.groupBox1.Controls.Add(this.btnSetupLicenseRegistration);
            this.groupBox1.Controls.Add(this.btnRenew);
            this.groupBox1.Controls.Add(this.txtAdminPassword);
            this.groupBox1.Location = new System.Drawing.Point(13, 16);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(338, 352);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "License Information";
            // 
            // lblValidityPeriod
            // 
            this.lblValidityPeriod.AutoSize = true;
            this.lblValidityPeriod.Location = new System.Drawing.Point(102, 54);
            this.lblValidityPeriod.Name = "lblValidityPeriod";
            this.lblValidityPeriod.Size = new System.Drawing.Size(105, 13);
            this.lblValidityPeriod.TabIndex = 16;
            this.lblValidityPeriod.Text = "Diplay Validity Period";
            // 
            // lblLicenseStatus
            // 
            this.lblLicenseStatus.AutoSize = true;
            this.lblLicenseStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLicenseStatus.Location = new System.Drawing.Point(104, 28);
            this.lblLicenseStatus.Name = "lblLicenseStatus";
            this.lblLicenseStatus.Size = new System.Drawing.Size(130, 15);
            this.lblLicenseStatus.TabIndex = 15;
            this.lblLicenseStatus.Text = "Display License Status";
            // 
            // lblPlsContact
            // 
            this.lblPlsContact.AutoSize = true;
            this.lblPlsContact.Location = new System.Drawing.Point(10, 114);
            this.lblPlsContact.Name = "lblPlsContact";
            this.lblPlsContact.Size = new System.Drawing.Size(307, 13);
            this.lblPlsContact.TabIndex = 14;
            this.lblPlsContact.Text = "Please contact the system provider for the License Registration.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(23, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Validity Period:";
            // 
            // grpLicenseRegistration
            // 
            this.grpLicenseRegistration.Controls.Add(this.btnCancel);
            this.grpLicenseRegistration.Controls.Add(this.cbNoOfMonths);
            this.grpLicenseRegistration.Controls.Add(this.label6);
            this.grpLicenseRegistration.Controls.Add(this.label5);
            this.grpLicenseRegistration.Controls.Add(this.dtValidUntil);
            this.grpLicenseRegistration.Controls.Add(this.label4);
            this.grpLicenseRegistration.Controls.Add(this.lblHardwareInfo);
            this.grpLicenseRegistration.Controls.Add(this.label1);
            this.grpLicenseRegistration.Controls.Add(this.btnActivate);
            this.grpLicenseRegistration.Location = new System.Drawing.Point(16, 131);
            this.grpLicenseRegistration.Name = "grpLicenseRegistration";
            this.grpLicenseRegistration.Size = new System.Drawing.Size(307, 217);
            this.grpLicenseRegistration.TabIndex = 9;
            this.grpLicenseRegistration.TabStop = false;
            this.grpLicenseRegistration.Text = "License Registration";
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(151, 182);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(128, 29);
            this.btnCancel.TabIndex = 11;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // cbNoOfMonths
            // 
            this.cbNoOfMonths.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbNoOfMonths.FormattingEnabled = true;
            this.cbNoOfMonths.Items.AddRange(new object[] {
            "12 - (1 yr)",
            "24 - (2 yrs)",
            "36 - (3 yrs)",
            "48 - (4 yrs)",
            "00 - (admin)"});
            this.cbNoOfMonths.Location = new System.Drawing.Point(96, 47);
            this.cbNoOfMonths.Name = "cbNoOfMonths";
            this.cbNoOfMonths.Size = new System.Drawing.Size(82, 21);
            this.cbNoOfMonths.TabIndex = 10;
            this.cbNoOfMonths.SelectedIndexChanged += new System.EventHandler(this.cbNoOfMonths_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(186, 31);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(77, 13);
            this.label6.TabIndex = 9;
            this.label6.Text = "Expiration date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(93, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "No. of Month(s)";
            // 
            // dtValidUntil
            // 
            this.dtValidUntil.Enabled = false;
            this.dtValidUntil.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtValidUntil.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtValidUntil.Location = new System.Drawing.Point(189, 48);
            this.dtValidUntil.Name = "dtValidUntil";
            this.dtValidUntil.Size = new System.Drawing.Size(87, 20);
            this.dtValidUntil.TabIndex = 7;
            this.dtValidUntil.ValueChanged += new System.EventHandler(this.dtValidUntil_ValueChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Validity Period:";
            // 
            // lblHardwareInfo
            // 
            this.lblHardwareInfo.Location = new System.Drawing.Point(14, 99);
            this.lblHardwareInfo.Multiline = true;
            this.lblHardwareInfo.Name = "lblHardwareInfo";
            this.lblHardwareInfo.ReadOnly = true;
            this.lblHardwareInfo.Size = new System.Drawing.Size(279, 80);
            this.lblHardwareInfo.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Hardware Information:";
            // 
            // btnActivate
            // 
            this.btnActivate.Location = new System.Drawing.Point(30, 182);
            this.btnActivate.Name = "btnActivate";
            this.btnActivate.Size = new System.Drawing.Size(121, 29);
            this.btnActivate.TabIndex = 2;
            this.btnActivate.Text = "Activate";
            this.btnActivate.UseVisualStyleBackColor = true;
            this.btnActivate.Click += new System.EventHandler(this.btnActivate_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label3.Location = new System.Drawing.Point(16, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "License Status:";
            // 
            // lblNote
            // 
            this.lblNote.AutoSize = true;
            this.lblNote.Location = new System.Drawing.Point(10, 98);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(33, 13);
            this.lblNote.TabIndex = 13;
            this.lblNote.Text = "Note:";
            this.lblNote.DoubleClick += new System.EventHandler(this.lblNote_DoubleClick);
            // 
            // btnSetupLicenseRegistration
            // 
            this.btnSetupLicenseRegistration.Location = new System.Drawing.Point(105, 85);
            this.btnSetupLicenseRegistration.Name = "btnSetupLicenseRegistration";
            this.btnSetupLicenseRegistration.Size = new System.Drawing.Size(212, 26);
            this.btnSetupLicenseRegistration.TabIndex = 12;
            this.btnSetupLicenseRegistration.Text = "Setup License Registration";
            this.btnSetupLicenseRegistration.UseVisualStyleBackColor = true;
            this.btnSetupLicenseRegistration.Click += new System.EventHandler(this.btnSetupLicenseRegistration_Click);
            // 
            // btnRenew
            // 
            this.btnRenew.Location = new System.Drawing.Point(105, 85);
            this.btnRenew.Name = "btnRenew";
            this.btnRenew.Size = new System.Drawing.Size(212, 26);
            this.btnRenew.TabIndex = 8;
            this.btnRenew.Text = "Renew";
            this.btnRenew.UseVisualStyleBackColor = true;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAdminPassword.Location = new System.Drawing.Point(105, 87);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.Size = new System.Drawing.Size(212, 21);
            this.txtAdminPassword.TabIndex = 0;
            this.txtAdminPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtAdminPassword_KeyDown);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label7.Location = new System.Drawing.Point(68, 378);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(99, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Last Running Date:";
            // 
            // txtLastRunningDate
            // 
            this.txtLastRunningDate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLastRunningDate.Enabled = false;
            this.txtLastRunningDate.Location = new System.Drawing.Point(174, 377);
            this.txtLastRunningDate.Name = "txtLastRunningDate";
            this.txtLastRunningDate.ReadOnly = true;
            this.txtLastRunningDate.Size = new System.Drawing.Size(128, 13);
            this.txtLastRunningDate.TabIndex = 14;
            // 
            // HMBLicense
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 398);
            this.Controls.Add(this.txtLastRunningDate);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "HMBLicense";
            this.Text = "HMB License";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.HMBLicense_FormClosed);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.HMBLicense_KeyDown);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpLicenseRegistration.ResumeLayout(false);
            this.grpLicenseRegistration.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GroupBox groupBox1;
        private Button btnActivate;
        private Label label1;
        private Label label3;
        private TextBox lblHardwareInfo;
        private Label label7;
        private Button btnSetupLicenseRegistration;
        private Label label2;
        private GroupBox grpLicenseRegistration;
        private Label label6;
        private Label label5;
        private DateTimePicker dtValidUntil;
        private Label label4;
        private Button btnRenew;
        private ComboBox cbNoOfMonths;
        private TextBox txtLastRunningDate;
        private Label lblNote;
        private Label lblPlsContact;
        private TextBox txtAdminPassword;
        private Button btnCancel;
        private Label lblLicenseStatus;
        private Label lblValidityPeriod;
    }
}