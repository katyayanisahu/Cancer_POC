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
            this.SuspendLayout();
            // 
            // cmbboxTesttypes
            // 
            this.cmbboxTesttypes.FormattingEnabled = true;
            this.cmbboxTesttypes.Items.AddRange(new object[] {
            "BloodTest",
            "CT Scan",
            "MRI"});
            this.cmbboxTesttypes.Location = new System.Drawing.Point(260, 96);
            this.cmbboxTesttypes.Name = "cmbboxTesttypes";
            this.cmbboxTesttypes.Size = new System.Drawing.Size(182, 33);
            this.cmbboxTesttypes.TabIndex = 0;
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
            this.Testtypes.Location = new System.Drawing.Point(89, 96);
            this.Testtypes.Name = "Testtypes";
            this.Testtypes.Size = new System.Drawing.Size(97, 25);
            this.Testtypes.TabIndex = 2;
            this.Testtypes.Text = "Test types";
            // 
            // TestInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.Controls.Add(this.Testtypes);
            this.Controls.Add(this.lblTesttypes);
            this.Controls.Add(this.cmbboxTesttypes);
            this.Name = "TestInformation";
            this.Size = new System.Drawing.Size(494, 264);
            this.Load += new System.EventHandler(this.TestInformation_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ComboBox cmbboxTesttypes;
        private Label lblTesttypes;
        private Label Testtypes;
    }
}
