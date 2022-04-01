﻿using Bunifu.UI.WinForms;
using Bunifu.Utils;
using JNogueira.Discord.Webhook.Client;
using KeyAuth_Seller_Panel.SellerPanel.Views.PopUpViews;
using System;
using System.IO;
using System.Windows.Forms;

namespace KeyAuth_Seller_Panel.SellerPanel.Views.SelectedAppControls
{
    public partial class LicensesView : UserControl
    {
        private static string TimeLicense(string str)
        {
            string time;
            var s = (long)Double.Parse(str);
            var t = TimeSpan.FromSeconds(s);

            if(t.Minutes == 0 && t.Hours == 0 && t.Days == 0)
                if(t.Seconds >= 2)
                    time = Convert.ToString($"{t.Seconds} Seconds");
                else
                    time = Convert.ToString($"{t.Seconds} Second");
            else if (t.Seconds == 0 && t.Hours == 0 && t.Days == 0)
                if (t.Minutes >= 2)
                    time = Convert.ToString($"{t.Minutes} Minutes");
                else
                    time = Convert.ToString($"{t.Minutes} Minute");

            else if (t.Seconds == 0 && t.Minutes == 0 && t.Days == 0)
                if (t.Hours >= 2)
                    time = Convert.ToString($"{t.Hours} Hours");
                else
                    time = Convert.ToString($"{t.Hours} Hour");
            else if (t.Seconds == 0 && t.Minutes == 0 && t.Hours == 0)
                if (t.Days >= 2)
                    time = Convert.ToString($"{t.Days} Days");
                else
                    time = Convert.ToString($"{t.Days} Day");
            else
                time = Convert.ToString($"{t.Days} Days");
            return time;

        }
        public LicensesView()
        {

            InitializeComponent();
        }

        string key;
        private void LicensesView_Load(object sender, EventArgs e)
        {
            string subName = string.Empty;
            
            ScrollbarBinder.BindDatagridView(bunifuDataGridView1, bunifuVScrollBar1);
            bunifuVScrollBar1.BorderRadius = 10;
            HomeView.sellerApi.LicenseViewAll();
            if (HomeView.sellerApi.response.Success)
            {
                HomeView.sellerApi.SubViewAll();
                foreach (var Keys in HomeView.sellerApi.license.Keys)
                {
                    foreach (var sub in HomeView.sellerApi.subs.All)
                        if (Keys.Level == sub.Level)
                            subName = sub.Name;
                    if (Keys.Banned == null)
                        Keys.Banned = "No";
                    else
                        Keys.Banned = "Yes reason: " + Keys.Banned;
                    if (Keys.Usedby == null)
                        Keys.Usedby = "N/A";
                    if (Keys.Usedon == null)
                        Keys.Usedon = "N/A";
                    else
                        Keys.Usedon = UsersView.UnixTimeToDateTime(long.Parse(Keys.Usedon));
                    bunifuDataGridView1.Rows.Insert(0, Keys.Status, Keys.Key, subName);
                        ////, Keys.Banned, Keys.Note, Keys.Genby, Keys.Usedby, Keys.Usedon, UsersView.UnixTimeToDateTime(long.Parse(Keys.Gendate)), TimeLicense(Keys.Expires));



                }
                bunifuVScrollBar1.BindTo(bunifuDataGridView1, true);
            }
            else if (HomeView.sellerApi.response.Message.Contains("No application with specified seller key found"))
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Redirecting to App info.", BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                bunifuSnackbar1.Show(HomeView.MainForm, "Your seller key may have been changed please update it.", BunifuSnackbar.MessageTypes.Error, 10000, "", BunifuSnackbar.Positions.MiddleCenter);
                AppStatsView appStatsView = new AppStatsView();
                SelectedAppView.AppViews.Controls.Add(appStatsView);
                SelectedAppView.AppViews.Controls.Remove(this);
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, BunifuSnackbar.MessageTypes.Information, 10000, "", BunifuSnackbar.Positions.MiddleCenter);


        }
        
