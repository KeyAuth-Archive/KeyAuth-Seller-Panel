namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    partial class AddNewAppView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddNewAppView));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties5 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties6 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties7 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties8 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties9 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties10 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties11 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties12 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.App1Card = new Bunifu.UI.WinForms.BunifuPanel();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.SellerKey = new Bunifu.UI.WinForms.BunifuTextBox();
            this.AppName = new Bunifu.UI.WinForms.BunifuTextBox();
            this.App1RemoveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AppPicURL = new Bunifu.UI.WinForms.BunifuTextBox();
            this.App1LoadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AppURL = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuSnackbar1 = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.App1Card.SuspendLayout();
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppURL)).BeginInit();
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
            this.App1Card.Location = new System.Drawing.Point(315, 77);
            this.App1Card.Name = "App1Card";
            this.App1Card.Padding = new System.Windows.Forms.Padding(5);
            this.App1Card.ShowBorders = true;
            this.App1Card.Size = new System.Drawing.Size(360, 262);
            this.App1Card.TabIndex = 34;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.bunifuLabel8);
            this.Card.Controls.Add(this.SellerKey);
            this.Card.Controls.Add(this.AppName);
            this.Card.Controls.Add(this.App1RemoveButton);
            this.Card.Controls.Add(this.AppPicURL);
            this.Card.Controls.Add(this.App1LoadButton);
            this.Card.Controls.Add(this.AppURL);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Card.LabelIndent = 10;
            this.Card.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.Card.Size = new System.Drawing.Size(350, 252);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            this.Card.Enter += new System.EventHandler(this.Card_Enter);
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
            this.bunifuLabel8.Size = new System.Drawing.Size(285, 52);
            this.bunifuLabel8.TabIndex = 107;
            this.bunifuLabel8.Text = "Fill in the details below";
            this.bunifuLabel8.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuLabel8.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // SellerKey
            // 
            this.SellerKey.AcceptsReturn = false;
            this.SellerKey.AcceptsTab = false;
            this.SellerKey.AnimationSpeed = 200;
            this.SellerKey.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.SellerKey.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.SellerKey.AutoSizeHeight = true;
            this.SellerKey.BackColor = System.Drawing.Color.Transparent;
            this.SellerKey.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SellerKey.BackgroundImage")));
            this.SellerKey.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SellerKey.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SellerKey.BorderColorHover = System.Drawing.SystemColors.ButtonFace;
            this.SellerKey.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SellerKey.BorderRadius = 10;
            this.SellerKey.BorderThickness = 1;
            this.SellerKey.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.SellerKey.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerKey.DefaultFont = new System.Drawing.Font("Segoe UI", 9F);
            this.SellerKey.DefaultText = "";
            this.SellerKey.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.SellerKey.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SellerKey.HideSelection = true;
            this.SellerKey.IconLeft = null;
            this.SellerKey.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerKey.IconPadding = 10;
            this.SellerKey.IconRight = null;
            this.SellerKey.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.SellerKey.Lines = new string[0];
            this.SellerKey.Location = new System.Drawing.Point(31, 173);
            this.SellerKey.MaximumSize = new System.Drawing.Size(285, 30);
            this.SellerKey.MaxLength = 32767;
            this.SellerKey.MinimumSize = new System.Drawing.Size(1, 1);
            this.SellerKey.Modified = false;
            this.SellerKey.Multiline = false;
            this.SellerKey.Name = "SellerKey";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SellerKey.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.SellerKey.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SellerKey.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.SellerKey.OnIdleState = stateProperties4;
            this.SellerKey.Padding = new System.Windows.Forms.Padding(3);
            this.SellerKey.PasswordChar = '\0';
            this.SellerKey.PlaceholderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.SellerKey.PlaceholderText = "Enter your sellerkey";
            this.SellerKey.ReadOnly = false;
            this.SellerKey.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.SellerKey.SelectedText = "";
            this.SellerKey.SelectionLength = 0;
            this.SellerKey.SelectionStart = 0;
            this.SellerKey.ShortcutsEnabled = true;
            this.SellerKey.Size = new System.Drawing.Size(285, 30);
            this.SellerKey.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.SellerKey.TabIndex = 14;
            this.SellerKey.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.SellerKey.TextMarginBottom = 0;
            this.SellerKey.TextMarginLeft = 3;
            this.SellerKey.TextMarginTop = 1;
            this.SellerKey.TextPlaceholder = "Enter your sellerkey";
            this.SellerKey.UseSystemPasswordChar = false;
            this.SellerKey.WordWrap = true;
            this.SellerKey.TextChanged += new System.EventHandler(this.SellerKey_TextChanged);
            // 
            // AppName
            // 
            this.AppName.AcceptsReturn = false;
            this.AppName.AcceptsTab = false;
            this.AppName.AnimationSpeed = 200;
            this.AppName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AppName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AppName.AutoSizeHeight = true;
            this.AppName.BackColor = System.Drawing.Color.Transparent;
            this.AppName.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppName.BackgroundImage")));
            this.AppName.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.AppName.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AppName.BorderColorHover = System.Drawing.SystemColors.ButtonFace;
            this.AppName.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AppName.BorderRadius = 10;
            this.AppName.BorderThickness = 1;
            this.AppName.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AppName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppName.DefaultFont = new System.Drawing.Font("Segoe UI", 9F);
            this.AppName.DefaultText = "";
            this.AppName.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.AppName.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppName.HideSelection = true;
            this.AppName.IconLeft = null;
            this.AppName.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.AppName.IconPadding = 10;
            this.AppName.IconRight = null;
            this.AppName.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.AppName.Lines = new string[0];
            this.AppName.Location = new System.Drawing.Point(32, 137);
            this.AppName.MaximumSize = new System.Drawing.Size(285, 30);
            this.AppName.MaxLength = 32767;
            this.AppName.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppName.Modified = false;
            this.AppName.Multiline = false;
            this.AppName.Name = "AppName";
            stateProperties5.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties5.FillColor = System.Drawing.Color.Empty;
            stateProperties5.ForeColor = System.Drawing.Color.Empty;
            stateProperties5.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AppName.OnActiveState = stateProperties5;
            stateProperties6.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties6.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties6.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.AppName.OnDisabledState = stateProperties6;
            stateProperties7.BorderColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties7.FillColor = System.Drawing.Color.Empty;
            stateProperties7.ForeColor = System.Drawing.Color.Empty;
            stateProperties7.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AppName.OnHoverState = stateProperties7;
            stateProperties8.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            stateProperties8.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties8.ForeColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties8.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AppName.OnIdleState = stateProperties8;
            this.AppName.Padding = new System.Windows.Forms.Padding(3);
            this.AppName.PasswordChar = '\0';
            this.AppName.PlaceholderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppName.PlaceholderText = "Enter your application name";
            this.AppName.ReadOnly = false;
            this.AppName.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AppName.SelectedText = "";
            this.AppName.SelectionLength = 0;
            this.AppName.SelectionStart = 0;
            this.AppName.ShortcutsEnabled = true;
            this.AppName.Size = new System.Drawing.Size(285, 30);
            this.AppName.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.AppName.TabIndex = 13;
            this.AppName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppName.TextMarginBottom = 0;
            this.AppName.TextMarginLeft = 3;
            this.AppName.TextMarginTop = 1;
            this.AppName.TextPlaceholder = "Enter your application name";
            this.AppName.UseSystemPasswordChar = false;
            this.AppName.WordWrap = true;
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
            this.App1RemoveButton.Location = new System.Drawing.Point(32, 209);
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
            // AppPicURL
            // 
            this.AppPicURL.AcceptsReturn = false;
            this.AppPicURL.AcceptsTab = false;
            this.AppPicURL.AnimationSpeed = 200;
            this.AppPicURL.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.AppPicURL.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.AppPicURL.AutoSizeHeight = true;
            this.AppPicURL.BackColor = System.Drawing.Color.Transparent;
            this.AppPicURL.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AppPicURL.BackgroundImage")));
            this.AppPicURL.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.AppPicURL.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AppPicURL.BorderColorHover = System.Drawing.SystemColors.ButtonFace;
            this.AppPicURL.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AppPicURL.BorderRadius = 10;
            this.AppPicURL.BorderThickness = 1;
            this.AppPicURL.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.AppPicURL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.AppPicURL.DefaultFont = new System.Drawing.Font("Segoe UI", 9F);
            this.AppPicURL.DefaultText = "";
            this.AppPicURL.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.AppPicURL.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppPicURL.HideSelection = true;
            this.AppPicURL.IconLeft = null;
            this.AppPicURL.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.AppPicURL.IconPadding = 10;
            this.AppPicURL.IconRight = null;
            this.AppPicURL.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.AppPicURL.Lines = new string[0];
            this.AppPicURL.Location = new System.Drawing.Point(32, 101);
            this.AppPicURL.MaximumSize = new System.Drawing.Size(285, 30);
            this.AppPicURL.MaxLength = 32767;
            this.AppPicURL.MinimumSize = new System.Drawing.Size(1, 1);
            this.AppPicURL.Modified = false;
            this.AppPicURL.Multiline = false;
            this.AppPicURL.Name = "AppPicURL";
            stateProperties9.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties9.FillColor = System.Drawing.Color.Empty;
            stateProperties9.ForeColor = System.Drawing.Color.Empty;
            stateProperties9.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AppPicURL.OnActiveState = stateProperties9;
            stateProperties10.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties10.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties10.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.AppPicURL.OnDisabledState = stateProperties10;
            stateProperties11.BorderColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties11.FillColor = System.Drawing.Color.Empty;
            stateProperties11.ForeColor = System.Drawing.Color.Empty;
            stateProperties11.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AppPicURL.OnHoverState = stateProperties11;
            stateProperties12.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            stateProperties12.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties12.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.AppPicURL.OnIdleState = stateProperties12;
            this.AppPicURL.Padding = new System.Windows.Forms.Padding(3);
            this.AppPicURL.PasswordChar = '\0';
            this.AppPicURL.PlaceholderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.AppPicURL.PlaceholderText = "Set a banner for your app (URL format)";
            this.AppPicURL.ReadOnly = false;
            this.AppPicURL.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.AppPicURL.SelectedText = "";
            this.AppPicURL.SelectionLength = 0;
            this.AppPicURL.SelectionStart = 0;
            this.AppPicURL.ShortcutsEnabled = true;
            this.AppPicURL.Size = new System.Drawing.Size(285, 30);
            this.AppPicURL.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.AppPicURL.TabIndex = 16;
            this.AppPicURL.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.AppPicURL.TextMarginBottom = 0;
            this.AppPicURL.TextMarginLeft = 3;
            this.AppPicURL.TextMarginTop = 1;
            this.AppPicURL.TextPlaceholder = "Set a banner for your app (URL format)";
            this.AppPicURL.UseSystemPasswordChar = false;
            this.AppPicURL.WordWrap = true;
            this.AppPicURL.TextChange += new System.EventHandler(this.AppPicURL_TextChanged);
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
            this.App1LoadButton.ButtonText = "Add";
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
            this.App1LoadButton.Location = new System.Drawing.Point(178, 209);
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
            // AppURL
            // 
            this.AppURL.AllowFocused = false;
            this.AppURL.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.AppURL.AutoSizeHeight = false;
            this.AppURL.BorderRadius = 10;
            this.AppURL.Image = global::KeyAuth_Seller_Panel.Properties.Resources.Banner;
            this.AppURL.IsCircle = false;
            this.AppURL.Location = new System.Drawing.Point(31, 55);
            this.AppURL.Name = "AppURL";
            this.AppURL.Size = new System.Drawing.Size(285, 40);
            this.AppURL.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppURL.TabIndex = 32;
            this.AppURL.TabStop = false;
            this.AppURL.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
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
            // AddNewAppView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.App1Card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "AddNewAppView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AddNewAppView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.AddNewAppView_Load);
            this.App1Card.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppURL)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel App1Card;
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private Bunifu.UI.WinForms.BunifuPictureBox AppURL;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton App1RemoveButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton App1LoadButton;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuSnackbar bunifuSnackbar1;
        private Bunifu.UI.WinForms.BunifuTextBox SellerKey;
        private Bunifu.UI.WinForms.BunifuTextBox AppName;
        private Bunifu.UI.WinForms.BunifuTextBox AppPicURL;
    }
}