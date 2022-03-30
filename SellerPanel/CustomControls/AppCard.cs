using KeyAuth_Seller_Panel.SellerPanel.Views;
using System;
using System.Collections.Specialized;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.CustomControls
{
    public partial class AppCard : UserControl
    {
        public StringCollection App;
        public string SelectedApp;

        public AppCard(StringCollection App , string SelectedApp)
        {
            this.App = App;
            this.SelectedApp = SelectedApp;
            InitializeComponent();
            Card.BorderColor = Properties.Settings.Default.AscentColor;
            RemoveBtn.onHoverState.FillColor = Properties.Settings.Default.AscentColor;
            RemoveBtn.OnIdleState.BorderColor = Properties.Settings.Default.AscentColor;
            RemoveBtn.OnIdleState.FillColor = Properties.Settings.Default.AscentColor;
            RemoveBtn.OnPressedState.BorderColor = Properties.Settings.Default.AscentColor;
            RemoveBtn.OnPressedState.FillColor = Properties.Settings.Default.AscentColor;
            RemoveBtn.Refresh();

            LoadBtn.onHoverState.FillColor = Properties.Settings.Default.AscentColor;
            LoadBtn.OnIdleState.BorderColor = Properties.Settings.Default.AscentColor;
            LoadBtn.OnIdleState.FillColor = Properties.Settings.Default.AscentColor;
            LoadBtn.OnPressedState.BorderColor = Properties.Settings.Default.AscentColor;
            LoadBtn.OnPressedState.FillColor = Properties.Settings.Default.AscentColor;
            LoadBtn.Refresh();
        }

        void AppLoad()
        {
            AppPic.ImageLocation = App[0];
            NameLb.Text = App[1];
        }

        private void AppCard_Load(object sender, EventArgs e)
        {
            AppLoad();         
        }

        private void LoadBtn_Click(object sender, EventArgs e)
        {
            SelectedAppView selectedAppView = new SelectedAppView(App , SelectedApp);
            selectedAppView.ShowDialog();
        }

        private void RemoveBtn_Click(object sender, EventArgs e)
        {
            HomeView.details.RemoveApp(SelectedApp);
            HomeView.details.LoadApps();
        }
    }
}
