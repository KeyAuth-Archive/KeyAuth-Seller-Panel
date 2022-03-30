using KeyAuth_Seller_Panel.SellerPanel.Views.SelectedAppControls;
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
    public partial class UserInfoView : Form
    {
        string Username;
        public UserInfoView(string username)
        {
            this.Username = username;
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void DeleteVar_Click(object sender, EventArgs e)
        {
            var test = VarDd.SelectedItem.ToString().Split(':');
            Console.WriteLine(test[0]);
            HomeView.sellerApi.UserDeleteVar(UsersView.Username,test[0]);
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Abort;
        }

        private void UserInfoView_Load(object sender, EventArgs e)
        {
            bunifuLabel8.Text = $"{UsersView.Username}, Info";
            foreach(var user in HomeView.sellerApi.users.Users)
                if(user.Username == UsersView.Username)
                {
                    HwidLb.Text = user.Hwid;
                    IpLb.Text = user.Ip;
                }
            HomeView.sellerApi.ViewUserData(UsersView.Username);
            if (HomeView.sellerApi.response.Success)
            {
                SubDd.Items.Add("All User's Subs");
                foreach (var Subs in HomeView.sellerApi.users.Subscriptions)
                    SubDd.Items.Add($"[{Subs.Subscription}] - Expires : {UsersView.UnixTimeToDateTime(long.Parse(Subs.Expiry))}");
                SubDd.SelectedIndex = 0;
            }


            HomeView.sellerApi.UserViewVars();
            Console.WriteLine(UsersView.Username);
            if (HomeView.sellerApi.response.Success)
            {
                VarDd.Items.Add("All User's var's");
                foreach (var vars in HomeView.sellerApi.users.AllVars)
                    if (UsersView.Username == vars.User)
                        VarDd.Items.Add($"{vars.Name} : {vars.Data}");
                VarDd.SelectedIndex = 0;
            }

        }


        private void DeleteSub_Click(object sender, EventArgs e)
        {
            var test = SubDd.SelectedItem.ToString().Split('[',']','-');
            Console.WriteLine(test[1]);
            HomeView.sellerApi.UserDeleteSub(UsersView.Username, test[1]);
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Abort;
        }

        private void Card_Enter(object sender, EventArgs e)
        {

        }

        private void IpLb_Click(object sender, EventArgs e)
        {

        }
    }
}
