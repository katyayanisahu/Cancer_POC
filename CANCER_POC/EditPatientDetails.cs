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

        public Panel PnlContainer
        {
            get { return PanelContainer; }
            set { PanelContainer = (FlowLayoutPanel)value; }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lblGenInfo_Click(object sender, EventArgs e)
        {
           
        }


        private void bTNGenInfo_Click(object sender, EventArgs e)
        {
            var generalInformation=new GeneralInformation { Dock= DockStyle.Fill };
            PanelContainer.Controls.Add(generalInformation);

            //AddPatientData lg = new AddPatientData();
            //lg.Show();
        }

        private void addPatientData_Click(object sender, EventArgs e)
        {
            AddPatientData ad = new AddPatientData();
            ad.Show();
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

            MedicalInformation1 uc = new MedicalInformation1();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);
        }

        private void btnTestInfo_Click(object sender, EventArgs e)
        {
            TestInformation uc = new TestInformation();
            uc.Dock = DockStyle.Fill;
            this.Controls.Add(uc);

           
            //if (!PanelContainer.Controls.Contains(TestInformation.Instance))
            //{
            //    PanelContainer.Controls.Add(TestInformation.Instance);
            //    TestInformation.Instance.Dock = DockStyle.Fill;
            //    TestInformation.Instance.BringToFront();
            //}
            //else
            //    TestInformation.Instance.BringToFront();
        }

        private void EditPatientDetails_Load(object sender, EventArgs e)
        {

        }

        private void PanelContainer_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
