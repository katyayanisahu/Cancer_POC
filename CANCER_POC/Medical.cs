using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;

namespace CANCER_POC
{
    public partial class Medical : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BH77SS1\SQLEXPRESS01;Initial Catalog=cancer_poc;Integrated Security=True");
        private int indexRow;
        public Medical()
        {
            InitializeComponent();
        }

       
        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from  medical_information1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
            dataGridViewMedical.DataSource = dt;
        }
        private void Medical_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void txtboxName_cancer_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
          
            string query = "INSERT INTO medical_information1(blood_group,smoking,alcohol,name_cancer,type_cancer,cancer_subtype,stage_cancer,occupational_hazard,chronic_lung_disease,chest_pain,blood_cough,frequent_cold,dry_cough,breath_shortness,obesity,fatigue,weight_loss,survival_status,room_no,floor_no) VALUES(@blood_group,@smoking,@alcohol,@name_cancer,@type_cancer,@cancer_subtype,@stage_cancer,@occupational_hazard,@chronic_lung_disease,@chest_pain,@blood_cough,@frequent_cold,@dry_cough,@breath_shortness,@obesity,@fatigue,@weight_loss,@survival_status,@room_no,@floor_no)";

            SqlCommand cmd2 = new SqlCommand(query, con);

            cmd2.CommandType = CommandType.Text;

            //Pass values to Parameters
           
            cmd2.Parameters.AddWithValue("@blood_group", textboxBlood_group.Text);
            cmd2.Parameters.AddWithValue("@smoking", txtboxSmoking.Text);
            cmd2.Parameters.AddWithValue("@alcohol", txtboxAlcohol.Text);
            cmd2.Parameters.AddWithValue("@name_cancer", combobox_NameCancer.Text);
            cmd2.Parameters.AddWithValue("@type_cancer", comboBox_TypeCancer.Text);
            cmd2.Parameters.AddWithValue("@cancer_subtype", comboBox_CancerSubtype.Text);
            cmd2.Parameters.AddWithValue("@stage_cancer", txtboxStage_cancer.Text);
            cmd2.Parameters.AddWithValue("@occupational_hazard", textBoxOccupational_hazard.Text);
            cmd2.Parameters.AddWithValue("@chronic_lung_disease", txtboxChronic_lung_disease.Text);
            cmd2.Parameters.AddWithValue("@chest_pain", txtboxChest_pain.Text);
            cmd2.Parameters.AddWithValue("@blood_cough", txtboxBlood_cough.Text);
            cmd2.Parameters.AddWithValue("@frequent_cold", txtboxFrequent_cold.Text);
            cmd2.Parameters.AddWithValue("@dry_cough", txtboxDrycough.Text);
            cmd2.Parameters.AddWithValue("@breath_shortness", txtboxBreath_shortness.Text);
            cmd2.Parameters.AddWithValue("@obesity", txtboxObesity.Text);
            cmd2.Parameters.AddWithValue("@fatigue", txtbox_Fatigue.Text);
            cmd2.Parameters.AddWithValue("@weight_loss", txtboxWeight_loss.Text);
            cmd2.Parameters.AddWithValue("@survival_status", txtboxServival_status.Text);
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
            newdata.Cells[1].Value = textboxBlood_group.Text;
            newdata.Cells[2].Value = txtboxSmoking.Text;
            newdata.Cells[3].Value = txtboxAlcohol.Text;
            newdata.Cells[4].Value = combobox_NameCancer.Text;
            newdata.Cells[5].Value = comboBox_TypeCancer.Text;
            newdata.Cells[6].Value = comboBox_CancerSubtype.Text;
            newdata.Cells[7].Value = txtboxStage_cancer.Text;
            newdata.Cells[8].Value = textBoxOccupational_hazard.Text;
            newdata.Cells[9].Value = txtboxChronic_lung_disease.Text;
            newdata.Cells[10].Value = txtboxChest_pain.Text;
            newdata.Cells[11].Value = txtboxBlood_cough.Text;
            newdata.Cells[12].Value = txtboxFrequent_cold.Text;
            newdata.Cells[13].Value = txtboxDrycough.Text;
            newdata.Cells[14].Value = txtboxBreath_shortness.Text;
            newdata.Cells[15].Value = txtboxObesity.Text;
            newdata.Cells[16].Value = txtbox_Fatigue.Text;
            newdata.Cells[17].Value = txtboxWeight_loss.Text;
            newdata.Cells[18].Value = txtboxServival_status.Text;
            newdata.Cells[19].Value = txtboxRoom_no.Text;
            newdata.Cells[20].Value = txtboxFloor_no.Text;
            MessageBox.Show("Records Updated Successfully");
            textboxBlood_group.Text = " ";
            txtboxSmoking.Text = " ";
            txtboxAlcohol.Text = " ";
            combobox_NameCancer.Text = " ";
            comboBox_TypeCancer.Text = " ";
            comboBox_CancerSubtype.Text = " ";
            txtboxStage_cancer.Text = " ";
            textBoxOccupational_hazard.Text = " ";
            txtboxChronic_lung_disease.Text = " ";
            txtboxChest_pain.Text = " ";
            txtboxBlood_cough.Text = " ";
            txtboxFrequent_cold.Text = " ";
            txtboxDrycough.Text = " ";
            txtboxBreath_shortness.Text = " ";
            txtboxObesity.Text = " ";
            txtbox_Fatigue.Text = " ";
            txtboxWeight_loss.Text = " ";
            txtboxServival_status.Text = " ";
            txtboxRoom_no.Text = " ";
            txtboxFloor_no.Text = " ";

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewMedical_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            try
            {

                if (dataGridViewMedical.SelectedRows.Count >= 0)
                {
                    textboxBlood_group.Text = dataGridViewMedical.SelectedRows[0].Cells[1].Value.ToString();
                    txtboxSmoking.Text = dataGridViewMedical.SelectedRows[0].Cells[2].Value.ToString();
                    txtboxAlcohol.Text = dataGridViewMedical.SelectedRows[0].Cells[3].Value.ToString();
                    combobox_NameCancer.Text = dataGridViewMedical.SelectedRows[0].Cells[4].Value.ToString();
                    comboBox_TypeCancer.Text = dataGridViewMedical.SelectedRows[0].Cells[5].Value.ToString();
                    comboBox_CancerSubtype.Text = dataGridViewMedical.SelectedRows[0].Cells[6].Value.ToString();
                    txtboxStage_cancer.Text = dataGridViewMedical.SelectedRows[0].Cells[7].Value.ToString();
                    textBoxOccupational_hazard.Text = dataGridViewMedical.SelectedRows[0].Cells[8].Value.ToString();
                    txtboxChronic_lung_disease.Text = dataGridViewMedical.SelectedRows[0].Cells[9].Value.ToString();
                    txtboxChest_pain.Text = dataGridViewMedical.SelectedRows[0].Cells[10].Value.ToString();
                    txtboxBlood_cough.Text = dataGridViewMedical.SelectedRows[0].Cells[11].Value.ToString();
                    txtboxFrequent_cold.Text = dataGridViewMedical.SelectedRows[0].Cells[12].Value.ToString();
                    txtboxDrycough.Text = dataGridViewMedical.SelectedRows[0].Cells[13].Value.ToString();
                    txtboxBreath_shortness.Text = dataGridViewMedical.SelectedRows[0].Cells[14].Value.ToString();
                    txtboxObesity.Text = dataGridViewMedical.SelectedRows[0].Cells[15].Value.ToString();
                    txtbox_Fatigue.Text = dataGridViewMedical.SelectedRows[0].Cells[16].Value.ToString();
                    txtboxWeight_loss.Text = dataGridViewMedical.SelectedRows[0].Cells[17].Value.ToString();
                    txtboxServival_status.Text = dataGridViewMedical.SelectedRows[0].Cells[18].Value.ToString();
                    txtboxRoom_no.Text = dataGridViewMedical.SelectedRows[0].Cells[19].Value.ToString();
                    txtboxFloor_no.Text = dataGridViewMedical.SelectedRows[0].Cells[20].Value.ToString();

                }
            }
            catch (Exception)
            {
                MessageBox.Show("Invalid Selection,Please select a row by double click");
            }
        }

    
    }
}
