namespace ZCXJ_CS.Presentation
{
    partial class FormMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.staStripMain = new System.Windows.Forms.StatusStrip();
            this.staStripShowOutWnd = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripX1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripNote = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripTest2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripX2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblLoginUser = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripTime = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.staStripVersion = new System.Windows.Forms.ToolStripStatusLabel();
            this.CenterImage = new System.Windows.Forms.ToolStripStatusLabel();
            this.timerMain = new System.Windows.Forms.Timer(this.components);
            this.toolTipInfo = new System.Windows.Forms.ToolTip(this.components);
            this.tabPageLog = new CCWin.SkinControl.SkinTabPage();
            this.rtbLog = new System.Windows.Forms.RichTextBox();
            this.tabCtrlBottom = new CCWin.SkinControl.SkinTabControl();
            this.tabCtrlMain = new CCWin.SkinControl.SkinTabControl();
            this.LogPage = new CCWin.SkinControl.SkinTabPage();
            this.logText = new System.Windows.Forms.Label();
            this.LogPictruce = new System.Windows.Forms.PictureBox();
            this.miniToolStrip = new System.Windows.Forms.ToolStrip();
            this.MainSplit = new System.Windows.Forms.SplitContainer();
            this.tsMainTop = new System.Windows.Forms.ToolStrip();
            this.staStripMain.SuspendLayout();
            this.tabPageLog.SuspendLayout();
            this.tabCtrlBottom.SuspendLayout();
            this.tabCtrlMain.SuspendLayout();
            this.LogPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.LogPictruce)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).BeginInit();
            this.MainSplit.Panel1.SuspendLayout();
            this.MainSplit.Panel2.SuspendLayout();
            this.MainSplit.SuspendLayout();
            this.SuspendLayout();
            // 
            // staStripMain
            // 
            this.staStripMain.BackColor = System.Drawing.Color.Transparent;
            this.staStripMain.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.staStripShowOutWnd,
            this.staStripX1,
            this.staStripNote,
            this.staStripTest2,
            this.staStripX2,
            this.lblLoginUser,
            this.staStripTime,
            this.toolStripStatusLabel1,
            this.staStripVersion,
            this.CenterImage});
            this.staStripMain.Location = new System.Drawing.Point(6, 620);
            this.staStripMain.Name = "staStripMain";
            this.staStripMain.Padding = new System.Windows.Forms.Padding(1, 0, 12, 0);
            this.staStripMain.Size = new System.Drawing.Size(886, 28);
            this.staStripMain.TabIndex = 1;
            // 
            // staStripShowOutWnd
            // 
            this.staStripShowOutWnd.ForeColor = System.Drawing.Color.Black;
            this.staStripShowOutWnd.Name = "staStripShowOutWnd";
            this.staStripShowOutWnd.Size = new System.Drawing.Size(83, 23);
            this.staStripShowOutWnd.Text = " ↑ [条码-日志]";
            this.staStripShowOutWnd.Click += new System.EventHandler(this.staStripShowOutWnd_Click);
            // 
            // staStripX1
            // 
            this.staStripX1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.staStripX1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.staStripX1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.staStripX1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripX1.Name = "staStripX1";
            this.staStripX1.Size = new System.Drawing.Size(16, 23);
            this.staStripX1.Text = " ";
            // 
            // staStripNote
            // 
            this.staStripNote.AutoSize = false;
            this.staStripNote.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripNote.ForeColor = System.Drawing.Color.Black;
            this.staStripNote.Name = "staStripNote";
            this.staStripNote.Size = new System.Drawing.Size(550, 23);
            this.staStripNote.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.staStripNote.Click += new System.EventHandler(this.staStripNote_Click);
            // 
            // staStripTest2
            // 
            this.staStripTest2.ForeColor = System.Drawing.Color.Black;
            this.staStripTest2.Name = "staStripTest2";
            this.staStripTest2.Size = new System.Drawing.Size(17, 23);
            this.staStripTest2.Text = "...";
            this.staStripTest2.Click += new System.EventHandler(this.staStripTest2_Click);
            // 
            // staStripX2
            // 
            this.staStripX2.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.staStripX2.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.staStripX2.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.staStripX2.Enabled = false;
            this.staStripX2.Font = new System.Drawing.Font("微软雅黑", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.staStripX2.Name = "staStripX2";
            this.staStripX2.Size = new System.Drawing.Size(17, 23);
            this.staStripX2.Text = " ";
            // 
            // lblLoginUser
            // 
            this.lblLoginUser.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.lblLoginUser.ForeColor = System.Drawing.Color.White;
            this.lblLoginUser.Name = "lblLoginUser";
            this.lblLoginUser.Size = new System.Drawing.Size(0, 23);
            // 
            // staStripTime
            // 
            this.staStripTime.ForeColor = System.Drawing.Color.Black;
            this.staStripTime.Name = "staStripTime";
            this.staStripTime.Size = new System.Drawing.Size(130, 23);
            this.staStripTime.Spring = true;
            this.staStripTime.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.BorderSides = System.Windows.Forms.ToolStripStatusLabelBorderSides.Right;
            this.toolStripStatusLabel1.BorderStyle = System.Windows.Forms.Border3DStyle.Etched;
            this.toolStripStatusLabel1.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.toolStripStatusLabel1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(16, 23);
            this.toolStripStatusLabel1.Text = " ";
            this.toolStripStatusLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // staStripVersion
            // 
            this.staStripVersion.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.staStripVersion.ForeColor = System.Drawing.Color.Black;
            this.staStripVersion.Name = "staStripVersion";
            this.staStripVersion.Size = new System.Drawing.Size(44, 23);
            this.staStripVersion.Text = "版本：";
            // 
            // CenterImage
            // 
            this.CenterImage.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.CenterImage.Name = "CenterImage";
            this.CenterImage.Size = new System.Drawing.Size(0, 23);
            this.CenterImage.Text = "toolStripStatusLabel2";
            // 
            // timerMain
            // 
            this.timerMain.Enabled = true;
            this.timerMain.Interval = 1000;
            this.timerMain.Tick += new System.EventHandler(this.timerMain_Tick);
            // 
            // tabPageLog
            // 
            this.tabPageLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.tabPageLog.Controls.Add(this.rtbLog);
            this.tabPageLog.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabPageLog.Location = new System.Drawing.Point(0, 0);
            this.tabPageLog.Margin = new System.Windows.Forms.Padding(0);
            this.tabPageLog.Name = "tabPageLog";
            this.tabPageLog.Size = new System.Drawing.Size(886, 177);
            this.tabPageLog.TabIndex = 0;
            this.tabPageLog.TabItemImage = null;
            // 
            // rtbLog
            // 
            this.rtbLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtbLog.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.rtbLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.rtbLog.ForeColor = System.Drawing.Color.Yellow;
            this.rtbLog.Location = new System.Drawing.Point(2, 3);
            this.rtbLog.Name = "rtbLog";
            this.rtbLog.ReadOnly = true;
            this.rtbLog.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.Vertical;
            this.rtbLog.Size = new System.Drawing.Size(874, 166);
            this.rtbLog.TabIndex = 0;
            this.rtbLog.Text = "";
            // 
            // tabCtrlBottom
            // 
            this.tabCtrlBottom.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrlBottom.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabCtrlBottom.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabCtrlBottom.Controls.Add(this.tabPageLog);
            this.tabCtrlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tabCtrlBottom.HeadBack = null;
            this.tabCtrlBottom.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabCtrlBottom.ItemSize = new System.Drawing.Size(0, 1);
            this.tabCtrlBottom.Location = new System.Drawing.Point(6, 442);
            this.tabCtrlBottom.Margin = new System.Windows.Forms.Padding(0);
            this.tabCtrlBottom.Multiline = true;
            this.tabCtrlBottom.Name = "tabCtrlBottom";
            this.tabCtrlBottom.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabCtrlBottom.PageArrowDown")));
            this.tabCtrlBottom.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabCtrlBottom.PageArrowHover")));
            this.tabCtrlBottom.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabCtrlBottom.PageCloseHover")));
            this.tabCtrlBottom.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabCtrlBottom.PageCloseNormal")));
            this.tabCtrlBottom.PageDown = ((System.Drawing.Image)(resources.GetObject("tabCtrlBottom.PageDown")));
            this.tabCtrlBottom.PageHover = ((System.Drawing.Image)(resources.GetObject("tabCtrlBottom.PageHover")));
            this.tabCtrlBottom.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabCtrlBottom.PageNorml = null;
            this.tabCtrlBottom.SelectedIndex = 0;
            this.tabCtrlBottom.Size = new System.Drawing.Size(886, 178);
            this.tabCtrlBottom.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrlBottom.TabIndex = 3;
            // 
            // tabCtrlMain
            // 
            this.tabCtrlMain.Alignment = System.Windows.Forms.TabAlignment.Bottom;
            this.tabCtrlMain.AnimatorType = CCWin.SkinControl.AnimationType.HorizSlide;
            this.tabCtrlMain.CloseRect = new System.Drawing.Rectangle(2, 2, 12, 12);
            this.tabCtrlMain.Controls.Add(this.LogPage);
            this.tabCtrlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabCtrlMain.HeadBack = null;
            this.tabCtrlMain.ImgTxtOffset = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.ItemSize = new System.Drawing.Size(1, 0);
            this.tabCtrlMain.Location = new System.Drawing.Point(0, 0);
            this.tabCtrlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabCtrlMain.Name = "tabCtrlMain";
            this.tabCtrlMain.PageArrowDown = ((System.Drawing.Image)(resources.GetObject("tabCtrlMain.PageArrowDown")));
            this.tabCtrlMain.PageArrowHover = ((System.Drawing.Image)(resources.GetObject("tabCtrlMain.PageArrowHover")));
            this.tabCtrlMain.PageCloseHover = ((System.Drawing.Image)(resources.GetObject("tabCtrlMain.PageCloseHover")));
            this.tabCtrlMain.PageCloseNormal = ((System.Drawing.Image)(resources.GetObject("tabCtrlMain.PageCloseNormal")));
            this.tabCtrlMain.PageDown = ((System.Drawing.Image)(resources.GetObject("tabCtrlMain.PageDown")));
            this.tabCtrlMain.PageHover = ((System.Drawing.Image)(resources.GetObject("tabCtrlMain.PageHover")));
            this.tabCtrlMain.PageImagePosition = CCWin.SkinControl.SkinTabControl.ePageImagePosition.Left;
            this.tabCtrlMain.PageNorml = null;
            this.tabCtrlMain.SelectedIndex = 0;
            this.tabCtrlMain.Size = new System.Drawing.Size(886, 618);
            this.tabCtrlMain.SizeMode = System.Windows.Forms.TabSizeMode.Fixed;
            this.tabCtrlMain.TabIndex = 2;
            this.tabCtrlMain.SizeChanged += new System.EventHandler(this.tabCtrlMain_SizeChanged);
            // 
            // LogPage
            // 
            this.LogPage.BackColor = System.Drawing.SystemColors.Control;
            this.LogPage.Controls.Add(this.logText);
            this.LogPage.Controls.Add(this.LogPictruce);
            this.LogPage.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LogPage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(44)))), ((int)(((byte)(44)))), ((int)(((byte)(44)))));
            this.LogPage.Location = new System.Drawing.Point(0, 0);
            this.LogPage.Margin = new System.Windows.Forms.Padding(0);
            this.LogPage.Name = "LogPage";
            this.LogPage.Size = new System.Drawing.Size(886, 596);
            this.LogPage.TabIndex = 0;
            this.LogPage.TabItemImage = null;
            // 
            // logText
            // 
            this.logText.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.logText.Font = new System.Drawing.Font("微软雅黑", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.logText.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.logText.Location = new System.Drawing.Point(176, 396);
            this.logText.Name = "logText";
            this.logText.Size = new System.Drawing.Size(494, 132);
            this.logText.TabIndex = 1;
            this.logText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LogPictruce
            // 
            this.LogPictruce.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.LogPictruce.BackColor = System.Drawing.Color.Transparent;
            this.LogPictruce.Location = new System.Drawing.Point(242, 34);
            this.LogPictruce.Name = "LogPictruce";
            this.LogPictruce.Size = new System.Drawing.Size(350, 358);
            this.LogPictruce.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.LogPictruce.TabIndex = 0;
            this.LogPictruce.TabStop = false;
            // 
            // miniToolStrip
            // 
            this.miniToolStrip.AutoSize = false;
            this.miniToolStrip.CanOverflow = false;
            this.miniToolStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.miniToolStrip.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.miniToolStrip.Location = new System.Drawing.Point(9, 25);
            this.miniToolStrip.Name = "miniToolStrip";
            this.miniToolStrip.Size = new System.Drawing.Size(784, 70);
            this.miniToolStrip.TabIndex = 5;
            // 
            // MainSplit
            // 
            this.MainSplit.BackColor = System.Drawing.Color.Transparent;
            this.MainSplit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainSplit.Location = new System.Drawing.Point(6, 30);
            this.MainSplit.Margin = new System.Windows.Forms.Padding(0);
            this.MainSplit.Name = "MainSplit";
            this.MainSplit.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // MainSplit.Panel1
            // 
            this.MainSplit.Panel1.Controls.Add(this.tsMainTop);
            this.MainSplit.Panel1Collapsed = true;
            this.MainSplit.Panel1MinSize = 1;
            // 
            // MainSplit.Panel2
            // 
            this.MainSplit.Panel2.Controls.Add(this.tabCtrlMain);
            this.MainSplit.Size = new System.Drawing.Size(886, 618);
            this.MainSplit.SplitterDistance = 70;
            this.MainSplit.SplitterWidth = 1;
            this.MainSplit.TabIndex = 5;
            this.MainSplit.TabStop = false;
            // 
            // tsMainTop
            // 
            this.tsMainTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tsMainTop.Location = new System.Drawing.Point(0, 0);
            this.tsMainTop.Name = "tsMainTop";
            this.tsMainTop.Size = new System.Drawing.Size(150, 70);
            this.tsMainTop.TabIndex = 6;
            this.tsMainTop.Text = "toolStrip2";
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnablePreventFocusChange;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.CaptionFont = new System.Drawing.Font("微软雅黑", 10F);
            this.ClientSize = new System.Drawing.Size(898, 654);
            this.Controls.Add(this.tabCtrlBottom);
            this.Controls.Add(this.staStripMain);
            this.Controls.Add(this.MainSplit);
            this.EffectWidth = 2;
            this.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.ICoOffset = new System.Drawing.Point(2, 0);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(896, 650);
            this.Name = "FormMain";
            this.Padding = new System.Windows.Forms.Padding(2, 0, 2, 2);
            this.Radius = 2;
            this.ShadowRectangle = new System.Drawing.Rectangle(5, 5, 5, 5);
            this.ShadowWidth = 1;
            this.ShowBorder = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "主框架窗口";
            this.TitleCenter = false;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormMain_FormClosing);
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.staStripMain.ResumeLayout(false);
            this.staStripMain.PerformLayout();
            this.tabPageLog.ResumeLayout(false);
            this.tabCtrlBottom.ResumeLayout(false);
            this.tabCtrlMain.ResumeLayout(false);
            this.LogPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.LogPictruce)).EndInit();
            this.MainSplit.Panel1.ResumeLayout(false);
            this.MainSplit.Panel1.PerformLayout();
            this.MainSplit.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MainSplit)).EndInit();
            this.MainSplit.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip staStripMain;
        private System.Windows.Forms.ToolStripStatusLabel staStripNote;
        private System.Windows.Forms.ToolStripStatusLabel staStripX1;
        private System.Windows.Forms.ToolStripStatusLabel staStripShowOutWnd;
        private System.Windows.Forms.ToolStripStatusLabel staStripX2;
        private System.Windows.Forms.ToolStripStatusLabel staStripTest2;
        private System.Windows.Forms.ToolStripStatusLabel staStripTime;
        private System.Windows.Forms.Timer timerMain;
        private System.Windows.Forms.ToolStripStatusLabel staStripVersion;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolTip toolTipInfo;
        private System.Windows.Forms.ToolStripStatusLabel lblLoginUser;
        private System.Windows.Forms.ToolStripStatusLabel CenterImage;
        private CCWin.SkinControl.SkinTabPage tabPageLog;
        private CCWin.SkinControl.SkinTabControl tabCtrlBottom; 
        private CCWin.SkinControl.SkinTabControl tabCtrlMain;
        private CCWin.SkinControl.SkinTabPage LogPage;
        private System.Windows.Forms.Label logText;
        private System.Windows.Forms.PictureBox LogPictruce;
        private System.Windows.Forms.ToolStrip miniToolStrip;
        private System.Windows.Forms.SplitContainer MainSplit;
        private System.Windows.Forms.RichTextBox rtbLog;
        private System.Windows.Forms.ToolStrip tsMainTop;
    }
}

