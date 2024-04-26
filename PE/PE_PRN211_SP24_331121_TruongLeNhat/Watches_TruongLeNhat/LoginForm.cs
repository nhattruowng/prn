using Microsoft.VisualBasic.ApplicationServices;
using Repositories.Models;
using Services;

namespace Watches_TruongLeNhat
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            String mail = txtEmail.Text;
            string pass = txtPassword.Text;
            Member a = new UserService().CheckLogin(mail, pass);
            if (a == null)
            {
                MessageBox.Show("You have no permission to access this function!","Erro",MessageBoxButtons.OK);
                return;
            }
            Watch_Managerment watch_Managerment = new Watch_Managerment();
            watch_Managerment.Show();
            this.Hide();
        }
    }
}
