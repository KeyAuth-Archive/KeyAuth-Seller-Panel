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
    public partial class BanUserView : Form
    {
        string user;
        public BanUserView(string user)
        {
            this.user = user;
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void BanBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.UserBan(user, BanReasonTb.Text);
            if(HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Abort;
        }

        private void BanUserView_Load(object sender, EventArgs e)
        {
            userLb.Text = $"Ban User : {user}";
        }
    }
}
