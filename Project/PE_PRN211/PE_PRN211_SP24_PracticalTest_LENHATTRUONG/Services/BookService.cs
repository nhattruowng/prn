using Repositories.Entities;

namespace Services
{

    // class nay trung gian giua UI (form) va DB nhan infor tu UI va dua vef Reposutori
    // do data tu Reposutori dua vao Ram => Ram vao UI.
    // ham ung voi tung nut tren mang hinh chinh.
    //

    //Ui goi BookService va Bookservice goi Repo
    // 
    public class BookService
    {
        /// hand - coded data cac cuon sach.
        public List<Book> GetBookList()
        {
            List<Book> list = new()
            {
            new Book(){BookId=01,BookName="Tuoi Tre dang gia Bao nhieu",Author = " ressio Nguyenn" },
            new Book(){BookId=02,BookName="doi ngan dung ngu day",Author ="Robi" },
            new Book(){BookId = 03, BookName= "Minh la nang viec minh la choi chang", Quantity=3 },
            };
            return list;
        }
    }
}
