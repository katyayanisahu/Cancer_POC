namespace CANCER_POC
{
    public partial class MedicalInformation1 : UserControl
    {
   
        public MedicalInformation1()
        {
            InitializeComponent();
            this.AutoScroll = true;

        }

       

        private void MedicalInformation1_Load(object sender, EventArgs e)
        {
            
        }

       

        private void btnNext_Click(object sender, EventArgs e)
        {
            MedicalSymptoms medical = new MedicalSymptoms();
            medical.Show();

        }

        private void vScrollBarMedical_Scroll(object sender, ScrollEventArgs e)
        {
            //this.AutoScroll = true;
        }
    }
}
