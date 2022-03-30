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
    public partial class CreateNewUserLicenseView : Form
    {
        string key;
        public CreateNewUserLicenseView(string key)
        {
            InitializeComponent();
            PassCheck.Checked = false;
            this.key = key;
            
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseCreateUser(UsernameTb.Text,SelectedKeyTb.Text, PasswordTb.Text);
            if (HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.OK;
            if (!HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.Abort;
        }

        private void SubLevelTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void Card_Enter(object sender, EventArgs e)
        {

        }

        private void bunifuCheckBox1_CheckedChanged(object sender, Bunifu.UI.WinForms.BunifuCheckBox.CheckedChangedEventArgs e)
        {
            if (PassCheck.Checked)
            {
                bunifuLabel2.Visible = false;
                PasswordTb.Visible = true;
            }else if (!PassCheck.Checked)
            {
                PasswordTb.Visible = false;
                bunifuLabel2.Visible=true;
            }
        }

        private void bunifuLabel8_Click(object sender, EventArgs e)
        {

        }

        private void CreateNewUserView_Load(object sender, EventArgs e)
        {
            SelectedKeyTb.Text = key;
        }

        private void SubNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
