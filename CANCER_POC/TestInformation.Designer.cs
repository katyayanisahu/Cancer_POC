namespace CANCER_POC
{
    partial class TestInformation
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
            this.cmbboxTesttypes = new System.Windows.Forms.ComboBox();
            this.lblTesttypes = new System.Windows.Forms.Label();
            this.Testtypes = new System.Windows.Forms.Label();
            this.panelContainer = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cmbboxTesttypes
            // 
            this.cmbboxTesttypes.FormattingEnabled = true;
            this.cmbboxTesttypes.Items.AddRange(new object[] {
            "BloodTest",
            "CT Scan",
            "MRI"});
            this.cmbboxTesttypes.Location = new System.Drawing.Point(509, 153);
            this.cmbboxTesttypes.Name = "cmbboxTesttypes";
            this.cmbboxTesttypes.Size = new System.Drawing.Size(182, 33);
            this.cmbboxTesttypes.TabIndex = 0;
            this.cmbboxTesttypes.SelectedIndexChanged += new System.EventHandler(this.cmbboxTesttypes_SelectedIndexChanged);
            // 
            // lblTesttypes
            // 
            this.lblTesttypes.AutoSize = true;
            this.lblTesttypes.Location = new System.Drawing.Point(89, 100);
            this.lblTesttypes.Name = "lblTesttypes";
            this.lblTesttypes.Size = new System.Drawing.Size(0, 25);
            this.lblTesttypes.TabIndex = 1;
            // 
            // Testtypes
            // 
            this.Testtypes.AutoSize = true;
            this.Testtypes.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.Testtypes.ForeColor = System.Drawing.Color.Maroon;
            this.Testtypes.Location = new System.Drawing.Point(269, 153);
            this.Testtypes.Name = "Testtypes";
            this.Testtypes.Size = new System.Drawing.Size(97, 25);
            this.Testtypes.TabIndex = 2;
            this.Testtypes.Text = "Test types";
            // 
            // panelContainer
            // 
            this.panelContainer.Location = new System.Drawing.Point(51, 213);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Size = new System.Drawing.Size(1019, 507);
            this.panelContainer.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.ForeColor = System.Drawing.Color.DarkGreen;
            this.label1.Location = new System.Drawing.Point(56, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(406, 54);
            this.label1.TabIndex = 4;
            this.label1.Text = "TEST INFORMATION";
            // 
            // TestInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panelContainer);
            this.Controls.Add(this.Testtypes);
            this.Controls.Add(this.lblTesttypes);
            this.Controls.Add(this.cmbboxTesttypes);
            this.Name = "TestInformation";
            this.Size = new System.Drawing.Size(1097, 750);
            this.Load += new System.EventHandler(this.TestInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbboxTesttypes;
        private Label lblTesttypes;
        private Label Testtypes;
        private Panel panelContainer;
        private Label label1;
    }
}
