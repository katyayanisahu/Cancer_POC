namespace CANCER_POC
{
    public partial class PatientDetails : Form
    {
        private GeneralInformation gi = new GeneralInformation();
        private MedicalQuestionarie mq = new MedicalQuestionarie();
        private TestInformation ti = new TestInformation();

        public PatientDetails()
        {
            InitializeComponent();
            this.AutoScroll= true;
        }

    
        private void bTNGenInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            this.gi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(gi);

        }

        private void btnMedicalInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            this.gi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(mq);

        }

        private void btnTestInfo_Click(object sender, EventArgs e)
        {
            panelContainer.Controls.Clear();
            this.gi.Dock = DockStyle.Fill;
            panelContainer.Controls.Add(ti);
        }

     
    }
}
