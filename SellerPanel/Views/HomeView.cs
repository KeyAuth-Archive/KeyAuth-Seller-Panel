using KeyAuth_Seller_Panel.SellerPanel.Classes;
using KeyAuthSeller;
using System.Windows.Forms;
using System;
using System.Drawing;

namespace KeyAuth_Seller_Panel
{
    public partial class HomeView : Form
    {
        public static SellerApi sellerApi = new SellerApi();
        public static AppDetails details = new AppDetails();
        public static Form MainForm;
        public static Panel AppLayout;
        public HomeView()
        {
            InitializeComponent();
            MainForm = this;
            SetColors(Properties.Settings.Default.AscentColor);
        }
        private void HomeView_Load(object sender, EventArgs e)
        {
            AppLayout = AppLayOutFp;
            details.LoadApps();
            HomeViewSb.BindTo(AppLayOutFp);
        }
        public void SetColors(Color color)
        {
            MainForm.Text = Properties.Settings.Default.ProgramName;
            ProgramNameLb.Text = Properties.Settings.Default.ProgramName;
            MainGroupB.BorderColor = color;
            HomeViewSb.BorderColor = color;
            MinButton.HoverState.IconColor = color;
            CloseButton.HoverState.IconColor = color;
        }
    }
}
