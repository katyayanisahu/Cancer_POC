namespace CANCER_POC
{
    public partial class EditPatientDetails : Form
    {
        private GeneralInformation gi = new GeneralInformation();
        private MedicalInformation1 mi = new MedicalInformation1();
        private TestInformation ti = new TestInformation();

        public EditPatientDetails()
        {
            InitializeComponent();
            //this.AutoScroll= true;
        }

      
        private void lblGenInfo_Click(object sender, EventArgs e)
        {
           
        }


        private void bTNGenInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            this.gi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(gi);

        }

        private void addPatientData_Click(object sender, EventArgs e)
        {

        }

        private void btnMedicalInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            this.gi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mi);

        }

        private void btnTestInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            this.gi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ti);
        }

        private void EditPatientDetails_Load(object sender, EventArgs e)
        {

        }

      
    }
}
