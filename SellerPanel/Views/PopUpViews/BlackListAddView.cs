using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    public partial class BlackListAddView : Form
    {
        public BlackListAddView()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }
        private void App1LoadButton_Click(object sender, EventArgs e)
        {

            HomeView.sellerApi.BlackAdd(IpTb.Text, HwidTb.Text);
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            if (!HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.Abort;
        }
    }
}
