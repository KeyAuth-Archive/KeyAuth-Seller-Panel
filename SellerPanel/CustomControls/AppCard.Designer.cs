namespace KeyAuth_Seller_Panel.SellerPanel.CustomControls
{
    partial class AppCard
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AppCard));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges2 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.Card = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.NameLb = new System.Windows.Forms.Label();
            this.AppPic = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.RemoveBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.LoadBtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.AppCardElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.Notify = new Bunifu.UI.WinForms.BunifuSnackbar(this.components);
            this.Card.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).BeginInit();
            this.SuspendLayout();
            // 
            // Card
            // 
            this.Card.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Card.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.Card.BorderRadius = 10;
            this.Card.BorderThickness = 1;
            this.Card.Controls.Add(this.NameLb);
            this.Card.Controls.Add(this.AppPic);
            this.Card.Controls.Add(this.RemoveBtn);
            this.Card.Controls.Add(this.LoadBtn);
            this.Card.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Card.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Card.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Card.LabelAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.Card.LabelIndent = 10;
            this.Card.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.Card.Location = new System.Drawing.Point(5, 5);
            this.Card.Name = "Card";
            this.Card.Padding = new System.Windows.Forms.Padding(5, 10, 5, 5);
            this.Card.Size = new System.Drawing.Size(295, 115);
            this.Card.TabIndex = 34;
            this.Card.TabStop = false;
            // 
            // NameLb
            // 
            this.NameLb.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.NameLb.Location = new System.Drawing.Point(5, 5);
            this.NameLb.Margin = new System.Windows.Forms.Padding(0);
            this.NameLb.Name = "NameLb";
            this.NameLb.Size = new System.Drawing.Size(285, 27);
            this.NameLb.TabIndex = 6;
            this.NameLb.Text = "Application Name";
            this.NameLb.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AppPic
            // 
            this.AppPic.AllowFocused = false;
            this.AppPic.AutoSizeHeight = false;
            this.AppPic.BorderRadius = 10;
            this.AppPic.Dock = System.Windows.Forms.DockStyle.Top;
            this.AppPic.Image = global::KeyAuth_Seller_Panel.Properties.Resources.Banner;
            this.AppPic.IsCircle = false;
            this.AppPic.Location = new System.Drawing.Point(5, 32);
            this.AppPic.Name = "AppPic";
            this.AppPic.Size = new System.Drawing.Size(285, 40);
            this.AppPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.AppPic.TabIndex = 32;
            this.AppPic.TabStop = false;
            this.AppPic.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Custom;
            // 
            // RemoveBtn
            // 
            this.RemoveBtn.AllowAnimations = true;
            this.RemoveBtn.AllowMouseEffects = true;
            this.RemoveBtn.AllowToggling = false;
            this.RemoveBtn.AnimationSpeed = 200;
            this.RemoveBtn.AutoGenerateColors = false;
            this.RemoveBtn.AutoRoundBorders = false;
            this.RemoveBtn.AutoSizeLeftIcon = true;
            this.RemoveBtn.AutoSizeRightIcon = true;
            this.RemoveBtn.BackColor = System.Drawing.Color.Transparent;
            this.RemoveBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.RemoveBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RemoveBtn.BackgroundImage")));
            this.RemoveBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveBtn.ButtonText = "Remove";
            this.RemoveBtn.ButtonTextMarginLeft = 0;
            this.RemoveBtn.ColorContrastOnClick = 45;
            this.RemoveBtn.ColorContrastOnHover = 45;
            this.RemoveBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.RemoveBtn.CustomizableEdges = borderEdges1;
            this.RemoveBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.RemoveBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RemoveBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.RemoveBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.RemoveBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.RemoveBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.RemoveBtn.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.IconLeft = null;
            this.RemoveBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.RemoveBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.RemoveBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.RemoveBtn.IconMarginLeft = 11;
            this.RemoveBtn.IconPadding = 10;
            this.RemoveBtn.IconRight = null;
            this.RemoveBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.RemoveBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.RemoveBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.RemoveBtn.IconSize = 25;
            this.RemoveBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.RemoveBtn.IdleBorderRadius = 0;
            this.RemoveBtn.IdleBorderThickness = 0;
            this.RemoveBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.RemoveBtn.IdleIconLeftImage = null;
            this.RemoveBtn.IdleIconRightImage = null;
            this.RemoveBtn.IndicateFocus = false;
            this.RemoveBtn.Location = new System.Drawing.Point(5, 78);
            this.RemoveBtn.Name = "RemoveBtn";
            this.RemoveBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.RemoveBtn.OnDisabledState.BorderRadius = 10;
            this.RemoveBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveBtn.OnDisabledState.BorderThickness = 2;
            this.RemoveBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.RemoveBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.RemoveBtn.OnDisabledState.IconLeftImage = null;
            this.RemoveBtn.OnDisabledState.IconRightImage = null;
            this.RemoveBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.RemoveBtn.onHoverState.BorderRadius = 10;
            this.RemoveBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveBtn.onHoverState.BorderThickness = 2;
            this.RemoveBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.onHoverState.IconLeftImage = null;
            this.RemoveBtn.onHoverState.IconRightImage = null;
            this.RemoveBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveBtn.OnIdleState.BorderRadius = 10;
            this.RemoveBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveBtn.OnIdleState.BorderThickness = 2;
            this.RemoveBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.OnIdleState.IconLeftImage = null;
            this.RemoveBtn.OnIdleState.IconRightImage = null;
            this.RemoveBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveBtn.OnPressedState.BorderRadius = 10;
            this.RemoveBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.RemoveBtn.OnPressedState.BorderThickness = 2;
            this.RemoveBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.RemoveBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.RemoveBtn.OnPressedState.IconLeftImage = null;
            this.RemoveBtn.OnPressedState.IconRightImage = null;
            this.RemoveBtn.Size = new System.Drawing.Size(140, 30);
            this.RemoveBtn.TabIndex = 34;
            this.RemoveBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.RemoveBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.RemoveBtn.TextMarginLeft = 0;
            this.RemoveBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.RemoveBtn.UseDefaultRadiusAndThickness = true;
            this.RemoveBtn.Click += new System.EventHandler(this.RemoveBtn_Click);
            // 
            // LoadBtn
            // 
            this.LoadBtn.AllowAnimations = true;
            this.LoadBtn.AllowMouseEffects = true;
            this.LoadBtn.AllowToggling = false;
            this.LoadBtn.AnimationSpeed = 200;
            this.LoadBtn.AutoGenerateColors = false;
            this.LoadBtn.AutoRoundBorders = false;
            this.LoadBtn.AutoSizeLeftIcon = true;
            this.LoadBtn.AutoSizeRightIcon = true;
            this.LoadBtn.BackColor = System.Drawing.Color.Transparent;
            this.LoadBtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(122)))), ((int)(((byte)(183)))));
            this.LoadBtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LoadBtn.BackgroundImage")));
            this.LoadBtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadBtn.ButtonText = "Load";
            this.LoadBtn.ButtonTextMarginLeft = 0;
            this.LoadBtn.ColorContrastOnClick = 45;
            this.LoadBtn.ColorContrastOnHover = 45;
            this.LoadBtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges2.BottomLeft = true;
            borderEdges2.BottomRight = true;
            borderEdges2.TopLeft = true;
            borderEdges2.TopRight = true;
            this.LoadBtn.CustomizableEdges = borderEdges2;
            this.LoadBtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.LoadBtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoadBtn.DisabledFillColor = System.Drawing.Color.Empty;
            this.LoadBtn.DisabledForecolor = System.Drawing.Color.Empty;
            this.LoadBtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Pressed;
            this.LoadBtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.LoadBtn.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.IconLeft = null;
            this.LoadBtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.LoadBtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.LoadBtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.LoadBtn.IconMarginLeft = 11;
            this.LoadBtn.IconPadding = 10;
            this.LoadBtn.IconRight = null;
            this.LoadBtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.LoadBtn.IconRightCursor = System.Windows.Forms.Cursors.Default;
            this.LoadBtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.LoadBtn.IconSize = 25;
            this.LoadBtn.IdleBorderColor = System.Drawing.Color.Empty;
            this.LoadBtn.IdleBorderRadius = 0;
            this.LoadBtn.IdleBorderThickness = 0;
            this.LoadBtn.IdleFillColor = System.Drawing.Color.Empty;
            this.LoadBtn.IdleIconLeftImage = null;
            this.LoadBtn.IdleIconRightImage = null;
            this.LoadBtn.IndicateFocus = false;
            this.LoadBtn.Location = new System.Drawing.Point(147, 78);
            this.LoadBtn.Name = "LoadBtn";
            this.LoadBtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.LoadBtn.OnDisabledState.BorderRadius = 10;
            this.LoadBtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadBtn.OnDisabledState.BorderThickness = 2;
            this.LoadBtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.LoadBtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.LoadBtn.OnDisabledState.IconLeftImage = null;
            this.LoadBtn.OnDisabledState.IconRightImage = null;
            this.LoadBtn.onHoverState.BorderColor = System.Drawing.SystemColors.ButtonFace;
            this.LoadBtn.onHoverState.BorderRadius = 10;
            this.LoadBtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadBtn.onHoverState.BorderThickness = 2;
            this.LoadBtn.onHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.LoadBtn.onHoverState.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.onHoverState.IconLeftImage = null;
            this.LoadBtn.onHoverState.IconRightImage = null;
            this.LoadBtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.LoadBtn.OnIdleState.BorderRadius = 10;
            this.LoadBtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadBtn.OnIdleState.BorderThickness = 2;
            this.LoadBtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.LoadBtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.OnIdleState.IconLeftImage = null;
            this.LoadBtn.OnIdleState.IconRightImage = null;
            this.LoadBtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.LoadBtn.OnPressedState.BorderRadius = 10;
            this.LoadBtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.LoadBtn.OnPressedState.BorderThickness = 2;
            this.LoadBtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.LoadBtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.LoadBtn.OnPressedState.IconLeftImage = null;
            this.LoadBtn.OnPressedState.IconRightImage = null;
            this.LoadBtn.Size = new System.Drawing.Size(140, 30);
            this.LoadBtn.TabIndex = 30;
            this.LoadBtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.LoadBtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.LoadBtn.TextMarginLeft = 0;
            this.LoadBtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.LoadBtn.UseDefaultRadiusAndThickness = true;
            this.LoadBtn.Click += new System.EventHandler(this.LoadBtn_Click);
            // 
            // AppCardElipse
            // 
            this.AppCardElipse.ElipseRadius = 10;
            this.AppCardElipse.TargetControl = this;
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
            // AppCard
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.Controls.Add(this.Card);
            this.Name = "AppCard";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.Size = new System.Drawing.Size(305, 125);
            this.Load += new System.EventHandler(this.AppCard_Load);
            this.Card.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AppPic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private Bunifu.UI.WinForms.BunifuGroupBox Card;
        private System.Windows.Forms.Label NameLb;
        private Bunifu.UI.WinForms.BunifuPictureBox AppPic;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton RemoveBtn;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton LoadBtn;
        private Bunifu.Framework.UI.BunifuElipse AppCardElipse;
        private Bunifu.UI.WinForms.BunifuSnackbar Notify;
    }
}
