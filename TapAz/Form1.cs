using System.Data;
using System.Data.SqlClient;
using TapAz;

namespace Tapaz
{
    public partial class Form1 : Form
    {
        SqlConnection conn = new SqlConnection(ClassSqlConnect.ConSql);
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGirish_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
        }
        void Sifirlama()
        {
            textBoxAd.Text = string.Empty;
            numericUpDown1.Value = 0;
            textBoxEmail.Text = string.Empty;
            textBoxMezmun.Text = string.Empty;
            comboBoxKateqoriya.Text = "Siyahidan Secin";
            cmbxSeher.Text = cmbxSeher.Items[0].ToString();
            cmbZeng.Text = cmbZeng.Items[0].ToString();
            maskedTextBox1.Text = string.Empty;

        }

        private void buttoGonder_Click(object sender, EventArgs e)
        {
            try
            {
                conn.Open();
                string script = "INSERT INTO Advert VALUES(@Category,@City,@Price,@Information,@Name,@Email,@Callstype,@Phone_number)";
                SqlCommand cmd = new SqlCommand(script, conn);
                cmd.Parameters.AddWithValue("@Category", comboBoxKateqoriya.Text);
                cmd.Parameters.AddWithValue("@City", cmbxSeher.Text);
                cmd.Parameters.AddWithValue("@Price", numericUpDown1.Text);
                cmd.Parameters.AddWithValue("@Information", textBoxMezmun.Text);
                cmd.Parameters.AddWithValue("@Name", textBoxAd.Text);
                cmd.Parameters.AddWithValue("@Email", textBoxEmail.Text);
                cmd.Parameters.AddWithValue("@Callstype", cmbZeng.Text);
                cmd.Parameters.AddWithValue("@Phone_number", maskedTextBox1.Text);
                cmd.ExecuteNonQuery();
                SqlDataAdapter Sda = new SqlDataAdapter(cmd);
                MessageBox.Show("Elan elave olundu");
                Sifirlama();
                conn.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}