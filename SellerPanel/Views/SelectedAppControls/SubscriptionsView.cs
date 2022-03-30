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
    public partial class SubscriptionsView : UserControl
    {
        string Subname = string.Empty;
        string SubLvl = string.Empty;
        public SubscriptionsView()
        {
            InitializeComponent();
            ScrollbarBinder.BindDatagridView(bunifuDataGridView1, bunifuVScrollBar1);
            HomeView.sellerApi.SubViewAll();
            if (HomeView.sellerApi.response.Success)
            {
                var test = HomeView.sellerApi.subs.All;
                bunifuDataGridView1.DataSource = test;
                bunifuDataGridView1.AutoResizeColumns();
                bunifuDataGridView1.AutoResizeRows();
            }
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.SubDelete(Subname);
            if (HomeView.sellerApi.response.Success)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new SubscriptionsView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedCells.Count > 0)
                Subname = bunifuDataGridView1.SelectedCells[0].Value.ToString();
        }

        private void editSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (EditSubView editSubView = new EditSubView())
            {
                var test = editSubView.ShowDialog();
                if (test == DialogResult.OK)
                {
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                    SelectedAppView.AppViews.Controls.Clear();
                    SelectedAppView.AppViews.Controls.Add(new SubscriptionsView());
                }
                if (test == DialogResult.Abort)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
        }

        private void createSubToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (CreateSubView createSubView = new CreateSubView())
            {
                var test = createSubView.ShowDialog();
                if (test == DialogResult.OK)
                {
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                    SelectedAppView.AppViews.Controls.Clear();
                    SelectedAppView.AppViews.Controls.Add(new SubscriptionsView());
                }
                if (test == DialogResult.Abort)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
        }
    }
}
