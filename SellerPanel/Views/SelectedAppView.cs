using Bunifu.UI.WinForms.BunifuButton;
using KeyAuth_Seller_Panel.SellerPanel.Views.SelectedAppControls;
using System;
using System.Collections.Specialized;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    public partial class SelectedAppView : Form
    {
        public static App app = new App();
        public static string SelectedApp;
        public static Form AppView;
        public static Panel AppViews;
        public class App
        {
            public string BannerUrl { get; set; }
            public string AppName { get; set; }
            public string SellerKey { get; set; }
            public string OwnerId { get; set; }
            public string AppSecret { get; set; }
        }
        

        private void SetAscentColors(Color color)
        {
            MainGroupB.BorderColor = color;
            MinButton.HoverState.IconColor = color;
            CloseButton.HoverState.IconColor = color;
            foreach (var button in bunifuPanel1.Controls.OfType<BunifuButton>())
            {
                button.onHoverState.FillColor = color;
                button.OnIdleState.BorderColor = color;
                button.OnIdleState.FillColor = color;
                button.OnPressedState.BorderColor = color;
                button.OnPressedState.FillColor = color;
                button.Refresh();
            }
        }

        public SelectedAppView(StringCollection App,string name)
        {
            app.BannerUrl = App[0];
            app.AppName = App[1];
            app.SellerKey = App[2];
            app.OwnerId = App[3];
            app.AppSecret = App[4];
            SelectedApp = name;
            InitializeComponent();
            SetAscentColors(Properties.Settings.Default.AscentColor);
            AppViews = AppViewsPanel;
            AppView = this;
            KeyAuthLb.Text = app.AppName;
            HomeView.sellerApi.SetSellerKey(app.SellerKey);
            if (!HomeView.sellerApi.response.Success)
            {
                AppInfoBtn.Enabled = false;
                LicensesButton.Enabled = false;
                UsersButton.Enabled = false;
                SubscriptionsButton.Enabled = false;
                BlacklistsButton.Enabled = false;
                VariablesButton.Enabled = false;
                FilesButton.Enabled = false;
                ChatsButton.Enabled = false;
                bunifuButton1.Enabled = false;
            }

        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void AppsButton_Click(object sender, EventArgs e)
        {
           AppStatsView appStatsView = new AppStatsView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(appStatsView);
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            SettingsView settingsView = new SettingsView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(settingsView);
        }

        private void SelectedAppView_Load(object sender, EventArgs e)
        {
            
            AppStatsView appStatsView = new AppStatsView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(appStatsView);
            HomeView.MainForm.Visible = false;
        }

        private void ChatsButton_Click(object sender, EventArgs e)
        {
            ChatsView chatsView = new ChatsView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(chatsView);
        }

        private void FilesButton_Click(object sender, EventArgs e)
        {
            FilesView filesView = new FilesView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(filesView);
        }

        private void VariablesButton_Click(object sender, EventArgs e)
        {
            VariablesView variablesView = new VariablesView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(variablesView);
        }

        private void BlacklistsButton_Click(object sender, EventArgs e)
        {
            BlackListsView blackListsView = new BlackListsView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(blackListsView);
        }

        private void SubscriptionsButton_Click(object sender, EventArgs e)
        {
            SubscriptionsView subscriptionsView = new SubscriptionsView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(subscriptionsView);
        }

        private void UsersButton_Click(object sender, EventArgs e)
        {
            UsersView usersView = new UsersView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(usersView);
        }

        private void LicensesButton_Click(object sender, EventArgs e)
        {
            LicensesView licensesView = new LicensesView();
            AppViews.Controls.Clear();
            AppViews.Controls.Add(licensesView);
        }

        private void HomeBtn_Click(object sender, EventArgs e)
        {
            HomeView.details.LoadApps();
            this.Close();
            HomeView.MainForm.Visible = true;
        }
    }
}
