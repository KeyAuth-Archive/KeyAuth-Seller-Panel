using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views.SelectedAppControls
{
    public partial class AppStatsView : UserControl
    {
        public AppStatsView()
        {
            InitializeComponent();
        }
        private void SetAscentColors(Color color)
        {
            foreach (var button in bunifuPanel4.Controls.OfType<BunifuButton>())
            {
                button.onHoverState.FillColor = color;
                button.OnIdleState.BorderColor = color;
                button.OnIdleState.FillColor = color;
                button.OnPressedState.BorderColor = color;
                button.OnPressedState.FillColor = color;
                button.Refresh();
            }
            foreach (var textBox in bunifuPanel4.Controls.OfType<BunifuTextBox>())
            {
                textBox.OnIdleState.BorderColor = color;
                textBox.BorderColorIdle = color;
                textBox.Refresh();
            }
        }
        private void AppStatsView_Load(object sender, EventArgs e)
        {
            SetAscentColors(Properties.Settings.Default.AscentColor);
            if (SelectedAppView.app.BannerUrl == "")
                AppURL.Image = Properties.Resources.Banner;
            else
                AppURL.LoadAsync(SelectedAppView.app.BannerUrl);
            if (SelectedAppView.app.OwnerId == "YourOwnerId")
                OwnerIdTb.Text = "";
            else OwnerIdTb.Text = SelectedAppView.app.OwnerId;
            if (SelectedAppView.app.AppSecret == "YourAppSecret")
                AppSecretTb.Text = "";
            else AppSecretTb.Text = SelectedAppView.app.AppSecret;
            AppNameTb.Text = SelectedAppView.app.AppName;
            SellerKeyTb.Text = SelectedAppView.app.SellerKey;
            UrlTb.Text = SelectedAppView.app.BannerUrl;
            HomeView.sellerApi.AppStats();
            if (HomeView.sellerApi.response.Success)
            {
                var Stats = HomeView.sellerApi.Stats;
                Keyslb.Text = $"Total Keys : {Stats.Totalkeys}";
                UsedLb.Text = $"Used Keys : {Stats.Used}";
                UnusedLb.Text = $"Unused Keys : {Stats.Unused}";
                PausedLb.Text = $"Paused Keys : {Stats.Paused}";
                BannedLb.Text = $"Banned Keys : {Stats.Banned}";
                WebHoolLb.Text = $"Total Webhooks : {Stats.Webhooks}";
                FilesLb.Text = $"Total Files : {Stats.Files}";
                VarsLb.Text = $"Total Vars : {Stats.Vars}";
                ResellersLb.Text = $"Total Resellers : {Stats.Resellers}";
                MangersLb.Text = $"Total Mangers : {Stats.Managers}";
                AccountsLb.Text = $"Total Accounts : {Stats.Totalaccs}";
            }
            else
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to load please update details", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }  
            
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            if (OwnerIdTb.Text == "")
                OwnerIdTb.Text = "YourOwnerId";
            if (AppSecretTb.Text == "")
                AppSecretTb.Text = "YourAppSecret";
            StringCollection myCol = new StringCollection
            {
                UrlTb.Text,
                AppNameTb.Text,
                SellerKeyTb.Text,
                OwnerIdTb.Text,
                AppSecretTb.Text,
            };
            HomeView.details.UpdateApp(SelectedAppView.SelectedApp, myCol);
        }

        private void UrlTb_TextChanged(object sender, EventArgs e)
        {
                if (UrlTb.Text.Length > 15)
                    AppURL.LoadAsync(UrlTb.Text);
        }

        private void AppSecretTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(AppSecretTb.Text))
                AppSecretTb.UseSystemPasswordChar = true;
            else
                AppSecretTb.UseSystemPasswordChar = false;
        }

        private void OwnerIdTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(OwnerIdTb.Text))
                OwnerIdTb.UseSystemPasswordChar = true;
            else
                OwnerIdTb.UseSystemPasswordChar = false;
        }

        private void SellerKeyTb_TextChanged(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(SellerKeyTb.Text))
                SellerKeyTb.UseSystemPasswordChar = true;
            else
                SellerKeyTb.UseSystemPasswordChar = false;
        }
    }
}
