using Repositories.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watches_TruongLeNhat
{
    public partial class ShowDetail : Form
    {

        public int Check { get; set; } = 0;
        public Watch EditWatches { get; set; }
        public ShowDetail()
        {
            InitializeComponent();
        }

        private void lblHearder_Click(object sender, EventArgs e)
        {

        }

        private void ShowDetail_Load(object sender, EventArgs e)
        {
            BrandSer a = new BrandSer();
            cbbrand.DataSource = a.GetBrands();
            cbbrand.DisplayMember = "BrandName";
            cbbrand.ValueMember = "BrandId";
            if (Check == 1)
                lblHearder.Text = " Create Watch.";
            if (Check == 2)
            {
                lblHearder.Text = "Update Watch!";
                cbbrand.DataSource = new BrandSer().GetBrands();
                cbbrand.SelectedValue = EditWatches.BrandId;
                txtPrice.Text = EditWatches.Price.ToString();
                txtname.Text = EditWatches.WatchName;
                txtDis.Text = EditWatches.Description;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (Check == 1)
            {
                Watch watch = new()
                {
                    BrandId = cbbrand.SelectedValue.ToString(),
                    Description = txtDis.SelectedText,
                    Price = int.Parse(txtPrice.Text),
                    WatchName = txtname.Text
                };
                new WatchService().AddWatch(watch);
            }
            if (Check == 2)
            {
                EditWatches.WatchName = txtname.Text;
                EditWatches.Description = txtDis.Text;
                EditWatches.Price = int.Parse(txtPrice.Text);
                EditWatches.BrandId = cbbrand.SelectedValue.ToString();
                new WatchService().Update(EditWatches);
            }
            Close();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
