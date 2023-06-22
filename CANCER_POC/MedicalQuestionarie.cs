using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANCER_POC
{
    public partial class MedicalQuestionarie : UserControl
    {
        public MedicalQuestionarie()
        {
            InitializeComponent();
            this.AutoScroll = true;

        }

      

        private void btnNext_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();          
            MedicalSymptoms u1 = new MedicalSymptoms();
            u1.Dock = DockStyle.Fill;
            this.Controls.Add(u1);
        }

        private void MedicalQuestionarie_Load(object sender, EventArgs e)
        {
            
        }

        private void vScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {

        }
    }
}
