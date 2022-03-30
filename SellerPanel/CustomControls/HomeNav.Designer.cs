namespace KeyAuth_Seller_Panel.SellerPanel.CustomControls
{
    partial class HomeNav
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeNav));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges3 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.NavPanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.NavGb = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.AddNewAppBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.TotalAppsLb = new System.Windows.Forms.Label();
            this.RemoveAllAppsBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.SettingsBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.Notify = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.NavPanel.SuspendLayout();
            this.NavGb.SuspendLayout();
            this.SuspendLayout();
            // 
            // NavPanel
            // 
            this.NavPanel.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.NavPanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("NavPanel.BackgroundImage")));
            this.NavPanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.NavPanel.BorderColor = System.Drawing.Color.Transparent;
            this.NavPanel.BorderRadius = 10;
            this.NavPanel.BorderThickness = 1;
            this.NavPanel.Controls.Add(this.NavGb);
            this.NavPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavPanel.Location = new System.Drawing.Point(0, 0);
            this.NavPanel.Name = "NavPanel";
            this.NavPanel.Padding = new System.Windows.Forms.Padding(5);
            this.NavPanel.ShowBorders = true;
            this.NavPanel.Size = new System.Drawing.Size(305, 125);
            this.NavPanel.TabIndex = 36;
            // 
            // NavGb
            // 
            this.NavGb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.NavGb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.NavGb.BorderRadius = 10;
            this.NavGb.BorderThickness = 1;
            this.NavGb.Controls.Add(this.AddNewAppBtn);
            this.NavGb.Controls.Add(this.TotalAppsLb);
            this.NavGb.Controls.Add(this.RemoveAllAppsBtn);
            this.NavGb.Controls.Add(this.SettingsBtn);
            this.NavGb.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NavGb.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NavGb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NavGb.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.NavGb.LabelIndent = 0;
            this.NavGb.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.NavGb.Location = new System.Drawing.Point(5, 5);
            this.NavGb.Name = "NavGb";
            this.NavGb.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.NavGb.Size = new System.Drawing.Size(295, 115);
            this.NavGb.TabIndex = 34;
            this.NavGb.TabStop = false;
            // 
            // AddNewAppBtn
            // 
            this.AddNewAppBtn.AllowAnimations = true;
            this.AddNewAppBtn.AllowMouseEffects = true;
            this.AddNewAppBtn.AllowToggling = false;
            this.AddNewAppBtn.AnimationSpeed = 200;
            this.AddNewAppBtn.AutoGenerateColors = false;
            this.AddNewAppBtn.AutoRoundBorders = false;
            this.AddNewAppBtn.AutoSizeLeftIcon = true;
            this.AddNewAppBtn.AutoSizeRightIcon = true;
            this.AddNewAppBtn.BackColor = System.Drawing.Color.Transparent;
            this.AddNewAppBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.AddNewAppBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("AddNewAppBtn.BackgroundImage")));
            this.AddNewAppBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddNewAppBtn.ButtonText = "Add New App";
            this.AddNewAppBtn.ButtonTextMarginLeft = 0;
            this.AddNewAppBtn.ColorContrastOnClick = 45;
            this.AddNewAppBtn.ColorContrastOnHover = 45;
            this.AddNewAppBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.AddNewAppBtn.CustomizableEdges = borderEdges1;
            this.AddNewAppBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.AddNewAppBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddNewAppBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.AddNewAppBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.AddNewAppBtn.Dock = System.Windows.Forms.DockStyle.Top;
            this.AddNewAppBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.AddNewAppBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.AddNewAppBtn.ForeColor = System.Drawing.Color.White;
            this.AddNewAppBtn.IconLeft = null;
            this.AddNewAppBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.AddNewAppBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.AddNewAppBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.AddNewAppBtn.IconMarginLeft = 11;
            this.AddNewAppBtn.IconPadding = 10;
            this.AddNewAppBtn.IconRight = null;
            this.AddNewAppBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.AddNewAppBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.AddNewAppBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.AddNewAppBtn.IconSize = 25;
            this.AddNewAppBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.AddNewAppBtn.IdleBorderRadius = 0;
            this.AddNewAppBtn.IdleBorderThickness = 0;
            this.AddNewAppBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.AddNewAppBtn.IdleIconLeftImage = null;
            this.AddNewAppBtn.IdleIconRightImage = null;
            this.AddNewAppBtn.IndicateFocus = false;
            this.AddNewAppBtn.Location = new System.Drawing.Point(5, 32);
            this.AddNewAppBtn.Name = "AddNewAppBtn";
            this.AddNewAppBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.AddNewAppBtn.OnDisabledState.BorderRadius = 10;
            this.AddNewAppBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddNewAppBtn.OnDisabledState.BorderThickness = 2;
            this.AddNewAppBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.AddNewAppBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.AddNewAppBtn.OnDisabledState.IconLeftImage = null;
            this.AddNewAppBtn.OnDisabledState.IconRightImage = null;
            this.AddNewAppBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.AddNewAppBtn.onHoverState.BorderRadius = 10;
            this.AddNewAppBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddNewAppBtn.onHoverState.BorderThickness = 2;
            this.AddNewAppBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AddNewAppBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.AddNewAppBtn.onHoverState.IconLeftImage = null;
            this.AddNewAppBtn.onHoverState.IconRightImage = null;
            this.AddNewAppBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AddNewAppBtn.OnIdleState.BorderRadius = 10;
            this.AddNewAppBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddNewAppBtn.OnIdleState.BorderThickness = 2;
            this.AddNewAppBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AddNewAppBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.AddNewAppBtn.OnIdleState.IconLeftImage = null;
            this.AddNewAppBtn.OnIdleState.IconRightImage = null;
            this.AddNewAppBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AddNewAppBtn.OnPressedState.BorderRadius = 10;
            this.AddNewAppBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.AddNewAppBtn.OnPressedState.BorderThickness = 2;
            this.AddNewAppBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.AddNewAppBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.AddNewAppBtn.OnPressedState.IconLeftImage = null;
            this.AddNewAppBtn.OnPressedState.IconRightImage = null;
            this.AddNewAppBtn.Size = new System.Drawing.Size(285, 40);
            this.AddNewAppBtn.TabIndex = 30;
            this.AddNewAppBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.AddNewAppBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.AddNewAppBtn.TextMarginLeft = 0;
            this.AddNewAppBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.AddNewAppBtn.UseDefaultRadiusAndThickness = true;
            this.AddNewAppBtn.Click += new System.EventHandler(this.AddNewAppBtn_Click);
            // 
            // TotalAppsLb
            // 
            this.TotalAppsLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalAppsLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.TotalAppsLb.Location = new System.Drawing.Point(5, 3);
            this.TotalAppsLb.Margin = new System.Windows.Forms.Padding(0);
            this.TotalAppsLb.Name = "TotalAppsLb";
            this.TotalAppsLb.Size = new System.Drawing.Size(285, 29);
            this.TotalAppsLb.TabIndex = 37;
            this.TotalAppsLb.Text = "Total Applications: 0";
            this.TotalAppsLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // RemoveAllAppsBtn
            // 
            this.RemoveAllAppsBtn.AllowAnimations = true;
            this.RemoveAllAppsBtn.AllowMouseEffects = true;
            this.RemoveAllAppsBtn.AllowToggling = false;
            this.RemoveAllAppsBtn.AnimationSpeed = 200;
            this.RemoveAllAppsBtn.AutoGenerateColors = false;
            this.RemoveAllAppsBtn.AutoRoundBorders = false;
            this.RemoveAllAppsBtn.AutoSizeLeftIcon = true;
            this.RemoveAllAppsBtn.AutoSizeRightIcon = true;
            this.RemoveAllAppsBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveAllAppsBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.RemoveAllAppsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveAllAppsBtn.BackgroundImage")));
            this.RemoveAllAppsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveAllAppsBtn.ButtonText = "Remove All App\'s";
            this.RemoveAllAppsBtn.ButtonTextMarginLeft = 0;
            this.RemoveAllAppsBtn.ColorContrastOnClick = 45;
            this.RemoveAllAppsBtn.ColorContrastOnHover = 45;
            this.RemoveAllAppsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.RemoveAllAppsBtn.CustomizableEdges = borderEdges2;
            this.RemoveAllAppsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RemoveAllAppsBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RemoveAllAppsBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.RemoveAllAppsBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.RemoveAllAppsBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.RemoveAllAppsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveAllAppsBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveAllAppsBtn.IconLeft = null;
            this.RemoveAllAppsBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveAllAppsBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.RemoveAllAppsBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.RemoveAllAppsBtn.IconMarginLeft = 11;
            this.RemoveAllAppsBtn.IconPadding = 10;
            this.RemoveAllAppsBtn.IconRight = null;
            this.RemoveAllAppsBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveAllAppsBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.RemoveAllAppsBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.RemoveAllAppsBtn.IconSize = 25;
            this.RemoveAllAppsBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.RemoveAllAppsBtn.IdleBorderRadius = 0;
            this.RemoveAllAppsBtn.IdleBorderThickness = 0;
            this.RemoveAllAppsBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.RemoveAllAppsBtn.IdleIconLeftImage = null;
            this.RemoveAllAppsBtn.IdleIconRightImage = null;
            this.RemoveAllAppsBtn.IndicateFocus = false;
            this.RemoveAllAppsBtn.Location = new System.Drawing.Point(5, 77);
            this.RemoveAllAppsBtn.Name = "RemoveAllAppsBtn";
            this.RemoveAllAppsBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RemoveAllAppsBtn.OnDisabledState.BorderRadius = 10;
            this.RemoveAllAppsBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveAllAppsBtn.OnDisabledState.BorderThickness = 2;
            this.RemoveAllAppsBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RemoveAllAppsBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.RemoveAllAppsBtn.OnDisabledState.IconLeftImage = null;
            this.RemoveAllAppsBtn.OnDisabledState.IconRightImage = null;
            this.RemoveAllAppsBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveAllAppsBtn.onHoverState.BorderRadius = 10;
            this.RemoveAllAppsBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveAllAppsBtn.onHoverState.BorderThickness = 2;
            this.RemoveAllAppsBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveAllAppsBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.RemoveAllAppsBtn.onHoverState.IconLeftImage = null;
            this.RemoveAllAppsBtn.onHoverState.IconRightImage = null;
            this.RemoveAllAppsBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveAllAppsBtn.OnIdleState.BorderRadius = 10;
            this.RemoveAllAppsBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveAllAppsBtn.OnIdleState.BorderThickness = 2;
            this.RemoveAllAppsBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveAllAppsBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.RemoveAllAppsBtn.OnIdleState.IconLeftImage = null;
            this.RemoveAllAppsBtn.OnIdleState.IconRightImage = null;
            this.RemoveAllAppsBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveAllAppsBtn.OnPressedState.BorderRadius = 10;
            this.RemoveAllAppsBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveAllAppsBtn.OnPressedState.BorderThickness = 2;
            this.RemoveAllAppsBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveAllAppsBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.RemoveAllAppsBtn.OnPressedState.IconLeftImage = null;
            this.RemoveAllAppsBtn.OnPressedState.IconRightImage = null;
            this.RemoveAllAppsBtn.Size = new System.Drawing.Size(140, 30);
            this.RemoveAllAppsBtn.TabIndex = 34;
            this.RemoveAllAppsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemoveAllAppsBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.RemoveAllAppsBtn.TextMarginLeft = 0;
            this.RemoveAllAppsBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.RemoveAllAppsBtn.UseDefaultRadiusAndThickness = true;
            this.RemoveAllAppsBtn.Click += new System.EventHandler(this.RemoveAllAppsBtn_Click);
            // 
            // SettingsBtn
            // 
            this.SettingsBtn.AllowAnimations = true;
            this.SettingsBtn.AllowMouseEffects = true;
            this.SettingsBtn.AllowToggling = false;
            this.SettingsBtn.AnimationSpeed = 200;
            this.SettingsBtn.AutoGenerateColors = false;
            this.SettingsBtn.AutoRoundBorders = false;
            this.SettingsBtn.AutoSizeLeftIcon = true;
            this.SettingsBtn.AutoSizeRightIcon = true;
            this.SettingsBtn.BackColor = System.Drawing.Color.Transparent;
            this.SettingsBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.SettingsBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("SettingsBtn.BackgroundImage")));
            this.SettingsBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsBtn.ButtonText = "Settings";
            this.SettingsBtn.ButtonTextMarginLeft = 0;
            this.SettingsBtn.ColorContrastOnClick = 45;
            this.SettingsBtn.ColorContrastOnHover = 45;
            this.SettingsBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges3.BottomLeft = true;
            borderEdges3.BottomRight = true;
            borderEdges3.TopLeft = true;
            borderEdges3.TopRight = true;
            this.SettingsBtn.CustomizableEdges = borderEdges3;
            this.SettingsBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.SettingsBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SettingsBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.SettingsBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.SettingsBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.SettingsBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.SettingsBtn.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.IconLeft = null;
            this.SettingsBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.SettingsBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.SettingsBtn.IconMarginLeft = 11;
            this.SettingsBtn.IconPadding = 10;
            this.SettingsBtn.IconRight = null;
            this.SettingsBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.SettingsBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.SettingsBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.SettingsBtn.IconSize = 25;
            this.SettingsBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.SettingsBtn.IdleBorderRadius = 0;
            this.SettingsBtn.IdleBorderThickness = 0;
            this.SettingsBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.SettingsBtn.IdleIconLeftImage = null;
            this.SettingsBtn.IdleIconRightImage = null;
            this.SettingsBtn.IndicateFocus = false;
            this.SettingsBtn.Location = new System.Drawing.Point(150, 77);
            this.SettingsBtn.Name = "SettingsBtn";
            this.SettingsBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.SettingsBtn.OnDisabledState.BorderRadius = 10;
            this.SettingsBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsBtn.OnDisabledState.BorderThickness = 2;
            this.SettingsBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.SettingsBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.SettingsBtn.OnDisabledState.IconLeftImage = null;
            this.SettingsBtn.OnDisabledState.IconRightImage = null;
            this.SettingsBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.SettingsBtn.onHoverState.BorderRadius = 10;
            this.SettingsBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsBtn.onHoverState.BorderThickness = 2;
            this.SettingsBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SettingsBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.onHoverState.IconLeftImage = null;
            this.SettingsBtn.onHoverState.IconRightImage = null;
            this.SettingsBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SettingsBtn.OnIdleState.BorderRadius = 10;
            this.SettingsBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsBtn.OnIdleState.BorderThickness = 2;
            this.SettingsBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SettingsBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.OnIdleState.IconLeftImage = null;
            this.SettingsBtn.OnIdleState.IconRightImage = null;
            this.SettingsBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SettingsBtn.OnPressedState.BorderRadius = 10;
            this.SettingsBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.SettingsBtn.OnPressedState.BorderThickness = 2;
            this.SettingsBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.SettingsBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.SettingsBtn.OnPressedState.IconLeftImage = null;
            this.SettingsBtn.OnPressedState.IconRightImage = null;
            this.SettingsBtn.Size = new System.Drawing.Size(140, 30);
            this.SettingsBtn.TabIndex = 38;
            this.SettingsBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.SettingsBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.SettingsBtn.TextMarginLeft = 0;
            this.SettingsBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.SettingsBtn.UseDefaultRadiusAndThickness = true;
            this.SettingsBtn.Click += new System.EventHandler(this.AboutBtn_Click);
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
            // HomeNav
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.Controls.Add(this.NavPanel);
            this.Name = "HomeNav";
            this.Size = new System.Drawing.Size(305, 125);
            this.Load += new System.EventHandler(this.HomeNav_Load);
            this.NavPanel.ResumeLayout(false);
            this.NavGb.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuPanel NavPanel;
        private Bunifu.UI.WinForms.BunifuGroupBox NavGb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton AddNewAppBtn;
        private System.Windows.Forms.Label TotalAppsLb;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton RemoveAllAppsBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton SettingsBtn;
        private Bunifu.UI.WinForms.BunifuSnackbar Notify;
    }
}
