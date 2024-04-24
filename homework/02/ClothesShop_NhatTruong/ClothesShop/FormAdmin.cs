using Repositories.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClothesShop
{
    public partial class FormAdmin : Form
    {

        public User UserDetail { set; get; }
        public FormAdmin()
        {
            InitializeComponent();
        }
    }
    /*
     * Image originalImage = Image.FromFile("path/to/image.jpg");
int newWidth = 100; // Kích thước mới cho chiều rộng
int newHeight = 100; // Kích thước mới cho chiều cao
Image resizedImage = new Bitmap(originalImage, newWidth, newHeight);
ptrAvata.Image = resizedImage;
     */
}
