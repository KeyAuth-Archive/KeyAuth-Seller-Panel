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
    public partial class ExtendUsersViews : Form
    {
        public ExtendUsersViews()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void AppBtn_Click(object sender, EventArgs e)
        {
            string user = UserListDd.SelectedItem.ToString();
            if (user == "Set for all users")
                user = "all";
            int expiry = 0;
            if (ExpiryDd.SelectedItem.ToString() == "Day")
                expiry = 0;
            if (ExpiryDd.SelectedItem.ToString() == "Week")
                expiry = 1;
            if (ExpiryDd.SelectedItem.ToString() == "Month")
                expiry = 2;
            if (ExpiryDd.SelectedItem.ToString() == "Year")
                expiry = 3;
            if (ExpiryDd.SelectedItem.ToString() == "Lifetime")
                expiry = 4;
            HomeView.sellerApi.UserExtendSub(user,SubListDd.SelectedItem.ToString(),expiry);
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Abort;
        }

        private void ExtendUsersViews_Load(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserAllUserNames();
            if (HomeView.sellerApi.response.Success)
            {
                UserListDd.Items.Add("Set for all users");
                foreach (var name in HomeView.sellerApi.users.Usernames)
                    UserListDd.Items.Add(name);
                UserListDd.Text = "Select user";
            }
            HomeView.sellerApi.SubViewAll();
            if (HomeView.sellerApi.response.Success)
            {
                UserListDd.Items.Add("Set for all users");
                foreach (var subs in HomeView.sellerApi.subs.All)
                    SubListDd.Items.Add(subs.Name);
                SubListDd.Text = "Select Sub";
            }
            else
                SubListDd.Text = "No Subs Found";
        }
    }
}
