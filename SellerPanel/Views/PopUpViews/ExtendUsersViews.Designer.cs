namespace KeyAuth_Seller_Panel.SellerPanel.Views.PopUpViews
{
    partial class ExtendUsersViews
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ExtendUsersViews));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.App1Card = new Bunifu.UI.WinForms.BunifuPanel();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.ExpiryDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.SubListDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.UserListDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.BackBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AppBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.App1Card.SuspendLayout();
            this.Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // bunifuElipse1
            // 
            this.bunifuElipse1.ElipseRadius = 10;
            this.bunifuElipse1.TargetControl = this;
            // 
            // App1Card
            // 
            this.App1Card.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.App1Card.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("App1Card.BackgroundImage")));
            this.App1Card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.App1Card.BorderColor = System.Drawing.Color.Transparent;
            this.App1Card.BorderRadius = 10;
            this.App1Card.BorderThickness = 1;
            this.App1Card.Controls.Add(this.Card);
            this.App1Card.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.App1Card.Location = new System.Drawing.Point(320, 45);
            this.App1Card.Name = "App1Card";
            this.App1Card.Padding = new System.Windows.Forms.Padding(5);
            this.App1Card.ShowBorders = true;
            this.App1Card.Size = new System.Drawing.Size(360, 360);
            this.App1Card.TabIndex = 37;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.ExpiryDd);
            this.Card.Controls.Add(this.SubListDd);
            this.Card.Controls.Add(this.UserListDd);
            this.Card.Controls.Add(this.bunifuLabel8);
            this.Card.Controls.Add(this.BackBtn);
            this.Card.Controls.Add(this.AppBtn);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Card.LabelIndent = 10;
            this.Card.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.Card.Size = new System.Drawing.Size(350, 350);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            // 
            // ExpiryDd
            // 
            this.ExpiryDd.BackColor = System.Drawing.Color.Transparent;
            this.ExpiryDd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ExpiryDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.ExpiryDd.BorderRadius = 6;
            this.ExpiryDd.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.ExpiryDd.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.ExpiryDd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ExpiryDd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.ExpiryDd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.ExpiryDd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.ExpiryDd.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.ExpiryDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.ExpiryDd.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.ExpiryDd.DropDownHeight = 300;
            this.ExpiryDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ExpiryDd.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ExpiryDd.FillDropDown = true;
            this.ExpiryDd.FillIndicator = false;
            this.ExpiryDd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ExpiryDd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.ExpiryDd.ForeColor = System.Drawing.Color.White;
            this.ExpiryDd.FormattingEnabled = true;
            this.ExpiryDd.Icon = null;
            this.ExpiryDd.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ExpiryDd.IndicatorColor = System.Drawing.Color.White;
            this.ExpiryDd.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.ExpiryDd.IndicatorThickness = 2;
            this.ExpiryDd.IntegralHeight = false;
            this.ExpiryDd.IsDropdownOpened = false;
            this.ExpiryDd.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.ExpiryDd.ItemBorderColor = System.Drawing.Color.White;
            this.ExpiryDd.ItemForeColor = System.Drawing.Color.White;
            this.ExpiryDd.ItemHeight = 24;
            this.ExpiryDd.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.ExpiryDd.ItemHighLightForeColor = System.Drawing.Color.White;
            this.ExpiryDd.Items.AddRange(new object[] {
            "Day",
            "Week",
            "Month",
            "Year",
            "Lifetime"});
            this.ExpiryDd.ItemTopMargin = 3;
            this.ExpiryDd.Location = new System.Drawing.Point(101, 208);
            this.ExpiryDd.Name = "ExpiryDd";
            this.ExpiryDd.Size = new System.Drawing.Size(149, 30);
            this.ExpiryDd.TabIndex = 127;
            this.ExpiryDd.Text = "User expiry";
            this.ExpiryDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.ExpiryDd.TextLeftMargin = 5;
            // 
            // SubListDd
            // 
            this.SubListDd.BackColor = System.Drawing.Color.Transparent;
            this.SubListDd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SubListDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SubListDd.BorderRadius = 6;
            this.SubListDd.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SubListDd.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.SubListDd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SubListDd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SubListDd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SubListDd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SubListDd.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.SubListDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubListDd.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.SubListDd.DropDownHeight = 300;
            this.SubListDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubListDd.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SubListDd.FillDropDown = true;
            this.SubListDd.FillIndicator = false;
            this.SubListDd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubListDd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubListDd.ForeColor = System.Drawing.Color.White;
            this.SubListDd.FormattingEnabled = true;
            this.SubListDd.Icon = null;
            this.SubListDd.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SubListDd.IndicatorColor = System.Drawing.Color.White;
            this.SubListDd.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SubListDd.IndicatorThickness = 2;
            this.SubListDd.IntegralHeight = false;
            this.SubListDd.IsDropdownOpened = false;
            this.SubListDd.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SubListDd.ItemBorderColor = System.Drawing.Color.White;
            this.SubListDd.ItemForeColor = System.Drawing.Color.White;
            this.SubListDd.ItemHeight = 24;
            this.SubListDd.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.SubListDd.ItemHighLightForeColor = System.Drawing.Color.White;
            this.SubListDd.ItemTopMargin = 3;
            this.SubListDd.Location = new System.Drawing.Point(101, 160);
            this.SubListDd.Name = "SubListDd";
            this.SubListDd.Size = new System.Drawing.Size(149, 30);
            this.SubListDd.TabIndex = 121;
            this.SubListDd.Text = "Sub List";
            this.SubListDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SubListDd.TextLeftMargin = 5;
            // 
            // UserListDd
            // 
            this.UserListDd.BackColor = System.Drawing.Color.Transparent;
            this.UserListDd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UserListDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.UserListDd.BorderRadius = 6;
            this.UserListDd.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.UserListDd.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.UserListDd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UserListDd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.UserListDd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UserListDd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.UserListDd.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.UserListDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.UserListDd.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.UserListDd.DropDownHeight = 300;
            this.UserListDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.UserListDd.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.UserListDd.FillDropDown = true;
            this.UserListDd.FillIndicator = false;
            this.UserListDd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UserListDd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.UserListDd.ForeColor = System.Drawing.Color.White;
            this.UserListDd.FormattingEnabled = true;
            this.UserListDd.Icon = null;
            this.UserListDd.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.UserListDd.IndicatorColor = System.Drawing.Color.White;
            this.UserListDd.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.UserListDd.IndicatorThickness = 2;
            this.UserListDd.IntegralHeight = false;
            this.UserListDd.IsDropdownOpened = false;
            this.UserListDd.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.UserListDd.ItemBorderColor = System.Drawing.Color.White;
            this.UserListDd.ItemForeColor = System.Drawing.Color.White;
            this.UserListDd.ItemHeight = 24;
            this.UserListDd.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.UserListDd.ItemHighLightForeColor = System.Drawing.Color.White;
            this.UserListDd.ItemTopMargin = 3;
            this.UserListDd.Location = new System.Drawing.Point(98, 88);
            this.UserListDd.Name = "UserListDd";
            this.UserListDd.Size = new System.Drawing.Size(149, 30);
            this.UserListDd.TabIndex = 120;
            this.UserListDd.Text = "User";
            this.UserListDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.UserListDd.TextLeftMargin = 5;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.AutoSize = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel8.Location = new System.Drawing.Point(32, 3);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(285, 79);
            this.bunifuLabel8.TabIndex = 107;
            this.bunifuLabel8.Text = "Extend User";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // BackBtn
            // 
            this.BackBtn.AllowAnimations = true;
            this.BackBtn.AllowMouseEffects = true;
            this.BackBtn.AllowToggling = false;
            this.BackBtn.AnimationSpeed = 200;
            this.BackBtn.AutoGenerateColors = false;
            this.BackBtn.AutoRoundBorders = false;
            this.BackBtn.AutoSizeLeftIcon = true;
            this.BackBtn.AutoSizeRightIcon = true;
            this.BackBtn.BackColor = System.Drawing.Color.Transparent;
            this.BackBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BackBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BackBtn.BackgroundImage")));
            this.BackBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackBtn.ButtonText = "Back";
            this.BackBtn.ButtonTextMarginLeft = 0;
            this.BackBtn.ColorContrastOnClick = 45;
            this.BackBtn.ColorContrastOnHover = 45;
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.BackBtn.CustomizableEdges = borderEdges1;
            this.BackBtn.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BackBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BackBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.BackBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.BackBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BackBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BackBtn.ForeColor = System.Drawing.Color.White;
            this.BackBtn.IconLeft = null;
            this.BackBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BackBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BackBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BackBtn.IconMarginLeft = 11;
            this.BackBtn.IconPadding = 10;
            this.BackBtn.IconRight = null;
            this.BackBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BackBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BackBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BackBtn.IconSize = 25;
            this.BackBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.BackBtn.IdleBorderRadius = 0;
            this.BackBtn.IdleBorderThickness = 0;
            this.BackBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.BackBtn.IdleIconLeftImage = null;
            this.BackBtn.IdleIconRightImage = null;
            this.BackBtn.IndicateFocus = false;
            this.BackBtn.Location = new System.Drawing.Point(31, 292);
            this.BackBtn.Name = "BackBtn";
            this.BackBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BackBtn.OnDisabledState.BorderRadius = 10;
            this.BackBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackBtn.OnDisabledState.BorderThickness = 2;
            this.BackBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BackBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BackBtn.OnDisabledState.IconLeftImage = null;
            this.BackBtn.OnDisabledState.IconRightImage = null;
            this.BackBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BackBtn.onHoverState.BorderRadius = 10;
            this.BackBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackBtn.onHoverState.BorderThickness = 2;
            this.BackBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BackBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BackBtn.onHoverState.IconLeftImage = null;
            this.BackBtn.onHoverState.IconRightImage = null;
            this.BackBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BackBtn.OnIdleState.BorderRadius = 10;
            this.BackBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackBtn.OnIdleState.BorderThickness = 2;
            this.BackBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BackBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BackBtn.OnIdleState.IconLeftImage = null;
            this.BackBtn.OnIdleState.IconRightImage = null;
            this.BackBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BackBtn.OnPressedState.BorderRadius = 10;
            this.BackBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BackBtn.OnPressedState.BorderThickness = 2;
            this.BackBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BackBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BackBtn.OnPressedState.IconLeftImage = null;
            this.BackBtn.OnPressedState.IconRightImage = null;
            this.BackBtn.Size = new System.Drawing.Size(140, 30);
            this.BackBtn.TabIndex = 34;
            this.BackBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BackBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BackBtn.TextMarginLeft = 0;
            this.BackBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.BackBtn.UseDefaultRadiusAndThickness = true;
            // 
            // AppBtn
            // 
            this.AppBtn.AllowAnimations = true;
            this.AppBtn.AllowMouseEffects = true;
            this.AppBtn.AllowToggling = false;
            this.AppBtn.AnimationSpeed = 200;
            this.AppBtn.AutoGenerateColors = false;
            this.AppBtn.AutoRoundBorders = false;
            this.AppBtn.AutoSizeLeftIcon = true;
            this.AppBtn.AutoSizeRightIcon = true;
            this.AppBtn.BackColor = System.Drawing.Color.Transparent;
            this.AppBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AppBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppBtn.BackgroundImage")));
            this.AppBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppBtn.ButtonText = "Extend";
            this.AppBtn.ButtonTextMarginLeft = 0;
            this.AppBtn.ColorContrastOnClick = 45;
            this.AppBtn.ColorContrastOnHover = 45;
            this.AppBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.AppBtn.CustomizableEdges = borderEdges2;
            this.AppBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AppBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AppBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.AppBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.AppBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AppBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppBtn.ForeColor = System.Drawing.Color.White;
            this.AppBtn.IconLeft = null;
            this.AppBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AppBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AppBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AppBtn.IconMarginLeft = 11;
            this.AppBtn.IconPadding = 10;
            this.AppBtn.IconRight = null;
            this.AppBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AppBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AppBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AppBtn.IconSize = 25;
            this.AppBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.AppBtn.IdleBorderRadius = 0;
            this.AppBtn.IdleBorderThickness = 0;
            this.AppBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.AppBtn.IdleIconLeftImage = null;
            this.AppBtn.IdleIconRightImage = null;
            this.AppBtn.IndicateFocus = false;
            this.AppBtn.Location = new System.Drawing.Point(177, 292);
            this.AppBtn.Name = "AppBtn";
            this.AppBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AppBtn.OnDisabledState.BorderRadius = 10;
            this.AppBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppBtn.OnDisabledState.BorderThickness = 2;
            this.AppBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AppBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AppBtn.OnDisabledState.IconLeftImage = null;
            this.AppBtn.OnDisabledState.IconRightImage = null;
            this.AppBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.AppBtn.onHoverState.BorderRadius = 10;
            this.AppBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppBtn.onHoverState.BorderThickness = 2;
            this.AppBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AppBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AppBtn.onHoverState.IconLeftImage = null;
            this.AppBtn.onHoverState.IconRightImage = null;
            this.AppBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AppBtn.OnIdleState.BorderRadius = 10;
            this.AppBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppBtn.OnIdleState.BorderThickness = 2;
            this.AppBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AppBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AppBtn.OnIdleState.IconLeftImage = null;
            this.AppBtn.OnIdleState.IconRightImage = null;
            this.AppBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AppBtn.OnPressedState.BorderRadius = 10;
            this.AppBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AppBtn.OnPressedState.BorderThickness = 2;
            this.AppBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AppBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AppBtn.OnPressedState.IconLeftImage = null;
            this.AppBtn.OnPressedState.IconRightImage = null;
            this.AppBtn.Size = new System.Drawing.Size(140, 30);
            this.AppBtn.TabIndex = 30;
            this.AppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AppBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppBtn.TextMarginLeft = 0;
            this.AppBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.AppBtn.UseDefaultRadiusAndThickness = true;
            this.AppBtn.Click += new System.EventHandler(this.AppBtn_Click);
            // 
            // ExtendUsersViews
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.App1Card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ExtendUsersViews";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "ExtendUsersViews";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.ExtendUsersViews_Load);
            this.App1Card.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel App1Card;
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private Bunifu.UI.WinForms.BunifuDropdown UserListDd;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BackBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AppBtn;
        private Bunifu.UI.WinForms.BunifuDropdown SubListDd;
        private Bunifu.UI.WinForms.BunifuDropdown ExpiryDd;
    }
}