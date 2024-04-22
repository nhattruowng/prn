using Repositories.Entities;
using Services;

namespace BookManagement_LENHATTRUONG
{
    public partial class ManagerBook : Form
    {
        /// <summary>
        /// _booService chua cac ham backing
        /// </summary>
        private BookService _bookService = new BookService();


        public ManagerBook()
        {
            InitializeComponent();
        }

        private void ManagerBook_Load(object sender, EventArgs e)
        {
            /// mang hinh show thi ham auto run 
            /// load data tu table db do vao.

            // BookService se cung cap data tu table 
            // 1 table db map voi 1 class Entities 
            // book == table book 
            // booksevice == cabinet<??>


            dgvBookList.DataSource = null;
            dgvBookList.DataSource = _bookService.GetBookList();



        }

        private void btnCreatBook_Click(object sender, EventArgs e)
        {
            Save f = new Save();
            f._editMode = 1;
            f.Text = "Creat Book";
            f.ShowDialog(); // dong moi tro lai main 
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            Save f = new Save();
            f._editMode = 2;
            f.Text = "Update Book";
            f.ShowDialog();
        }

     
    }
}
