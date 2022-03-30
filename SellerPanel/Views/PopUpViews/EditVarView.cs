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

namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    public partial class EditVarView : Form
    {
        public EditVarView()
        {
            InitializeComponent();
        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void EditVarView_Load(object sender, EventArgs e)
        {
            if (HomeView.sellerApi.response.Success)
            {
                foreach (var vars in HomeView.sellerApi.variables.All)
                    IdListDd.Items.Add(vars.Varid);
                IdListDd.Text = "Select Var";
            }
            else
            {
                VarDataTb.Text = "ERROR";
                IdListDd.Text = "No Vars Found";
            }  
        }

        private void App1LoadButton_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.VariableEdit(IdListDd.SelectedItem.ToString(), VarDataTb.Text);
            if (HomeView.sellerApi.response.Success)
            {
                DialogResult = DialogResult.OK;
            }
            if (!HomeView.sellerApi.response.Success)
                DialogResult = DialogResult.Abort;


        }

        private void VarDataTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void IdListDd_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
