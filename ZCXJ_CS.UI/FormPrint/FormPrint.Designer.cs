

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
            this.skinPanel4 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel11 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel12 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel9 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel10 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel7 = new CCWin.SkinControl.SkinLabel();
            this.skinLabel5 = new CCWin.SkinControl.SkinLabel();
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.picBox = new CCWin.SkinControl.SkinPictureBox();
            this.GRD_Lineinfor = new CCWin.SkinControl.SkinDataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.彩盒工单号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.彩盒条码 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.类型 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.属性 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.描述 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.skinLabel8 = new CCWin.SkinControl.SkinLabel();
            this.skinLine2 = new CCWin.SkinControl.SkinLine();
            this.skinPanel3 = new CCWin.SkinControl.SkinPanel();
            this.lblInfo = new CCWin.SkinControl.SkinLabel();
            this.skinLabel4 = new CCWin.SkinControl.SkinLabel();
            this.btnCancel = new CCWin.SkinControl.SkinButton();
            this.btnOK = new CCWin.SkinControl.SkinButton();
            this.skinTextBox1 = new CCWin.SkinControl.SkinTextBox();
            this.skinLabel3 = new CCWin.SkinControl.SkinLabel();
            this.cmbWO = new CCWin.SkinControl.SkinComboBox();
            this.skinLabel2 = new CCWin.SkinControl.SkinLabel();
            this.skinLine1 = new CCWin.SkinControl.SkinLine();
            this.skinPanel2 = new CCWin.SkinControl.SkinPanel();
            this.skinLabel1 = new CCWin.SkinControl.SkinLabel();
            this.skinPanel1.SuspendLayout();
            this.skinPanel4.SuspendLayout();
            this.skinGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Lineinfor)).BeginInit();
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
            this.skinPanel1.Controls.Add(this.skinPanel4);
            this.skinPanel1.Controls.Add(this.skinGroupBox1);
            this.skinPanel1.Controls.Add(this.GRD_Lineinfor);
            this.skinPanel1.Controls.Add(this.skinLabel8);
            this.skinPanel1.Controls.Add(this.skinLine2);
            this.skinPanel1.Controls.Add(this.skinPanel3);
            this.skinPanel1.Controls.Add(this.skinLabel4);
            this.skinPanel1.Controls.Add(this.btnCancel);
            this.skinPanel1.Controls.Add(this.btnOK);
            this.skinPanel1.Controls.Add(this.skinTextBox1);
            this.skinPanel1.Controls.Add(this.skinLabel3);
            this.skinPanel1.Controls.Add(this.cmbWO);
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
            // skinPanel4
            // 
            this.skinPanel4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinPanel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinPanel4.Controls.Add(this.skinLabel11);
            this.skinPanel4.Controls.Add(this.skinLabel12);
            this.skinPanel4.Controls.Add(this.skinLabel9);
            this.skinPanel4.Controls.Add(this.skinLabel10);
            this.skinPanel4.Controls.Add(this.skinLabel7);
            this.skinPanel4.Controls.Add(this.skinLabel5);
            this.skinPanel4.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.skinPanel4.DownBack = null;
            this.skinPanel4.Location = new System.Drawing.Point(13, 136);
            this.skinPanel4.MouseBack = null;
            this.skinPanel4.Name = "skinPanel4";
            this.skinPanel4.NormlBack = null;
            this.skinPanel4.Size = new System.Drawing.Size(1107, 34);
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
            // skinLabel12
            // 
            this.skinLabel12.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel12.AutoSize = true;
            this.skinLabel12.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel12.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinLabel12.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.skinLabel12.Location = new System.Drawing.Point(428, 6);
            this.skinLabel12.Name = "skinLabel12";
            this.skinLabel12.Size = new System.Drawing.Size(40, 22);
            this.skinLabel12.TabIndex = 19;
            this.skinLabel12.Text = "100";
            // 
            // skinLabel9
            // 
            this.skinLabel9.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel9.AutoSize = true;
            this.skinLabel9.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel9.BorderColor = System.Drawing.Color.White;
            this.skinLabel9.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel9.Location = new System.Drawing.Point(178, 7);
            this.skinLabel9.Name = "skinLabel9";
            this.skinLabel9.Size = new System.Drawing.Size(79, 20);
            this.skinLabel9.TabIndex = 18;
            this.skinLabel9.Text = "已生产数：";
            // 
            // skinLabel10
            // 
            this.skinLabel10.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel10.AutoSize = true;
            this.skinLabel10.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel10.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinLabel10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.skinLabel10.Location = new System.Drawing.Point(258, 6);
            this.skinLabel10.Name = "skinLabel10";
            this.skinLabel10.Size = new System.Drawing.Size(40, 22);
            this.skinLabel10.TabIndex = 17;
            this.skinLabel10.Text = "100";
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
            // skinLabel5
            // 
            this.skinLabel5.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel5.AutoSize = true;
            this.skinLabel5.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel5.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinLabel5.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.skinLabel5.Location = new System.Drawing.Point(96, 6);
            this.skinLabel5.Name = "skinLabel5";
            this.skinLabel5.Size = new System.Drawing.Size(40, 22);
            this.skinLabel5.TabIndex = 15;
            this.skinLabel5.Text = "100";
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
            // GRD_Lineinfor
            // 
            this.GRD_Lineinfor.AllowUserToAddRows = false;
            this.GRD_Lineinfor.AllowUserToDeleteRows = false;
            this.GRD_Lineinfor.AllowUserToResizeRows = false;
            this.GRD_Lineinfor.AlternatingCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.GRD_Lineinfor.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.GRD_Lineinfor.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.GRD_Lineinfor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.GRD_Lineinfor.BackgroundColor = System.Drawing.Color.White;
            this.GRD_Lineinfor.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.GRD_Lineinfor.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.GRD_Lineinfor.ColumnFont = null;
            this.GRD_Lineinfor.ColumnForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            this.GRD_Lineinfor.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD_Lineinfor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.GRD_Lineinfor.ColumnHeadersHeight = 32;
            this.GRD_Lineinfor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.GRD_Lineinfor.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.彩盒工单号,
            this.彩盒条码,
            this.类型,
            this.属性,
            this.描述});
            this.GRD_Lineinfor.ColumnSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GRD_Lineinfor.ColumnSelectForeColor = System.Drawing.Color.Empty;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(188)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD_Lineinfor.DefaultCellStyle = dataGridViewCellStyle3;
            this.GRD_Lineinfor.EnableHeadersVisualStyles = false;
            this.GRD_Lineinfor.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F);
            this.GRD_Lineinfor.GridColor = System.Drawing.Color.LightGray;
            this.GRD_Lineinfor.HeadFont = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.GRD_Lineinfor.HeadForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(65)))), ((int)(((byte)(65)))), ((int)(((byte)(65)))));
            this.GRD_Lineinfor.HeadSelectBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.GRD_Lineinfor.HeadSelectForeColor = System.Drawing.SystemColors.HighlightText;
            this.GRD_Lineinfor.LineNumberForeColor = System.Drawing.Color.Gray;
            this.GRD_Lineinfor.Location = new System.Drawing.Point(12, 176);
            this.GRD_Lineinfor.MouseCellBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.GRD_Lineinfor.Name = "GRD_Lineinfor";
            this.GRD_Lineinfor.ReadOnly = true;
            this.GRD_Lineinfor.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.GRD_Lineinfor.RowHeadersVisible = false;
            this.GRD_Lineinfor.RowHeadersWidth = 25;
            this.GRD_Lineinfor.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(45)))), ((int)(((byte)(45)))));
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.GRD_Lineinfor.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.GRD_Lineinfor.RowTemplate.Height = 28;
            this.GRD_Lineinfor.Size = new System.Drawing.Size(1111, 80);
            this.GRD_Lineinfor.SkinGridColor = System.Drawing.Color.LightGray;
            this.GRD_Lineinfor.TabIndex = 66;
            this.GRD_Lineinfor.TitleBack = null;
            this.GRD_Lineinfor.TitleBackColorBegin = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.GRD_Lineinfor.TitleBackColorEnd = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            // 
            // 序号
            // 
            this.序号.FillWeight = 88.13588F;
            this.序号.HeaderText = "序号";
            this.序号.MinimumWidth = 50;
            this.序号.Name = "序号";
            this.序号.ReadOnly = true;
            // 
            // 彩盒工单号
            // 
            this.彩盒工单号.FillWeight = 304.5685F;
            this.彩盒工单号.HeaderText = "彩盒工单号";
            this.彩盒工单号.MinimumWidth = 100;
            this.彩盒工单号.Name = "彩盒工单号";
            this.彩盒工单号.ReadOnly = true;
            // 
            // 彩盒条码
            // 
            this.彩盒条码.FillWeight = 51.82389F;
            this.彩盒条码.HeaderText = "彩盒条码";
            this.彩盒条码.MinimumWidth = 100;
            this.彩盒条码.Name = "彩盒条码";
            this.彩盒条码.ReadOnly = true;
            // 
            // 类型
            // 
            this.类型.FillWeight = 51.82389F;
            this.类型.HeaderText = "类型";
            this.类型.MinimumWidth = 100;
            this.类型.Name = "类型";
            this.类型.ReadOnly = true;
            // 
            // 属性
            // 
            this.属性.FillWeight = 51.82389F;
            this.属性.HeaderText = "属性";
            this.属性.MinimumWidth = 100;
            this.属性.Name = "属性";
            this.属性.ReadOnly = true;
            // 
            // 描述
            // 
            this.描述.FillWeight = 51.82389F;
            this.描述.HeaderText = "描述";
            this.描述.MinimumWidth = 100;
            this.描述.Name = "描述";
            this.描述.ReadOnly = true;
            // 
            // skinLabel8
            // 
            this.skinLabel8.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel8.AutoSize = true;
            this.skinLabel8.BackColor = System.Drawing.Color.WhiteSmoke;
            this.skinLabel8.BorderColor = System.Drawing.Color.Gainsboro;
            this.skinLabel8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.skinLabel8.Location = new System.Drawing.Point(490, 84);
            this.skinLabel8.Name = "skinLabel8";
            this.skinLabel8.Size = new System.Drawing.Size(34, 22);
            this.skinLabel8.TabIndex = 10;
            this.skinLabel8.Text = "OK";
            // 
            // skinLine2
            // 
            this.skinLine2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skinLine2.BackColor = System.Drawing.Color.Transparent;
            this.skinLine2.LineColor = System.Drawing.Color.Gainsboro;
            this.skinLine2.LineHeight = 1;
            this.skinLine2.Location = new System.Drawing.Point(12, 118);
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
            this.skinPanel3.Location = new System.Drawing.Point(558, 45);
            this.skinPanel3.MouseBack = null;
            this.skinPanel3.Name = "skinPanel3";
            this.skinPanel3.NormlBack = null;
            this.skinPanel3.RoundStyle = CCWin.SkinClass.RoundStyle.All;
            this.skinPanel3.Size = new System.Drawing.Size(574, 64);
            this.skinPanel3.TabIndex = 1;
            // 
            // lblInfo
            // 
            this.lblInfo.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.lblInfo.AutoSize = true;
            this.lblInfo.BackColor = System.Drawing.Color.Transparent;
            this.lblInfo.BorderColor = System.Drawing.Color.White;
            this.lblInfo.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblInfo.ForeColor = System.Drawing.Color.Red;
            this.lblInfo.Location = new System.Drawing.Point(7, 22);
            this.lblInfo.Name = "lblInfo";
            this.lblInfo.Size = new System.Drawing.Size(65, 20);
            this.lblInfo.TabIndex = 0;
            this.lblInfo.Text = "操作提示";
            // 
            // skinLabel4
            // 
            this.skinLabel4.ArtTextStyle = CCWin.SkinControl.ArtTextStyle.None;
            this.skinLabel4.AutoSize = true;
            this.skinLabel4.BackColor = System.Drawing.Color.Transparent;
            this.skinLabel4.BorderColor = System.Drawing.Color.White;
            this.skinLabel4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.skinLabel4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.skinLabel4.Location = new System.Drawing.Point(357, 84);
            this.skinLabel4.Name = "skinLabel4";
            this.skinLabel4.Size = new System.Drawing.Size(126, 20);
            this.skinLabel4.TabIndex = 7;
            this.skinLabel4.Text = "产品SN校验结果：";
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Transparent;
            this.btnCancel.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnCancel.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnCancel.DownBack = null;
            this.btnCancel.DownBaseColor = System.Drawing.Color.Silver;
            this.btnCancel.Enabled = false;
            this.btnCancel.Location = new System.Drawing.Point(457, 46);
            this.btnCancel.MouseBack = null;
            this.btnCancel.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.NormlBack = null;
            this.btnCancel.Size = new System.Drawing.Size(94, 26);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "解 除";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.Transparent;
            this.btnOK.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btnOK.BorderColor = System.Drawing.Color.Gainsboro;
            this.btnOK.ControlState = CCWin.SkinClass.ControlState.Normal;
            this.btnOK.DownBack = null;
            this.btnOK.DownBaseColor = System.Drawing.Color.Silver;
            this.btnOK.Location = new System.Drawing.Point(357, 46);
            this.btnOK.MouseBack = null;
            this.btnOK.MouseBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnOK.Name = "btnOK";
            this.btnOK.NormlBack = null;
            this.btnOK.Size = new System.Drawing.Size(94, 26);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "确 认";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // skinTextBox1
            // 
            this.skinTextBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinTextBox1.DownBack = null;
            this.skinTextBox1.Icon = null;
            this.skinTextBox1.IconIsButton = false;
            this.skinTextBox1.IconMouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.IsPasswordChat = '\0';
            this.skinTextBox1.IsSystemPasswordChar = false;
            this.skinTextBox1.Lines = new string[] {
        "SN0987654321"};
            this.skinTextBox1.Location = new System.Drawing.Point(100, 81);
            this.skinTextBox1.Margin = new System.Windows.Forms.Padding(0);
            this.skinTextBox1.MaxLength = 32767;
            this.skinTextBox1.MinimumSize = new System.Drawing.Size(28, 28);
            this.skinTextBox1.MouseBack = null;
            this.skinTextBox1.MouseState = CCWin.SkinClass.ControlState.Normal;
            this.skinTextBox1.Multiline = false;
            this.skinTextBox1.Name = "skinTextBox1";
            this.skinTextBox1.NormlBack = null;
            this.skinTextBox1.Padding = new System.Windows.Forms.Padding(5);
            this.skinTextBox1.ReadOnly = true;
            this.skinTextBox1.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.skinTextBox1.Size = new System.Drawing.Size(251, 28);
            // 
            // 
            // 
            this.skinTextBox1.SkinTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.skinTextBox1.SkinTxt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.skinTextBox1.SkinTxt.Font = new System.Drawing.Font("微软雅黑", 9.75F);
            this.skinTextBox1.SkinTxt.Location = new System.Drawing.Point(5, 5);
            this.skinTextBox1.SkinTxt.Name = "BaseText";
            this.skinTextBox1.SkinTxt.ReadOnly = true;
            this.skinTextBox1.SkinTxt.Size = new System.Drawing.Size(241, 18);
            this.skinTextBox1.SkinTxt.TabIndex = 0;
            this.skinTextBox1.SkinTxt.Text = "SN0987654321";
            this.skinTextBox1.SkinTxt.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.SkinTxt.WaterText = "";
            this.skinTextBox1.TabIndex = 4;
            this.skinTextBox1.Text = "SN0987654321";
            this.skinTextBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.skinTextBox1.WaterColor = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(127)))), ((int)(((byte)(127)))));
            this.skinTextBox1.WaterText = "";
            this.skinTextBox1.WordWrap = true;
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
            // 
            // cmbWO
            // 
            this.cmbWO.ArrowColor = System.Drawing.Color.Gray;
            this.cmbWO.BaseColor = System.Drawing.Color.Gainsboro;
            this.cmbWO.BorderColor = System.Drawing.Color.Gainsboro;
            this.cmbWO.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cmbWO.FormattingEnabled = true;
            this.cmbWO.Location = new System.Drawing.Point(100, 46);
            this.cmbWO.Name = "cmbWO";
            this.cmbWO.Size = new System.Drawing.Size(251, 26);
            this.cmbWO.TabIndex = 2;
            this.cmbWO.WaterText = "";
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
            ((System.ComponentModel.ISupportInitialize)(this.GRD_Lineinfor)).EndInit();
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
        private CCWin.SkinControl.SkinComboBox cmbWO;
        private CCWin.SkinControl.SkinTextBox skinTextBox1;
        private CCWin.SkinControl.SkinLabel skinLabel3;
        private CCWin.SkinControl.SkinButton btnOK;
        private CCWin.SkinControl.SkinButton btnCancel;
        private CCWin.SkinControl.SkinLabel skinLabel4;
        private CCWin.SkinControl.SkinPanel skinPanel3;
        private CCWin.SkinControl.SkinLabel lblInfo;
        private CCWin.SkinControl.SkinLine skinLine2;
        private CCWin.SkinControl.SkinLabel skinLabel8;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CCWin.SkinControl.SkinDataGridView GRD_Lineinfor;
        private System.Windows.Forms.DataGridViewTextBoxColumn 序号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 彩盒工单号;
        private System.Windows.Forms.DataGridViewTextBoxColumn 彩盒条码;
        private System.Windows.Forms.DataGridViewTextBoxColumn 类型;
        private System.Windows.Forms.DataGridViewTextBoxColumn 属性;
        private System.Windows.Forms.DataGridViewTextBoxColumn 描述;
        private CCWin.SkinControl.SkinPictureBox picBox;
        private CCWin.SkinControl.SkinPanel skinPanel4;
        private CCWin.SkinControl.SkinLabel skinLabel11;
        private CCWin.SkinControl.SkinLabel skinLabel12;
        private CCWin.SkinControl.SkinLabel skinLabel9;
        private CCWin.SkinControl.SkinLabel skinLabel10;
        private CCWin.SkinControl.SkinLabel skinLabel7;
        private CCWin.SkinControl.SkinLabel skinLabel5;
    }
}