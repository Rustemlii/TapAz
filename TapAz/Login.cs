using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TapAz
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if (textBoxUserName.Text.ToLower() == "kamil" && textBoxPassword.Text.ToLower() == "123")
            {
                Admin admin = new Admin();
                admin.Show();
                Hide();
            }
            else
            {
                MessageBox.Show("Xeta", "Parol ve ya Login Yanlisdir", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
