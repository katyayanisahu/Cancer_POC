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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

 
      
        private void btnEdit_Click(object sender, EventArgs e)
        {

        }

        private void Dashboard_Load(object sender, EventArgs e)
        {

        }

        private void btnAddPatient_Click(object sender, EventArgs e)
        {
           EditPatientDetails ti = new EditPatientDetails();
           ti.Show();



        }

        private void dgvDashboard_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
