﻿using Repositories.Entities;
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


        // reset lai luoi
        private void FillDataToGrid(List<Book> book) =>
            dgvBookList.DataSource = book;

        private void Show_Detail_Load(object sender, EventArgs e)
        {
            FillDataToGrid(new BookService().GetBookList());
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            DetailBook dt = new DetailBook();
            dt.Text = "Create Book";
            dt.Set = 1;
            dt.ShowDialog();
            FillDataToGrid(new BookService().GetBookList());
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // bat truoc khi mo form update, edit, delete ktr user chon chua.
            // user chon thi dgvBookList dc win bao va tu cap nhat propety so dong chon va nhung dong gi.
            // 
            if (dgvBookList.SelectedRows.Count == 0)
            {
                MessageBox.Show("chua chon dong nao het", "Thong bao");
                return;
            }


            Book _book = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
            // dataSource = List<book> dua vao.
            // MessageBox.Show(_book.BookName);


            DetailBook dt = new DetailBook();
            dt.Text = "Update Book";
            dt.Set = 2;
            dt.EditBook = _book; /// gan _book vao form update.
            dt.ShowDialog();
            FillDataToGrid(new BookService().GetBookList());

        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Ban co muon thoat App khong?", "Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (a == DialogResult.Yes)
                Application.Exit();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            String key = txtBookName.Text.ToLower();
            List<Book> List = new BookService().GetBookList().Where(x =>
                            x.BookName.ToLower().Contains(key)).ToList();

            //dgvBookList.DataSource = List;
            FillDataToGrid(List);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dgvBookList.SelectedRows.Count == 0)
            {
                MessageBox.Show("chua chon dong nao de xoa", "Thong bao");
                return;
            }

            DialogResult a = MessageBox.Show("Ban co muon xoa khong?", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (a == DialogResult.Yes)
            {
                Book _book = (Book)dgvBookList.SelectedRows[0].DataBoundItem;
                new BookService().DeleteBook(_book);
                FillDataToGrid(new BookService().GetBookList());
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult a = MessageBox.Show("Ban co muon Dang Xuat khong?", "LogOut", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (a == DialogResult.Yes)
                Close();
        }
    }
}
