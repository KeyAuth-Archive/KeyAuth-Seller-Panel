using Bunifu.UI.WinForms;
using Bunifu.UI.WinForms.BunifuButton;
using KeyAuth;
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
    public partial class ChatsView : UserControl
    {
        public static api KeyAuthApp = new api();
        int ChatDelay = 1;
        string Username = string.Empty;

        private void SetAscentColors(Color color)
        {
            foreach (var button in panel.Controls.OfType<BunifuButton>())
            {
                button.onHoverState.FillColor = color;
                button.OnIdleState.BorderColor = color;
                button.OnIdleState.FillColor = color;
                button.OnPressedState.BorderColor = color;
                button.OnPressedState.FillColor = color;
                button.Refresh();
            }
            foreach (var textBox in panel.Controls.OfType<BunifuTextBox>())
            {
                textBox.OnIdleState.BorderColor = color;
                textBox.BorderColorIdle = color;
                textBox.Refresh();
            }
            foreach (var Dd in panel.Controls.OfType<BunifuDropdown>())
            {
                Dd.ItemHighLightColor = color;
                Dd.BorderColor = color;
                Dd.Refresh();
            }


            foreach (var button in bunifuPanel1.Controls.OfType<BunifuButton>())
            {
                button.onHoverState.FillColor = color;
                button.OnIdleState.BorderColor = color;
                button.OnIdleState.FillColor = color;
                button.OnPressedState.BorderColor = color;
                button.OnPressedState.FillColor = color;
                button.Refresh();
            }
            foreach (var textBox in bunifuPanel1.Controls.OfType<BunifuTextBox>())
            {
                textBox.OnIdleState.BorderColor = color;
                textBox.BorderColorIdle = color;
                textBox.Refresh();
            }
        }

        public ChatsView()
        {
            InitializeComponent();

        }

        private void QtyDd_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ChannelDelayDd.SelectedItem.Equals("No Delay"))
                ChatDelay = 1;
            if (ChannelDelayDd.SelectedItem.Equals("10 Sec Delay"))
                ChatDelay = 10;
            if (ChannelDelayDd.SelectedItem.Equals("20 Sec Delay"))
                ChatDelay = 20;
            if (ChannelDelayDd.SelectedItem.Equals("40 Sec Delay"))
                ChatDelay = 40;
            if (ChannelDelayDd.SelectedItem.Equals("1 Min Delay"))
                ChatDelay = 60;
            if (ChannelDelayDd.SelectedItem.Equals("3 Min Delay"))
                ChatDelay = 180;
            if (ChannelDelayDd.SelectedItem.Equals("5 Min Delay"))
                ChatDelay = 300;
            if (ChannelDelayDd.SelectedItem.Equals("10 Min Delay"))
                ChatDelay = 600;
            if (ChannelDelayDd.SelectedItem.Equals("20 Min Delay"))
                ChatDelay = 1200;
            if (ChannelDelayDd.SelectedItem.Equals("30 Min Delay"))
                ChatDelay = 1800;
            if (ChannelDelayDd.SelectedItem.Equals("1 Hr Delay"))
                ChatDelay = 3600;
        }

        private void CreateChannelBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatCreateChannel(CreateChannelNameTb.Text, ChatDelay);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            CreateChannelNameTb.Text = "";
            ChannelDelayDd.Text = "Delay";
        }

        private void ClearChannelBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatClearChannel(CreateChannelNameTb.Text);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            CreateChannelNameTb.Text = "";
        }

        private void DeleteChannelBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatDeleteChannel(CreateChannelNameTb.Text);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            if (!HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(new HomeView(), HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            CreateChannelNameTb.Text = "";
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            if (SelectedAppView.app.OwnerId == "YourOwnerId")
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "You need to set your owner ID to use this function." , Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            if (SelectedAppView.app.AppSecret == "YourAppSecret")
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "You need to set your app secret to use this function.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            HomeView.sellerApi.SettingsView();
            KeyAuthApp.SetApp(SelectedAppView.app.AppName, SelectedAppView.app.OwnerId, SelectedAppView.app.AppSecret, HomeView.sellerApi.settings.Version);
            KeyAuthApp.init();
            if (!KeyAuthApp.response.success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to init", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            KeyAuthApp.login(UsernameTb.Text, PasswordTb.Text);
            if (!KeyAuthApp.response.success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, KeyAuthApp.response.message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            KeyAuthApp.check();
            if (!KeyAuthApp.response.success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, KeyAuthApp.response.message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                return;
            }
            bunifuButton2.Enabled = true;
            bunifuDataGridView1.Enabled = true;
            timer1.Start();//741
            bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully signed in and connected to channel", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);


        }

        private void timer1_Tick(object sender, EventArgs e)
        {

            bunifuDataGridView1.Rows.Clear();
            timer1.Interval = 15000;
            if (!String.IsNullOrEmpty(CreateChannelNameTb.Text))
            {
                var messages = KeyAuthApp.chatget(CreateChannelNameTb.Text);
                Console.WriteLine(KeyAuthApp.response.message);
                if (messages == null || !messages.Any())
                    bunifuDataGridView1.Rows.Insert(0, "System", "No Chat Messages", UsersView.UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
                else
                    foreach (var message in messages)
                        bunifuDataGridView1.Rows.Insert(0, message.author, "Message : "+message.message, "At : "+ UsersView.UnixTimeToDateTime(long.Parse(message.timestamp)));
            }
            else
                bunifuDataGridView1.Rows.Insert(0, "System", "Enter a chat channel first", UsersView.UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
            bunifuDataGridView1.Columns[0].Width = 150;
            bunifuDataGridView1.Columns[1].Width = 550;
            bunifuDataGridView1.Columns[2].Width = 41;
        }

        private void bunifuButton2_Click(object sender, EventArgs e)
        {
            if (KeyAuthApp.chatsend(chatmsg.Text, CreateChannelNameTb.Text))
            {
                bunifuDataGridView1.Rows.Insert(0, KeyAuthApp.user_data.username, "Message : " + chatmsg.Text, "At : " + UsersView.UnixTimeToDateTime(DateTimeOffset.Now.ToUnixTimeSeconds()));
                chatmsg.Text = "";
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, KeyAuthApp.response.message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void unmuteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatUnmuteUser(Username);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully unmuted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to unmute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (bunifuDataGridView1.SelectedCells.Count > 0)
                Username = bunifuDataGridView1.SelectedCells[0].Value.ToString();
        }

        private void secsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username, 30);
            if(HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void minToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username, 60);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void minToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username, 120);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void minToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username, 300);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void minToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username, 600);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void minToolStripMenuItem4_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username, 1200);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void minToolStripMenuItem6_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username,1800);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void hrToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.ChatMuteUser(Username, 3600);
            if (HomeView.sellerApi.response.Success)
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfully muted user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Failed to mute user", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void ChatsView_Leave(object sender, EventArgs e)
        {
            timer1.Enabled = false;
        }

        private void PasswordTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void ChatsView_Load(object sender, EventArgs e)
        {

            SetAscentColors(Properties.Settings.Default.AscentColor);
        }
    }
}
