namespace KeyAuth_Seller_Panel
{
    partial class HomeView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomeView));
            this.HomeViewElipse = new Bunifu.Framework.UI.BunifuElipse(this.components);
            this.HomeViewDragControl = new Bunifu.Framework.UI.BunifuDragControl(this.components);
            this.TitlePanel = new Bunifu.UI.WinForms.BunifuPanel();
            this.KeyAuthLogoPb = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.MinButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.CloseButton = new Guna.UI2.WinForms.Guna2ControlBox();
            this.ProgramNameLb = new System.Windows.Forms.Label();
            this.MainGroupB = new Bunifu.UI.WinForms.BunifuGroupBox();
            this.HomeViewSb = new Bunifu.UI.WinForms.BunifuVScrollBar();
            this.AppLayOutFp = new System.Windows.Forms.FlowLayoutPanel();
            this.RightPn = new Bunifu.UI.WinForms.BunifuPanel();
            this.LeftPn = new Bunifu.UI.WinForms.BunifuPanel();
            this.BottomPn = new Bunifu.UI.WinForms.BunifuPanel();
            this.TitlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyAuthLogoPb)).BeginInit();
            this.MainGroupB.SuspendLayout();
            this.SuspendLayout();
            // 
            // HomeViewElipse
            // 
            this.HomeViewElipse.ElipseRadius = 15;
            this.HomeViewElipse.TargetControl = this;
            // 
            // HomeViewDragControl
            // 
            this.HomeViewDragControl.Fixed = true;
            this.HomeViewDragControl.Horizontal = true;
            this.HomeViewDragControl.TargetControl = this.TitlePanel;
            this.HomeViewDragControl.Vertical = true;
            // 
            // TitlePanel
            // 
            this.TitlePanel.BackgroundColor = System.Drawing.Color.Transparent;
            this.TitlePanel.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("TitlePanel.BackgroundImage")));
            this.TitlePanel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.TitlePanel.BorderColor = System.Drawing.Color.Transparent;
            this.TitlePanel.BorderRadius = 3;
            this.TitlePanel.BorderThickness = 1;
            this.TitlePanel.Controls.Add(this.KeyAuthLogoPb);
            this.TitlePanel.Controls.Add(this.MinButton);
            this.TitlePanel.Controls.Add(this.CloseButton);
            this.TitlePanel.Controls.Add(this.ProgramNameLb);
            this.TitlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.TitlePanel.Location = new System.Drawing.Point(0, 0);
            this.TitlePanel.Name = "TitlePanel";
            this.TitlePanel.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.TitlePanel.ShowBorders = true;
            this.TitlePanel.Size = new System.Drawing.Size(1000, 45);
            this.TitlePanel.TabIndex = 1;
            // 
            // KeyAuthLogoPb
            // 
            this.KeyAuthLogoPb.AllowFocused = false;
            this.KeyAuthLogoPb.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.KeyAuthLogoPb.AutoSizeHeight = true;
            this.KeyAuthLogoPb.BorderRadius = 20;
            this.KeyAuthLogoPb.Image = global::KeyAuth_Seller_Panel.Properties.Resources.favicon;
            this.KeyAuthLogoPb.IsCircle = true;
            this.KeyAuthLogoPb.Location = new System.Drawing.Point(8, 5);
            this.KeyAuthLogoPb.Name = "KeyAuthLogoPb";
            this.KeyAuthLogoPb.Size = new System.Drawing.Size(40, 40);
            this.KeyAuthLogoPb.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.KeyAuthLogoPb.TabIndex = 6;
            this.KeyAuthLogoPb.TabStop = false;
            this.KeyAuthLogoPb.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // MinButton
            // 
            this.MinButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.MinButton.ControlBoxType = Guna.UI2.WinForms.Enums.ControlBoxType.MinimizeBox;
            this.MinButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.MinButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.MinButton.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.MinButton.IconColor = System.Drawing.SystemColors.ButtonFace;
            this.MinButton.Location = new System.Drawing.Point(935, 5);
            this.MinButton.MaximumSize = new System.Drawing.Size(40, 40);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(30, 30);
            this.MinButton.TabIndex = 5;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButton
            // 
            this.CloseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.CloseButton.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.CloseButton.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.CloseButton.HoverState.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.CloseButton.IconColor = System.Drawing.Color.White;
            this.CloseButton.Location = new System.Drawing.Point(965, 5);
            this.CloseButton.Name = "CloseButton";
            this.CloseButton.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.CloseButton.Size = new System.Drawing.Size(30, 30);
            this.CloseButton.TabIndex = 4;
            // 
            // ProgramNameLb
            // 
            this.ProgramNameLb.AutoSize = true;
            this.ProgramNameLb.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ProgramNameLb.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.ProgramNameLb.Location = new System.Drawing.Point(46, -8);
            this.ProgramNameLb.Name = "ProgramNameLb";
            this.ProgramNameLb.Padding = new System.Windows.Forms.Padding(0, 10, 0, 0);
            this.ProgramNameLb.Size = new System.Drawing.Size(309, 47);
            this.ProgramNameLb.TabIndex = 3;
            this.ProgramNameLb.Text = "KeyAuth Admin Panel";
            // 
            // MainGroupB
            // 
            this.MainGroupB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.MainGroupB.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.MainGroupB.BorderRadius = 10;
            this.MainGroupB.BorderThickness = 2;
            this.MainGroupB.Controls.Add(this.HomeViewSb);
            this.MainGroupB.Controls.Add(this.AppLayOutFp);
            this.MainGroupB.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainGroupB.Font = new System.Drawing.Font("Segoe UI", 5.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainGroupB.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.MainGroupB.LabelAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.MainGroupB.LabelIndent = 0;
            this.MainGroupB.LineStyle = Bunifu.UI.WinForms.BunifuGroupBox.LineStyles.Solid;
            this.MainGroupB.Location = new System.Drawing.Point(10, 45);
            this.MainGroupB.Margin = new System.Windows.Forms.Padding(0);
            this.MainGroupB.Name = "MainGroupB";
            this.MainGroupB.Padding = new System.Windows.Forms.Padding(10, 0, 10, 15);
            this.MainGroupB.Size = new System.Drawing.Size(980, 395);
            this.MainGroupB.TabIndex = 42;
            this.MainGroupB.TabStop = false;
            // 
            // HomeViewSb
            // 
            this.HomeViewSb.AllowCursorChanges = true;
            this.HomeViewSb.AllowHomeEndKeysDetection = false;
            this.HomeViewSb.AllowIncrementalClickMoves = true;
            this.HomeViewSb.AllowMouseDownEffects = true;
            this.HomeViewSb.AllowMouseHoverEffects = true;
            this.HomeViewSb.AllowScrollingAnimations = true;
            this.HomeViewSb.AllowScrollKeysDetection = true;
            this.HomeViewSb.AllowScrollOptionsMenu = true;
            this.HomeViewSb.AllowShrinkingOnFocusLost = false;
            this.HomeViewSb.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.HomeViewSb.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("HomeViewSb.BackgroundImage")));
            this.HomeViewSb.BindingContainer = this.AppLayOutFp;
            this.HomeViewSb.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.HomeViewSb.BorderRadius = 14;
            this.HomeViewSb.BorderThickness = 1;
            this.HomeViewSb.Dock = System.Windows.Forms.DockStyle.Right;
            this.HomeViewSb.DurationBeforeShrink = 2000;
            this.HomeViewSb.LargeChange = 10;
            this.HomeViewSb.Location = new System.Drawing.Point(954, 10);
            this.HomeViewSb.Margin = new System.Windows.Forms.Padding(13, 16, 13, 16);
            this.HomeViewSb.Maximum = 100;
            this.HomeViewSb.Minimum = 0;
            this.HomeViewSb.MinimumThumbLength = 18;
            this.HomeViewSb.Name = "HomeViewSb";
            this.HomeViewSb.OnDisable.ScrollBarBorderColor = System.Drawing.Color.Silver;
            this.HomeViewSb.OnDisable.ScrollBarColor = System.Drawing.Color.Transparent;
            this.HomeViewSb.OnDisable.ThumbColor = System.Drawing.Color.Silver;
            this.HomeViewSb.ScrollBarBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(127)))), ((int)(((byte)(243)))));
            this.HomeViewSb.ScrollBarColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(39)))), ((int)(((byte)(42)))));
            this.HomeViewSb.ShrinkSizeLimit = 3;
            this.HomeViewSb.Size = new System.Drawing.Size(16, 370);
            this.HomeViewSb.SmallChange = 1;
            this.HomeViewSb.TabIndex = 0;
            this.HomeViewSb.ThumbColor = System.Drawing.SystemColors.ButtonFace;
            this.HomeViewSb.ThumbLength = 36;
            this.HomeViewSb.ThumbMargin = 0;
            this.HomeViewSb.ThumbStyle = Bunifu.UI.WinForms.BunifuVScrollBar.ThumbStyles.Proportional;
            this.HomeViewSb.Value = 0;
            // 
            // AppLayOutFp
            // 
            this.AppLayOutFp.AllowDrop = true;
            this.AppLayOutFp.AutoSize = true;
            this.AppLayOutFp.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AppLayOutFp.Location = new System.Drawing.Point(10, 10);
            this.AppLayOutFp.Name = "AppLayOutFp";
            this.AppLayOutFp.Size = new System.Drawing.Size(960, 370);
            this.AppLayOutFp.TabIndex = 0;
            // 
            // RightPn
            // 
            this.RightPn.BackgroundColor = System.Drawing.Color.Transparent;
            this.RightPn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("RightPn.BackgroundImage")));
            this.RightPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.RightPn.BorderColor = System.Drawing.Color.Transparent;
            this.RightPn.BorderRadius = 3;
            this.RightPn.BorderThickness = 1;
            this.RightPn.Dock = System.Windows.Forms.DockStyle.Right;
            this.RightPn.Location = new System.Drawing.Point(990, 45);
            this.RightPn.Name = "RightPn";
            this.RightPn.ShowBorders = true;
            this.RightPn.Size = new System.Drawing.Size(10, 395);
            this.RightPn.TabIndex = 41;
            // 
            // LeftPn
            // 
            this.LeftPn.BackgroundColor = System.Drawing.Color.Transparent;
            this.LeftPn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("LeftPn.BackgroundImage")));
            this.LeftPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.LeftPn.BorderColor = System.Drawing.Color.Transparent;
            this.LeftPn.BorderRadius = 3;
            this.LeftPn.BorderThickness = 1;
            this.LeftPn.Dock = System.Windows.Forms.DockStyle.Left;
            this.LeftPn.Location = new System.Drawing.Point(0, 45);
            this.LeftPn.Name = "LeftPn";
            this.LeftPn.ShowBorders = true;
            this.LeftPn.Size = new System.Drawing.Size(10, 395);
            this.LeftPn.TabIndex = 40;
            // 
            // BottomPn
            // 
            this.BottomPn.BackgroundColor = System.Drawing.Color.Transparent;
            this.BottomPn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("BottomPn.BackgroundImage")));
            this.BottomPn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BottomPn.BorderColor = System.Drawing.Color.Transparent;
            this.BottomPn.BorderRadius = 3;
            this.BottomPn.BorderThickness = 1;
            this.BottomPn.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BottomPn.Location = new System.Drawing.Point(0, 440);
            this.BottomPn.Name = "BottomPn";
            this.BottomPn.ShowBorders = true;
            this.BottomPn.Size = new System.Drawing.Size(1000, 10);
            this.BottomPn.TabIndex = 41;
            // 
            // HomeView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(24)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(1000, 450);
            this.Controls.Add(this.MainGroupB);
            this.Controls.Add(this.RightPn);
            this.Controls.Add(this.LeftPn);
            this.Controls.Add(this.TitlePanel);
            this.Controls.Add(this.BottomPn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HomeView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "KeyAuth Seller Panel";
            this.Load += new System.EventHandler(this.HomeView_Load);
            this.TitlePanel.ResumeLayout(false);
            this.TitlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.KeyAuthLogoPb)).EndInit();
            this.MainGroupB.ResumeLayout(false);
            this.MainGroupB.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Bunifu.Framework.UI.BunifuElipse HomeViewElipse;
        private Bunifu.UI.WinForms.BunifuPanel TitlePanel;
        private Guna.UI2.WinForms.Guna2ControlBox MinButton;
        private Guna.UI2.WinForms.Guna2ControlBox CloseButton;
        private Bunifu.Framework.UI.BunifuDragControl HomeViewDragControl;
        private Bunifu.UI.WinForms.BunifuPanel LeftPn;
        private Bunifu.UI.WinForms.BunifuPanel RightPn;
        private Bunifu.UI.WinForms.BunifuPanel BottomPn;
        private Bunifu.UI.WinForms.BunifuGroupBox MainGroupB;
        private Bunifu.UI.WinForms.BunifuVScrollBar HomeViewSb;
        private System.Windows.Forms.FlowLayoutPanel AppLayOutFp;
        private System.Windows.Forms.Label ProgramNameLb;
        private Bunifu.UI.WinForms.BunifuPictureBox KeyAuthLogoPb;
    }
}

