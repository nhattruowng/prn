using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories.Entities
{
    public class Book
    {
        public int BookId { get; set; }
        public string BookName { get; set; }
        public string Description { get; set; }
        public string PublicationDate { get; set; }
        public int Quantity { get; set; }
        public float Price { get; set; }
        public string Author { get; set; }
        public int BookCategoryId { get; set; }


    }
}
/*
    BookId int PRIMARY KEY,
	BookName nvarchar(100) NOT NULL,
	Description nvarchar(1000) NOT NULL,
	PublicationDate datetime NOT NULL,
	Quantity int NOT NULL,
	Price float NOT NULL,
	Author nvarchar(50) NOT NULL,
	BookCategoryId int NOT NULL
 */