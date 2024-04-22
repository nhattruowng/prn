using Services;

namespace WinFormsApp1
{
    public partial class ZodiacMain : Form
    {
        public ZodiacMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {
            String day = txtDay.Text;
            String month = txtMonth.Text;
            // MessageBox.Show(day + " \\ " + month, " Day and month ");
            if (int.Parse(month) <= 0 || int.Parse(month) > 12 || int.Parse(day) <= 0 || int.Parse(day) > 31)
                MessageBox.Show("Sai Thang Sai ngay ! ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
           else
            lblResure.Text += ZodiacCalculator.GetZodiacEnglish(int.Parse(month), int.Parse(day));

        }

        private void binQuit_Click(object sender, EventArgs e)
        {
            DialogResult anser = MessageBox.Show("Ban muon tat khong? ", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Stop);
            if (anser == DialogResult.Yes)
                Application.Exit();
        }

        private void lblResure_Click(object sender, EventArgs e)
        {

        }
    }
}
