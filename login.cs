using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AplikasiDataPKL
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
            txt_password.UseSystemPasswordChar = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            string username = "admin";
            string password = "admin123";

            if (txt_username.Text == username && txt_password.Text == password)
            {
                MessageBox.Show("Login berhasil!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dashboard formdashboard = new dashboard();
                formdashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Username atau Password salah!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_username.Clear();
                txt_password.Clear();
                txt_username.Focus();
            }
        }

        private void showpassword_CheckedChanged(object sender, EventArgs e)
        {
            txt_password.UseSystemPasswordChar = !showpassword.Checked;
        }

        private void lbl_judul_Click(object sender, EventArgs e)
        {

        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}