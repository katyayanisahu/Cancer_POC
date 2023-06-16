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

        //public Panel PnlContainer
        //{
        //    get { return PanelContainer; }
        //    set { PanelContainer = (FlowLayoutPanel)value; }
        //}

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGenInfo_Click(object sender, EventArgs e)
        {
           
        }


        private void bTNGenInfo_Click(object sender, EventArgs e)
        {
            GeneralInformation gi = new GeneralInformation();
            gi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(gi);

        
        }

        private void addPatientData_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicalInfo_Click(object sender, EventArgs e)
        {
            //if (!PanelContainer.Controls.Contains(MedicalInformation1.Instance))
            //{
            //    PanelContainer.Controls.Add(MedicalInformation1.Instance);
            //    MedicalInformation1.Instance.Dock = DockStyle.Fill;
            //    MedicalInformation1.Instance.BringToFront();
            //}
            //else
            //    MedicalInformation1.Instance.BringToFront();

            //MedicalInformation1 mi= new MedicalInformation1();
            //mi.Dock= DockStyle.Fill;
            //PanelContainer.Controls.Add(mi);

            MedicalInformation1 mi = new MedicalInformation1();
            mi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mi);
        }

        private void btnTestInfo_Click(object sender, EventArgs e)
        {
            TestInformation ti = new TestInformation();
            ti.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ti);

        }

        private void EditPatientDetails_Load(object sender, EventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panelContainer_Paint_1(object sender, PaintEventArgs e)
        {

        }
    }
}
