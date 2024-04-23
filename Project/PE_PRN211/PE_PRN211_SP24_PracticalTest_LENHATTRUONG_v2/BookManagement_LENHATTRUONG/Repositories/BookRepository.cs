using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    // class truc tiep table nhuwng qua BookManagementDbContext.
    // thao tac truc tiep tren csdl SQL thong qua dependency vua add vao class 
    // class cung cap cac ham CRUD table Book nen moi goi la Bookreporitogy
    // dua va nhan data cho BookSevice 
    // UI - BookService - BookRepo - DbContext - Entitise - Db.
    // 
    public class BookRepository
    {
        // khai bao db context dai dien cho csdl.
        // dung moi neu.( Quan trong)
        // CRUD moi neu KHONG neu san.
        // dung ham nao neu ham do.
        private BookManagementDbContext _context;
        public List<Book> GetBooks() => new BookManagementDbContext().Books.ToList();

        // xoa 1 cuon sach
        public void DeleteBook(Book book)
        {
            _context = new();
            _context.Books.Remove(book);
            _context.SaveChanges();
        }

        public void CreateBook(Book book)
        {
            _context = new();
            _context.Books.Add(book);
            _context.SaveChanges();
        }

        public void UpdateBook(Book book)
        {
            _context = new();
            _context.Books.Update(book);
            _context.SaveChanges();
        }

    }
}
