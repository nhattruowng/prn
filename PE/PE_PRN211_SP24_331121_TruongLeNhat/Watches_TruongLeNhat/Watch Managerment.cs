using Repositories.Models;
using Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Watches_TruongLeNhat
{
    public partial class Watch_Managerment : Form
    {
        public Watch_Managerment()
        {
            InitializeComponent();
        }

        private void Watch_Managerment_Load(object sender, EventArgs e)
        {
            dtaWatch.DataSource = new WatchService().GetAllWatchs();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string ts = txtSearchDescription.Text.ToLower();
            string name = txtSearchName.Text.ToLower();
            List<Watch> watchs = null; ;
            if (!string.IsNullOrEmpty(ts) && !string.IsNullOrEmpty(name))
            {
                watchs = new WatchService().GetAllWatchs().Where(x => x.WatchName.ToLower().Contains(name) || x.Description.Contains(ts)).ToList();
            }
            else if (!string.IsNullOrEmpty(ts) && string.IsNullOrEmpty(name))
            {
                watchs = new WatchService().GetAllWatchs().Where(x => x.Description.Contains(ts)).ToList();
            }
            else if (string.IsNullOrEmpty(ts) && !string.IsNullOrEmpty(name))
            {
                watchs = new WatchService().GetAllWatchs().Where(x => x.WatchName.ToLower().Contains(name)).ToList();
            }
            else
                watchs = new WatchService().GetAllWatchs();
            dtaWatch.DataSource = watchs;
        }

        private void btnCreat_Click(object sender, EventArgs e)
        {
            ShowDetail show = new ShowDetail();
            show.Check = 1;
            show.ShowDialog();
            dtaWatch.DataSource = new WatchService().GetAllWatchs();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (dtaWatch.SelectedRows != null)
            {
                DialogResult a = MessageBox.Show("Delete Watch!", "Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (a == DialogResult.Yes)
                    new WatchService().DeleteWatch((Watch)dtaWatch.SelectedRows[0].DataBoundItem);
            }
            dtaWatch.DataSource = new WatchService().GetAllWatchs();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (dtaWatch.SelectedRows.Count == 0)
            {
                DialogResult a = MessageBox.Show(" ... ", "Update", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }

            ShowDetail show = new ShowDetail();
            show.Check = 2;
            show.EditWatches = (Watch)dtaWatch.SelectedRows[0].DataBoundItem;
            show.ShowDialog();
            dtaWatch.DataSource = new WatchService().GetAllWatchs();
        }

        private void btnQuit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
