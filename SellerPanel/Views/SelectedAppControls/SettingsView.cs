using KeyAuth_Seller_Panel.SellerPanel.Classes;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    public partial class SettingsView : UserControl
    {
        bool authed;
        public SettingsView()
        {
            InitializeComponent();
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            AuthedYesNo.Checked = false;
            HomeView.sellerApi.SettingsView();
            if (HomeView.sellerApi.response.Success)
            {
                AppEnabled.Checked = HomeView.sellerApi.settings.AppEnabled;
                HwidLockEnabled.Checked = HomeView.sellerApi.settings.HwidLockEnabled;
                VersionTb.Text = HomeView.sellerApi.settings.Version;
                WebhookTb.Text = HomeView.sellerApi.settings.Webhook;
                HwidMismatchTb.Text = HomeView.sellerApi.settings.Hwidmismatchmsg;
                NoSubsMsgTb.Text = HomeView.sellerApi.settings.Nosubmsg;
                AppDisabledMsgTb.Text = HomeView.sellerApi.settings.Disabledmsg;
                UsedKeyTb.Text = HomeView.sellerApi.settings.Keytakenmsg;
                ExpiredMsgTb.Text = HomeView.sellerApi.settings.Expiredmsg;
                UsernameTakenMsgTb.Text = HomeView.sellerApi.settings.Usernametakenmsg;
                InvalidKeyMsgTb.Text = HomeView.sellerApi.settings.Licenseinvalidmsg;
                ExpiredSubMsgTb.Text = HomeView.sellerApi.settings.Noactivesubmsg;
                BlacklistedMsgTb.Text = HomeView.sellerApi.settings.Blackedmsg;
                PasswordMismatchMsgTb.Text = HomeView.sellerApi.settings.Passinvalidmsg;
                SellixWebhookTb.Text = HomeView.sellerApi.settings.Sellixsecret;
                ResellerStoreTb.Text = HomeView.sellerApi.settings.Resellerstore;
                UsernameInvalidMsgTb.Text = HomeView.sellerApi.settings.Userinvalidmsg;
            }
            bunifuVScrollBar1.BindTo(flowLayoutPanel1);


        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {

            if (NewHaskTB.Text != "")
            {
                HomeView.sellerApi.HashAdd(NewHaskTB.Text);
                if (HomeView.sellerApi.response.Success)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                if (!HomeView.sellerApi.response.Success)
                    bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            }
            if (AppEnabled.Checked)
                HomeView.sellerApi.AppEnabled(true);
            else if (!AppEnabled.Checked)
                HomeView.sellerApi.AppEnabled(false);
            if (HwidLockEnabled.Checked)
                HomeView.sellerApi.HwidLockEnabled(true);
            else if (!HwidLockEnabled.Checked)
                HomeView.sellerApi.HwidLockEnabled(false);
            HomeView.sellerApi.SettingsUpdate(VersionTb.Text, WebhookTb.Text, ResellerStoreTb.Text, AppDisabledMsgTb.Text, UsernameTakenMsgTb.Text, InvalidKeyMsgTb.Text, UsedKeyTb.Text, NoSubsMsgTb.Text, UsernameInvalidMsgTb.Text, PasswordMismatchMsgTb.Text, HwidMismatchTb.Text, NoSubsMsgTb.Text, BlacklistedMsgTb.Text, ExpiredMsgTb.Text, SellixWebhookTb.Text);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            SelectedAppView.AppViews.Controls.Clear();
            SelectedAppView.AppViews.Controls.Add(new SettingsView());
        }

        private void DeleteHashBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.HashReset();
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void KillAllSessionsBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.SessionKillAll();
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void KillSessionsIdBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(SessionIdTb.Text))
            {
                bunifuSnackbar1.Show(new HomeView(), "You did not enter a session ID, set one first!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            HomeView.sellerApi.SessionKill(SessionIdTb.Text);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            SessionIdTb.Text = "";
        }

        private void HwidLockEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (HwidLockEnabled.Checked)
                HwidLockEnabledLb.Text = "Enabled";
            else if (!HwidLockEnabled.Checked)
                HwidLockEnabledLb.Text = "Disabled";
        }

        private void AppEnabled_CheckedChanged(object sender, EventArgs e)
        {
            if (AppEnabled.Checked)
                AppEnabledLb.Text = "Enabled";
            else if (!AppEnabled.Checked)
                AppEnabledLb.Text = "Disabled";
        }


        
        private void AddWebhookBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(CreateWebHookTB.Text))
            {
                bunifuSnackbar1.Show(new HomeView(), "You did not set a Url, set one first!", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            HomeView.sellerApi.CreateWebHook(CreateWebHookTB.Text, authed);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            CreateWebHookTB.Text = "";
        }

        private void AuthedYesNo_CheckedChanged(object sender, EventArgs e)
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

        private void ResetToDefaultBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.SettingsDefault();
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(new HomeView(), "Successfuly reset settings to default.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new SettingsView());
            }
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), "Failed to reset settings to default.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }
    }
}

