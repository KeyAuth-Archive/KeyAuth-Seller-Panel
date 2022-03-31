using Bunifu.UI.WinForms;
using Bunifu.Utils;
using KeyAuth_Seller_Panel.SellerPanel.Views.PopUpViews;
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
    public partial class UsersView : UserControl
    {

        public UsersView()
        {
            InitializeComponent();
            ScrollbarBinder.BindDatagridView(bunifuDataGridView1, bunifuVScrollBar1);

            bunifuVScrollBar1.BorderRadius = 14;
            HomeView.sellerApi.UserViewAll();
            if (HomeView.sellerApi.response.Success)
            {
                foreach (var blacks in HomeView.sellerApi.users.Users)
                {
                    if (blacks.Banned == null)
                        blacks.Banned = "No";
                    else
                        blacks.Banned = "Yes reason: " + blacks.Banned;
                    if (blacks.Ip == null)
                        blacks.Ip = "N/A";
                    if (blacks.Hwid == null)
                        blacks.Hwid = "N/A";
                    if (blacks.Lastlogin == null)
                        blacks.Lastlogin = "N/A";
                    else
                        blacks.Lastlogin = UnixTimeToDateTime(long.Parse(blacks.Lastlogin));
                    bunifuDataGridView1.Rows.Insert(0, blacks.Username, blacks.Banned, UnixTimeToDateTime(long.Parse(blacks.Createdate)), blacks.Lastlogin);
                }//
                bunifuDataGridView1.Columns[0].Width = 223;
                bunifuDataGridView1.Columns[1].Width = 372;
                bunifuDataGridView1.Columns[2].Width = 75;
                bunifuDataGridView1.Columns[3].Width = 75;
            }
            else if (HomeView.sellerApi.response.Message.Contains("No application with specified seller key found"))
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Redirecting to App info.", BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                bunifuSnackbar1.Show(HomeView.MainForm, "Your seller key may have been changed please update it.", BunifuSnackbar.MessageTypes.Error, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                AppStatsView appStatsView = new AppStatsView();
                SelectedAppView.AppViews.Controls.Add(appStatsView);
                SelectedAppView.AppViews.Controls.Remove(this);

            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);

        }
        public static string UnixTimeToDateTime(long unixtime)
        {
            DateTime dtDateTime = new DateTime(1970, 1, 1, 0, 0, 0, 0, System.DateTimeKind.Local);
            dtDateTime = dtDateTime.AddSeconds(unixtime).ToLocalTime();
            string shorttime = dtDateTime.ToShortDateString();
            return shorttime;
        }
        private void UsersView_Load(object sender, EventArgs e)
        {
            bunifuVScrollBar1.BindTo(bunifuDataGridView1, true);
        }


        private void createNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewUserView createNewUserView = new CreateNewUserView();
            var test = createNewUserView.ShowDialog();
            if (test == DialogResult.OK)
            {
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
            }
            if (test == DialogResult.Abort)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }
        public static string Username = string.Empty;
        private void resetUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            HomeView.sellerApi.UserResetPass(Username);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedCells.Count > 0)
            {
                Username = bunifuDataGridView1.SelectedCells[0].Value.ToString();
                Console.WriteLine(Username);
            }
        }

        private void deleteToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserDelete(Username);
            if (HomeView.sellerApi.response.Success)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void resetHwidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserHwidReset(Username);
            if (HomeView.sellerApi.response.Success)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanUserView banUserView = new BanUserView(Username);
            var test = banUserView.ShowDialog();
            if (test == DialogResult.OK)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
            else if (test == DialogResult.Abort)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void unbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserUnban(Username);
            if (HomeView.sellerApi.response.Success)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void expiredUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserDeleteExpired();
            if (HomeView.sellerApi.response.Success)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void allUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserDeleteAll();
            if (HomeView.sellerApi.response.Success)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void resetAllUsersHWIDToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserHwidResetAll();
            if (HomeView.sellerApi.response.Success)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }

            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void userInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoView userInfoView = new UserInfoView(Username);
            var test = userInfoView.ShowDialog();
            if (test == DialogResult.OK)
            {
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
            }
                
            else if (test == DialogResult.Abort)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);


        }

        private void setVariableToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SetUserVarView setUserVarView = new SetUserVarView();
            var test = setUserVarView.ShowDialog();
 }

        private void extendUsersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ExtendUsersViews extendUsersViews = new ExtendUsersViews();
            var test = extendUsersViews.ShowDialog();
            if (test == DialogResult.OK)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else if (test == DialogResult.Abort)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UserInfoView userInfoView = new UserInfoView(Username);
            var test = userInfoView.ShowDialog();
            if (test == DialogResult.OK)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new UsersView());
            }
            else
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }
    }
}
