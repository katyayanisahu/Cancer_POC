﻿using System;
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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            //EditPatientDetails d = new EditPatientDetails();
            //MedicalInformation2 d = new MedicalInformation2();
           
            //d.Show();

            Scrollbar sc = new Scrollbar();
            sc.Dock = DockStyle.Fill;
            this.Controls.Add(sc);
        }
    }
}
