

using CCWin.SkinControl;
using System;

namespace ZCXJ_CS.UI
{
    partial class FormPrint
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.timerPrint = new System.Windows.Forms.Timer(this.components);
            this.skinPanel1 = new CCWin.SkinControl.SkinPanel();
            this.txbBoxID = new MetroFramework.Controls.MetroTextBox();
            this.cmbWO = new MetroFramework.Controls.MetroComboBox();
            this.btnCancel = new MetroFramework.Controls.MetroButtonStyled();
            this.btnOK = new MetroFramework.Controls.MetroButtonStyled();
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.lblCountU = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.lblCountP = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.lblCount = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.picBox = new CCWin.SkinControl.SkinPictureBox();
            this.dgvList = new CCWin.SkinControl.SkinDataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.彩盒工单 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.属性 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.描述 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblSNC = new CCWin.SkinControl.SkinLabel();
            this.skinLine2 = new CCWin.SkinControl.SkinLine();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.lblInfo = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.skinPanel4.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.skinPanel3.SuspendLayout();
            this.skinPanel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timerPrint
            // 
            this.timerPrint.Enabled = true;
            this.timerPrint.Interval = 2000;
            this.timerPrint.Tick += new System.EventHandler(this.timerPrint_Tick);
            // 
            // skinPanel1
            // 
            this.skinPanel1.BackColor = System.Drawing.Color.White;
            this.skinPanel1.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinPanel1.Controls.Add(this.txbBoxID);
            this.skinPanel1.Controls.Add(this.cmbWO);
            this.skinPanel1.Controls.Add(this.btnCancel);
            this.skinPanel1.Controls.Add(this.btnOK);
            this.skinPanel1.Controls.Add(this.skinPanel4);
            this.skinPanel1.Controls.Add(this.skinGroupBox1);
            this.skinPanel1.Controls.Add(this.dgvList);
            this.skinPanel1.Controls.Add(this.lblSNC);
            this.skinPanel1.Controls.Add(this.skinLine2);
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.skinLabel2);
            this.skinPanel1.Controls.Add(this.skinLine1);
            this.skinPanel1.Controls.Add(this.skinPanel2);
            this.skinPanel1.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinPanel1.DownBack = null;
            this.skinPanel1.Location = new System.Drawing.Point(0, 0);
            this.skinPanel1.MouseBack = null;
            this.skinPanel1.Name = "skinPanel1";
            this.skinPanel1.NormlBack = null;
            this.skinPanel1.Size = new System.Drawing.Size(1135, 506);
            this.skinPanel1.TabIndex = 0;
            // 
            // txbBoxID
            // 
            this.txbBoxID.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.txbBoxID.FontSize = MetroFramework.MetroTextBoxSize.Medium;
            this.txbBoxID.FontWeight = MetroFramework.MetroTextBoxWeight.Bold;
            this.txbBoxID.Lines = new string[] {
        "BOX0987652394"};
            this.txbBoxID.Location = new System.Drawing.Point(100, 80);
            this.txbBoxID.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.txbBoxID.MaxLength = 32767;
            this.txbBoxID.Name = "txbBoxID";
            this.txbBoxID.Padding = new System.Windows.Forms.Padding(0, 2, 0, 0);
            this.txbBoxID.PasswordChar = '\0';
            this.txbBoxID.ReadOnly = true;
            this.txbBoxID.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbBoxID.SelectedText = "";
            this.txbBoxID.Size = new System.Drawing.Size(306, 29);
            this.txbBoxID.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbBoxID.StyleManager = null;
            this.txbBoxID.TabIndex = 72;
            this.txbBoxID.Text = "BOX0987652394";
            this.txbBoxID.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbBoxID.UseSelectable = true;
            this.txbBoxID.TextChanged += new System.EventHandler(this.txbBoxID_TextChanged);
            // 
            // cmbWO
            // 
            this.cmbWO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWO.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbWO.FontSize = MetroFramework.MetroLinkSize.Medium;
            this.cmbWO.FontWeight = MetroFramework.MetroLinkWeight.Regular;
            this.cmbWO.ItemHeight = 23;
            this.cmbWO.Location = new System.Drawing.Point(100, 45);
            this.cmbWO.Name = "cmbWO";
            this.cmbWO.Size = new System.Drawing.Size(307, 29);
            this.cmbWO.Style = MetroFramework.MetroColorStyle.Blue;
            this.cmbWO.StyleManager = null;
            this.cmbWO.TabIndex = 71;
            this.cmbWO.Theme = MetroFramework.MetroThemeStyle.Light;
            this.cmbWO.DropDownClosed += new System.EventHandler(this.cmbWO_DropDownClosed);
            // 
            // btnCancel
            // 
            this.btnCancel.Enabled = false;
            this.btnCancel.FlatAppearance = false;
            this.btnCancel.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnCancel.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnCancel.Highlight = false;
            this.btnCancel.Location = new System.Drawing.Point(511, 46);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(92, 26);
            this.btnCancel.Style = MetroFramework.MetroColorStyle.Default;
            this.btnCancel.StyleManager = null;
            this.btnCancel.TabIndex = 70;
            this.btnCancel.Text = "取消";
            this.btnCancel.Theme = MetroFramework.MetroThemeStyle.Default;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.FlatAppearance = false;
            this.btnOK.FontSize = MetroFramework.MetroButtonSize.Medium;
            this.btnOK.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnOK.Highlight = false;
            this.btnOK.Location = new System.Drawing.Point(413, 46);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(92, 26);
            this.btnOK.Style = MetroFramework.MetroColorStyle.Default;
            this.btnOK.StyleManager = null;
            this.btnOK.TabIndex = 69;
            this.btnOK.Text = "确认";
            this.btnOK.Theme = MetroFramework.MetroThemeStyle.Default;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // skinPanel4
            // 
            this.skinPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel4.Controls.Add(this.skinLabel11);
            this.skinPanel4.Controls.Add(this.lblCountU);
            this.skinPanel4.Controls.Add(this.skinLabel9);
            this.skinPanel4.Controls.Add(this.lblCountP);
            this.skinPanel4.Controls.Add(this.skinLabel7);
            this.skinPanel4.Controls.Add(this.lblCount);
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(12, 142);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Size = new System.Drawing.Size(1111, 34);
            this.skinPanel4.TabIndex = 68;
            // 
            // skinLabel11
            // 
            this.skinLabel11.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel11.AutoSize = true;
            this.skinLabel11.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel11.BorderColor = System.Drawing.Color.White;
            this.skinLabel11.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel11.Location = new System.Drawing.Point(348, 7);
            this.skinLabel11.Name = "skinLabel11";
            this.skinLabel11.Size = new System.Drawing.Size(79, 20);
            this.skinLabel11.TabIndex = 20;
            this.skinLabel11.Text = "未生产数：";
            // 
            // lblCountU
            // 
            this.lblCountU.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblCountU.AutoSize = true;
            this.lblCountU.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCountU.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblCountU.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCountU.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblCountU.Location = new System.Drawing.Point(428, 6);
            this.lblCountU.Name = "lblCountU";
            this.lblCountU.Size = new System.Drawing.Size(20, 22);
            this.lblCountU.TabIndex = 19;
            this.lblCountU.Text = "0";
            // 
            // skinLabel9
            // 
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel9.Location = new System.Drawing.Point(177, 7);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(79, 20);
            this.skinLabel9.TabIndex = 18;
            this.skinLabel9.Text = "已生产数：";
            // 
            // lblCountP
            // 
            this.lblCountP.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblCountP.AutoSize = true;
            this.lblCountP.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCountP.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblCountP.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCountP.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblCountP.Location = new System.Drawing.Point(258, 6);
            this.lblCountP.Name = "lblCountP";
            this.lblCountP.Size = new System.Drawing.Size(20, 22);
            this.lblCountP.TabIndex = 17;
            this.lblCountP.Text = "0";
            // 
            // skinLabel7
            // 
            this.skinLabel7.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel7.AutoSize = true;
            this.skinLabel7.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel7.BorderColor = System.Drawing.Color.White;
            this.skinLabel7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel7.Location = new System.Drawing.Point(7, 7);
            this.skinLabel7.Name = "skinLabel7";
            this.skinLabel7.Size = new System.Drawing.Size(79, 20);
            this.skinLabel7.TabIndex = 16;
            this.skinLabel7.Text = "工单总数：";
            // 
            // lblCount
            // 
            this.lblCount.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblCount.AutoSize = true;
            this.lblCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblCount.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblCount.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.lblCount.Location = new System.Drawing.Point(96, 6);
            this.lblCount.Name = "lblCount";
            this.lblCount.Size = new System.Drawing.Size(20, 22);
            this.lblCount.TabIndex = 15;
            this.lblCount.Text = "0";
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinGroupBox1.Controls.Add(this.picBox);
            this.skinGroupBox1.Font = new System.Drawing.Font("微软雅黑", 9F);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Gray;
            this.skinGroupBox1.Location = new System.Drawing.Point(12, 263);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinGroupBox1.Size = new System.Drawing.Size(1111, 231);
            this.skinGroupBox1.TabIndex = 67;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "彩盒封面";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.TitleRoundStyle = CCWin.SkinClass.RoundStyle.All;
            // 
            // picBox
            // 
            this.picBox.BackColor = System.Drawing.Color.Transparent;
            this.picBox.Dock = System.Windows.Forms.DockStyle.Fill;
            this.picBox.Location = new System.Drawing.Point(3, 19);
            this.picBox.Name = "picBox";
            this.picBox.Size = new System.Drawing.Size(1105, 209);
            this.picBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.picBox.TabIndex = 0;
            this.picBox.TabStop = false;
            // 
            // dgvList
            // 
            this.dgvList.AllowUserToAddRows = false;
            this.dgvList.AllowUserToDeleteRows = false;
            this.dgvList.AllowUserToResizeRows = false;
            this.dgvList.AlternatingCellBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgvList.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvList.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvList.BackgroundColor = System.Drawing.Color.White;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.dgvList.ColumnFont = null;
            this.dgvList.ColumnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.dgvList.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgvList.ColumnHeadersHeight = 36;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.彩盒工单,
            this.类型,
            this.属性,
            this.描述});
            this.dgvList.ColumnSelectBackColor = System.Drawing.Color.White;
            this.dgvList.ColumnSelectForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgvList.EnableHeadersVisualStyles = false;
            this.dgvList.Font = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.dgvList.GridColor = System.Drawing.Color.LightGray;
            this.dgvList.HeadFont = new System.Drawing.Font("微软雅黑", 13F, System.Drawing.FontStyle.Bold);
            this.dgvList.HeadForeColor = System.Drawing.Color.White;
            this.dgvList.HeadSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.dgvList.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.dgvList.LineNumberForeColor = System.Drawing.Color.Gray;
            this.dgvList.Location = new System.Drawing.Point(12, 176);
            this.dgvList.MouseCellBackColor = System.Drawing.Color.White;
            this.dgvList.Name = "dgvList";
            this.dgvList.ReadOnly = true;
            this.dgvList.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvList.RowHeadersVisible = false;
            this.dgvList.RowHeadersWidth = 25;
            this.dgvList.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.dgvList.RowTemplate.Height = 48;
            this.dgvList.Size = new System.Drawing.Size(1111, 80);
            this.dgvList.SkinGridColor = System.Drawing.Color.LightGray;
            this.dgvList.TabIndex = 66;
            this.dgvList.TitleBack = null;
            this.dgvList.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.dgvList.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(200)))), ((int)(((byte)(100)))));
            this.dgvList.SelectionChanged += new System.EventHandler(this.dgvList_SelectionChanged);
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "序号";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // 彩盒工单
            // 
            this.彩盒工单.DataPropertyName = "彩盒工单";
            this.彩盒工单.HeaderText = "彩盒工单";
            this.彩盒工单.Name = "彩盒工单";
            this.彩盒工单.ReadOnly = true;
            // 
            // 类型
            // 
            this.类型.DataPropertyName = "类型";
            this.类型.HeaderText = "类型";
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            // 
            // 属性
            // 
            this.属性.DataPropertyName = "属性";
            this.属性.HeaderText = "属性";
            this.属性.Name = "属性";
            this.属性.ReadOnly = true;
            // 
            // 描述
            // 
            this.描述.DataPropertyName = "描述";
            this.描述.HeaderText = "描述";
            this.描述.Name = "描述";
            this.描述.ReadOnly = true;
            // 
            // lblSNC
            // 
            this.lblSNC.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblSNC.AutoSize = true;
            this.lblSNC.BackColor = System.Drawing.Color.WhiteSmoke;
            this.lblSNC.BorderColor = System.Drawing.Color.Gainsboro;
            this.lblSNC.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSNC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.lblSNC.Location = new System.Drawing.Point(545, 84);
            this.lblSNC.Name = "lblSNC";
            this.lblSNC.Size = new System.Drawing.Size(0, 22);
            this.lblSNC.TabIndex = 10;
            // 
            // skinLine2
            // 
            this.skinLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLine2.BackColor = System.Drawing.Color.Transparent;
            this.skinLine2.LineColor = System.Drawing.Color.Gainsboro;
            this.skinLine2.LineHeight = 1;
            this.skinLine2.Location = new System.Drawing.Point(12, 127);
            this.skinLine2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 3);
            this.skinLine2.Name = "skinLine2";
            this.skinLine2.Size = new System.Drawing.Size(1111, 10);
            this.skinLine2.TabIndex = 8;
            this.skinLine2.Text = "skinLine2";
            // 
            // skinPanel3
            // 
            this.skinPanel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.skinPanel3.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinPanel3.Controls.Add(this.lblInfo);
            this.skinPanel3.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel3.DownBack = null;
            this.skinPanel3.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinPanel3.Location = new System.Drawing.Point(619, 45);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel3.Size = new System.Drawing.Size(513, 64);
            this.skinPanel3.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.BorderColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 12F);
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(7, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(110, 21);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "请选择制令单.";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel4.Location = new System.Drawing.Point(412, 84);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(126, 20);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "产品SN校验结果：";
            // 
            // skinLabel3
            // 
            this.skinLabel3.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel3.AutoSize = true;
            this.skinLabel3.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel3.BorderColor = System.Drawing.Color.White;
            this.skinLabel3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel3.Location = new System.Drawing.Point(12, 84);
            this.skinLabel3.Name = "skinLabel3";
            this.skinLabel3.Size = new System.Drawing.Size(94, 20);
            this.skinLabel3.TabIndex = 3;
            this.skinLabel3.Text = "彩盒ID扫描：";
            this.skinLabel3.DoubleClick += new System.EventHandler(this.skinLabel3_DoubleClick);
            // 
            // skinLabel2
            // 
            this.skinLabel2.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel2.AutoSize = true;
            this.skinLabel2.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel2.BorderColor = System.Drawing.Color.White;
            this.skinLabel2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel2.Location = new System.Drawing.Point(12, 48);
            this.skinLabel2.Name = "skinLabel2";
            this.skinLabel2.Size = new System.Drawing.Size(93, 20);
            this.skinLabel2.TabIndex = 1;
            this.skinLabel2.Text = "选择制令单：";
            // 
            // skinLine1
            // 
            this.skinLine1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLine1.BackColor = System.Drawing.Color.Transparent;
            this.skinLine1.LineColor = System.Drawing.Color.Gainsboro;
            this.skinLine1.LineHeight = 1;
            this.skinLine1.Location = new System.Drawing.Point(3, 39);
            this.skinLine1.Name = "skinLine1";
            this.skinLine1.Size = new System.Drawing.Size(1129, 10);
            this.skinLine1.TabIndex = 1;
            this.skinLine1.Text = "skinLine1";
            // 
            // skinPanel2
            // 
            this.skinPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.skinPanel2.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinPanel2.Controls.Add(this.skinLabel1);
            this.skinPanel2.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel2.DownBack = null;
            this.skinPanel2.Font = new System.Drawing.Font("黑体", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinPanel2.Location = new System.Drawing.Point(4, 4);
            this.skinPanel2.MouseBack = null;
            this.skinPanel2.Name = "skinPanel2";
            this.skinPanel2.NormlBack = null;
            this.skinPanel2.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel2.Size = new System.Drawing.Size(131, 33);
            this.skinPanel2.TabIndex = 0;
            // 
            // skinLabel1
            // 
            this.skinLabel1.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel1.AutoSize = true;
            this.skinLabel1.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel1.BorderColor = System.Drawing.Color.White;
            this.skinLabel1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel1.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.skinLabel1.Location = new System.Drawing.Point(28, 7);
            this.skinLabel1.Name = "skinLabel1";
            this.skinLabel1.Size = new System.Drawing.Size(74, 21);
            this.skinLabel1.TabIndex = 0;
            this.skinLabel1.Text = "彩盒上料";
            this.skinLabel1.DoubleClick += new System.EventHandler(this.skinLabel1_DoubleClick);
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1135, 506);
            this.Controls.Add(this.skinPanel1);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            this.skinPanel1.ResumeLayout(false);
            this.skinPanel1.PerformLayout();
            this.skinPanel4.ResumeLayout(false);
            this.skinPanel4.PerformLayout();
            this.skinGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.skinPanel3.ResumeLayout(false);
            this.skinPanel3.PerformLayout();
            this.skinPanel2.ResumeLayout(false);
            this.skinPanel2.PerformLayout();
            this.ResumeLayout(false);

        }

        

        #endregion
        private System.Windows.Forms.Timer timerPrint;
        private CCWin.SkinControl.SkinPanel skinPanel1;
        private CCWin.SkinControl.SkinPanel skinPanel2;
        private CCWin.SkinControl.SkinLabel skinLabel1;
        private CCWin.SkinControl.SkinLine skinLine1;
        private CCWin.SkinControl.SkinLabel skinLabel2;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinLabel lblInfo;
        private CCWin.SkinControl.SkinLine skinLine2;
        private CCWin.SkinControl.SkinLabel lblSNC;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinDataGridView dgvList;
        private CCWin.SkinControl.SkinPictureBox picBox;
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel lblCountU;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel lblCountP;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel lblCount;
        private MetroFramework.Controls.MetroButtonStyled btnOK;
        private MetroFramework.Controls.MetroButtonStyled btnCancel;
        private MetroFramework.Controls.MetroComboBox cmbWO;
        private MetroFramework.Controls.MetroTextBox txbBoxID;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 彩盒工单;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 属性;
        private System.Windows.Forms.DataGridViewTextBoxColumn 描述;
    }
}