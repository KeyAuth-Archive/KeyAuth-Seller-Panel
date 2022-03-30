namespace KeyAuth_Seller_Panel.SellerPanel.Views.PopUpViews
{
    partial class UserInfoView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UserInfoView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.App1Card = new Bunifu.UI.WinForms.BunifuPanel();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.IpLb = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel4 = new Bunifu.UI.WinForms.BunifuLabel();
            this.HwidLb = new Bunifu.UI.WinForms.BunifuLabel();
            this.DeleteVar = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.VarDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.DeleteSub = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SubDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.BackBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.App1Card.Location = new System.Drawing.Point(168, 55);
            this.App1Card.Name = "App1Card";
            this.App1Card.Padding = new System.Windows.Forms.Padding(5);
            this.App1Card.ShowBorders = true;
            this.App1Card.Size = new System.Drawing.Size(641, 351);
            this.App1Card.TabIndex = 38;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.bunifuLabel1);
            this.Card.Controls.Add(this.IpLb);
            this.Card.Controls.Add(this.bunifuLabel4);
            this.Card.Controls.Add(this.HwidLb);
            this.Card.Controls.Add(this.DeleteVar);
            this.Card.Controls.Add(this.VarDd);
            this.Card.Controls.Add(this.DeleteSub);
            this.Card.Controls.Add(this.SubDd);
            this.Card.Controls.Add(this.bunifuLabel8);
            this.Card.Controls.Add(this.BackBtn);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Card.LabelIndent = 10;
            this.Card.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.Card.Size = new System.Drawing.Size(631, 341);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            this.Card.Enter += new System.EventHandler(this.Card_Enter);
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel1.Location = new System.Drawing.Point(8, 245);
            this.bunifuLabel1.MaximumSize = new System.Drawing.Size(43, 17);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(19, 17);
            this.bunifuLabel1.TabIndex = 132;
            this.bunifuLabel1.Text = "IP :";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // IpLb
            // 
            this.IpLb.AllowParentOverrides = false;
            this.IpLb.AutoEllipsis = false;
            this.IpLb.AutoSize = false;
            this.IpLb.CursorType = null;
            this.IpLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IpLb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.IpLb.Location = new System.Drawing.Point(8, 268);
            this.IpLb.Name = "IpLb";
            this.IpLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.IpLb.Size = new System.Drawing.Size(324, 34);
            this.IpLb.TabIndex = 133;
            this.IpLb.Text = "00.00.00.000";
            this.IpLb.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.IpLb.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            this.IpLb.Click += new System.EventHandler(this.IpLb_Click);
            // 
            // bunifuLabel4
            // 
            this.bunifuLabel4.AllowParentOverrides = false;
            this.bunifuLabel4.AutoEllipsis = false;
            this.bunifuLabel4.CursorType = null;
            this.bunifuLabel4.Font = new System.Drawing.Font("Segoe UI Semibold", 9.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel4.Location = new System.Drawing.Point(8, 193);
            this.bunifuLabel4.MaximumSize = new System.Drawing.Size(43, 17);
            this.bunifuLabel4.Name = "bunifuLabel4";
            this.bunifuLabel4.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel4.Size = new System.Drawing.Size(43, 17);
            this.bunifuLabel4.TabIndex = 130;
            this.bunifuLabel4.Text = "HWID :";
            this.bunifuLabel4.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel4.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // HwidLb
            // 
            this.HwidLb.AllowParentOverrides = false;
            this.HwidLb.AutoEllipsis = false;
            this.HwidLb.AutoSize = false;
            this.HwidLb.CursorType = null;
            this.HwidLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HwidLb.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.HwidLb.Location = new System.Drawing.Point(8, 216);
            this.HwidLb.Name = "HwidLb";
            this.HwidLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.HwidLb.Size = new System.Drawing.Size(324, 34);
            this.HwidLb.TabIndex = 131;
            this.HwidLb.Text = "00.00.00.000";
            this.HwidLb.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.HwidLb.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // DeleteVar
            // 
            this.DeleteVar.AllowAnimations = true;
            this.DeleteVar.AllowMouseEffects = true;
            this.DeleteVar.AllowToggling = false;
            this.DeleteVar.AnimationSpeed = 200;
            this.DeleteVar.AutoGenerateColors = false;
            this.DeleteVar.AutoRoundBorders = false;
            this.DeleteVar.AutoSizeLeftIcon = true;
            this.DeleteVar.AutoSizeRightIcon = true;
            this.DeleteVar.BackColor = System.Drawing.Color.Transparent;
            this.DeleteVar.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DeleteVar.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteVar.BackgroundImage")));
            this.DeleteVar.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteVar.ButtonText = "Delete Var";
            this.DeleteVar.ButtonTextMarginLeft = 0;
            this.DeleteVar.ColorContrastOnClick = 45;
            this.DeleteVar.ColorContrastOnHover = 45;
            this.DeleteVar.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.DeleteVar.CustomizableEdges = borderEdges1;
            this.DeleteVar.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteVar.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteVar.DisabledFillColor = System.Drawing.Color.Empty;
            this.DeleteVar.DisabledForecolor = System.Drawing.Color.Empty;
            this.DeleteVar.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DeleteVar.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteVar.ForeColor = System.Drawing.Color.White;
            this.DeleteVar.IconLeft = null;
            this.DeleteVar.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteVar.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteVar.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DeleteVar.IconMarginLeft = 11;
            this.DeleteVar.IconPadding = 10;
            this.DeleteVar.IconRight = null;
            this.DeleteVar.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteVar.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteVar.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DeleteVar.IconSize = 25;
            this.DeleteVar.IdleBorderColor = System.Drawing.Color.Empty;
            this.DeleteVar.IdleBorderRadius = 0;
            this.DeleteVar.IdleBorderThickness = 0;
            this.DeleteVar.IdleFillColor = System.Drawing.Color.Empty;
            this.DeleteVar.IdleIconLeftImage = null;
            this.DeleteVar.IdleIconRightImage = null;
            this.DeleteVar.IndicateFocus = false;
            this.DeleteVar.Location = new System.Drawing.Point(249, 301);
            this.DeleteVar.Name = "DeleteVar";
            this.DeleteVar.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteVar.OnDisabledState.BorderRadius = 10;
            this.DeleteVar.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteVar.OnDisabledState.BorderThickness = 2;
            this.DeleteVar.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteVar.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteVar.OnDisabledState.IconLeftImage = null;
            this.DeleteVar.OnDisabledState.IconRightImage = null;
            this.DeleteVar.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteVar.onHoverState.BorderRadius = 10;
            this.DeleteVar.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteVar.onHoverState.BorderThickness = 2;
            this.DeleteVar.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteVar.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DeleteVar.onHoverState.IconLeftImage = null;
            this.DeleteVar.onHoverState.IconRightImage = null;
            this.DeleteVar.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteVar.OnIdleState.BorderRadius = 10;
            this.DeleteVar.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteVar.OnIdleState.BorderThickness = 2;
            this.DeleteVar.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteVar.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DeleteVar.OnIdleState.IconLeftImage = null;
            this.DeleteVar.OnIdleState.IconRightImage = null;
            this.DeleteVar.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteVar.OnPressedState.BorderRadius = 10;
            this.DeleteVar.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteVar.OnPressedState.BorderThickness = 2;
            this.DeleteVar.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteVar.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeleteVar.OnPressedState.IconLeftImage = null;
            this.DeleteVar.OnPressedState.IconRightImage = null;
            this.DeleteVar.Size = new System.Drawing.Size(140, 30);
            this.DeleteVar.TabIndex = 129;
            this.DeleteVar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteVar.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteVar.TextMarginLeft = 0;
            this.DeleteVar.TextPadding = new System.Windows.Forms.Padding(0);
            this.DeleteVar.UseDefaultRadiusAndThickness = true;
            this.DeleteVar.Click += new System.EventHandler(this.DeleteVar_Click);
            // 
            // VarDd
            // 
            this.VarDd.BackColor = System.Drawing.Color.Transparent;
            this.VarDd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.VarDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.VarDd.BorderRadius = 6;
            this.VarDd.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.VarDd.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.VarDd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.VarDd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.VarDd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.VarDd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.VarDd.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.VarDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.VarDd.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.VarDd.DropDownHeight = 300;
            this.VarDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.VarDd.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.VarDd.FillDropDown = true;
            this.VarDd.FillIndicator = false;
            this.VarDd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.VarDd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.VarDd.ForeColor = System.Drawing.Color.White;
            this.VarDd.FormattingEnabled = true;
            this.VarDd.Icon = null;
            this.VarDd.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.VarDd.IndicatorColor = System.Drawing.Color.White;
            this.VarDd.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.VarDd.IndicatorThickness = 2;
            this.VarDd.IntegralHeight = false;
            this.VarDd.IsDropdownOpened = false;
            this.VarDd.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.VarDd.ItemBorderColor = System.Drawing.Color.White;
            this.VarDd.ItemForeColor = System.Drawing.Color.White;
            this.VarDd.ItemHeight = 24;
            this.VarDd.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.VarDd.ItemHighLightForeColor = System.Drawing.Color.White;
            this.VarDd.ItemTopMargin = 3;
            this.VarDd.Location = new System.Drawing.Point(8, 155);
            this.VarDd.Name = "VarDd";
            this.VarDd.Size = new System.Drawing.Size(615, 30);
            this.VarDd.TabIndex = 128;
            this.VarDd.Text = "User Var";
            this.VarDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.VarDd.TextLeftMargin = 5;
            // 
            // DeleteSub
            // 
            this.DeleteSub.AllowAnimations = true;
            this.DeleteSub.AllowMouseEffects = true;
            this.DeleteSub.AllowToggling = false;
            this.DeleteSub.AnimationSpeed = 200;
            this.DeleteSub.AutoGenerateColors = false;
            this.DeleteSub.AutoRoundBorders = false;
            this.DeleteSub.AutoSizeLeftIcon = true;
            this.DeleteSub.AutoSizeRightIcon = true;
            this.DeleteSub.BackColor = System.Drawing.Color.Transparent;
            this.DeleteSub.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DeleteSub.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DeleteSub.BackgroundImage")));
            this.DeleteSub.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSub.ButtonText = "Delete Sub";
            this.DeleteSub.ButtonTextMarginLeft = 0;
            this.DeleteSub.ColorContrastOnClick = 45;
            this.DeleteSub.ColorContrastOnHover = 45;
            this.DeleteSub.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.DeleteSub.CustomizableEdges = borderEdges2;
            this.DeleteSub.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DeleteSub.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteSub.DisabledFillColor = System.Drawing.Color.Empty;
            this.DeleteSub.DisabledForecolor = System.Drawing.Color.Empty;
            this.DeleteSub.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DeleteSub.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DeleteSub.ForeColor = System.Drawing.Color.White;
            this.DeleteSub.IconLeft = null;
            this.DeleteSub.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DeleteSub.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteSub.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DeleteSub.IconMarginLeft = 11;
            this.DeleteSub.IconPadding = 10;
            this.DeleteSub.IconRight = null;
            this.DeleteSub.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DeleteSub.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DeleteSub.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DeleteSub.IconSize = 25;
            this.DeleteSub.IdleBorderColor = System.Drawing.Color.Empty;
            this.DeleteSub.IdleBorderRadius = 0;
            this.DeleteSub.IdleBorderThickness = 0;
            this.DeleteSub.IdleFillColor = System.Drawing.Color.Empty;
            this.DeleteSub.IdleIconLeftImage = null;
            this.DeleteSub.IdleIconRightImage = null;
            this.DeleteSub.IndicateFocus = false;
            this.DeleteSub.Location = new System.Drawing.Point(395, 301);
            this.DeleteSub.Name = "DeleteSub";
            this.DeleteSub.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DeleteSub.OnDisabledState.BorderRadius = 10;
            this.DeleteSub.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSub.OnDisabledState.BorderThickness = 2;
            this.DeleteSub.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DeleteSub.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DeleteSub.OnDisabledState.IconLeftImage = null;
            this.DeleteSub.OnDisabledState.IconRightImage = null;
            this.DeleteSub.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.DeleteSub.onHoverState.BorderRadius = 10;
            this.DeleteSub.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSub.onHoverState.BorderThickness = 2;
            this.DeleteSub.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteSub.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DeleteSub.onHoverState.IconLeftImage = null;
            this.DeleteSub.onHoverState.IconRightImage = null;
            this.DeleteSub.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteSub.OnIdleState.BorderRadius = 10;
            this.DeleteSub.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSub.OnIdleState.BorderThickness = 2;
            this.DeleteSub.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteSub.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DeleteSub.OnIdleState.IconLeftImage = null;
            this.DeleteSub.OnIdleState.IconRightImage = null;
            this.DeleteSub.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteSub.OnPressedState.BorderRadius = 10;
            this.DeleteSub.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DeleteSub.OnPressedState.BorderThickness = 2;
            this.DeleteSub.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DeleteSub.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DeleteSub.OnPressedState.IconLeftImage = null;
            this.DeleteSub.OnPressedState.IconRightImage = null;
            this.DeleteSub.Size = new System.Drawing.Size(140, 30);
            this.DeleteSub.TabIndex = 127;
            this.DeleteSub.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DeleteSub.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DeleteSub.TextMarginLeft = 0;
            this.DeleteSub.TextPadding = new System.Windows.Forms.Padding(0);
            this.DeleteSub.UseDefaultRadiusAndThickness = true;
            this.DeleteSub.Click += new System.EventHandler(this.DeleteSub_Click);
            // 
            // SubDd
            // 
            this.SubDd.BackColor = System.Drawing.Color.Transparent;
            this.SubDd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SubDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SubDd.BorderRadius = 6;
            this.SubDd.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SubDd.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.SubDd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SubDd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SubDd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.SubDd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.SubDd.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.SubDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.SubDd.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.SubDd.DropDownHeight = 300;
            this.SubDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SubDd.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SubDd.FillDropDown = true;
            this.SubDd.FillIndicator = false;
            this.SubDd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SubDd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SubDd.ForeColor = System.Drawing.Color.White;
            this.SubDd.FormattingEnabled = true;
            this.SubDd.Icon = null;
            this.SubDd.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SubDd.IndicatorColor = System.Drawing.Color.White;
            this.SubDd.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.SubDd.IndicatorThickness = 2;
            this.SubDd.IntegralHeight = false;
            this.SubDd.IsDropdownOpened = false;
            this.SubDd.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SubDd.ItemBorderColor = System.Drawing.Color.White;
            this.SubDd.ItemForeColor = System.Drawing.Color.White;
            this.SubDd.ItemHeight = 24;
            this.SubDd.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.SubDd.ItemHighLightForeColor = System.Drawing.Color.White;
            this.SubDd.ItemTopMargin = 3;
            this.SubDd.Location = new System.Drawing.Point(8, 119);
            this.SubDd.Name = "SubDd";
            this.SubDd.Size = new System.Drawing.Size(615, 30);
            this.SubDd.TabIndex = 125;
            this.SubDd.Text = "User sub";
            this.SubDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.SubDd.TextLeftMargin = 5;
            // 
            // bunifuLabel8
            // 
            this.bunifuLabel8.AllowParentOverrides = false;
            this.bunifuLabel8.AutoEllipsis = false;
            this.bunifuLabel8.AutoSize = false;
            this.bunifuLabel8.CursorType = null;
            this.bunifuLabel8.EllipsisFormat = Bunifu.UI.WinForms.Ellipsis.EllipsisFormat.Word;
            this.bunifuLabel8.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.bunifuLabel8.Location = new System.Drawing.Point(8, 13);
            this.bunifuLabel8.Name = "bunifuLabel8";
            this.bunifuLabel8.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel8.Size = new System.Drawing.Size(615, 99);
            this.bunifuLabel8.TabIndex = 107;
            this.bunifuLabel8.Text = "test-XXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXXX \r\nInfo";
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
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.BackBtn.CustomizableEdges = borderEdges3;
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
            this.BackBtn.Location = new System.Drawing.Point(103, 301);
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
            // UserInfoView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.App1Card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserInfoView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "UserInfoView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.UserInfoView_Load);
            this.App1Card.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel App1Card;
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private Bunifu.UI.WinForms.BunifuDropdown SubDd;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BackBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteSub;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DeleteVar;
        private Bunifu.UI.WinForms.BunifuDropdown VarDd;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel IpLb;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel4;
        private Bunifu.UI.WinForms.BunifuLabel HwidLb;
    }
}