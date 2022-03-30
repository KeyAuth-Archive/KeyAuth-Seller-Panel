using KeyAuth_Seller_Panel.SellerPanel.CustomControls;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;

namespace KeyAuth_Seller_Panel.SellerPanel.Classes
{
    public class AppDetails
    {
        public string RemoveAllApps()
        {
            try
            {
                StringCollection defaultSettings = new StringCollection
                {
                    "YourBanerUrl",
                    "YourAppName",
                    "YourSellerKey",
                    "YourOwnerId",
                    "YourAppSecret",
                    "YourUser",
                    "YourUserPassword"
                };
                Properties.Settings.Default.App1 = defaultSettings;
                Properties.Settings.Default.App2 = defaultSettings;
                Properties.Settings.Default.App3 = defaultSettings;
                Properties.Settings.Default.App4 = defaultSettings;
                Properties.Settings.Default.App5 = defaultSettings;
                Properties.Settings.Default.App6 = defaultSettings;
                Properties.Settings.Default.App7 = defaultSettings;
                Properties.Settings.Default.App8 = defaultSettings;
                Properties.Settings.Default.App9 = defaultSettings;
                Properties.Settings.Default.App10 = defaultSettings;
                Properties.Settings.Default.FirstStart = true;
                Properties.Settings.Default.Save();
                return "Successfuly removed all apps.";
            }
            catch
            {
                return "Failed to remove all apps";
            }
        }

        public string RemoveApp(string Name)
        {
            try
            {
                StringCollection defaultSettings = new StringCollection
                {
                    "YourBanerUrl",
                    "YourAppName",
                    "YourSellerKey",
                    "YourOwnerId",
                    "YourAppSecret",
                    "YourUser",
                    "YourUserPassword"
                };
                Properties.Settings.Default[Name] = defaultSettings;
                Properties.Settings.Default.Save();
                return "Successfuly removed App.";
            }
            catch
            {
                return "Failed to remove App.";
            }
        }

        public string UpdateApp(string Name, StringCollection App)
        {
            try
            {
                Properties.Settings.Default[Name] = App;
                Properties.Settings.Default.Save();
                return "Successfuly Updated App settings.";
            }
            catch
            {
                return "Failed to update app setttings";
            }
        }

        public string SaveApp(StringCollection App)
        {
            HashSet<string> strings = new HashSet<string>
            {
                Properties.Settings.Default.App1[2],
                Properties.Settings.Default.App2[2],
                Properties.Settings.Default.App3[2],
                Properties.Settings.Default.App4[2],
                Properties.Settings.Default.App5[2],
                Properties.Settings.Default.App6[2],
                Properties.Settings.Default.App7[2],
                Properties.Settings.Default.App8[2],
                Properties.Settings.Default.App9[2],
                Properties.Settings.Default.App10[2]
            };
            if (!strings.Contains(App[2]))
            {
                HomeView.sellerApi.SetSellerKey(App[2]);
                if (HomeView.sellerApi.response.Success)
                    try
                    {
                        if (Properties.Settings.Default.App1[0] == "YourBanerUrl")
                            Properties.Settings.Default.App1 = App;
                        else if (Properties.Settings.Default.App2[0] == "YourBanerUrl")
                            Properties.Settings.Default.App2 = App;
                        else if (Properties.Settings.Default.App3[0] == "YourBanerUrl")
                            Properties.Settings.Default.App3 = App;
                        else if (Properties.Settings.Default.App4[0] == "YourBanerUrl")
                            Properties.Settings.Default.App4 = App;
                        else if (Properties.Settings.Default.App5[0] == "YourBanerUrl")
                            Properties.Settings.Default.App5 = App;
                        else if (Properties.Settings.Default.App6[0] == "YourBanerUrl")
                            Properties.Settings.Default.App6 = App;
                        else if (Properties.Settings.Default.App7[0] == "YourBanerUrl")
                            Properties.Settings.Default.App7 = App;
                        else if (Properties.Settings.Default.App8[0] == "YourBanerUrl")
                            Properties.Settings.Default.App8 = App;
                        else if (Properties.Settings.Default.App9[0] == "YourBanerUrl")
                            Properties.Settings.Default.App9 = App;
                        else if (Properties.Settings.Default.App10[0] == "YourBanerUrl")
                            Properties.Settings.Default.App10 = App;
                        else
                            return $"Failed to add {App[1]}, as you have no more app Spaces availible.";
                        Properties.Settings.Default.FirstStart = false;
                        Properties.Settings.Default.Save();
                        return $"Successfully added, {App[1]} !";
                    }
                    catch
                    {
                        return $"Failed while adding new app ( {App[1]} )";
                    }
                else
                return $"Failed {HomeView.sellerApi.response.Message}";
            }
            else
                return $"Failed to add ( {App[1]} ) as that seller key is already added";
        }

        public void LoadApps()   
        {
            HomeView.AppLayout.Controls.Clear();
            var Settings = Properties.Settings.Default;
            int numberOfApps = 0;
            if (Settings.App1[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App1, "App1");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App2[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App2, "App2");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App3[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App3, "App3");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App4[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App4, "App4");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App5[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App5, "App5");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App6[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App6, "App6");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App7[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App7, "App7");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App8[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App8, "App8");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App9[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App9, "App9");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            if (Settings.App10[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App10, "App10");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            HomeNav homeNav = new HomeNav(numberOfApps);
            HomeView.AppLayout.Controls.Add(homeNav);
            homeNav.BringToFront();
        }
        /*public void TestLoadApps()
        {
            HomeView.AppLayout.Controls.Clear();

            int numberOfApps = 0;
            int num = 0;
            string test = $"App{num}";
            var test1 = Properties.Settings.Default[test];
            var test2 = test1
            Console.WriteLine(test1.);
            StringCollection s = new StringCollection
            {
                
            };
            if (Settings[0] != "YourBanerUrl")
            {
                numberOfApps++;
                AppCard appCard = new AppCard(Settings.App1, "App1");
                HomeView.AppLayout.Controls.Add(appCard);
            }
            HomeNav homeNav = new HomeNav(numberOfApps);
            HomeView.AppLayout.Controls.Add(homeNav);
            homeNav.BringToFront();
        }*/
    }
}
