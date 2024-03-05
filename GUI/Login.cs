using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GUI
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Apakah anda yakin akan keluar?", "Konfirmasi", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = tbUserId.Text.Trim();
            string password = tbPassword.Text.Trim();

            if(username =="Hassan" &&  password == "hassan")
            {
                Dashboard dashboard = new Dashboard();
                dashboard.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("User ID dan Password yang kamu masukkan tidak tepat.", "Pemberitahuan", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                tbUserId.SelectAll();
                tbUserId.Focus();
            }
        }
    }
}
