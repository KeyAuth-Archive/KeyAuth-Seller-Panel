using Bunifu.UI.WinForms;
using KeyAuth_Seller_Panel.SellerPanel.Views;
using KeyAuth_Seller_Panel.SellerPanel.Views.PopUpViews;
using System;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.CustomControls
{
    public partial class HomeNav : UserControl
    {
        readonly int TotalApps;
        public HomeNav(int TotalApps)
        {
            InitializeComponent();
            this.TotalApps = TotalApps;
            NavGb.BorderColor = Properties.Settings.Default.AscentColor;

            AddNewAppBtn.onHoverState.FillColor = Properties.Settings.Default.AscentColor;
            AddNewAppBtn.OnIdleState.BorderColor = Properties.Settings.Default.AscentColor;
            AddNewAppBtn.OnIdleState.FillColor = Properties.Settings.Default.AscentColor;
            AddNewAppBtn.OnPressedState.BorderColor = Properties.Settings.Default.AscentColor;
            AddNewAppBtn.OnPressedState.FillColor = Properties.Settings.Default.AscentColor;
            AddNewAppBtn.Refresh();

            RemoveAllAppsBtn.onHoverState.FillColor = Properties.Settings.Default.AscentColor;
            RemoveAllAppsBtn.OnIdleState.BorderColor = Properties.Settings.Default.AscentColor;
            RemoveAllAppsBtn.OnIdleState.FillColor = Properties.Settings.Default.AscentColor;
            RemoveAllAppsBtn.OnPressedState.BorderColor = Properties.Settings.Default.AscentColor;
            RemoveAllAppsBtn.OnPressedState.FillColor = Properties.Settings.Default.AscentColor;
            RemoveAllAppsBtn.Refresh();

            SettingsBtn.onHoverState.FillColor = Properties.Settings.Default.AscentColor;
            SettingsBtn.OnIdleState.BorderColor = Properties.Settings.Default.AscentColor;
            SettingsBtn.OnIdleState.FillColor = Properties.Settings.Default.AscentColor;
            SettingsBtn.OnPressedState.BorderColor = Properties.Settings.Default.AscentColor;
            SettingsBtn.OnPressedState.FillColor = Properties.Settings.Default.AscentColor;
            SettingsBtn.Refresh();
        }

        private void AddNewAppBtn_Click(object sender, EventArgs e)
        {
            AddNewAppView addNewAppView = new AddNewAppView();
            addNewAppView.ShowDialog();
        }

        private void RemoveAllAppsBtn_Click(object sender, EventArgs e)
        {
            Notify.Show(HomeView.MainForm, HomeView.details.RemoveAllApps(), BunifuSnackbar.MessageTypes.Information, 5000, "", BunifuSnackbar.Positions.MiddleCenter);
            HomeView.details.LoadApps();
        }

        private void AboutBtn_Click(object sender, EventArgs e)
        {
            ProgramSettingsView programSettingsView = new ProgramSettingsView();
            if (programSettingsView.ShowDialog() == DialogResult.OK)
                Application.Restart();
        }

        private void HomeNav_Load(object sender, EventArgs e)
        {
            TotalAppsLb.Text = $"Total Applications: {TotalApps}";
        }
    }
}
