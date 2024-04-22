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
    public partial class DetailBook : Form
    {
        public int Set { set; get; } = 1;
        private BookCategoryService _bookCategoryService = new();
        public DetailBook()
        {
            InitializeComponent();
        }

        private void DetailBook_Load(object sender, EventArgs e)
        {
            cboBookCategory.DataSource = _bookCategoryService.GetAllBookCategory();
            cboBookCategory.DisplayMember = "BookGenreType";
            cboBookCategory.ValueMember = "BookCategoryId";
            if (Set == 1)
                lblHearder.Text = " Creat Book";
            else
                lblHearder.Text = "Update Book";
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            MessageBox.Show(cboBookCategory.SelectedValue.ToString());
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Ban co muon thoat App khong?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
                Close();
        }
    }
}
