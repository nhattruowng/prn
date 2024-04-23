using Repositories;
using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookService
    {
        private BookRepository _repository = new();
        public List<Book> GetBookList() => _repository.GetBooks();


        public void DeleteBook(Book book) =>
            _repository.DeleteBook(book);


        public void CreatBook(Book book) =>
            _repository.CreateBook(book);

        public void UpdateBook(Book book) => 
            _repository.UpdateBook(book);

    }
}
