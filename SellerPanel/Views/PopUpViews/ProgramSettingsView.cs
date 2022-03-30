using Bunifu.UI.WinForms.BunifuButton;
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
    public partial class ProgramSettingsView : Form
    {
        private void SetAscentColors(Color color)
        {
            Card.BorderColor = color;
            ProgramNameTb.OnIdleState.BorderColor = color;
            ProgramNameTb.BorderColorIdle = color;
            ProgramNameTb.Refresh();
            foreach (var button in Card.Controls.OfType<BunifuButton>())
            {
                button.onHoverState.FillColor = color;
                button.OnIdleState.BorderColor = color;
                button.OnIdleState.FillColor = color;
                button.OnPressedState.BorderColor = color;
                button.OnPressedState.FillColor = color;
                button.Refresh();
            }

        }
        private void SetBackColors(Color color)
        {
            Card.BackColor = color;
            this.BackColor = color;
            App1Card.BackgroundColor = color;
        }

        public ProgramSettingsView()
        {

            InitializeComponent();
            ProgramNameTb.Text = Properties.Settings.Default.ProgramName;
            SetAscentColors(Properties.Settings.Default.AscentColor);
            SetBackColors(Properties.Settings.Default.BackColor);

        }
        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void ProgramSettingsView_Load(object sender, EventArgs e)
        {
           
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProgramName = ProgramNameTb.Text;
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void bunifuButton1_Click(object sender, EventArgs e)
        {
            
            if(colorDialog1.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.AscentColor = colorDialog1.Color;
                SetAscentColors(colorDialog1.Color);
            }
                
            

        }

        private void DefaultBtn_Click(object sender, EventArgs e)
        {
            Properties.Settings.Default.ProgramName = "KeyAuth Seller Panel";
            Properties.Settings.Default.BackColor = Color.FromArgb(22, 24, 26);
            Properties.Settings.Default.AscentColor =Color.FromArgb(7, 127, 243);
            Properties.Settings.Default.Save();
            DialogResult = DialogResult.OK;
        }

        private void BackColorBtn_Click(object sender, EventArgs e)
        {
            if (colorDialog2.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackColor = colorDialog2.Color;
                SetBackColors(colorDialog2.Color);
            }
        }
    }
}
