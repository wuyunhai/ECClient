
namespace ZCXJ_CS.UI
{
    partial class FormAddMaterial
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
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.txbInfo = new MetroFramework.Controls.MetroTextBox();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grid = new MetroFramework.Controls.MetroGrid();
            this.metroPanel1 = new MetroFramework.Controls.MetroPanel();
            this.metroGroupBox3 = new MetroFramework.Controls.MetroGroupBox();
            this.txbScan = new MetroFramework.Controls.MetroTextBox();
            this.labScan = new MetroFramework.Controls.MetroLabel();
            this.txbElse = new MetroFramework.Controls.MetroTextBox();
            this.txbAttr = new MetroFramework.Controls.MetroTextBox();
            this.txbDescription = new MetroFramework.Controls.MetroTextBox();
            this.txbType = new MetroFramework.Controls.MetroTextBox();
            this.txbSN = new MetroFramework.Controls.MetroTextBox();
            this.labElse = new MetroFramework.Controls.MetroLabel();
            this.labAttr = new MetroFramework.Controls.MetroLabel();
            this.labDescription = new MetroFramework.Controls.MetroLabel();
            this.labType = new MetroFramework.Controls.MetroLabel();
            this.labWO = new MetroFramework.Controls.MetroLabel();
            this.labSN = new MetroFramework.Controls.MetroLabel();
            this.metroLabel1 = new MetroFramework.Controls.MetroLabel();
            this.txbWO = new MetroFramework.Controls.MetroTextBox();
            this.metroGroupBox1 = new MetroFramework.Controls.MetroGroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.grid)).BeginInit();
            this.metroGroupBox3.SuspendLayout();
            this.metroGroupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txbInfo
            // 
            this.txbInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(45)))), ((int)(((byte)(50)))), ((int)(((byte)(55)))));
            this.txbInfo.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbInfo.ForeColor = System.Drawing.Color.Yellow;
            this.txbInfo.Lines = new string[0];
            this.txbInfo.Location = new System.Drawing.Point(581, 200);
            this.txbInfo.MaxLength = 32767;
            this.txbInfo.Multiline = true;
            this.txbInfo.Name = "txbInfo";
            this.txbInfo.PasswordChar = '\0';
            this.txbInfo.ReadOnly = true;
            this.txbInfo.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbInfo.SelectedText = "";
            this.txbInfo.Size = new System.Drawing.Size(215, 32);
            this.txbInfo.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbInfo.StyleManager = null;
            this.txbInfo.TabIndex = 56;
            this.txbInfo.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbInfo.UseCustomBackColor = true;
            this.txbInfo.UseCustomForeColor = true;
            this.txbInfo.UseSelectable = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "物料描述";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 322;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "通用产品物料批次标签";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            this.Column2.Width = 300;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "顺序";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            this.Column1.Width = 150;
            // 
            // grid
            // 
            this.grid.AllowUserToAddRows = false;
            this.grid.AllowUserToDeleteRows = false;
            this.grid.AllowUserToResizeRows = false;
            this.grid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.grid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleVertical;
            this.grid.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("微软雅黑", 12F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.Silver;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.DefaultCellStyle = dataGridViewCellStyle2;
            this.grid.EnableHeadersVisualStyles = false;
            this.grid.FontSize = MetroFramework.MetroDataGridSize.Medium;
            this.grid.FontWeight = MetroFramework.MetroDataGridWeight.Regular;
            this.grid.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.grid.Location = new System.Drawing.Point(11, 13);
            this.grid.Name = "grid";
            this.grid.ReadOnly = true;
            this.grid.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(174)))), ((int)(((byte)(219)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(17)))), ((int)(((byte)(17)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grid.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grid.RowHeadersVisible = false;
            this.grid.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.grid.RowTemplate.Height = 40;
            this.grid.RowTemplate.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            this.grid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.grid.Size = new System.Drawing.Size(773, 80);
            this.grid.TabIndex = 18;
            // 
            // metroPanel1
            // 
            this.metroPanel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.metroPanel1.CustomBackground = false;
            this.metroPanel1.HorizontalScrollbar = false;
            this.metroPanel1.HorizontalScrollbarBarColor = true;
            this.metroPanel1.HorizontalScrollbarHighlightOnWheel = false;
            this.metroPanel1.HorizontalScrollbarSize = 10;
            this.metroPanel1.Location = new System.Drawing.Point(17, 368);
            this.metroPanel1.Name = "metroPanel1";
            this.metroPanel1.Size = new System.Drawing.Size(781, 242);
            this.metroPanel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroPanel1.StyleManager = null;
            this.metroPanel1.TabIndex = 55;
            this.metroPanel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroPanel1.VerticalScrollbar = false;
            this.metroPanel1.VerticalScrollbarBarColor = true;
            this.metroPanel1.VerticalScrollbarHighlightOnWheel = false;
            this.metroPanel1.VerticalScrollbarSize = 10;
            // 
            // metroGroupBox3
            // 
            this.metroGroupBox3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGroupBox3.BorderStyle = MetroFramework.Controls.MetroGroupBox.BorderMode.Header;
            this.metroGroupBox3.Controls.Add(this.grid);
            this.metroGroupBox3.DrawBottomLine = false;
            this.metroGroupBox3.DrawShadows = false;
            this.metroGroupBox3.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGroupBox3.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroGroupBox3.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroGroupBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(170)))), ((int)(((byte)(173)))));
            this.metroGroupBox3.Location = new System.Drawing.Point(14, 247);
            this.metroGroupBox3.Name = "metroGroupBox3";
            this.metroGroupBox3.PaintDefault = false;
            this.metroGroupBox3.Size = new System.Drawing.Size(784, 115);
            this.metroGroupBox3.Style = MetroFramework.MetroColorStyle.Teal;
            this.metroGroupBox3.StyleManager = null;
            this.metroGroupBox3.TabIndex = 54;
            this.metroGroupBox3.TabStop = false;
            this.metroGroupBox3.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGroupBox3.UseStyleColors = true;
            // 
            // txbScan
            // 
            this.txbScan.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbScan.Lines = new string[0];
            this.txbScan.Location = new System.Drawing.Point(128, 200);
            this.txbScan.MaxLength = 32767;
            this.txbScan.Multiline = true;
            this.txbScan.Name = "txbScan";
            this.txbScan.PasswordChar = '\0';
            this.txbScan.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbScan.SelectedText = "";
            this.txbScan.Size = new System.Drawing.Size(389, 32);
            this.txbScan.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbScan.StyleManager = null;
            this.txbScan.TabIndex = 53;
            this.txbScan.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbScan.UseCustomBackColor = true;
            this.txbScan.UseSelectable = true;
            // 
            // labScan
            // 
            this.labScan.AutoSize = true;
            this.labScan.CustomBackground = false;
            this.labScan.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labScan.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labScan.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labScan.Location = new System.Drawing.Point(12, 200);
            this.labScan.Name = "labScan";
            this.labScan.Size = new System.Drawing.Size(120, 25);
            this.labScan.Style = MetroFramework.MetroColorStyle.Blue;
            this.labScan.StyleManager = null;
            this.labScan.TabIndex = 52;
            this.labScan.Text = "通用扫描区：";
            this.labScan.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labScan.UseStyleColors = false;
            // 
            // txbElse
            // 
            this.txbElse.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbElse.Lines = new string[0];
            this.txbElse.Location = new System.Drawing.Point(644, 148);
            this.txbElse.MaxLength = 32767;
            this.txbElse.Multiline = true;
            this.txbElse.Name = "txbElse";
            this.txbElse.PasswordChar = '\0';
            this.txbElse.ReadOnly = true;
            this.txbElse.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbElse.SelectedText = "";
            this.txbElse.Size = new System.Drawing.Size(152, 32);
            this.txbElse.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbElse.StyleManager = null;
            this.txbElse.TabIndex = 51;
            this.txbElse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbElse.UseCustomBackColor = true;
            this.txbElse.UseSelectable = true;
            // 
            // txbAttr
            // 
            this.txbAttr.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbAttr.Lines = new string[0];
            this.txbAttr.Location = new System.Drawing.Point(644, 95);
            this.txbAttr.MaxLength = 32767;
            this.txbAttr.Multiline = true;
            this.txbAttr.Name = "txbAttr";
            this.txbAttr.PasswordChar = '\0';
            this.txbAttr.ReadOnly = true;
            this.txbAttr.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbAttr.SelectedText = "";
            this.txbAttr.Size = new System.Drawing.Size(152, 32);
            this.txbAttr.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbAttr.StyleManager = null;
            this.txbAttr.TabIndex = 50;
            this.txbAttr.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbAttr.UseCustomBackColor = true;
            this.txbAttr.UseSelectable = true;
            // 
            // txbDescription
            // 
            this.txbDescription.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbDescription.Lines = new string[0];
            this.txbDescription.Location = new System.Drawing.Point(365, 148);
            this.txbDescription.MaxLength = 32767;
            this.txbDescription.Multiline = true;
            this.txbDescription.Name = "txbDescription";
            this.txbDescription.PasswordChar = '\0';
            this.txbDescription.ReadOnly = true;
            this.txbDescription.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbDescription.SelectedText = "";
            this.txbDescription.Size = new System.Drawing.Size(152, 32);
            this.txbDescription.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbDescription.StyleManager = null;
            this.txbDescription.TabIndex = 49;
            this.txbDescription.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbDescription.UseCustomBackColor = true;
            this.txbDescription.UseSelectable = true;
            // 
            // txbType
            // 
            this.txbType.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbType.Lines = new string[0];
            this.txbType.Location = new System.Drawing.Point(365, 95);
            this.txbType.MaxLength = 32767;
            this.txbType.Multiline = true;
            this.txbType.Name = "txbType";
            this.txbType.PasswordChar = '\0';
            this.txbType.ReadOnly = true;
            this.txbType.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbType.SelectedText = "";
            this.txbType.Size = new System.Drawing.Size(152, 32);
            this.txbType.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbType.StyleManager = null;
            this.txbType.TabIndex = 48;
            this.txbType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbType.UseCustomBackColor = true;
            this.txbType.UseSelectable = true;
            // 
            // txbSN
            // 
            this.txbSN.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbSN.Lines = new string[0];
            this.txbSN.Location = new System.Drawing.Point(73, 95);
            this.txbSN.MaxLength = 32767;
            this.txbSN.Multiline = true;
            this.txbSN.Name = "txbSN";
            this.txbSN.PasswordChar = '\0';
            this.txbSN.ReadOnly = true;
            this.txbSN.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbSN.SelectedText = "";
            this.txbSN.Size = new System.Drawing.Size(152, 32);
            this.txbSN.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbSN.StyleManager = null;
            this.txbSN.TabIndex = 46;
            this.txbSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbSN.UseCustomBackColor = true;
            this.txbSN.UseSelectable = true;
            // 
            // labElse
            // 
            this.labElse.AutoSize = true;
            this.labElse.CustomBackground = false;
            this.labElse.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labElse.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labElse.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labElse.Location = new System.Drawing.Point(581, 148);
            this.labElse.Name = "labElse";
            this.labElse.Size = new System.Drawing.Size(66, 25);
            this.labElse.Style = MetroFramework.MetroColorStyle.Blue;
            this.labElse.StyleManager = null;
            this.labElse.TabIndex = 45;
            this.labElse.Text = "其他：";
            this.labElse.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labElse.UseStyleColors = false;
            // 
            // labAttr
            // 
            this.labAttr.AutoSize = true;
            this.labAttr.CustomBackground = false;
            this.labAttr.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labAttr.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labAttr.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labAttr.Location = new System.Drawing.Point(581, 95);
            this.labAttr.Name = "labAttr";
            this.labAttr.Size = new System.Drawing.Size(66, 25);
            this.labAttr.Style = MetroFramework.MetroColorStyle.Blue;
            this.labAttr.StyleManager = null;
            this.labAttr.TabIndex = 44;
            this.labAttr.Text = "属性：";
            this.labAttr.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labAttr.UseStyleColors = false;
            // 
            // labDescription
            // 
            this.labDescription.AutoSize = true;
            this.labDescription.CustomBackground = false;
            this.labDescription.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labDescription.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labDescription.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labDescription.Location = new System.Drawing.Point(304, 148);
            this.labDescription.Name = "labDescription";
            this.labDescription.Size = new System.Drawing.Size(66, 25);
            this.labDescription.Style = MetroFramework.MetroColorStyle.Blue;
            this.labDescription.StyleManager = null;
            this.labDescription.TabIndex = 43;
            this.labDescription.Text = "描述：";
            this.labDescription.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labDescription.UseStyleColors = false;
            // 
            // labType
            // 
            this.labType.AutoSize = true;
            this.labType.CustomBackground = false;
            this.labType.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labType.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labType.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labType.Location = new System.Drawing.Point(304, 95);
            this.labType.Name = "labType";
            this.labType.Size = new System.Drawing.Size(66, 25);
            this.labType.Style = MetroFramework.MetroColorStyle.Blue;
            this.labType.StyleManager = null;
            this.labType.TabIndex = 42;
            this.labType.Text = "类型：";
            this.labType.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labType.UseStyleColors = false;
            // 
            // labWO
            // 
            this.labWO.AutoSize = true;
            this.labWO.CustomBackground = false;
            this.labWO.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labWO.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labWO.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labWO.Location = new System.Drawing.Point(12, 148);
            this.labWO.Name = "labWO";
            this.labWO.Size = new System.Drawing.Size(66, 25);
            this.labWO.Style = MetroFramework.MetroColorStyle.Blue;
            this.labWO.StyleManager = null;
            this.labWO.TabIndex = 41;
            this.labWO.Text = "工单：";
            this.labWO.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labWO.UseStyleColors = false;
            // 
            // labSN
            // 
            this.labSN.AutoSize = true;
            this.labSN.CustomBackground = false;
            this.labSN.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labSN.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labSN.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.labSN.Location = new System.Drawing.Point(12, 95);
            this.labSN.Name = "labSN";
            this.labSN.Size = new System.Drawing.Size(66, 25);
            this.labSN.Style = MetroFramework.MetroColorStyle.Blue;
            this.labSN.StyleManager = null;
            this.labSN.TabIndex = 40;
            this.labSN.Text = "条码：";
            this.labSN.Theme = MetroFramework.MetroThemeStyle.Light;
            this.labSN.UseStyleColors = false;
            // 
            // metroLabel1
            // 
            this.metroLabel1.CustomBackground = false;
            this.metroLabel1.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.metroLabel1.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.metroLabel1.LabelMode = MetroFramework.Controls.MetroLabelMode.Default;
            this.metroLabel1.Location = new System.Drawing.Point(3, 13);
            this.metroLabel1.Name = "metroLabel1";
            this.metroLabel1.Size = new System.Drawing.Size(143, 50);
            this.metroLabel1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroLabel1.StyleManager = null;
            this.metroLabel1.TabIndex = 0;
            this.metroLabel1.Text = "彩盒通用上料";
            this.metroLabel1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.metroLabel1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroLabel1.UseStyleColors = false;
            // 
            // txbWO
            // 
            this.txbWO.FontSize = MetroFramework.MetroTextBoxSize.Tall;
            this.txbWO.Lines = new string[0];
            this.txbWO.Location = new System.Drawing.Point(73, 148);
            this.txbWO.MaxLength = 32767;
            this.txbWO.Multiline = true;
            this.txbWO.Name = "txbWO";
            this.txbWO.PasswordChar = '\0';
            this.txbWO.ReadOnly = true;
            this.txbWO.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txbWO.SelectedText = "";
            this.txbWO.Size = new System.Drawing.Size(152, 32);
            this.txbWO.Style = MetroFramework.MetroColorStyle.Blue;
            this.txbWO.StyleManager = null;
            this.txbWO.TabIndex = 47;
            this.txbWO.Theme = MetroFramework.MetroThemeStyle.Light;
            this.txbWO.UseCustomBackColor = true;
            this.txbWO.UseSelectable = true;
            // 
            // metroGroupBox1
            // 
            this.metroGroupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.metroGroupBox1.BorderStyle = MetroFramework.Controls.MetroGroupBox.BorderMode.Full;
            this.metroGroupBox1.Controls.Add(this.metroLabel1);
            this.metroGroupBox1.DrawBottomLine = false;
            this.metroGroupBox1.DrawShadows = false;
            this.metroGroupBox1.Font = new System.Drawing.Font("Segoe UI Light", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.metroGroupBox1.FontSize = MetroFramework.MetroLabelSize.Medium;
            this.metroGroupBox1.FontWeight = MetroFramework.MetroLabelWeight.Light;
            this.metroGroupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.metroGroupBox1.Location = new System.Drawing.Point(14, 7);
            this.metroGroupBox1.Margin = new System.Windows.Forms.Padding(0);
            this.metroGroupBox1.Name = "metroGroupBox1";
            this.metroGroupBox1.Padding = new System.Windows.Forms.Padding(0);
            this.metroGroupBox1.PaintDefault = false;
            this.metroGroupBox1.Size = new System.Drawing.Size(157, 70);
            this.metroGroupBox1.Style = MetroFramework.MetroColorStyle.Blue;
            this.metroGroupBox1.StyleManager = null;
            this.metroGroupBox1.TabIndex = 39;
            this.metroGroupBox1.TabStop = false;
            this.metroGroupBox1.Theme = MetroFramework.MetroThemeStyle.Light;
            this.metroGroupBox1.UseStyleColors = false;
            // 
            // FormAddMaterial
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 19F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1081, 519);
            this.Controls.Add(this.txbInfo);
            this.Controls.Add(this.metroPanel1);
            this.Controls.Add(this.metroGroupBox3);
            this.Controls.Add(this.txbScan);
            this.Controls.Add(this.labScan);
            this.Controls.Add(this.txbElse);
            this.Controls.Add(this.txbAttr);
            this.Controls.Add(this.txbDescription);
            this.Controls.Add(this.txbType);
            this.Controls.Add(this.txbSN);
            this.Controls.Add(this.labElse);
            this.Controls.Add(this.labAttr);
            this.Controls.Add(this.labDescription);
            this.Controls.Add(this.labType);
            this.Controls.Add(this.labWO);
            this.Controls.Add(this.labSN);
            this.Controls.Add(this.txbWO);
            this.Controls.Add(this.metroGroupBox1);
            this.Name = "FormAddMaterial";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormAddMaterial_Load);
            ((System.ComponentModel.ISupportInitialize)(this.grid)).EndInit();
            this.metroGroupBox3.ResumeLayout(false);
            this.metroGroupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Controls.MetroTextBox txbInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private MetroFramework.Controls.MetroGrid grid;
        private MetroFramework.Controls.MetroPanel metroPanel1;
        private MetroFramework.Controls.MetroGroupBox metroGroupBox3;
        private MetroFramework.Controls.MetroTextBox txbScan;
        private MetroFramework.Controls.MetroLabel labScan;
        private MetroFramework.Controls.MetroTextBox txbElse;
        private MetroFramework.Controls.MetroTextBox txbAttr;
        private MetroFramework.Controls.MetroTextBox txbDescription;
        private MetroFramework.Controls.MetroTextBox txbType;
        private MetroFramework.Controls.MetroTextBox txbSN;
        private MetroFramework.Controls.MetroLabel labElse;
        private MetroFramework.Controls.MetroLabel labAttr;
        private MetroFramework.Controls.MetroLabel labDescription;
        private MetroFramework.Controls.MetroLabel labType;
        private MetroFramework.Controls.MetroLabel labWO;
        private MetroFramework.Controls.MetroLabel labSN;
        private MetroFramework.Controls.MetroLabel metroLabel1;
        private MetroFramework.Controls.MetroTextBox txbWO;
        private MetroFramework.Controls.MetroGroupBox metroGroupBox1;
    }
}

