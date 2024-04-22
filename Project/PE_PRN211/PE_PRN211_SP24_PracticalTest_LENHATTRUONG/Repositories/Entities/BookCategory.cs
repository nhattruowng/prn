using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class BookCategory
    {
        public int BookCategoryId { get; set; }
        public string BookGenreType { get; set; }
        public string Description { get; set; }



    }
    /**
     BookCategoryId int PRIMARY KEY,
	BookGenreType nvarchar(50) NOT NULL,
	Description nvarchar(500) NOT NULL
     */
}
