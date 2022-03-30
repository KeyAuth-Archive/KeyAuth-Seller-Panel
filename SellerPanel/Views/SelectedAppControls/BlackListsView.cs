using Bunifu.Utils;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views.SelectedAppControls
{
    public partial class BlackListsView : UserControl
    {
        private void SetAscentColors(Color color)
        {
            bunifuVScrollBar1.BorderColor = color;
        }
        List<Blacks> Black = new List<Blacks>();
        string Type = string.Empty;
        string Data = string.Empty;
        public class Blacks
        {
            public string Type { get; set; }
            public string Data { get; set; }
        }
        public BlackListsView()
        {
            InitializeComponent();
            SetAscentColors(Properties.Settings.Default.AscentColor);
            ScrollbarBinder.BindDatagridView(bunifuDataGridView1, bunifuVScrollBar1);
            HomeView.sellerApi.BlackViewAll();
            if (HomeView.sellerApi.response.Success)
            {
                foreach(var blacks in HomeView.sellerApi.blacks.All)
                    Black.Add(new Blacks { Type = blacks.Type, Data = blacks.Ip+blacks.Hwid });
                bunifuDataGridView1.DataSource = Black;
                bunifuDataGridView1.Columns[0].Width = 172;
                bunifuDataGridView1.Columns[1].Width = 573;
            }
        }

        private void BlackListsView_Load(object sender, EventArgs e)
        {
            bunifuVScrollBar1.BindTo(bunifuDataGridView1, true);
        }

        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedCells.Count > 0)
            {
                Type = bunifuDataGridView1.SelectedCells[0].Value.ToString();
                Data = bunifuDataGridView1.SelectedCells[1].Value.ToString();
            }
        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.BlackDelectAll();
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new BlackListsView());
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.BlackDelete(Data,Type);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new BlackListsView());
            }
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void addToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(BlackListAddView blackListAddView = new BlackListAddView())
            {
                var test = blackListAddView.ShowDialog();
                if (test == DialogResult.OK)
                {
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                    SelectedAppView.AppViews.Controls.Clear();
                    SelectedAppView.AppViews.Controls.Add(new BlackListsView());
                }
                if (test == DialogResult.Abort)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
        }

        private void bunifuLabel3_Click(object sender, EventArgs e)
        {

        }
    }
}
