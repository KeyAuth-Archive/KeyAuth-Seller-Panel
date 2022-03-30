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
    public partial class CreateSubView : Form
    {
        public CreateSubView()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }
        private void AddBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.SubCreate(SubNameTb.Text, Convert.ToInt32(SubLevelTb.Text));
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            if (!HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.Abort;
        }

        private void CreateSubView_Load(object sender, EventArgs e)
        {

        }
    }
}
