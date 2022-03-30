using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    public partial class DownloadFileView : Form
    {
        public DownloadFileView()
        {
            InitializeComponent();

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void App1LoadButton_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "EXE|*.exe|TXT|*.txt|BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|CSV|*.csv";
            sfd.FileName = "App";
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bool start = true;
                bool overwrite = true;
                if (AppEnabled.Checked)
                    start = true;
                if (!AppEnabled.Checked)
                    start = false;
                if (HwidLockEnabled.Checked)
                    overwrite = true;
                if (!HwidLockEnabled.Checked)
                    overwrite = false;
                HomeView.sellerApi.FileDownload(Convert.ToInt32(IdListDd.SelectedItem), sfd.FileName, start, overwrite);
                if (HomeView.sellerApi.response.Success)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

                if (!HomeView.sellerApi.response.Success)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
          

        }

        private void AppEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (AppEnabled.Checked)
                AppEnabledLb.Text = "Yes";
            else if (!AppEnabled.Checked)
                AppEnabledLb.Text = "No";
        }

        private void DownloadFileView_Load(object sender, EventArgs e)
        {
            AppEnabled.Checked = true;
            HwidLockEnabled.Checked = true;
            foreach(var Id in HomeView.sellerApi.files.All)
                IdListDd.Items.Add(Id.Id);
            IdListDd.SelectedIndex = 0;
        }

        private void HwidLockEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (HwidLockEnabled.Checked)
                HwidLockEnabledLb.Text = "Yes";
            else if (!HwidLockEnabled.Checked)
                HwidLockEnabledLb.Text = "No";
        }
    }
}
