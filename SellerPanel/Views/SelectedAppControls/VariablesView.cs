using Bunifu.UI.WinForms;
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
    public partial class VariablesView : UserControl
    {
        bool authed;
        string VarId;
        public VariablesView()
        {
            InitializeComponent();
 
        }

        private void AuthedYesNo_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (AuthedYesNo.Checked)
            {
                YesNoLb.Text = "Yes";
                authed = true;
            }
            else if (!AuthedYesNo.Checked)
            {
                YesNoLb.Text = "No";
                authed = false;
            }
        }

        private void VariablesView_Load(object sender, EventArgs e)
        {
            ScrollbarBinder.BindDatagridView(bunifuDataGridView1, bunifuVScrollBar1);
            HomeView.sellerApi.VariableViewAll();
            if (HomeView.sellerApi.response.Success)
            {
                foreach (var Vars in HomeView.sellerApi.variables.All)
                {
                    bunifuDataGridView1.Rows.Insert(0, Vars.Varid, Vars.Msg);
                }//
                bunifuDataGridView1.Columns[0].Width = 359;
                bunifuDataGridView1.Columns[1].Width = 359;

            }
            else if(HomeView.sellerApi.response.Message.Contains("No application with specified seller key found"))
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Redirecting to App info.", BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                bunifuSnackbar1.Show(HomeView.MainForm, "Your seller key may have been changed please update it.", BunifuSnackbar.MessageTypes.Error, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                AppStatsView appStatsView = new AppStatsView();
                SelectedAppView.AppViews.Controls.Add(appStatsView);
                SelectedAppView.AppViews.Controls.Remove(this);

            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);

            AuthedYesNo.Checked = false;
            bunifuVScrollBar1.BindTo(bunifuDataGridView1, true);
        }

        private void CreateBtn_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(VarNameTb.Text))
            {
                bunifuSnackbar1.Show(new HomeView(), "You must set a var name.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            if (string.IsNullOrEmpty(VarDataTb.Text))
            {
                bunifuSnackbar1.Show(new HomeView(), "Your var data cannot be null", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            foreach(var var in HomeView.sellerApi.variables.All)
                if (VarNameTb.Text == var.Varid)
                {
                    bunifuSnackbar1.Show(new HomeView(), $"You already have a var called {VarNameTb.Text}.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                    return;
                }

            HomeView.sellerApi.VariableCreate(VarNameTb.Text,VarDataTb.Text,authed);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new VariablesView());
                
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void seletedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.VariableDelete(VarId);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new VariablesView());
                
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.VariableDeleteAll();
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new VariablesView());
                
            }
            else
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using(EditVarView editVarView = new EditVarView())
            {
                var test = editVarView.ShowDialog();
                if (test== DialogResult.OK)
                {
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                    SelectedAppView.AppViews.Controls.Clear();
                    SelectedAppView.AppViews.Controls.Add(new VariablesView());
                }
                if (test == DialogResult.Abort)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
        }

        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedCells.Count > 0)
            {
                VarId = bunifuDataGridView1.SelectedCells[0].Value.ToString();
                Console.WriteLine(VarId);
            }
        }
    }
}