        private void bunifuDataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void generateLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            GenerateLicensesView licensesView = new GenerateLicensesView();
            if (licensesView.ShowDialog() == DialogResult.Cancel)
            {
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());

            }
        }

        private void dayToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseAddTime(0);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfuly added 1 day to all ununsed keys.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void weekToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseAddTime(1);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfuly added 1 Week to all ununsed keys.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void monthToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseAddTime(2);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfuly added 1 month to all ununsed keys.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void yeaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseAddTime(3);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfuly added 1 year to all ununsed keys.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void lieftimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseAddTime(4);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, "Succussfuly added lifetime to all ununsed keys.", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void allToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseDeleteAll();
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void selectedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseDelete(key);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void usedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseDeleteUsed();
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void unusedToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseDeleteUnused();
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void banToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BanKeyView banKeyView = new BanKeyView(key);
            var test = banKeyView.ShowDialog();
            if (test == DialogResult.OK)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
}
            else if (test == DialogResult.Abort)
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void unbanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            HomeView.sellerApi.LicenseUnban(key);
            if (HomeView.sellerApi.response.Success)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void cSVFileToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (HomeView.sellerApi.license.Keys.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            bunifuSnackbar1.Show(HomeView.MainForm, "It wasn't possible to write the data to the disk." + ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                    if (!fileError)
                        try
                        {
                            using (var file = File.CreateText(sfd.FileName))
                            {
                                file.WriteLine(string.Join(",", "License", "Generated Date", "Status"));
                                foreach (var arr in HomeView.sellerApi.license.Keys)
                                    file.WriteLine(string.Join(",", arr.Key, UsersView.UnixTimeToDateTime(long.Parse(arr.Gendate)), arr.Status));
                            }
                            bunifuSnackbar1.Show(HomeView.MainForm, "Data Exported Successfully !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                        catch (Exception ex)
                        {
                            bunifuSnackbar1.Show(HomeView.MainForm, "Error :" + ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                }
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "No Record To Export !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void cSVFileToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            if (HomeView.sellerApi.license.Keys.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            bunifuSnackbar1.Show(HomeView.MainForm, "It wasn't possible to write the data to the disk." + ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                    if (!fileError)
                        try
                        {
                            using (var file = File.CreateText(sfd.FileName))
                            {
                                file.WriteLine(string.Join(",", "License", "Generated Date", "Status"));
                                foreach (var arr in HomeView.sellerApi.license.Keys)
                                    if (arr.Status == "Used")
                                        file.WriteLine(string.Join(",", arr.Key, UsersView.UnixTimeToDateTime(long.Parse(arr.Gendate)), arr.Status));
                            }
                            bunifuSnackbar1.Show(HomeView.MainForm, "Data Exported Successfully !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                        catch (Exception ex)
                        {
                            bunifuSnackbar1.Show(HomeView.MainForm, "Error :" + ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                }
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "No Record To Export !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void cSVFileToolStripMenuItem3_Click(object sender, EventArgs e)
        {
            if (HomeView.sellerApi.license.Keys.Count > 0)
            {
                SaveFileDialog sfd = new SaveFileDialog();
                sfd.Filter = "CSV (*.csv)|*.csv";
                sfd.FileName = "Output.csv";
                bool fileError = false;
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    if (File.Exists(sfd.FileName))
                        try
                        {
                            File.Delete(sfd.FileName);
                        }
                        catch (IOException ex)
                        {
                            fileError = true;
                            bunifuSnackbar1.Show(HomeView.MainForm, "It wasn't possible to write the data to the disk." + ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                    if (!fileError)
                        try
                        {
                            using (var file = File.CreateText(sfd.FileName))
                            {
                                file.WriteLine(string.Join(",", "License", "Generated Date", "Status"));
                                foreach (var arr in HomeView.sellerApi.license.Keys)
                                    if (arr.Status == "Not Used")
                                        file.WriteLine(string.Join(",", arr.Key, UsersView.UnixTimeToDateTime(long.Parse(arr.Gendate)), arr.Status));
                            }
                            bunifuSnackbar1.Show(HomeView.MainForm, "Data Exported Successfully !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                        catch (Exception ex)
                        {
                            bunifuSnackbar1.Show(HomeView.MainForm, "Error :" + ex.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                        }
                }
            }
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "No Record To Export !", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void copyToClipboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Clipboard.SetDataObject(key);
            IDataObject iData = Clipboard.GetDataObject();
            if (iData.GetDataPresent(DataFormats.Text))
                bunifuSnackbar1.Show(HomeView.MainForm, "Key successfuly copied to clipboard.", BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else
                bunifuSnackbar1.Show(HomeView.MainForm, "Error", BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }
        private void createUserWithLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CreateNewUserLicenseView createNewUserLicenseView = new CreateNewUserLicenseView(key);
            var test = createNewUserLicenseView.ShowDialog();
            if (test == DialogResult.OK)
            {
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
                SelectedAppView.AppViews.Controls.Clear();
                SelectedAppView.AppViews.Controls.Add(new LicensesView());
            }
            else if(test == DialogResult.Abort)
                bunifuSnackbar1.Show(HomeView.MainForm, HomeView.sellerApi.response.Message, Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);

        }

        private void iscordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SendWebhookView sendWebhookView = new SendWebhookView(key);
            var test = sendWebhookView.ShowDialog();
            if (test == DialogResult.OK)
                bunifuSnackbar1.Show(HomeView.MainForm, "Webhook Sent", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Success, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
            else if (test == DialogResult.Abort)
                bunifuSnackbar1.Show(HomeView.MainForm, "Webhook Failed", Bunifu.UI.WinForms.BunifuSnackbar.MessageTypes.Error, 5000, "", Bunifu.UI.WinForms.BunifuSnackbar.Positions.MiddleCenter);
        }

        private void bunifuPanel1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            
        }
    }
}
