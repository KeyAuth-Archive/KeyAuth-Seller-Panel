using Bunifu.UI.WinForms;
using KeyAuth_Seller_Panel.SellerPanel.Classes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    public partial class AddNewAppView : Form
    {
        public AddNewAppView()
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
            if(string.IsNullOrWhiteSpace(AppPicURL.Text) || !AppPicURL.Text.Contains("https://"))
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "You must set a vaild URL for your banner", BunifuSnackbar.MessageTypes.Error, 5000, "", BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            StringCollection myCol = new StringCollection
                {
                    AppURL.ImageLocation,
                    AppName.Text,
                    SellerKey.Text,
                    "YourOwnerId",
                    "YourAppSecret",
                    "YourUser",
                    "YourUserPassword"
                };
            string result = HomeView.details.SaveApp(myCol);
            if (!result.Contains("Failed"))
            {
                bunifuSnackbar1.Show(HomeView.MainForm, result, BunifuSnackbar.MessageTypes.Success, 5000, "", BunifuSnackbar.Positions.MiddleCenter);
                HomeView.details.LoadApps();
                this.Close();
            }
            else
            {
                bunifuSnackbar1.Show(HomeView.MainForm, result, BunifuSnackbar.MessageTypes.Error, 5000, "", BunifuSnackbar.Positions.MiddleCenter);
                AppPicURL.Clear();
                AppName.Clear();
                SellerKey.Clear();
            }
        }

        private void AppPicURL_TextChanged(object sender, EventArgs e)
        {
            if (AppPicURL.Text.Length > 15)
                AppURL.LoadAsync(AppPicURL.Text);
        }

        private void AddNewAppView_Load(object sender, EventArgs e)
        {

        }

        private void Card_Enter(object sender, EventArgs e)
        {

        }

        private void SellerKey_TextChanged(object sender, EventArgs e)
        {
            if(!string.IsNullOrWhiteSpace(SellerKey.Text))
                SellerKey.UseSystemPasswordChar = true;
            else
                SellerKey.UseSystemPasswordChar=false;
        }
    }
}
