namespace CANCER_POC
{
    partial class EditPatientDetails
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLogout = new System.Windows.Forms.Button();
            this.btnTestInfo = new System.Windows.Forms.Button();
            this.btnMedicalInfo = new System.Windows.Forms.Button();
            this.bTNGenInfo = new System.Windows.Forms.Button();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.CadetBlue;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1201, 82);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.CadetBlue;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(253, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 60);
            this.label1.TabIndex = 0;
            this.label1.Text = "PATIENT DETAILS";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.Controls.Add(this.btnLogout);
            this.panel2.Controls.Add(this.btnTestInfo);
            this.panel2.Controls.Add(this.btnMedicalInfo);
            this.panel2.Controls.Add(this.bTNGenInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 566);
            this.panel2.TabIndex = 5;
            // 
            // btnLogout
            // 
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogout.ForeColor = System.Drawing.Color.Maroon;
            this.btnLogout.Location = new System.Drawing.Point(77, 477);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(112, 34);
            this.btnLogout.TabIndex = 3;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = true;
            // 
            // btnTestInfo
            // 
            this.btnTestInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnTestInfo.ForeColor = System.Drawing.Color.Maroon;
            this.btnTestInfo.Location = new System.Drawing.Point(51, 326);
            this.btnTestInfo.Name = "btnTestInfo";
            this.btnTestInfo.Size = new System.Drawing.Size(200, 34);
            this.btnTestInfo.TabIndex = 2;
            this.btnTestInfo.Text = "Test Information";
            this.btnTestInfo.UseVisualStyleBackColor = true;
            this.btnTestInfo.Click += new System.EventHandler(this.btnTestInfo_Click);
            // 
            // btnMedicalInfo
            // 
            this.btnMedicalInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnMedicalInfo.ForeColor = System.Drawing.Color.Maroon;
            this.btnMedicalInfo.Location = new System.Drawing.Point(51, 194);
            this.btnMedicalInfo.Name = "btnMedicalInfo";
            this.btnMedicalInfo.Size = new System.Drawing.Size(216, 34);
            this.btnMedicalInfo.TabIndex = 1;
            this.btnMedicalInfo.Text = "Medical Information";
            this.btnMedicalInfo.UseVisualStyleBackColor = true;
            this.btnMedicalInfo.Click += new System.EventHandler(this.btnMedicalInfo_Click);
            // 
            // bTNGenInfo
            // 
            this.bTNGenInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTNGenInfo.ForeColor = System.Drawing.Color.Maroon;
            this.bTNGenInfo.Location = new System.Drawing.Point(37, 77);
            this.bTNGenInfo.Name = "bTNGenInfo";
            this.bTNGenInfo.Size = new System.Drawing.Size(242, 34);
            this.bTNGenInfo.TabIndex = 0;
            this.bTNGenInfo.Text = "General Information\r\n\r\n";
            this.bTNGenInfo.UseVisualStyleBackColor = true;
            this.bTNGenInfo.Click += new System.EventHandler(this.bTNGenInfo_Click);
            // 
            // panelContainer
            // 
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.Location = new System.Drawing.Point(300, 82);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(901, 566);
            this.panelContainer.TabIndex = 6;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint_1);
            // 
            // EditPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1201, 648);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditPatientDetails";
            this.Text = "Edit Patient Details";
            this.Load += new System.EventHandler(this.EditPatientDetails_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button btnLogout;
        private Button btnTestInfo;
        private Button btnMedicalInfo;
        private Button bTNGenInfo;
        private Panel panelContainer;
    }
}