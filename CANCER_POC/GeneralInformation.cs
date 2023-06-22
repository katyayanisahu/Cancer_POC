using System.Data;
using System.Data.SqlClient;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CANCER_POC
{
    public partial class GeneralInformation : UserControl
    {
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-BH77SS1\SQLEXPRESS01;Initial Catalog=cancer_poc;Integrated Security=True");
   
        public GeneralInformation()
        {
            InitializeComponent();
            
        }


        public void disp_data()
        {
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandText = "select * from  general_information1";
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            da.Fill(dt);
        
        }


        private void GeneralInformation_Load(object sender, EventArgs e)
        {
            disp_data();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            string query = "INSERT INTO general_information1 VALUES(@name,@age,@dob,@gender,@address,@phone,@email)";

            SqlCommand cmd2 = new SqlCommand(query, con);

            cmd2.CommandType = CommandType.Text;

            //Pass values to Parameters

            cmd2.Parameters.AddWithValue("@name",txtboxName.Text);

            if (string.IsNullOrEmpty(txtboxName.Text.Trim()))
            {
                errorProviderName.SetError(txtboxName, "Name is required");
                return;
            }
            else
            {
                errorProviderName.SetError(txtboxName, string.Empty);

            }

            cmd2.Parameters.AddWithValue("@age", txtboxAge.Text);
            cmd2.Parameters.AddWithValue("@dob", dtpDOB.Value);
           
            if (rdbMale.Checked == true)
                cmd2.Parameters.AddWithValue("@Gender", "Male");

            else
                cmd2.Parameters.AddWithValue("@Gender", "Female");

            cmd2.Parameters.AddWithValue("@address", txtboxAddress.Text);
            if (string.IsNullOrEmpty(txtboxAddress.Text.Trim()))
            {
                errorProviderAddress.SetError(txtboxAddress, "Address is required");
                return;
            }
            else
            {
                errorProviderAddress.SetError(txtboxAddress, string.Empty);

            }
            cmd2.Parameters.AddWithValue("@phone", txtboxPhone.Text);

            cmd2.Parameters.AddWithValue("@email", txtboxEmail.Text);       

            
            if(string.IsNullOrEmpty(txtboxEmail.Text.Trim()))
            {
                errorProviderEmail.SetError(this.txtboxEmail, "Plzz provide valid Email ID");
            }
            else
            {
                errorProviderEmail.Clear();
            }

          
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

        private void txtboxPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            Regex regex = new Regex("^[0-9]{10}$");
            if (regex.IsMatch(txtboxPhone.Text))
            {
                e.Handled = true;

            }

        }

        private void txtboxName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsLetter(e.KeyChar) && !char.IsControl(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtboxAge_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) & (Keys)e.KeyChar != Keys.Back)
            {
                e.Handled = true;
            }
        }

      

        private void txtboxEmail_TextChanged(object sender, EventArgs e)
        {
            string pattern = @"^([a-zA-Z0-9_\.\-\+])+\@(([a-zA-Z0-9\-])+\.)+([a-za-za-z]{2,3})+$";
            if (Regex.IsMatch(txtboxEmail.Text, pattern))
            {
                errorProviderEmail.Clear();


            }
            else
            {
                errorProviderEmail.SetError(this.txtboxEmail, "Plzz provide valid email address");
            }
        }

        private void txtboxPhone_TextChanged(object sender, EventArgs e)
        {

        }
    }
   
}
