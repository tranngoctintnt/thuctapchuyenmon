
namespace QuanLy_CuaHang.HoaDon
{
    partial class Lap_HD
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Lap_HD));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btnThem = new System.Windows.Forms.ToolStripButton();
            this.btnHuy = new System.Windows.Forms.ToolStripButton();
            this.label5 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dgv_hd = new Guna.UI.WinForms.GunaDataGridView();
            this.txtSL = new Guna.UI.WinForms.GunaTextBox();
            this.txtDongia = new Guna.UI.WinForms.GunaTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.gunaButton1 = new Guna.UI.WinForms.GunaButton();
            this.label12 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lbMaHD = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtMaKh = new Guna.UI.WinForms.GunaTextBox();
            this.cbbKH = new Guna.UI.WinForms.GunaComboBox();
            this.cbbTenHang = new Guna.UI.WinForms.GunaComboBox();
            this.ma_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ten_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.soluong_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gia_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tongtien_sp = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.toolStrip1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnThem,
            this.btnHuy});
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1164, 31);
            this.toolStrip1.TabIndex = 17;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btnThem
            // 
            this.btnThem.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThem.Image = ((System.Drawing.Image)(resources.GetObject("btnThem.Image")));
            this.btnThem.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(156, 28);
            this.btnThem.Text = "Thêm hóa đơn";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(71, 28);
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 89);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(140, 24);
            this.label5.TabIndex = 1;
            this.label5.Text = "Mã khách hàng";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(415, 33);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(66, 20);
            this.label11.TabIndex = 8;
            this.label11.Text = "Đơn giá";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 33);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(78, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Tên hàng";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cbbTenHang);
            this.groupBox2.Controls.Add(this.dgv_hd);
            this.groupBox2.Controls.Add(this.txtSL);
            this.groupBox2.Controls.Add(this.txtDongia);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.lbTongTien);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.gunaButton1);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(0, 233);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox2.Size = new System.Drawing.Size(1164, 425);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Thông tin các mặt hàng";
            // 
            // dgv_hd
            // 
            this.dgv_hd.AllowUserToAddRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_hd.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_hd.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_hd.BackgroundColor = System.Drawing.Color.White;
            this.dgv_hd.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_hd.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hd.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_hd.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_hd.ColumnHeadersHeight = 52;
            this.dgv_hd.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ma_sp,
            this.ten_sp,
            this.soluong_sp,
            this.gia_sp,
            this.tongtien_sp,
            this.xoa});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_hd.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_hd.EnableHeadersVisualStyles = false;
            this.dgv_hd.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hd.Location = new System.Drawing.Point(17, 68);
            this.dgv_hd.Name = "dgv_hd";
            this.dgv_hd.ReadOnly = true;
            this.dgv_hd.RowHeadersVisible = false;
            this.dgv_hd.RowHeadersWidth = 51;
            this.dgv_hd.RowTemplate.Height = 24;
            this.dgv_hd.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_hd.Size = new System.Drawing.Size(1140, 249);
            this.dgv_hd.TabIndex = 30;
            this.dgv_hd.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_hd.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hd.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_hd.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_hd.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_hd.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_hd.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hd.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hd.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_hd.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_hd.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hd.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_hd.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_hd.ThemeStyle.HeaderStyle.Height = 52;
            this.dgv_hd.ThemeStyle.ReadOnly = true;
            this.dgv_hd.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_hd.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_hd.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dgv_hd.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_hd.ThemeStyle.RowsStyle.Height = 24;
            this.dgv_hd.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_hd.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.Transparent;
            this.txtSL.BaseColor = System.Drawing.Color.White;
            this.txtSL.BorderColor = System.Drawing.Color.Silver;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSL.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSL.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSL.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSL.Location = new System.Drawing.Point(804, 30);
            this.txtSL.Name = "txtSL";
            this.txtSL.PasswordChar = '\0';
            this.txtSL.Radius = 10;
            this.txtSL.SelectedText = "";
            this.txtSL.Size = new System.Drawing.Size(172, 32);
            this.txtSL.TabIndex = 29;
            // 
            // txtDongia
            // 
            this.txtDongia.BackColor = System.Drawing.Color.Transparent;
            this.txtDongia.BaseColor = System.Drawing.Color.White;
            this.txtDongia.BorderColor = System.Drawing.Color.Silver;
            this.txtDongia.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDongia.FocusedBaseColor = System.Drawing.Color.White;
            this.txtDongia.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtDongia.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtDongia.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtDongia.Location = new System.Drawing.Point(491, 30);
            this.txtDongia.Name = "txtDongia";
            this.txtDongia.PasswordChar = '\0';
            this.txtDongia.Radius = 10;
            this.txtDongia.SelectedText = "";
            this.txtDongia.Size = new System.Drawing.Size(221, 32);
            this.txtDongia.TabIndex = 28;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(983, 33);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(19, 25);
            this.label4.TabIndex = 26;
            this.label4.Text = "/";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(1014, 30);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 25);
            this.label2.TabIndex = 25;
            this.label2.Text = "0";
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(979, 364);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(23, 25);
            this.lbTongTien.TabIndex = 8;
            this.lbTongTien.Text = "0";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(765, 364);
            this.label15.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 25);
            this.label15.TabIndex = 20;
            this.label15.Text = "Tổng tiền";
            // 
            // gunaButton1
            // 
            this.gunaButton1.AnimationHoverSpeed = 0.07F;
            this.gunaButton1.AnimationSpeed = 0.03F;
            this.gunaButton1.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.gunaButton1.BorderColor = System.Drawing.Color.Black;
            this.gunaButton1.DialogResult = System.Windows.Forms.DialogResult.None;
            this.gunaButton1.FocusedColor = System.Drawing.Color.Empty;
            this.gunaButton1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.gunaButton1.ForeColor = System.Drawing.Color.White;
            this.gunaButton1.Image = null;
            this.gunaButton1.ImageSize = new System.Drawing.Size(20, 20);
            this.gunaButton1.Location = new System.Drawing.Point(120, 341);
            this.gunaButton1.Margin = new System.Windows.Forms.Padding(4);
            this.gunaButton1.Name = "gunaButton1";
            this.gunaButton1.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.gunaButton1.OnHoverBorderColor = System.Drawing.Color.Black;
            this.gunaButton1.OnHoverForeColor = System.Drawing.Color.White;
            this.gunaButton1.OnHoverImage = null;
            this.gunaButton1.OnPressedColor = System.Drawing.Color.Black;
            this.gunaButton1.Size = new System.Drawing.Size(197, 48);
            this.gunaButton1.TabIndex = 19;
            this.gunaButton1.Text = "In Hóa đơn ";
            this.gunaButton1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.gunaButton1.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(719, 34);
            this.label12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(74, 20);
            this.label12.TabIndex = 9;
            this.label12.Text = "Số lượng";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(412, 18);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 33);
            this.label1.TabIndex = 6;
            this.label1.Text = "Hóa đơn";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(10, 148);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 24);
            this.label6.TabIndex = 2;
            this.label6.Text = "Tên khách hàng";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(612, 89);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 24);
            this.label7.TabIndex = 3;
            this.label7.Text = "Email";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(612, 148);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 24);
            this.label8.TabIndex = 4;
            this.label8.Text = "Điện thoại";
            // 
            // lbMaHD
            // 
            this.lbMaHD.AutoSize = true;
            this.lbMaHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaHD.Location = new System.Drawing.Point(584, 21);
            this.lbMaHD.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaHD.Name = "lbMaHD";
            this.lbMaHD.Size = new System.Drawing.Size(0, 25);
            this.lbMaHD.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbbKH);
            this.groupBox1.Controls.Add(this.txtSDT);
            this.groupBox1.Controls.Add(this.txtEmail);
            this.groupBox1.Controls.Add(this.txtMaKh);
            this.groupBox1.Controls.Add(this.lbMaHD);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(3, 36);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(1161, 190);
            this.groupBox1.TabIndex = 16;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Thông tin chung";
            // 
            // txtSDT
            // 
            this.txtSDT.BackColor = System.Drawing.Color.Transparent;
            this.txtSDT.BaseColor = System.Drawing.Color.White;
            this.txtSDT.BorderColor = System.Drawing.Color.Silver;
            this.txtSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSDT.FocusedBaseColor = System.Drawing.Color.White;
            this.txtSDT.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtSDT.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtSDT.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSDT.Location = new System.Drawing.Point(720, 141);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.Radius = 15;
            this.txtSDT.SelectedText = "";
            this.txtSDT.Size = new System.Drawing.Size(302, 45);
            this.txtSDT.TabIndex = 11;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.Color.Transparent;
            this.txtEmail.BaseColor = System.Drawing.Color.White;
            this.txtEmail.BorderColor = System.Drawing.Color.Silver;
            this.txtEmail.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmail.FocusedBaseColor = System.Drawing.Color.White;
            this.txtEmail.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtEmail.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtEmail.Location = new System.Drawing.Point(720, 76);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 15;
            this.txtEmail.SelectedText = "";
            this.txtEmail.Size = new System.Drawing.Size(302, 45);
            this.txtEmail.TabIndex = 9;
            // 
            // txtMaKh
            // 
            this.txtMaKh.BackColor = System.Drawing.Color.Transparent;
            this.txtMaKh.BaseColor = System.Drawing.Color.White;
            this.txtMaKh.BorderColor = System.Drawing.Color.Silver;
            this.txtMaKh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaKh.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMaKh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMaKh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMaKh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMaKh.Location = new System.Drawing.Point(176, 76);
            this.txtMaKh.Name = "txtMaKh";
            this.txtMaKh.PasswordChar = '\0';
            this.txtMaKh.Radius = 15;
            this.txtMaKh.SelectedText = "";
            this.txtMaKh.Size = new System.Drawing.Size(302, 45);
            this.txtMaKh.TabIndex = 8;
            // 
            // cbbKH
            // 
            this.cbbKH.BackColor = System.Drawing.Color.Transparent;
            this.cbbKH.BaseColor = System.Drawing.Color.White;
            this.cbbKH.BorderColor = System.Drawing.Color.Silver;
            this.cbbKH.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbKH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbKH.FocusedColor = System.Drawing.Color.Empty;
            this.cbbKH.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbKH.ForeColor = System.Drawing.Color.Black;
            this.cbbKH.FormattingEnabled = true;
            this.cbbKH.Location = new System.Drawing.Point(176, 146);
            this.cbbKH.Name = "cbbKH";
            this.cbbKH.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbKH.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbKH.Radius = 10;
            this.cbbKH.Size = new System.Drawing.Size(302, 31);
            this.cbbKH.TabIndex = 12;
            this.cbbKH.SelectedIndexChanged += new System.EventHandler(this.cbbKH_SelectedIndexChanged);
            // 
            // cbbTenHang
            // 
            this.cbbTenHang.BackColor = System.Drawing.Color.Transparent;
            this.cbbTenHang.BaseColor = System.Drawing.Color.White;
            this.cbbTenHang.BorderColor = System.Drawing.Color.Silver;
            this.cbbTenHang.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cbbTenHang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbbTenHang.FocusedColor = System.Drawing.Color.Empty;
            this.cbbTenHang.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.cbbTenHang.ForeColor = System.Drawing.Color.Black;
            this.cbbTenHang.FormattingEnabled = true;
            this.cbbTenHang.Location = new System.Drawing.Point(98, 27);
            this.cbbTenHang.Name = "cbbTenHang";
            this.cbbTenHang.OnHoverItemBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.cbbTenHang.OnHoverItemForeColor = System.Drawing.Color.White;
            this.cbbTenHang.Radius = 10;
            this.cbbTenHang.Size = new System.Drawing.Size(244, 31);
            this.cbbTenHang.TabIndex = 31;
            this.cbbTenHang.SelectedIndexChanged += new System.EventHandler(this.cbbTenHang_SelectedIndexChanged);
            this.cbbTenHang.SelectedValueChanged += new System.EventHandler(this.cbbTenHang_SelectedValueChanged);
            // 
            // ma_sp
            // 
            this.ma_sp.DataPropertyName = "ma_sp";
            this.ma_sp.HeaderText = "Mã Sản Phẩm";
            this.ma_sp.MinimumWidth = 6;
            this.ma_sp.Name = "ma_sp";
            this.ma_sp.ReadOnly = true;
            // 
            // ten_sp
            // 
            this.ten_sp.DataPropertyName = "ten_sp";
            this.ten_sp.HeaderText = "Tên Sản Phẩm";
            this.ten_sp.MinimumWidth = 6;
            this.ten_sp.Name = "ten_sp";
            this.ten_sp.ReadOnly = true;
            // 
            // soluong_sp
            // 
            this.soluong_sp.DataPropertyName = "soluong_sp";
            this.soluong_sp.HeaderText = "Số Lượng";
            this.soluong_sp.MinimumWidth = 6;
            this.soluong_sp.Name = "soluong_sp";
            this.soluong_sp.ReadOnly = true;
            // 
            // gia_sp
            // 
            this.gia_sp.DataPropertyName = "gia_sp";
            this.gia_sp.HeaderText = "Đơn giá";
            this.gia_sp.MinimumWidth = 6;
            this.gia_sp.Name = "gia_sp";
            this.gia_sp.ReadOnly = true;
            // 
            // tongtien_sp
            // 
            this.tongtien_sp.DataPropertyName = "tongtien_sp";
            this.tongtien_sp.HeaderText = "Thành Tiền";
            this.tongtien_sp.MinimumWidth = 6;
            this.tongtien_sp.Name = "tongtien_sp";
            this.tongtien_sp.ReadOnly = true;
            // 
            // xoa
            // 
            this.xoa.HeaderText = "Xóa";
            this.xoa.MinimumWidth = 6;
            this.xoa.Name = "xoa";
            this.xoa.ReadOnly = true;
            this.xoa.Text = "Xóa";
            this.xoa.ToolTipText = "Xóa";
            // 
            // Lap_HD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1164, 662);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Lap_HD";
            this.Text = "Lap_HD";
            this.Load += new System.EventHandler(this.Lap_HD_Load);
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_hd)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStripButton btnHuy;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btnThem;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label15;
        private Guna.UI.WinForms.GunaButton gunaButton1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lbMaHD;
        private System.Windows.Forms.GroupBox groupBox1;
        private Guna.UI.WinForms.GunaTextBox txtSL;
        private Guna.UI.WinForms.GunaTextBox txtDongia;
        private Guna.UI.WinForms.GunaTextBox txtSDT;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtMaKh;
        private Guna.UI.WinForms.GunaDataGridView dgv_hd;
        private Guna.UI.WinForms.GunaComboBox cbbTenHang;
        private Guna.UI.WinForms.GunaComboBox cbbKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn ma_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn ten_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn soluong_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn gia_sp;
        private System.Windows.Forms.DataGridViewTextBoxColumn tongtien_sp;
        private System.Windows.Forms.DataGridViewButtonColumn xoa;
    }
}