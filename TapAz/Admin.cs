using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tapaz;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace TapAz
{
    public partial class Admin : Form
    {



        SqlConnection connection = new SqlConnection(ClassSqlConnect.ConSql);
        public Admin()
        {
            InitializeComponent();
        }

        void Getall()
        {
            try
            {
                // connection.Open();// Sqlle baglantini aciriq-----1ci duzeliw xetanin qarwisin almaq ucun
                string script = "SELECT * FROM Advert";// Sqlde bu tableni cagririq
                SqlCommand cmd = new SqlCommand(script, connection);//komanda veririk ve klasda qeyd etdiymiz baglantini Sqlconnection vasitesile qowuruq
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);// Sqlden melumati cekirik
                DataTable dt = new DataTable();//Cedvel yaradiriq
                adapter.Fill(dt);//Fill acar sozu vasitesile yaradtdigmiz cedveli sqlden cekdiymiz melumatlarla doldururuq
                dataGridView1.DataSource = dt;//datagridview-u Datasource acar sozu ile doldururuq
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();//baglantini bagliyiriq
            }
        }
        private void buttonRefresh_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();// Sqlle baglantini aciriq
                string script = "SELECT * FROM Advert";// Sqlde bu tableni cagririq
                SqlCommand cmd = new SqlCommand(script, connection);//komanda veririk ve klasda qeyd etdiymiz baglantini Sqlconnection vasitesile qowuruq
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);// Sqlden melumati cekirik
                DataTable dt = new DataTable();//Cedvel yaradiriq
                adapter.Fill(dt);//Fill acar sozu vasitesile yaradtdigmiz cedveli sqlden cekdiymiz melumatlarla doldururuq
                dataGridView1.DataSource = dt;//datagridview-u Datasource acar sozu ile doldururuq
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();//baglantini bagliyiriq
            }


        }

        private void buttonSearch_Click(object sender, EventArgs e)
        {
            try
            {

                connection.Open();
                string search = "SELECT * FROM Advert WHERE NAME=@Name";
                SqlCommand cmd = new SqlCommand(search, connection);
                cmd.Parameters.AddWithValue("@Name", textBoxSearch.Text);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);
              

                dataGridView1.DataSource = dt;
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            //if (dataGridView1.Rows.Count.ToString()!=string.Empty)
            //{
            //    MessageBox.Show("Tapildi");
            //}

        }

        void Delete(int id)
        {
            try
            {
                connection.Open();
                string script = "DELETE FROM Advert WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elan silindi..");
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }


        private void buttonDelete_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow item in dataGridView1.SelectedRows)
            {
                int id = Convert.ToInt32(item.Cells[0].Value);
                Delete(id);//Secilen rowa gore silirik
                Getall();//sildikden sora avtomatik datagridviewda gorunmesi ucun bu metoddan istifade edirik yeni yeniliyirik
            }

        }

        void Update()
        {
            try
            {
                connection.Open();
                string script = "UPDATE Advert SET NAME=@Name WHERE ID=@Id";
                SqlCommand cmd = new SqlCommand(script, connection);
                cmd.Parameters.AddWithValue("@Name", textBoxUpdate.Text);
                cmd.Parameters.AddWithValue("@Id", textBoxID.Text);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Elan Redakte edildi");
                Getall();
                connection.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if(textBoxID.Text ==string.Empty && textBoxUpdate.Text == string.Empty)
            {
                MessageBox.Show("Xahis olunur redakte edeceyniz setiri secin..");
            }
            else
            {
                Update();
            }

            

        }


        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int i = 0;
            i = e.RowIndex;//Click elediymiz Rowd-du onun deyeri i-ye duwur
            textBoxUpdate.Text = dataGridView1.Rows[i].Cells[5].Value.ToString();
            textBoxID.Text = dataGridView1.Rows[i].Cells[0].Value.ToString();// Butun rowlarin adini deyiwmemesi ucun verilen Id textboxudur
                                                                             // sirf select olunan rowun adini deyismesi ucun verilib
            connection.Close();
        }

        private void buttonDelete_MouseMove(object sender, MouseEventArgs e)
        {
            buttonDelete.BackColor = Color.Red;
        }

        private void buttonDelete_MouseLeave(object sender, EventArgs e)
        {
            buttonDelete.BackColor = Color.White;
        }

        private void buttonRefresh_MouseMove(object sender, MouseEventArgs e)
        {
            buttonRefresh.BackColor = Color.Green;
        }

        private void buttonRefresh_MouseLeave(object sender, EventArgs e)
        {
            buttonRefresh.BackColor = Color.White;
        }

        private void buttonUpdate_MouseMove(object sender, MouseEventArgs e)
        {
            buttonUpdate.BackColor = Color.Yellow;
        }

        private void buttonUpdate_MouseLeave(object sender, EventArgs e)
        {
            buttonUpdate.BackColor = Color.White;
        }

        private void buttonSearch_MouseMove(object sender, MouseEventArgs e)
        {
            buttonSearch.BackColor = Color.Blue;
        }

        private void buttonSearch_MouseLeave(object sender, EventArgs e)
        {
            buttonSearch.BackColor= Color.White;
        }
    }
}
