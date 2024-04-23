using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookManagement_LENHATTRUONG
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Ban co muon thoat App khong?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
                Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (!new UserAccountService().IsLoggedIn(txtGmail.Text, txtPassWord.Text))
            {
                DialogResult b = MessageBox.Show("Dang nhap That Bai !", "Login", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            txtGmail.Text = null;
            txtPassWord.Text = null;
            using (Show_Detail a = new Show_Detail())
                a.ShowDialog();
        }
    }
}
