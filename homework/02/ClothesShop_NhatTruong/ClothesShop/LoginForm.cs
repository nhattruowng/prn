using Repositories.Entities;
using Services;

namespace ClothesShop
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            User? a = new UserServices().GetUser(txtGmail.Text, txtPass.Text, out int i);
            if (a == null)
                MessageBox.Show("Dang nhap That bai!", "Login",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);

            FormAdmin admin = new();
            admin.UserDetail = a;
            admin.Show();
            this.Hide();

        }


        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Thoat App", "Exit",
                  MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
                Close();
        }
    }
}

