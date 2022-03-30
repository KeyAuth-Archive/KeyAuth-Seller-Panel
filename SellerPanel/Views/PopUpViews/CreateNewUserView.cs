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
    public partial class CreateNewUserView : Form
    {
        public CreateNewUserView()
        {
            InitializeComponent();
            PassCheck.Checked = false;
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void AddBtn_Click(object sender, EventArgs e)
        {
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
            string Sub = SubDd.SelectedItem.ToString();
            Console.WriteLine(Sub);
            HomeView.sellerApi.UserCreate(UsernameTb.Text,Sub,expiry,PasswordTb.Text);
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
            HomeView.sellerApi.SubViewAll();
            if (HomeView.sellerApi.response.Success)
            {
                foreach (var subs in HomeView.sellerApi.subs.All)
                    SubDd.Items.Add(subs.Name);
                SubDd.Text = "User sub";
            }
            else
                SubDd.Text = "No subs found";
        }

        private void SubNameTb_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
