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
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.MainFormElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.MainPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.FileUrlTb = new Bunifu.UI.WinForms.BunifuTextBox();
            this.RunAsAdminToggle = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.RunAsAdminLb = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.IdListDd = new Bunifu.UI.WinForms.BunifuDropdown();
            this.AutoStartToggle = new Bunifu.UI.WinForms.BunifuToggleSwitch2();
            this.AutoStartLb = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.TitleLb = new Bunifu.UI.WinForms.BunifuLabel();
            this.BackBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.DownloadBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Notify = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.MainPanel.SuspendLayout();
            this.Card.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainFormElipse
            // 
            this.MainFormElipse.ElipseRadius = 10;
            this.MainFormElipse.TargetControl = this;
            // 
            // MainPanel
            // 
            this.MainPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.MainPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("MainPanel.BackgroundImage")));
            this.MainPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.MainPanel.BorderColor = System.Drawing.Color.Transparent;
            this.MainPanel.BorderRadius = 10;
            this.MainPanel.BorderThickness = 1;
            this.MainPanel.Controls.Add(this.Card);
            this.MainPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.MainPanel.Location = new System.Drawing.Point(325, 65);
            this.MainPanel.Name = "MainPanel";
            this.MainPanel.Padding = new System.Windows.Forms.Padding(5);
            this.MainPanel.ShowBorders = true;
            this.MainPanel.Size = new System.Drawing.Size(350, 320);
            this.MainPanel.TabIndex = 35;
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.label2);
            this.Card.Controls.Add(this.label1);
            this.Card.Controls.Add(this.FileUrlTb);
            this.Card.Controls.Add(this.RunAsAdminToggle);
            this.Card.Controls.Add(this.RunAsAdminLb);
            this.Card.Controls.Add(this.label4);
            this.Card.Controls.Add(this.IdListDd);
            this.Card.Controls.Add(this.AutoStartToggle);
            this.Card.Controls.Add(this.AutoStartLb);
            this.Card.Controls.Add(this.label3);
            this.Card.Controls.Add(this.TitleLb);
            this.Card.Controls.Add(this.BackBtn);
            this.Card.Controls.Add(this.DownloadBtn);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Card.LabelIndent = 10;
            this.Card.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5, 25, 5, 5);
            this.Card.Size = new System.Drawing.Size(340, 310);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Control;
            this.label2.Location = new System.Drawing.Point(16, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 21);
            this.label2.TabIndex = 125;
            this.label2.Text = "Selected File URL :";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(16, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 21);
            this.label1.TabIndex = 124;
            this.label1.Text = "Select File :";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FileUrlTb
            // 
            this.FileUrlTb.AcceptsReturn = false;
            this.FileUrlTb.AcceptsTab = false;
            this.FileUrlTb.AnimationSpeed = 200;
            this.FileUrlTb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.FileUrlTb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.FileUrlTb.AutoSizeHeight = false;
            this.FileUrlTb.BackColor = System.Drawing.Color.Transparent;
            this.FileUrlTb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("FileUrlTb.BackgroundImage")));
            this.FileUrlTb.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.FileUrlTb.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.FileUrlTb.BorderColorHover = System.Drawing.SystemColors.ButtonFace;
            this.FileUrlTb.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.FileUrlTb.BorderRadius = 10;
            this.FileUrlTb.BorderThickness = 1;
            this.FileUrlTb.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.FileUrlTb.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.FileUrlTb.DefaultFont = new System.Drawing.Font("Segoe UI", 9F);
            this.FileUrlTb.DefaultText = "";
            this.FileUrlTb.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.FileUrlTb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileUrlTb.HideSelection = true;
            this.FileUrlTb.IconLeft = null;
            this.FileUrlTb.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.FileUrlTb.IconPadding = 10;
            this.FileUrlTb.IconRight = null;
            this.FileUrlTb.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.FileUrlTb.Lines = new string[0];
            this.FileUrlTb.Location = new System.Drawing.Point(20, 130);
            this.FileUrlTb.MaxLength = 32767;
            this.FileUrlTb.MinimumSize = new System.Drawing.Size(0, 30);
            this.FileUrlTb.Modified = false;
            this.FileUrlTb.Multiline = false;
            this.FileUrlTb.Name = "FileUrlTb";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FileUrlTb.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.FileUrlTb.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FileUrlTb.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            stateProperties4.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            stateProperties4.ForeColor = System.Drawing.SystemColors.ButtonFace;
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.FileUrlTb.OnIdleState = stateProperties4;
            this.FileUrlTb.Padding = new System.Windows.Forms.Padding(3);
            this.FileUrlTb.PasswordChar = '\0';
            this.FileUrlTb.PlaceholderForeColor = System.Drawing.SystemColors.ButtonFace;
            this.FileUrlTb.PlaceholderText = "Select your file first";
            this.FileUrlTb.ReadOnly = true;
            this.FileUrlTb.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.FileUrlTb.SelectedText = "";
            this.FileUrlTb.SelectionLength = 0;
            this.FileUrlTb.SelectionStart = 0;
            this.FileUrlTb.ShortcutsEnabled = true;
            this.FileUrlTb.Size = new System.Drawing.Size(300, 30);
            this.FileUrlTb.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.FileUrlTb.TabIndex = 123;
            this.FileUrlTb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.FileUrlTb.TextMarginBottom = 0;
            this.FileUrlTb.TextMarginLeft = 3;
            this.FileUrlTb.TextMarginTop = 1;
            this.FileUrlTb.TextPlaceholder = "Select your file first";
            this.FileUrlTb.UseSystemPasswordChar = false;
            this.FileUrlTb.WordWrap = true;
            // 
            // RunAsAdminToggle
            // 
            this.RunAsAdminToggle.BackColor = System.Drawing.Color.Transparent;
            this.RunAsAdminToggle.Checked = true;
            this.RunAsAdminToggle.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.RunAsAdminToggle.CheckedSwitchColor = System.Drawing.Color.White;
            this.RunAsAdminToggle.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.RunAsAdminToggle.Enabled = false;
            this.RunAsAdminToggle.Location = new System.Drawing.Point(138, 222);
            this.RunAsAdminToggle.Name = "RunAsAdminToggle";
            this.RunAsAdminToggle.OutlineThickness = 2;
            this.RunAsAdminToggle.Size = new System.Drawing.Size(46, 19);
            this.RunAsAdminToggle.TabIndex = 122;
            this.RunAsAdminToggle.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.RunAsAdminToggle.UncheckedSwitchColor = System.Drawing.Color.White;
            this.RunAsAdminToggle.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.RunAsAdminToggle.CheckedChanged += new System.EventHandler(this.RunAsAdminToggle_CheckedChanged);
            // 
            // RunAsAdminLb
            // 
            this.RunAsAdminLb.AutoSize = true;
            this.RunAsAdminLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.RunAsAdminLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RunAsAdminLb.ForeColor = System.Drawing.SystemColors.Control;
            this.RunAsAdminLb.Location = new System.Drawing.Point(190, 226);
            this.RunAsAdminLb.Name = "RunAsAdminLb";
            this.RunAsAdminLb.Size = new System.Drawing.Size(36, 15);
            this.RunAsAdminLb.TabIndex = 121;
            this.RunAsAdminLb.Text = "NULL";
            this.RunAsAdminLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label4.ForeColor = System.Drawing.SystemColors.Control;
            this.label4.Location = new System.Drawing.Point(16, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 21);
            this.label4.TabIndex = 120;
            this.label4.Text = "Run As Admin :";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
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
            this.IdListDd.Location = new System.Drawing.Point(105, 59);
            this.IdListDd.Name = "IdListDd";
            this.IdListDd.Size = new System.Drawing.Size(146, 30);
            this.IdListDd.TabIndex = 119;
            this.IdListDd.Text = null;
            this.IdListDd.TextAlignment = Bunifu.UI.WinForms.BunifuDropdown.TextAlign.Left;
            this.IdListDd.TextLeftMargin = 5;
            this.IdListDd.SelectedIndexChanged += new System.EventHandler(this.IdListDd_SelectedIndexChanged);
            // 
            // AutoStartToggle
            // 
            this.AutoStartToggle.BackColor = System.Drawing.Color.Transparent;
            this.AutoStartToggle.Checked = true;
            this.AutoStartToggle.CheckedBackColor = System.Drawing.Color.DodgerBlue;
            this.AutoStartToggle.CheckedSwitchColor = System.Drawing.Color.White;
            this.AutoStartToggle.CheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Fill;
            this.AutoStartToggle.Location = new System.Drawing.Point(108, 182);
            this.AutoStartToggle.Name = "AutoStartToggle";
            this.AutoStartToggle.OutlineThickness = 2;
            this.AutoStartToggle.Size = new System.Drawing.Size(46, 19);
            this.AutoStartToggle.TabIndex = 115;
            this.AutoStartToggle.UncheckedBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(189)))), ((int)(((byte)(189)))), ((int)(((byte)(189)))));
            this.AutoStartToggle.UncheckedSwitchColor = System.Drawing.Color.White;
            this.AutoStartToggle.UncheckedSwitchStyle = Bunifu.UI.WinForms.BunifuToggleSwitch2.SwitchStyles.Outline;
            this.AutoStartToggle.CheckedChanged += new System.EventHandler(this.AutoStartToggle_CheckedChanged);
            // 
            // AutoStartLb
            // 
            this.AutoStartLb.AutoSize = true;
            this.AutoStartLb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.AutoStartLb.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AutoStartLb.ForeColor = System.Drawing.SystemColors.Control;
            this.AutoStartLb.Location = new System.Drawing.Point(160, 185);
            this.AutoStartLb.Name = "AutoStartLb";
            this.AutoStartLb.Size = new System.Drawing.Size(36, 15);
            this.AutoStartLb.TabIndex = 114;
            this.AutoStartLb.Text = "NULL";
            this.AutoStartLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F);
            this.label3.ForeColor = System.Drawing.SystemColors.Control;
            this.label3.Location = new System.Drawing.Point(16, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 112;
            this.label3.Text = "Auto Start :";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // TitleLb
            // 
            this.TitleLb.AllowParentOverrides = false;
            this.TitleLb.AutoEllipsis = false;
            this.TitleLb.CursorType = null;
            this.TitleLb.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TitleLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TitleLb.Location = new System.Drawing.Point(88, 10);
            this.TitleLb.Name = "TitleLb";
            this.TitleLb.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.TitleLb.Size = new System.Drawing.Size(163, 32);
            this.TitleLb.TabIndex = 107;
            this.TitleLb.Text = "File Download";
            this.TitleLb.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            this.TitleLb.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
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
            this.BackBtn.Location = new System.Drawing.Point(20, 260);
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
            // DownloadBtn
            // 
            this.DownloadBtn.AllowAnimations = true;
            this.DownloadBtn.AllowMouseEffects = true;
            this.DownloadBtn.AllowToggling = false;
            this.DownloadBtn.AnimationSpeed = 200;
            this.DownloadBtn.AutoGenerateColors = false;
            this.DownloadBtn.AutoRoundBorders = false;
            this.DownloadBtn.AutoSizeLeftIcon = true;
            this.DownloadBtn.AutoSizeRightIcon = true;
            this.DownloadBtn.BackColor = System.Drawing.Color.Transparent;
            this.DownloadBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.DownloadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DownloadBtn.BackgroundImage")));
            this.DownloadBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DownloadBtn.ButtonText = "Download";
            this.DownloadBtn.ButtonTextMarginLeft = 0;
            this.DownloadBtn.ColorContrastOnClick = 45;
            this.DownloadBtn.ColorContrastOnHover = 45;
            this.DownloadBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.DownloadBtn.CustomizableEdges = borderEdges2;
            this.DownloadBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.DownloadBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DownloadBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.DownloadBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.DownloadBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.DownloadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.DownloadBtn.ForeColor = System.Drawing.Color.White;
            this.DownloadBtn.IconLeft = null;
            this.DownloadBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.DownloadBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.DownloadBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.DownloadBtn.IconMarginLeft = 11;
            this.DownloadBtn.IconPadding = 10;
            this.DownloadBtn.IconRight = null;
            this.DownloadBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.DownloadBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.DownloadBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.DownloadBtn.IconSize = 25;
            this.DownloadBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.DownloadBtn.IdleBorderRadius = 0;
            this.DownloadBtn.IdleBorderThickness = 0;
            this.DownloadBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.DownloadBtn.IdleIconLeftImage = null;
            this.DownloadBtn.IdleIconRightImage = null;
            this.DownloadBtn.IndicateFocus = false;
            this.DownloadBtn.Location = new System.Drawing.Point(180, 260);
            this.DownloadBtn.Name = "DownloadBtn";
            this.DownloadBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.DownloadBtn.OnDisabledState.BorderRadius = 10;
            this.DownloadBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DownloadBtn.OnDisabledState.BorderThickness = 2;
            this.DownloadBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.DownloadBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.DownloadBtn.OnDisabledState.IconLeftImage = null;
            this.DownloadBtn.OnDisabledState.IconRightImage = null;
            this.DownloadBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.DownloadBtn.onHoverState.BorderRadius = 10;
            this.DownloadBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DownloadBtn.onHoverState.BorderThickness = 2;
            this.DownloadBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DownloadBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.DownloadBtn.onHoverState.IconLeftImage = null;
            this.DownloadBtn.onHoverState.IconRightImage = null;
            this.DownloadBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DownloadBtn.OnIdleState.BorderRadius = 10;
            this.DownloadBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DownloadBtn.OnIdleState.BorderThickness = 2;
            this.DownloadBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DownloadBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.DownloadBtn.OnIdleState.IconLeftImage = null;
            this.DownloadBtn.OnIdleState.IconRightImage = null;
            this.DownloadBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DownloadBtn.OnPressedState.BorderRadius = 10;
            this.DownloadBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.DownloadBtn.OnPressedState.BorderThickness = 2;
            this.DownloadBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.DownloadBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.DownloadBtn.OnPressedState.IconLeftImage = null;
            this.DownloadBtn.OnPressedState.IconRightImage = null;
            this.DownloadBtn.Size = new System.Drawing.Size(140, 30);
            this.DownloadBtn.TabIndex = 30;
            this.DownloadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.DownloadBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.DownloadBtn.TextMarginLeft = 0;
            this.DownloadBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.DownloadBtn.UseDefaultRadiusAndThickness = true;
            this.DownloadBtn.Click += new System.EventHandler(this.DownloadBtn_Click);
            // 
            // Notify
            // 
            this.Notify.AllowDragging = false;
            this.Notify.AllowMultipleViews = true;
            this.Notify.ClickToClose = true;
            this.Notify.DoubleClickToClose = true;
            this.Notify.DurationAfterIdle = 3000;
            this.Notify.ErrorOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.ErrorOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.ErrorOptions.ActionBorderRadius = 1;
            this.Notify.ErrorOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notify.ErrorOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notify.ErrorOptions.BackColor = System.Drawing.Color.White;
            this.Notify.ErrorOptions.BorderColor = System.Drawing.Color.White;
            this.Notify.ErrorOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(204)))), ((int)(((byte)(199)))));
            this.Notify.ErrorOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notify.ErrorOptions.ForeColor = System.Drawing.Color.Black;
            this.Notify.ErrorOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon")));
            this.Notify.ErrorOptions.IconLeftMargin = 12;
            this.Notify.FadeCloseIcon = false;
            this.Notify.Host = Bunifu.UI.WinForms.BunifuSnackbar.Hosts.FormOwner;
            this.Notify.InformationOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.InformationOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.InformationOptions.ActionBorderRadius = 1;
            this.Notify.InformationOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notify.InformationOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notify.InformationOptions.BackColor = System.Drawing.Color.White;
            this.Notify.InformationOptions.BorderColor = System.Drawing.Color.White;
            this.Notify.InformationOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(145)))), ((int)(((byte)(213)))), ((int)(((byte)(255)))));
            this.Notify.InformationOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notify.InformationOptions.ForeColor = System.Drawing.Color.Black;
            this.Notify.InformationOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon1")));
            this.Notify.InformationOptions.IconLeftMargin = 12;
            this.Notify.Margin = 10;
            this.Notify.MaximumSize = new System.Drawing.Size(0, 0);
            this.Notify.MaximumViews = 7;
            this.Notify.MessageRightMargin = 15;
            this.Notify.MinimumSize = new System.Drawing.Size(0, 0);
            this.Notify.ShowBorders = false;
            this.Notify.ShowCloseIcon = false;
            this.Notify.ShowIcon = true;
            this.Notify.ShowShadows = true;
            this.Notify.SuccessOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.SuccessOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.SuccessOptions.ActionBorderRadius = 1;
            this.Notify.SuccessOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notify.SuccessOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notify.SuccessOptions.BackColor = System.Drawing.Color.White;
            this.Notify.SuccessOptions.BorderColor = System.Drawing.Color.White;
            this.Notify.SuccessOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(255)))), ((int)(((byte)(237)))));
            this.Notify.SuccessOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notify.SuccessOptions.ForeColor = System.Drawing.Color.Black;
            this.Notify.SuccessOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon2")));
            this.Notify.SuccessOptions.IconLeftMargin = 12;
            this.Notify.ViewsMargin = 7;
            this.Notify.WarningOptions.ActionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.WarningOptions.ActionBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.Notify.WarningOptions.ActionBorderRadius = 1;
            this.Notify.WarningOptions.ActionFont = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Bold);
            this.Notify.WarningOptions.ActionForeColor = System.Drawing.Color.Black;
            this.Notify.WarningOptions.BackColor = System.Drawing.Color.White;
            this.Notify.WarningOptions.BorderColor = System.Drawing.Color.White;
            this.Notify.WarningOptions.CloseIconColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(229)))), ((int)(((byte)(143)))));
            this.Notify.WarningOptions.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.Notify.WarningOptions.ForeColor = System.Drawing.Color.Black;
            this.Notify.WarningOptions.Icon = ((System.Drawing.Image)(resources.GetObject("resource.Icon3")));
            this.Notify.WarningOptions.IconLeftMargin = 12;
            this.Notify.ZoomCloseIcon = true;
            // 
            // DownloadFileView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.MainPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "DownloadFileView";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "DownloadFileView";
            this.Load += new System.EventHandler(this.DownloadFileView_Load);
            this.MainPanel.ResumeLayout(false);
            this.Card.ResumeLayout(false);
            this.Card.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse MainFormElipse;
        private Bunifu.UI.WinForms.BunifuPanel MainPanel;
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private Bunifu.UI.WinForms.BunifuLabel TitleLb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton BackBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton DownloadBtn;
        private Bunifu.UI.WinForms.BunifuSnackbar Notify;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 AutoStartToggle;
        private System.Windows.Forms.Label AutoStartLb;
        private System.Windows.Forms.Label label3;
        private Bunifu.UI.WinForms.BunifuDropdown IdListDd;
        private Bunifu.UI.WinForms.BunifuToggleSwitch2 RunAsAdminToggle;
        private System.Windows.Forms.Label RunAsAdminLb;
        private System.Windows.Forms.Label label4;
        private Bunifu.UI.WinForms.BunifuTextBox FileUrlTb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}