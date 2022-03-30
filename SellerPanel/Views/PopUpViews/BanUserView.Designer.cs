namespace KeyAuth_Seller_Panel.SellerPanel.Views.PopUpViews
{
    partial class BanUserView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BanUserView));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.App1Card = new Bunifu.UI.WinForms.BunifuPanel();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.BanReasonTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.userLb = new Bunifu.UI.WinForms.BunifuLabel();
            this.BackBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.BanBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.App1Card.Location = new System.Drawing.Point(234, 134);
            this.App1Card.Name = "App1Card";
            this.App1Card.Padding = new System.Windows.Forms.Padding(5);
            this.App1Card.ShowBorders = true;
            this.App1Card.Size = new System.Drawing.Size(554, 147);
            this.App1Card.TabIndex = 37;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.BanReasonTb);
            this.Card.Controls.Add(this.userLb);
            this.Card.Controls.Add(this.BackBtn);
            this.Card.Controls.Add(this.BanBtn);
            this.Card.Cursor = System.Windows.Forms.Cursors.Default;
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Card.LabelIndent = 1;
            this.Card.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5, 0, 5, 5);
            this.Card.Size = new System.Drawing.Size(544, 137);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            // 
            // BanReasonTb
            // 
            this.BanReasonTb.AcceptsReturn = false;
            this.BanReasonTb.AcceptsTab = false;
            this.BanReasonTb.AnimationSpeed = 200;
            this.BanReasonTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.BanReasonTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.BanReasonTb.AutoSizeHeight = false;
            this.BanReasonTb.BackColor = System.Drawing.Color.Transparent;
            this.BanReasonTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BanReasonTb.BackgroundImage")));
            this.BanReasonTb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.BanReasonTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BanReasonTb.BorderColorHover = System.Drawing.SystemColors.ButtonFace;
            this.BanReasonTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BanReasonTb.BorderRadius = 10;
            this.BanReasonTb.BorderThickness = 1;
            this.BanReasonTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.BanReasonTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.BanReasonTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9F);
            this.BanReasonTb.DefaultText = "";
            this.BanReasonTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.BanReasonTb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BanReasonTb.HideSelection = true;
            this.BanReasonTb.IconLeft = null;
            this.BanReasonTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.BanReasonTb.IconPadding = 10;
            this.BanReasonTb.IconRight = null;
            this.BanReasonTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.BanReasonTb.Lines = new string[0];
            this.BanReasonTb.Location = new System.Drawing.Point(8, 61);
            this.BanReasonTb.MaxLength = 32767;
            this.BanReasonTb.MinimumSize = new System.Drawing.Size(0, 30);
            this.BanReasonTb.Modified = false;
            this.BanReasonTb.Multiline = false;
            this.BanReasonTb.Name = "BanReasonTb";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BanReasonTb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.BanReasonTb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BanReasonTb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.BanReasonTb.OnIdleState = stateProperties4;
            this.BanReasonTb.Padding = new System.Windows.Forms.Padding(3);
            this.BanReasonTb.PasswordChar = '\0';
            this.BanReasonTb.PlaceholderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.BanReasonTb.PlaceholderText = "Reason for user ban (can leave blank)";
            this.BanReasonTb.ReadOnly = false;
            this.BanReasonTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.BanReasonTb.SelectedText = "";
            this.BanReasonTb.SelectionLength = 0;
            this.BanReasonTb.SelectionStart = 0;
            this.BanReasonTb.ShortcutsEnabled = true;
            this.BanReasonTb.Size = new System.Drawing.Size(528, 30);
            this.BanReasonTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.BanReasonTb.TabIndex = 122;
            this.BanReasonTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BanReasonTb.TextMarginBottom = 0;
            this.BanReasonTb.TextMarginLeft = 3;
            this.BanReasonTb.TextMarginTop = 1;
            this.BanReasonTb.TextPlaceholder = "Reason for user ban (can leave blank)";
            this.BanReasonTb.UseSystemPasswordChar = false;
            this.BanReasonTb.WordWrap = true;
            // 
            // userLb
            // 
            this.userLb.AllowParentOverrides = false;
            this.userLb.AutoEllipsis = false;
            this.userLb.AutoSize = false;
            this.userLb.CursorType = null;
            this.userLb.Dock = System.Windows.Forms.DockStyle.Top;
            this.userLb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.userLb.Location = new System.Drawing.Point(5, 22);
            this.userLb.Name = "userLb";
            this.userLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.userLb.Size = new System.Drawing.Size(534, 33);
            this.userLb.TabIndex = 107;
            this.userLb.Text = "Ban user :";
            this.userLb.TextAlignment = System.Drawing.ContentAlignment.MiddleCenter;
            this.userLb.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.BackBtn.Cursor = System.Windows.Forms.Cursors.Hand;
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
            this.BackBtn.Location = new System.Drawing.Point(8, 97);
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
            // BanBtn
            // 
            this.BanBtn.AllowAnimations = true;
            this.BanBtn.AllowMouseEffects = true;
            this.BanBtn.AllowToggling = false;
            this.BanBtn.AnimationSpeed = 200;
            this.BanBtn.AutoGenerateColors = false;
            this.BanBtn.AutoRoundBorders = false;
            this.BanBtn.AutoSizeLeftIcon = true;
            this.BanBtn.AutoSizeRightIcon = true;
            this.BanBtn.BackColor = System.Drawing.Color.Transparent;
            this.BanBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.BanBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BanBtn.BackgroundImage")));
            this.BanBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BanBtn.ButtonText = "Ban";
            this.BanBtn.ButtonTextMarginLeft = 0;
            this.BanBtn.ColorContrastOnClick = 45;
            this.BanBtn.ColorContrastOnHover = 45;
            this.BanBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.BanBtn.CustomizableEdges = borderEdges2;
            this.BanBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.BanBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BanBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.BanBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.BanBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.BanBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BanBtn.ForeColor = System.Drawing.Color.White;
            this.BanBtn.IconLeft = null;
            this.BanBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BanBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.BanBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.BanBtn.IconMarginLeft = 11;
            this.BanBtn.IconPadding = 10;
            this.BanBtn.IconRight = null;
            this.BanBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.BanBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.BanBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.BanBtn.IconSize = 25;
            this.BanBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.BanBtn.IdleBorderRadius = 0;
            this.BanBtn.IdleBorderThickness = 0;
            this.BanBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.BanBtn.IdleIconLeftImage = null;
            this.BanBtn.IdleIconRightImage = null;
            this.BanBtn.IndicateFocus = false;
            this.BanBtn.Location = new System.Drawing.Point(396, 97);
            this.BanBtn.Name = "BanBtn";
            this.BanBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.BanBtn.OnDisabledState.BorderRadius = 10;
            this.BanBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BanBtn.OnDisabledState.BorderThickness = 2;
            this.BanBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.BanBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.BanBtn.OnDisabledState.IconLeftImage = null;
            this.BanBtn.OnDisabledState.IconRightImage = null;
            this.BanBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.BanBtn.onHoverState.BorderRadius = 10;
            this.BanBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BanBtn.onHoverState.BorderThickness = 2;
            this.BanBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BanBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.BanBtn.onHoverState.IconLeftImage = null;
            this.BanBtn.onHoverState.IconRightImage = null;
            this.BanBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BanBtn.OnIdleState.BorderRadius = 10;
            this.BanBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BanBtn.OnIdleState.BorderThickness = 2;
            this.BanBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BanBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.BanBtn.OnIdleState.IconLeftImage = null;
            this.BanBtn.OnIdleState.IconRightImage = null;
            this.BanBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BanBtn.OnPressedState.BorderRadius = 10;
            this.BanBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.BanBtn.OnPressedState.BorderThickness = 2;
            this.BanBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.BanBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.BanBtn.OnPressedState.IconLeftImage = null;
            this.BanBtn.OnPressedState.IconRightImage = null;
            this.BanBtn.Size = new System.Drawing.Size(140, 30);
            this.BanBtn.TabIndex = 30;
            this.BanBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BanBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.BanBtn.TextMarginLeft = 0;
            this.BanBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.BanBtn.UseDefaultRadiusAndThickness = true;
            this.BanBtn.Click += new System.EventHandler(this.BanBtn_Click);
            // 
            // BanUserView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.App1Card);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "BanUserView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "BanUserView";
            this.Load += new System.EventHandler(this.BanUserView_Load);
            this.App1Card.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel App1Card;
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private Bunifu.UI.WinForms.BunifuTextBox BanReasonTb;
        private Bunifu.UI.WinForms.BunifuLabel userLb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BackBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BanBtn;
    }
}