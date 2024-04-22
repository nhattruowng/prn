using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class BookCategoryService
    {
        public List<BookCategory> GetAllBookCategory()
        {
            return new ()
            {
                new BookCategory(){BookCategoryId = 1,BookGenreType = "fiction", Description = "ald" },
                new BookCategory(){BookCategoryId = 2,BookGenreType = "Science Fiction", Description = "ald"},
                new BookCategory(){BookCategoryId = 3,BookGenreType = "Historical Fiction" , Description = "ald"}
            };
        }
    }
}
