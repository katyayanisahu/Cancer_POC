namespace CANCER_POC
{
    partial class GeneralInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblName = new System.Windows.Forms.Label();
            this.txtboxName = new System.Windows.Forms.TextBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.lbldob = new System.Windows.Forms.Label();
            this.lblgender = new System.Windows.Forms.Label();
            this.lbladdress = new System.Windows.Forms.Label();
            this.lblAge = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblemail = new System.Windows.Forms.Label();
            this.txtboxAge = new System.Windows.Forms.TextBox();
            this.txtboxPhone = new System.Windows.Forms.TextBox();
            this.txtboxAddress = new System.Windows.Forms.TextBox();
            this.txtboxEmail = new System.Windows.Forms.TextBox();
            this.rdbMale = new System.Windows.Forms.RadioButton();
            this.rdbFemale = new System.Windows.Forms.RadioButton();
            this.dtpDOB = new System.Windows.Forms.DateTimePicker();
            this.errorProviderName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAge = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhone = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Maroon;
            this.lblName.Location = new System.Drawing.Point(75, 98);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 5;
            this.lblName.Text = "Name";
            // 
            // txtboxName
            // 
            this.txtboxName.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxName.ForeColor = System.Drawing.Color.Maroon;
            this.txtboxName.Location = new System.Drawing.Point(185, 98);
            this.txtboxName.Name = "txtboxName";
            this.txtboxName.Size = new System.Drawing.Size(150, 31);
            this.txtboxName.TabIndex = 6;
            this.txtboxName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxName_KeyPress);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSave.ForeColor = System.Drawing.Color.Purple;
            this.btnSave.Location = new System.Drawing.Point(319, 438);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(112, 34);
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lbldob
            // 
            this.lbldob.AutoSize = true;
            this.lbldob.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbldob.ForeColor = System.Drawing.Color.Maroon;
            this.lbldob.Location = new System.Drawing.Point(77, 265);
            this.lbldob.Name = "lbldob";
            this.lbldob.Size = new System.Drawing.Size(47, 25);
            this.lbldob.TabIndex = 10;
            this.lbldob.Text = "Dob";
            // 
            // lblgender
            // 
            this.lblgender.AutoSize = true;
            this.lblgender.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblgender.ForeColor = System.Drawing.Color.Maroon;
            this.lblgender.Location = new System.Drawing.Point(77, 338);
            this.lblgender.Name = "lblgender";
            this.lblgender.Size = new System.Drawing.Size(74, 25);
            this.lblgender.TabIndex = 11;
            this.lblgender.Text = "Gender";
            // 
            // lbladdress
            // 
            this.lbladdress.AutoSize = true;
            this.lbladdress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbladdress.ForeColor = System.Drawing.Color.Maroon;
            this.lbladdress.Location = new System.Drawing.Point(407, 104);
            this.lbladdress.Name = "lbladdress";
            this.lbladdress.Size = new System.Drawing.Size(80, 25);
            this.lbladdress.TabIndex = 12;
            this.lbladdress.Text = "Address";
            // 
            // lblAge
            // 
            this.lblAge.AutoSize = true;
            this.lblAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblAge.ForeColor = System.Drawing.Color.Maroon;
            this.lblAge.Location = new System.Drawing.Point(77, 178);
            this.lblAge.Name = "lblAge";
            this.lblAge.Size = new System.Drawing.Size(46, 25);
            this.lblAge.TabIndex = 13;
            this.lblAge.Text = "Age";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.ForeColor = System.Drawing.Color.Maroon;
            this.lblPhone.Location = new System.Drawing.Point(418, 181);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(66, 25);
            this.lblPhone.TabIndex = 14;
            this.lblPhone.Text = "Phone";
            // 
            // lblemail
            // 
            this.lblemail.AutoSize = true;
            this.lblemail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblemail.ForeColor = System.Drawing.Color.Maroon;
            this.lblemail.Location = new System.Drawing.Point(426, 268);
            this.lblemail.Name = "lblemail";
            this.lblemail.Size = new System.Drawing.Size(58, 25);
            this.lblemail.TabIndex = 15;
            this.lblemail.Text = "Email";
            // 
            // txtboxAge
            // 
            this.txtboxAge.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxAge.ForeColor = System.Drawing.Color.Maroon;
            this.txtboxAge.Location = new System.Drawing.Point(185, 178);
            this.txtboxAge.Name = "txtboxAge";
            this.txtboxAge.Size = new System.Drawing.Size(150, 31);
            this.txtboxAge.TabIndex = 16;
            this.txtboxAge.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxAge_KeyPress);
            // 
            // txtboxPhone
            // 
            this.txtboxPhone.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxPhone.ForeColor = System.Drawing.Color.Maroon;
            this.txtboxPhone.Location = new System.Drawing.Point(532, 181);
            this.txtboxPhone.Name = "txtboxPhone";
            this.txtboxPhone.Size = new System.Drawing.Size(150, 31);
            this.txtboxPhone.TabIndex = 17;
            this.txtboxPhone.TextChanged += new System.EventHandler(this.txtboxPhone_TextChanged);
            this.txtboxPhone.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtboxPhone_KeyPress);
            // 
            // txtboxAddress
            // 
            this.txtboxAddress.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxAddress.ForeColor = System.Drawing.Color.Maroon;
            this.txtboxAddress.Location = new System.Drawing.Point(532, 104);
            this.txtboxAddress.Name = "txtboxAddress";
            this.txtboxAddress.Size = new System.Drawing.Size(150, 31);
            this.txtboxAddress.TabIndex = 18;
            // 
            // txtboxEmail
            // 
            this.txtboxEmail.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txtboxEmail.ForeColor = System.Drawing.Color.Maroon;
            this.txtboxEmail.Location = new System.Drawing.Point(532, 268);
            this.txtboxEmail.Name = "txtboxEmail";
            this.txtboxEmail.Size = new System.Drawing.Size(150, 31);
            this.txtboxEmail.TabIndex = 21;
            this.txtboxEmail.TextChanged += new System.EventHandler(this.txtboxEmail_TextChanged);
        
            // 
            // rdbMale
            // 
            this.rdbMale.AutoSize = true;
            this.rdbMale.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rdbMale.Location = new System.Drawing.Point(194, 338);
            this.rdbMale.Name = "rdbMale";
            this.rdbMale.Size = new System.Drawing.Size(75, 29);
            this.rdbMale.TabIndex = 22;
            this.rdbMale.TabStop = true;
            this.rdbMale.Text = "Male";
            this.rdbMale.UseVisualStyleBackColor = true;
            // 
            // rdbFemale
            // 
            this.rdbFemale.AutoSize = true;
            this.rdbFemale.Location = new System.Drawing.Point(305, 336);
            this.rdbFemale.Name = "rdbFemale";
            this.rdbFemale.Size = new System.Drawing.Size(93, 29);
            this.rdbFemale.TabIndex = 23;
            this.rdbFemale.TabStop = true;
            this.rdbFemale.Text = "Female";
            this.rdbFemale.UseVisualStyleBackColor = true;
            // 
            // dtpDOB
            // 
            this.dtpDOB.Location = new System.Drawing.Point(175, 263);
            this.dtpDOB.Name = "dtpDOB";
            this.dtpDOB.Size = new System.Drawing.Size(187, 31);
            this.dtpDOB.TabIndex = 24;
            // 
            // errorProviderName
            // 
            this.errorProviderName.ContainerControl = this;
            // 
            // errorProviderAge
            // 
            this.errorProviderAge.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderPhone
            // 
            this.errorProviderPhone.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // GeneralInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.dtpDOB);
            this.Controls.Add(this.rdbFemale);
            this.Controls.Add(this.rdbMale);
            this.Controls.Add(this.txtboxEmail);
            this.Controls.Add(this.txtboxAddress);
            this.Controls.Add(this.txtboxPhone);
            this.Controls.Add(this.txtboxAge);
            this.Controls.Add(this.lblemail);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblAge);
            this.Controls.Add(this.lbladdress);
            this.Controls.Add(this.lblgender);
            this.Controls.Add(this.lbldob);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtboxName);
            this.Controls.Add(this.lblName);
            this.Name = "GeneralInformation";
            this.Size = new System.Drawing.Size(745, 565);
            this.Load += new System.EventHandler(this.GeneralInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAge)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhone)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblName;
        private TextBox txtboxName;
        private Button btnSave;
        private Label lbldob;
        private Label lblgender;
        private Label lbladdress;
        private Label lblAge;
        private Label lblPhone;
        private Label lblemail;
        private TextBox txtboxAge;
        private TextBox txtboxPhone;
        private TextBox txtboxAddress;
        private TextBox txtboxEmail;
        private RadioButton rdbMale;
        private RadioButton rdbFemale;
        private DateTimePicker dtpDOB;
        private ErrorProvider errorProviderName;
        private ErrorProvider errorProviderAge;
        private ErrorProvider errorProviderAddress;
        private ErrorProvider errorProviderPhone;
        private ErrorProvider errorProviderEmail;
    }
}
