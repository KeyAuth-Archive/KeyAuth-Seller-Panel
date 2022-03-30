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
    public partial class BanKeyView : Form
    {
        string key;
        public BanKeyView(string key)
        {
            InitializeComponent();
            this.key = key;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void BanBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseBan(key, BanReasonTb.Text);
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            else DialogResult = DialogResult.Abort;
        }
    }
}
