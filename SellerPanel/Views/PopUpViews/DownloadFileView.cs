using System;
using System.Drawing;
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

        private void DownloadBtn_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "EXE|*.exe|TXT|*.txt|BMP|*.bmp|GIF|*.gif|JPG|*.jpg;*.jpeg|PNG|*.png|TIFF|*.tif;*.tiff|CSV|*.csv|MP4|*.mp4",
                Title = "Pick where to save your downloaded file."
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                bool start = false;
                bool runAsAdmin = false;
                if (AutoStartToggle.Checked)
                    start = true;
                if (RunAsAdminToggle.Checked)
                    runAsAdmin = true;
                string response = HomeView.sellerApi.FileDownload(FileUrlTb.Text, sfd.FileName, start, runAsAdmin);
                if (response.Contains("Successfully"))
                    Notify.Show(new HomeView(), response, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                else
                    Notify.Show(new HomeView(), response, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
        }

        private void AutoStartToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (AutoStartToggle.Checked)
            {
                AutoStartLb.Text = "Yes";
                RunAsAdminToggle.Enabled = true;
            }
            else
            {
                AutoStartLb.Text = "No";
                RunAsAdminToggle.Checked = false;
                RunAsAdminToggle.Enabled = false;
            }
        }

        private void DownloadFileView_Load(object sender, EventArgs e)
        {
            AutoStartToggle.Checked = false;
            RunAsAdminToggle.Checked = false;
            foreach(var Id in HomeView.sellerApi.files.All)
                IdListDd.Items.Add(Id.Id);
            IdListDd.Text = "Your file";
        }

        private void RunAsAdminToggle_CheckedChanged(object sender, EventArgs e)
        {
            if (RunAsAdminToggle.Checked)
                RunAsAdminLb.Text = "Yes";
            else
                RunAsAdminLb.Text = "No";
        }

        private void IdListDd_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (var var in HomeView.sellerApi.files.All)
                if (IdListDd.SelectedItem.ToString() == var.Id)
                    FileUrlTb.Text = var.Url;
        }
    }
}
