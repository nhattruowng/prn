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
    public partial class Show_Detail : Form
    {
        public Show_Detail()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Show_Detail_Load(object sender, EventArgs e)
        {
            dtaBook.DataSource = new BookService().GetBookList();

        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            DetailBook dt = new DetailBook();
            dt.Text = "Create Book";
            dt.Set = 1;
            dt.ShowDialog();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            DetailBook dt = new DetailBook();
            dt.Text = "Update Book";
            dt.Set = 2;
            dt.ShowDialog();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult a= MessageBox.Show("Ban co muon thoat App khong?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(a == DialogResult.Yes) 
                Application.Exit();
        }
    }
}
