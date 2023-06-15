using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CANCER_POC
{
    public partial class EditPatientDetails : Form
    {
        public EditPatientDetails()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGenInfo_Click(object sender, EventArgs e)
        {
           
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void bTNGenInfo_Click(object sender, EventArgs e)
        {
            //AddPatientData lg = new AddPatientData();
            //lg.Show();
        }

        private void addPatientData_Click(object sender, EventArgs e)
        {
            AddPatientData ad = new AddPatientData();
            ad.Show();
        }
    }
}
