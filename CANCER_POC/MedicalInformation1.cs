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
    public partial class MedicalInformation1 : UserControl
    {
        //public static MedicalInformation1 _instance;
        //public static MedicalInformation1 Instance
        //{
        //    get
        //    {
        //        if (_instance == null)
        //            _instance = new MedicalInformation1();
        //        return _instance;
        //    }
        //}
        public MedicalInformation1()
        {
            InitializeComponent();
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void MedicalInformation1_Load(object sender, EventArgs e)
        {

        }

        private void vScrollBar_Scroll(object sender, ScrollEventArgs e)
        {
            this.AutoScroll = true;
        }
    }
}
