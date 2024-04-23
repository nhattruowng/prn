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
        public List<Book> GetBookList() =>
         new()
            {
            new Book(){BookId=01,BookName="Tuoi Tre dang gia Bao nhieu",Author = " ressio Nguyenn",BookCategoryId = 3 },
            new Book(){BookId=02,BookName="doi ngan dung ngu day",Author ="Robi" ,BookCategoryId = 2},
            new Book(){BookId = 03, BookName= "Minh la nang viec minh la choi chang", Quantity=3 ,BookCategoryId =1 }
            };
    }
}
