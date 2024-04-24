using Repositories.Entities;
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
        public Book EditBook { set; get; }
        public DetailBook()
        {
            InitializeComponent();
        }

        private void DetailBook_Load(object sender, EventArgs e)
        {
            cboBookCategory.DataSource = _bookCategoryService.GetAllBookCategory();
            cboBookCategory.DisplayMember = "BookGenreType";
            string a = cboBookCategory.ValueMember = "BookCategoryId";
            if (Set == 1)
            {
                lblHearder.Text = " Creat Book";
                grDetail.Text = " Creat Detail Book ";
               // txtId.Text = (string)new BookService().GetBookList().FindLast();
            }
            else
            {
                lblHearder.Text = "Update Book";
                grDetail.Text = " Update Detail Book ";

                txtId.Text = EditBook.BookId.ToString();
                txtId.Enabled = false;
                txtNameBook.Text = EditBook.BookName;
                cboBookCategory.SelectedValue = EditBook.BookCategoryId;
                txtAuthor.Text = EditBook.Author;
                txtPrice.Text = EditBook.Price.ToString();
                txtDescription.Text = EditBook.Description;
                dtpPub.Value = EditBook.PublicationDate;
                numQuantity.Value = EditBook.Quantity;
                cboBookCategory.SelectedValue = EditBook.BookCategoryId;   
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (Set == 2) // update book
            {
                // id k cho sua
                EditBook.Author = txtAuthor.Text;
                EditBook.BookName = txtNameBook.Text;
                EditBook.Price = double.Parse(txtPrice.Text);
                EditBook.Description = txtDescription.Text;
                EditBook.PublicationDate = dtpPub.Value;
                EditBook.Quantity = (int)numQuantity.Value;
                EditBook.BookCategoryId = int.Parse(cboBookCategory.SelectedValue.ToString());


                new BookService().UpdateBook(EditBook); /// truyen khai ham Update(book)

                MessageBox.Show("Update book succesfunly","Update",
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            if (Set == 1) /// tao book moi
            {
                // tao 1 book vao dua truc tiep vao CreatBook().
                new BookService().CreatBook(new()
                {
                    Author = txtAuthor.Text,
                    BookName = txtNameBook.Text,
                    Price = double.Parse(txtPrice.Text),
                    Description = txtDescription.Text,
                    PublicationDate = dtpPub.Value,
                    Quantity = (int)numQuantity.Value,
                    BookId = int.Parse(txtId.Text),
                    BookCategoryId = (int)cboBookCategory.SelectedValue
                });
                MessageBox.Show("Create book succesfunly", "Create", 
                    MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Ban co muon thoat App khong?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
                Close();
        }
    }
}
