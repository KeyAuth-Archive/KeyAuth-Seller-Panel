using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views.PopUpViews
{
    public partial class GenerateLicensesView : Form
    {
        public GenerateLicensesView()
        {
            InitializeComponent();

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void GenBtn_Click(object sender, EventArgs e)
        {
            string mask = MaskTb.Text;
            int level = 0;
            foreach (var var in HomeView.sellerApi.subs.All)
                if (var.Name == LevelDd.Text)
                    level = Convert.ToInt32(var.Level);
            int qty = Convert.ToInt32(QtyDd.Text);
            int expiry;
            if (DaysDd.SelectedItem.Equals("Week"))
                expiry = 1;
            else if (DaysDd.SelectedItem.Equals("Month"))
                expiry = 2;
            else if (DaysDd.SelectedItem.Equals("Year"))
                expiry = 3;
            else if (DaysDd.SelectedItem.Equals("Lifetime"))
                expiry = 4;
            else
                expiry = 0;
            HomeView.sellerApi.LicenseGen(expiry, mask, level, qty);
            if (HomeView.sellerApi.response.Success)
                if (qty > 1)
                {
                    bunifuSnackbar1.Show(HomeView.MainForm, $"Successfuly generated {qty} keys.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                    bunifuTextBox1.Text = String.Join(Environment.NewLine, HomeView.sellerApi.keys.Keys);
                }
                else
                {
                    bunifuSnackbar1.Show(HomeView.MainForm, $"Successfuly generated a key.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                    bunifuTextBox1.Text = HomeView.sellerApi.keys.Key;
                }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void GenerateLicensesView_Load(object sender, EventArgs e)
        {
            HomeView.sellerApi.SubViewAll();
            if (HomeView.sellerApi.response.Success)
                foreach (var var in HomeView.sellerApi.subs.All)
                    LevelDd.Items.Add(var.Name);
            LevelDd.SelectedIndex = 0;
            DaysDd.SelectedIndex = 0;
            QtyDd.SelectedIndex = 0;
        }
    }
}
