namespace KeyAuth_Seller_Panel.SellerPanel.Views
{
    partial class EditVarView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditVarView));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.bunifuElipse1 = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.App1Card = new Bunifu.UI.WinForms.BunifuPanel();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.VarDataTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.IdListDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.bunifuLabel8 = new Bunifu.UI.WinForms.BunifuLabel();
            this.App1RemoveButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.App1LoadButton = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
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
            this.App1Card.TabIndex = 35;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.VarDataTb);
            this.Card.Controls.Add(this.IdListDd);
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
            this.Card.Size = new System.Drawing.Size(350, 350);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            // 
            // VarDataTb
            // 
            this.VarDataTb.AcceptsReturn = false;
            this.VarDataTb.AcceptsTab = false;
            this.VarDataTb.AnimationSpeed = 200;
            this.VarDataTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.VarDataTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.VarDataTb.AutoSizeHeight = false;
            this.VarDataTb.BackColor = System.Drawing.Color.Transparent;
            this.VarDataTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("VarDataTb.BackgroundImage")));
            this.VarDataTb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.VarDataTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.VarDataTb.BorderColorHover = System.Drawing.SystemColors.ButtonFace;
            this.VarDataTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.VarDataTb.BorderRadius = 10;
            this.VarDataTb.BorderThickness = 1;
            this.VarDataTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.VarDataTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.VarDataTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9F);
            this.VarDataTb.DefaultText = "";
            this.VarDataTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.VarDataTb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VarDataTb.HideSelection = true;
            this.VarDataTb.IconLeft = null;
            this.VarDataTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.VarDataTb.IconPadding = 10;
            this.VarDataTb.IconRight = null;
            this.VarDataTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.VarDataTb.Lines = new string[0];
            this.VarDataTb.Location = new System.Drawing.Point(31, 242);
            this.VarDataTb.MaxLength = 32767;
            this.VarDataTb.MinimumSize = new System.Drawing.Size(0, 30);
            this.VarDataTb.Modified = false;
            this.VarDataTb.Multiline = false;
            this.VarDataTb.Name = "VarDataTb";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.VarDataTb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.VarDataTb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.VarDataTb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.VarDataTb.OnIdleState = stateProperties4;
            this.VarDataTb.Padding = new System.Windows.Forms.Padding(3);
            this.VarDataTb.PasswordChar = '\0';
            this.VarDataTb.PlaceholderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.VarDataTb.PlaceholderText = "New var data";
            this.VarDataTb.ReadOnly = false;
            this.VarDataTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.VarDataTb.SelectedText = "";
            this.VarDataTb.SelectionLength = 0;
            this.VarDataTb.SelectionStart = 0;
            this.VarDataTb.ShortcutsEnabled = true;
            this.VarDataTb.Size = new System.Drawing.Size(285, 30);
            this.VarDataTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.VarDataTb.TabIndex = 121;
            this.VarDataTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.VarDataTb.TextMarginBottom = 0;
            this.VarDataTb.TextMarginLeft = 3;
            this.VarDataTb.TextMarginTop = 1;
            this.VarDataTb.TextPlaceholder = "New var data";
            this.VarDataTb.UseSystemPasswordChar = false;
            this.VarDataTb.WordWrap = true;
            this.VarDataTb.TextChanged += new System.EventHandler(this.VarDataTb_TextChanged);
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
            this.IdListDd.Location = new System.Drawing.Point(94, 144);
            this.IdListDd.Name = "IdListDd";
            this.IdListDd.Size = new System.Drawing.Size(149, 30);
            this.IdListDd.TabIndex = 120;
            this.IdListDd.Text = null;
            this.IdListDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IdListDd.TextLeftMargin = 5;
            this.IdListDd.SelectedIndexChanged += new System.EventHandler(this.IdListDd_SelectedIndexChanged);
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
            this.bunifuLabel8.Text = "Edit variables data";
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
            this.App1RemoveButton.Location = new System.Drawing.Point(31, 292);
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
            this.App1LoadButton.ButtonText = "Edit";
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
            this.App1LoadButton.Location = new System.Drawing.Point(177, 292);
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
            // EditVarView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.App1Card);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "EditVarView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "EditVarView";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.EditVarView_Load);
            this.App1Card.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse bunifuElipse1;
        private Bunifu.UI.WinForms.BunifuPanel App1Card;
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel8;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton App1RemoveButton;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton App1LoadButton;
        private Bunifu.UI.WinForms.BunifuDropdown IdListDd;
        private Bunifu.UI.WinForms.BunifuTextBox VarDataTb;
    }
}