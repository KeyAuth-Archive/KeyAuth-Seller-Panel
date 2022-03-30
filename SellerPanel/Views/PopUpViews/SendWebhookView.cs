using JNogueira.Discord.Webhook.Client;
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
    public partial class SendWebhookView : Form
    {
        string key;
        public SendWebhookView(string key)
        {
            InitializeComponent();
            this.key = key;
        }


        public async void DiscordMessage()
        {
            var client = new DiscordWebhookClient(WebhookTb.Text);
            var message = new DiscordMessage(
                $"Key : {key}",
                username: BotNameTb.Text,
                avatarUrl: PicUrlTb.Text);
            await client.SendToDiscord(message);
            DialogResult = DialogResult.OK;
        }

        public async void DiscordEmbed()
        {
            var client = new DiscordWebhookClient(WebhookTb.Text);
            // Create your DiscordMessage with all parameters of your message.
            var message = new DiscordMessage(
                username: BotNameTb.Text,
                avatarUrl: PicUrlTb.Text,
        embeds: new[]
                {
        new DiscordMessageEmbed(
            color: 491507,
            author: new DiscordMessageEmbedAuthor(BotNameTb.Text),
            fields: new[]
            {
                new DiscordMessageEmbedField("Key :", $"`{key}`"),
            },
            thumbnail: new DiscordMessageEmbedThumbnail(PicUrlTb.Text),
            footer: new DiscordMessageEmbedFooter("Sent at: "+DateTime.Now.ToShortDateString(), PicUrlTb.Text)
        )
                }
            );

            // Send the message!
            await client.SendToDiscord(message);
            DialogResult = DialogResult.OK;
        }

        protected override void OnPaintBackground(PaintEventArgs e)
        {

            using (SolidBrush brush = new SolidBrush(Color.FromArgb(70, 0, 0, 0)))
                e.Graphics.FillRectangle(brush, e.ClipRectangle);
        }

        private void SendWebhookView_Load(object sender, EventArgs e)
        {
            PicUrlTb.Text = "https://www.gitbook.com/cdn-cgi/image/width=40,height=40,fit=contain,dpr=1,format=auto/https%3A%2F%2F4104118852-files.gitbook.io%2F~%2Ffiles%2Fv0%2Fb%2Fgitbook-legacy-files%2Fo%2Fspaces%252F-MN3xz4dcbly791TZk7q%252Favatar-1606415153929.png%3Fgeneration%3D1606415154289472%26alt%3Dmedia";
            BotNameTb.Text = "KeyAuth Seller Panel";
        }

        private void PicUrlTb_TextChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(PicUrlTb.Text) || !PicUrlTb.Text.Contains("https://"))
            {
                //bunifuSnackbar1.Show(HomeView.MainForm, "You must set a vaild URL for your banner", BunifuSnackbar.MessageTypes.Error, 5000, "", BunifuSnackbar.Positions.MiddleCenter);
                ///return;
            }
            else
            {
                bunifuPictureBox1.LoadAsync(PicUrlTb.Text);
            }
        }

        private void SendBtn_Click(object sender, EventArgs e)
        {
            if (TypeDd.SelectedIndex == 0)
            {
                DiscordEmbed();
            }
            else if (TypeDd.SelectedIndex == 1)
            {
                DiscordMessage();
            }
            else
                return;
        }
    }
}
