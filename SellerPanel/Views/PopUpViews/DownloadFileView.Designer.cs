namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    partial class DownloadFileView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DownloadFileView));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.App1Card = new Bunifu.UI.WinForms.BunifuPanel();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.IdListDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.HwidLockEnabled = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.HwidLockEnabledLb = new System.Windows.Forms.Label();
            this.AppEnabled = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.AppEnabledLb = new System.Windows.Forms.Label();
            this.label26 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.App1RemoveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.App1LoadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
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
            this.App1Card.Size = new System.Drawing.Size(360, 231);
            this.App1Card.TabIndex = 35;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.IdListDd);
            this.Card.Controls.Add(this.HwidLockEnabled);
            this.Card.Controls.Add(this.HwidLockEnabledLb);
            this.Card.Controls.Add(this.AppEnabled);
            this.Card.Controls.Add(this.AppEnabledLb);
            this.Card.Controls.Add(this.label26);
            this.Card.Controls.Add(this.label32);
            this.Card.Controls.Add(this.bunifuLabel8);
            this.Card.Controls.Add(this.App1RemoveButton);
            this.Card.Controls.Add(this.App1LoadButton);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Card.LabelIndent = 10;
            this.Card.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.Card.Size = new System.Drawing.Size(350, 221);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            // 
            // IdListDd
            // 
            this.IdListDd.BackColor = System.Drawing.Color.Transparent;
            this.IdListDd.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.IdListDd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.IdListDd.BorderRadius = 6;
            this.IdListDd.Color = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.IdListDd.Direction = Bunifu.UI.WinForms.BunifuDropdown.Directions.Down;
            this.IdListDd.DisabledBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.IdListDd.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.IdListDd.DisabledColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.IdListDd.DisabledForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            this.IdListDd.DisabledIndicatorColor = System.Drawing.Color.DarkGray;
            this.IdListDd.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.IdListDd.DropdownBorderThickness = Bunifu.UI.WinForms.BunifuDropdown.BorderThickness.Thin;
            this.IdListDd.DropDownHeight = 300;
            this.IdListDd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.IdListDd.DropDownTextAlign = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IdListDd.FillDropDown = true;
            this.IdListDd.FillIndicator = false;
            this.IdListDd.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.IdListDd.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.IdListDd.ForeColor = System.Drawing.Color.White;
            this.IdListDd.FormattingEnabled = true;
            this.IdListDd.Icon = null;
            this.IdListDd.IndicatorAlignment = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.IdListDd.IndicatorColor = System.Drawing.Color.White;
            this.IdListDd.IndicatorLocation = Bunifu.UI.WinForms.BunifuDropdown.Indicator.Right;
            this.IdListDd.IndicatorThickness = 2;
            this.IdListDd.IntegralHeight = false;
            this.IdListDd.IsDropdownOpened = false;
            this.IdListDd.ItemBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.IdListDd.ItemBorderColor = System.Drawing.Color.White;
            this.IdListDd.ItemForeColor = System.Drawing.Color.White;
            this.IdListDd.ItemHeight = 24;
            this.IdListDd.ItemHighLightColor = System.Drawing.Color.DodgerBlue;
            this.IdListDd.ItemHighLightForeColor = System.Drawing.Color.White;
            this.IdListDd.ItemTopMargin = 3;
            this.IdListDd.Location = new System.Drawing.Point(107, 79);
            this.IdListDd.Name = "IdListDd";
            this.IdListDd.Size = new System.Drawing.Size(149, 30);
            this.IdListDd.TabIndex = 119;
            this.IdListDd.Text = null;
            this.IdListDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IdListDd.TextLeftMargin = 5;
            // 
            // HwidLockEnabled
            // 
            this.HwidLockEnabled.BackColor = System.Drawing.Color.Transparent;
            this.HwidLockEnabled.Checked = false;
            this.HwidLockEnabled.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.HwidLockEnabled.CheckedSwitchColor = System.Drawing.Color.White;
            this.HwidLockEnabled.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.HwidLockEnabled.Location = new System.Drawing.Point(154, 149);
            this.HwidLockEnabled.Name = "HwidLockEnabled";
            this.HwidLockEnabled.OutlineThickness = 2;
            this.HwidLockEnabled.Size = new System.Drawing.Size(46, 19);
            this.HwidLockEnabled.TabIndex = 117;
            this.HwidLockEnabled.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.HwidLockEnabled.UncheckedSwitchColor = System.Drawing.Color.White;
            this.HwidLockEnabled.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.HwidLockEnabled.CheckedChanged += new System.EventHandler(this.HwidLockEnabled_CheckedChanged);
            // 
            // HwidLockEnabledLb
            // 
            this.HwidLockEnabledLb.AutoSize = true;
            this.HwidLockEnabledLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.HwidLockEnabledLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.HwidLockEnabledLb.ForeColor = System.Drawing.SystemColors.Control;
            this.HwidLockEnabledLb.Location = new System.Drawing.Point(206, 153);
            this.HwidLockEnabledLb.Name = "HwidLockEnabledLb";
            this.HwidLockEnabledLb.Size = new System.Drawing.Size(36, 15);
            this.HwidLockEnabledLb.TabIndex = 116;
            this.HwidLockEnabledLb.Text = "NULL";
            this.HwidLockEnabledLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppEnabled
            // 
            this.AppEnabled.BackColor = System.Drawing.Color.Transparent;
            this.AppEnabled.Checked = false;
            this.AppEnabled.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.AppEnabled.CheckedSwitchColor = System.Drawing.Color.White;
            this.AppEnabled.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.AppEnabled.Location = new System.Drawing.Point(154, 124);
            this.AppEnabled.Name = "AppEnabled";
            this.AppEnabled.OutlineThickness = 2;
            this.AppEnabled.Size = new System.Drawing.Size(46, 19);
            this.AppEnabled.TabIndex = 115;
            this.AppEnabled.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.AppEnabled.UncheckedSwitchColor = System.Drawing.Color.White;
            this.AppEnabled.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.AppEnabled.CheckedChanged += new System.EventHandler(this.AppEnabled_CheckedChanged);
            // 
            // AppEnabledLb
            // 
            this.AppEnabledLb.AutoSize = true;
            this.AppEnabledLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.AppEnabledLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AppEnabledLb.ForeColor = System.Drawing.SystemColors.Control;
            this.AppEnabledLb.Location = new System.Drawing.Point(206, 128);
            this.AppEnabledLb.Name = "AppEnabledLb";
            this.AppEnabledLb.Size = new System.Drawing.Size(36, 15);
            this.AppEnabledLb.TabIndex = 114;
            this.AppEnabledLb.Text = "NULL";
            this.AppEnabledLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label26.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label26.ForeColor = System.Drawing.SystemColors.Control;
            this.label26.Location = new System.Drawing.Point(76, 153);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(66, 15);
            this.label26.TabIndex = 113;
            this.label26.Text = "OverWrite :";
            this.label26.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label32.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.label32.ForeColor = System.Drawing.SystemColors.Control;
            this.label32.Location = new System.Drawing.Point(104, 128);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(34, 15);
            this.label32.TabIndex = 112;
            this.label32.Text = "Run :";
            this.label32.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.bunifuLabel8.Text = "File Download";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // App1RemoveButton
            // 
            this.App1RemoveButton.AllowAnimations = true;
            this.App1RemoveButton.AllowMouseEffects = true;
            this.App1RemoveButton.AllowToggling = false;
            this.App1RemoveButton.AnimationSpeed = 200;
            this.App1RemoveButton.AutoGenerateColors = false;
            this.App1RemoveButton.AutoRoundBorders = false;
            this.App1RemoveButton.AutoSizeLeftIcon = true;
            this.App1RemoveButton.AutoSizeRightIcon = true;
            this.App1RemoveButton.BackColor = System.Drawing.Color.Transparent;
            this.App1RemoveButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.App1RemoveButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("App1RemoveButton.BackgroundImage")));
            this.App1RemoveButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1RemoveButton.ButtonText = "Back";
            this.App1RemoveButton.ButtonTextMarginLeft = 0;
            this.App1RemoveButton.ColorContrastOnClick = 45;
            this.App1RemoveButton.ColorContrastOnHover = 45;
            this.App1RemoveButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.App1RemoveButton.CustomizableEdges = borderEdges1;
            this.App1RemoveButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.App1RemoveButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.App1RemoveButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.App1RemoveButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.App1RemoveButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.App1RemoveButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.App1RemoveButton.ForeColor = System.Drawing.Color.White;
            this.App1RemoveButton.IconLeft = null;
            this.App1RemoveButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.App1RemoveButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.App1RemoveButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.App1RemoveButton.IconMarginLeft = 11;
            this.App1RemoveButton.IconPadding = 10;
            this.App1RemoveButton.IconRight = null;
            this.App1RemoveButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.App1RemoveButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.App1RemoveButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.App1RemoveButton.IconSize = 25;
            this.App1RemoveButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.App1RemoveButton.IdleBorderRadius = 0;
            this.App1RemoveButton.IdleBorderThickness = 0;
            this.App1RemoveButton.IdleFillColor = System.Drawing.Color.Empty;
            this.App1RemoveButton.IdleIconLeftImage = null;
            this.App1RemoveButton.IdleIconRightImage = null;
            this.App1RemoveButton.IndicateFocus = false;
            this.App1RemoveButton.Location = new System.Drawing.Point(31, 174);
            this.App1RemoveButton.Name = "App1RemoveButton";
            this.App1RemoveButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.App1RemoveButton.OnDisabledState.BorderRadius = 10;
            this.App1RemoveButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1RemoveButton.OnDisabledState.BorderThickness = 2;
            this.App1RemoveButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.App1RemoveButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.App1RemoveButton.OnDisabledState.IconLeftImage = null;
            this.App1RemoveButton.OnDisabledState.IconRightImage = null;
            this.App1RemoveButton.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.App1RemoveButton.onHoverState.BorderRadius = 10;
            this.App1RemoveButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1RemoveButton.onHoverState.BorderThickness = 2;
            this.App1RemoveButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1RemoveButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.App1RemoveButton.onHoverState.IconLeftImage = null;
            this.App1RemoveButton.onHoverState.IconRightImage = null;
            this.App1RemoveButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1RemoveButton.OnIdleState.BorderRadius = 10;
            this.App1RemoveButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1RemoveButton.OnIdleState.BorderThickness = 2;
            this.App1RemoveButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1RemoveButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.App1RemoveButton.OnIdleState.IconLeftImage = null;
            this.App1RemoveButton.OnIdleState.IconRightImage = null;
            this.App1RemoveButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1RemoveButton.OnPressedState.BorderRadius = 10;
            this.App1RemoveButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1RemoveButton.OnPressedState.BorderThickness = 2;
            this.App1RemoveButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1RemoveButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.App1RemoveButton.OnPressedState.IconLeftImage = null;
            this.App1RemoveButton.OnPressedState.IconRightImage = null;
            this.App1RemoveButton.Size = new System.Drawing.Size(140, 30);
            this.App1RemoveButton.TabIndex = 34;
            this.App1RemoveButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.App1RemoveButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.App1RemoveButton.TextMarginLeft = 0;
            this.App1RemoveButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.App1RemoveButton.UseDefaultRadiusAndThickness = true;
            // 
            // App1LoadButton
            // 
            this.App1LoadButton.AllowAnimations = true;
            this.App1LoadButton.AllowMouseEffects = true;
            this.App1LoadButton.AllowToggling = false;
            this.App1LoadButton.AnimationSpeed = 200;
            this.App1LoadButton.AutoGenerateColors = false;
            this.App1LoadButton.AutoRoundBorders = false;
            this.App1LoadButton.AutoSizeLeftIcon = true;
            this.App1LoadButton.AutoSizeRightIcon = true;
            this.App1LoadButton.BackColor = System.Drawing.Color.Transparent;
            this.App1LoadButton.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.App1LoadButton.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("App1LoadButton.BackgroundImage")));
            this.App1LoadButton.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1LoadButton.ButtonText = "Download";
            this.App1LoadButton.ButtonTextMarginLeft = 0;
            this.App1LoadButton.ColorContrastOnClick = 45;
            this.App1LoadButton.ColorContrastOnHover = 45;
            this.App1LoadButton.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.App1LoadButton.CustomizableEdges = borderEdges2;
            this.App1LoadButton.DialogResult = System.Windows.Forms.DialogResult.None;
            this.App1LoadButton.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.App1LoadButton.DisabledFillColor = System.Drawing.Color.Empty;
            this.App1LoadButton.DisabledForecolor = System.Drawing.Color.Empty;
            this.App1LoadButton.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.App1LoadButton.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.App1LoadButton.ForeColor = System.Drawing.Color.White;
            this.App1LoadButton.IconLeft = null;
            this.App1LoadButton.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.App1LoadButton.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.App1LoadButton.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.App1LoadButton.IconMarginLeft = 11;
            this.App1LoadButton.IconPadding = 10;
            this.App1LoadButton.IconRight = null;
            this.App1LoadButton.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.App1LoadButton.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.App1LoadButton.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.App1LoadButton.IconSize = 25;
            this.App1LoadButton.IdleBorderColor = System.Drawing.Color.Empty;
            this.App1LoadButton.IdleBorderRadius = 0;
            this.App1LoadButton.IdleBorderThickness = 0;
            this.App1LoadButton.IdleFillColor = System.Drawing.Color.Empty;
            this.App1LoadButton.IdleIconLeftImage = null;
            this.App1LoadButton.IdleIconRightImage = null;
            this.App1LoadButton.IndicateFocus = false;
            this.App1LoadButton.Location = new System.Drawing.Point(177, 174);
            this.App1LoadButton.Name = "App1LoadButton";
            this.App1LoadButton.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.App1LoadButton.OnDisabledState.BorderRadius = 10;
            this.App1LoadButton.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1LoadButton.OnDisabledState.BorderThickness = 2;
            this.App1LoadButton.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.App1LoadButton.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.App1LoadButton.OnDisabledState.IconLeftImage = null;
            this.App1LoadButton.OnDisabledState.IconRightImage = null;
            this.App1LoadButton.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.App1LoadButton.onHoverState.BorderRadius = 10;
            this.App1LoadButton.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1LoadButton.onHoverState.BorderThickness = 2;
            this.App1LoadButton.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1LoadButton.onHoverState.ForeColor = System.Drawing.Color.White;
            this.App1LoadButton.onHoverState.IconLeftImage = null;
            this.App1LoadButton.onHoverState.IconRightImage = null;
            this.App1LoadButton.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1LoadButton.OnIdleState.BorderRadius = 10;
            this.App1LoadButton.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1LoadButton.OnIdleState.BorderThickness = 2;
            this.App1LoadButton.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1LoadButton.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.App1LoadButton.OnIdleState.IconLeftImage = null;
            this.App1LoadButton.OnIdleState.IconRightImage = null;
            this.App1LoadButton.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1LoadButton.OnPressedState.BorderRadius = 10;
            this.App1LoadButton.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.App1LoadButton.OnPressedState.BorderThickness = 2;
            this.App1LoadButton.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.App1LoadButton.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.App1LoadButton.OnPressedState.IconLeftImage = null;
            this.App1LoadButton.OnPressedState.IconRightImage = null;
            this.App1LoadButton.Size = new System.Drawing.Size(140, 30);
            this.App1LoadButton.TabIndex = 30;
            this.App1LoadButton.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.App1LoadButton.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.App1LoadButton.TextMarginLeft = 0;
            this.App1LoadButton.TextPadding = new System.Windows.Forms.Padding(0);
            this.App1LoadButton.UseDefaultRadiusAndThickness = true;
            this.App1LoadButton.Click += new System.EventHandler(this.App1LoadButton_Click);
            // 
            // bunifuSnackbar1
            // 
            this.bunifuSnackbar1.AllowDragging = false;
            this.bunifuSnackbar1.AllowMultipleViews = true;
            this.bunifuSnackbar1.ClickToClose = true;
            this.bunifuSnackbar1.DoubleClickToClose = true;
            this.bunifuSnackbar1.DurationAfterIdle = 3000;
            this.bunifuSnackbar1.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.ErrorOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.bunifuSnackbar1.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.bunifuSnackbar1.ErrorOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.FadeCloseIcon = false;
            this.bunifuSnackbar1.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.bunifuSnackbar1.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.bunifuSnackbar1.InformationOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.Margin = 10;
            this.bunifuSnackbar1.MaximumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.MaximumViews = 7;
            this.bunifuSnackbar1.MessageRightMargin = 15;
            this.bunifuSnackbar1.MinimumSize = new System.Drawing.Size(0, 0);
            this.bunifuSnackbar1.ShowBorders = false;
            this.bunifuSnackbar1.ShowCloseIcon = false;
            this.bunifuSnackbar1.ShowIcon = true;
            this.bunifuSnackbar1.ShowShadows = true;
            this.bunifuSnackbar1.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.SuccessOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.bunifuSnackbar1.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.bunifuSnackbar1.SuccessOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ViewsMargin = 7;
            this.bunifuSnackbar1.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.bunifuSnackbar1.WarningOptions.ActionBorderRadius = 1;
            this.bunifuSnackbar1.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.bunifuSnackbar1.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.BackColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.bunifuSnackbar1.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.bunifuSnackbar1.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.bunifuSnackbar1.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.bunifuSnackbar1.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.bunifuSnackbar1.WarningOptions.IconLeftMargin = 12;
            this.bunifuSnackbar1.ZoomCloseIcon = true;
            // 
            // DownloadFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.App1Card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownloadFileView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DownloadFileView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.DownloadFileView_Load);
            this.App1Card.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel App1Card;
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton App1RemoveButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton App1LoadButton;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 HwidLockEnabled;
        private System.Windows.Forms.Label HwidLockEnabledLb;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 AppEnabled;
        private System.Windows.Forms.Label AppEnabledLb;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label32;
        private Bunifu.UI.WinForms.BunifuDropdown IdListDd;
    }
}