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
            this.addPatientData = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.bTNGenInfo = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
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
            this.panel1.Size = new System.Drawing.Size(1003, 82);
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
            this.panel2.Controls.Add(this.addPatientData);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.bTNGenInfo);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 82);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 566);
            this.panel2.TabIndex = 5;
            // 
            // addPatientData
            // 
            this.addPatientData.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.addPatientData.ForeColor = System.Drawing.Color.Maroon;
            this.addPatientData.Location = new System.Drawing.Point(37, 108);
            this.addPatientData.Name = "addPatientData";
            this.addPatientData.Size = new System.Drawing.Size(216, 34);
            this.addPatientData.TabIndex = 4;
            this.addPatientData.Text = "Add Patient Data";
            this.addPatientData.UseVisualStyleBackColor = true;
            this.addPatientData.Click += new System.EventHandler(this.addPatientData_Click);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button4.ForeColor = System.Drawing.Color.Maroon;
            this.button4.Location = new System.Drawing.Point(77, 477);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(112, 34);
            this.button4.TabIndex = 3;
            this.button4.Text = "Logout";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button3.ForeColor = System.Drawing.Color.Maroon;
            this.button3.Location = new System.Drawing.Point(37, 369);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(200, 34);
            this.button3.TabIndex = 2;
            this.button3.Text = "Test Information";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.button2.ForeColor = System.Drawing.Color.Maroon;
            this.button2.Location = new System.Drawing.Point(37, 284);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(216, 34);
            this.button2.TabIndex = 1;
            this.button2.Text = "Medical Information";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // bTNGenInfo
            // 
            this.bTNGenInfo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.bTNGenInfo.ForeColor = System.Drawing.Color.Maroon;
            this.bTNGenInfo.Location = new System.Drawing.Point(12, 198);
            this.bTNGenInfo.Name = "bTNGenInfo";
            this.bTNGenInfo.Size = new System.Drawing.Size(270, 34);
            this.bTNGenInfo.TabIndex = 0;
            this.bTNGenInfo.Text = "Edit General Information\r\n\r\n";
            this.bTNGenInfo.UseVisualStyleBackColor = true;
            this.bTNGenInfo.Click += new System.EventHandler(this.bTNGenInfo_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Location = new System.Drawing.Point(306, 82);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(694, 566);
            this.flowLayoutPanel1.TabIndex = 6;
            // 
            // EditPatientDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(1003, 648);
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "EditPatientDetails";
            this.Text = "Edit Patient Details";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Button button4;
        private Button button3;
        private Button button2;
        private Button bTNGenInfo;
        private FlowLayoutPanel flowLayoutPanel1;
        private Button addPatientData;
    }
}