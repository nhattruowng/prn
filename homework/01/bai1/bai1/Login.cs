using ExamMain;
using System.Windows.Forms;

namespace bai1
{
    public partial class Main1 : Form
    {
        public Main1()
        {
            InitializeComponent();
        }

        private void Main1_Load(object sender, EventArgs e)
        {

        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string code = txtCode.Text;
            string name = txtName.Text;
            string pass = txtPass.Text;

            DialogResult a= MessageBox.Show($"code = {code} \n name = {name} " +$"\n pass = {pass}","information",MessageBoxButtons.YesNo,MessageBoxIcon.Error);
            if (a == DialogResult.Yes)
            {
                new ExamMain.ExamMain().Show();              
            }
        }
    }
}
