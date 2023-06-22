
using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace CANCER_POC
{
    public partial class MedicalSymptoms : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BH77SS1\SQLEXPRESS01;Initial Catalog=cancer_poc;Integrated Security=True");
        private int indexRow;
        public MedicalSymptoms()
        {
            InitializeComponent();
        }

        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from  medical_information_patient";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewMedical.DataSource = dt;
        }

        private void MedicalSymptoms_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            string query = "INSERT INTO medical_information_patient(blood_group,smoking,alcohol,name_cancer,type_cancer,stage_cancer,occupational_hazard,chronic_lung_disease,chest_pain,blood_cough,frequent_cold,dry_cough,breath_shortness,obesity,fatigue,weight_loss,level,survival_status,room_no,floor_no) VALUES(@blood_group,@smoking,@alcohol,@name_cancer,@type_cancer,@stage_cancer,@occupational_hazard,@chronic_lung_disease,@chest_pain,@blood_cough,@frequent_cold,@dry_cough,@breath_shortness,@obesity,@fatigue,@weight_loss,@level,@survival_status,@room_no,@floor_no)";
 
            SqlCommand cmd2 = new SqlCommand(query, con);

            cmd2.CommandType = CommandType.Text;

            //Pass values to Parameters

            cmd2.Parameters.AddWithValue("@blood_group", comboBox_BloodGroup.Text);
            cmd2.Parameters.AddWithValue("@smoking", comboBox_Smoking.Text);
            cmd2.Parameters.AddWithValue("@alcohol", comboBox_Alcohol.Text);
            cmd2.Parameters.AddWithValue("@name_cancer", combobox_NameCancer.Text);
            cmd2.Parameters.AddWithValue("@type_cancer", comboBox_TypeCancer.Text);
            cmd2.Parameters.AddWithValue("@stage_cancer", comboBox_StageCancer.Text);
            cmd2.Parameters.AddWithValue("@occupational_hazard", comboBox_OccupationalHazard.Text);
            cmd2.Parameters.AddWithValue("@chronic_lung_disease", comboBox_ChronicLungDisease.Text);
            cmd2.Parameters.AddWithValue("@chest_pain", comboBox_ChestPain.Text);
            cmd2.Parameters.AddWithValue("@blood_cough", comboBox_BloodCough.Text);
            cmd2.Parameters.AddWithValue("@frequent_cold", comboBox_FrequentCold.Text);
            cmd2.Parameters.AddWithValue("@dry_cough", comboBox_DryCough.Text);
            cmd2.Parameters.AddWithValue("@breath_shortness", comboBox_DryCough.Text);
            cmd2.Parameters.AddWithValue("@obesity", comboBox_Obesity.Text);
            cmd2.Parameters.AddWithValue("@fatigue", comboBox_Fatigue.Text);
            cmd2.Parameters.AddWithValue("@weight_loss", comboBox_WeightLoss.Text);
            cmd2.Parameters.AddWithValue("@level", comboBox_Level.Text);
            cmd2.Parameters.AddWithValue("@survival_status", comboBox_ServivalStatus.Text);
            cmd2.Parameters.AddWithValue("@room_no", txtboxRoom_no.Text);
            cmd2.Parameters.AddWithValue("@floor_no", txtboxFloor_no.Text);


            try
            {
                con.Open();
                cmd2.ExecuteNonQuery();
                disp_data();
                MessageBox.Show("Records Inserted Successfully");
            }

            catch (SqlException s)
            {
                MessageBox.Show("Error Generated. Details: " + s.ToString());
            }
            finally
            {
                con.Close();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            int rowIndex = dataGridViewMedical.CurrentCell.RowIndex;
            dataGridViewMedical.Rows.RemoveAt(rowIndex);

        }


        private void btnEdit_Click(object sender, EventArgs e)
        {
            DataGridViewRow newdata = dataGridViewMedical.Rows[indexRow];
            newdata.Cells[1].Value = comboBox_BloodGroup.Text;
            newdata.Cells[2].Value = comboBox_Smoking.Text;
            newdata.Cells[3].Value = comboBox_Alcohol.Text;
            newdata.Cells[4].Value = combobox_NameCancer.Text;
            newdata.Cells[5].Value = comboBox_TypeCancer.Text;
            newdata.Cells[6].Value = comboBox_StageCancer.Text;
            newdata.Cells[7].Value = comboBox_OccupationalHazard.Text;
            newdata.Cells[8].Value = comboBox_ChronicLungDisease.Text;
            newdata.Cells[9].Value = comboBox_ChestPain.Text;
            newdata.Cells[10].Value = comboBox_BloodCough.Text;
            newdata.Cells[11].Value = comboBox_FrequentCold.Text;
            newdata.Cells[12].Value = comboBox_DryCough.Text;
            newdata.Cells[13].Value = comboBox_BreathShortness.Text;
            newdata.Cells[14].Value = comboBox_Obesity.Text;
            newdata.Cells[15].Value = comboBox_Fatigue.Text;
            newdata.Cells[16].Value = comboBox_WeightLoss.Text;
            newdata.Cells[17].Value = comboBox_Level.Text;
            newdata.Cells[18].Value = comboBox_ServivalStatus.Text;
            newdata.Cells[19].Value = txtboxRoom_no.Text;
            newdata.Cells[20].Value = txtboxFloor_no.Text;
            MessageBox.Show("Records Updated Successfully");
            comboBox_BloodGroup.Text = " ";
            comboBox_Smoking.Text = " ";
            comboBox_Alcohol.Text = " ";
            combobox_NameCancer.Text = " ";
            comboBox_TypeCancer.Text = " ";
            comboBox_StageCancer.Text = " ";
            comboBox_OccupationalHazard.Text = " ";
            comboBox_ChronicLungDisease.Text = " ";
            comboBox_ChestPain.Text = " ";
            comboBox_BloodCough.Text = " ";
            comboBox_FrequentCold.Text = " ";
            comboBox_DryCough.Text = " ";
            comboBox_BreathShortness.Text = " ";
            comboBox_Obesity.Text = " ";
            comboBox_Fatigue.Text = " ";
            comboBox_WeightLoss.Text = " ";
            comboBox_Level.Text = " ";
            comboBox_ServivalStatus.Text = " ";
            txtboxRoom_no.Text = " ";
            txtboxFloor_no.Text = " ";


        }

        private void btnClose_Click(object sender, EventArgs e)
        {
           //this.Controls.Clear();
        }

        private void dataGridViewMedical_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (dataGridViewMedical.SelectedRows.Count >= 0)
                {
                    comboBox_BloodGroup.Text = dataGridViewMedical.SelectedRows[0].Cells[1].Value.ToString();
                    comboBox_Smoking.Text = dataGridViewMedical.SelectedRows[0].Cells[2].Value.ToString();
                    comboBox_Alcohol.Text = dataGridViewMedical.SelectedRows[0].Cells[3].Value.ToString();
                    combobox_NameCancer.Text = dataGridViewMedical.SelectedRows[0].Cells[4].Value.ToString();
                    comboBox_TypeCancer.Text = dataGridViewMedical.SelectedRows[0].Cells[5].Value.ToString();
                    comboBox_StageCancer.Text = dataGridViewMedical.SelectedRows[0].Cells[6].Value.ToString();
                    comboBox_OccupationalHazard.Text = dataGridViewMedical.SelectedRows[0].Cells[7].Value.ToString();
                    comboBox_ChronicLungDisease.Text = dataGridViewMedical.SelectedRows[0].Cells[8].Value.ToString();
                    comboBox_ChestPain.Text = dataGridViewMedical.SelectedRows[0].Cells[9].Value.ToString();
                    comboBox_BloodCough.Text = dataGridViewMedical.SelectedRows[0].Cells[10].Value.ToString();
                    comboBox_FrequentCold.Text = dataGridViewMedical.SelectedRows[0].Cells[11].Value.ToString();
                    comboBox_DryCough.Text = dataGridViewMedical.SelectedRows[0].Cells[12].Value.ToString();
                    comboBox_BreathShortness.Text = dataGridViewMedical.SelectedRows[0].Cells[13].Value.ToString();
                    comboBox_Obesity.Text = dataGridViewMedical.SelectedRows[0].Cells[14].Value.ToString();
                    comboBox_Fatigue.Text = dataGridViewMedical.SelectedRows[0].Cells[15].Value.ToString();
                    comboBox_WeightLoss.Text = dataGridViewMedical.SelectedRows[0].Cells[16].Value.ToString();
                    comboBox_Level.Text = dataGridViewMedical.SelectedRows[0].Cells[17].Value.ToString();
                    comboBox_ServivalStatus.Text = dataGridViewMedical.SelectedRows[0].Cells[18].Value.ToString();
                    txtboxRoom_no.Text = dataGridViewMedical.SelectedRows[0].Cells[19].Value.ToString();
                    txtboxFloor_no.Text = dataGridViewMedical.SelectedRows[0].Cells[20].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Selection,Please select a row by double click");
            }
        }

       

        private void txtboxRoom_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{3}$");
            if (regex.IsMatch(txtboxRoom_no.Text))
            {
                e.Handled = true;

            }
        }

        private void txtboxFloor_no_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{1}$");
            if (regex.IsMatch(txtboxFloor_no.Text))
            {
                e.Handled = true;

            }
        }
    }
}

