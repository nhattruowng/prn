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
    public partial class Save : Form
    {
        public int _editMode { get; set; } = 1;

        private BookCategoryService _bookCategoryService = new();
        public Save()
        {
            InitializeComponent();
        }

        private void BookDetail_Load(object sender, EventArgs e)
        {
            // tu chay khi mang hinh delta ddc mo
            // mang hinh mo se lm nhu viec:
            //1 doi che do phu hop
            //2. doi data vao dropdow
            //3. neu edit thi fall data sach muon edit.
            // ta dung bien class de luu mode hinh anh
            // khi nhan nut uI doi class/
            cboBookCategory.DataSource = _bookCategoryService.GetAllBookCategory();
            cboBookCategory.DisplayMember = "BookGenreType";
            cboBookCategory.ValueMember = "BookCategoryId";
            if (_editMode == 1)
            {
                lblName.Text = "Add Book";
            }
            else
            {
                lblName.Text = "Update Book";
                cboBookCategory.SelectedValue = 2;
            }
            // dropdown 
           
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            /// show value chon
            String category = cboBookCategory.SelectedValue.ToString();
            MessageBox.Show(category);
        }
    }
}
