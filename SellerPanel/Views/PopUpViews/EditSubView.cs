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
    public partial class EditSubView : Form
    {
        public EditSubView()
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
            HomeView.sellerApi.SubEdit(IdListDd.SelectedItem.ToString(),Convert.ToInt32(LevelTb.Text));
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            if (!HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.Abort;
        }

        private void EditSubView_Load(object sender, EventArgs e)
        {


            if (HomeView.sellerApi.response.Success)
            {
                foreach (var subs in HomeView.sellerApi.subs.All)
                    IdListDd.Items.Add(subs.Name);
                IdListDd.Text = "Select Sub";
            }
            else
            {
                LevelTb.Text = "ERROR";
                IdListDd.Text = "No Subs Found";
            }

        }

        private void IdListDd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
