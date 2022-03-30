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
    public partial class SetUserVarView : Form
    {
        public SetUserVarView()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }
        private void SetUserVarView_Load(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserAllUserNames();
            if (HomeView.sellerApi.response.Success)
            {
                UserListDd.Items.Add("Set for all users");
                foreach (var name in HomeView.sellerApi.users.Usernames)
                    UserListDd.Items.Add(name);
                UserListDd.Text = "Select user";
            }
        }

        private void AppBtn_Click(object sender, EventArgs e)
        {
            string user = UserListDd.SelectedItem.ToString();
            if (user == "Set for all users")
                user = "all";
            HomeView.sellerApi.UserSetVar(user,VarNameTb.Text,VarDataTb.Text);
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            else
                DialogResult = DialogResult.Abort;

        }
    }
}
