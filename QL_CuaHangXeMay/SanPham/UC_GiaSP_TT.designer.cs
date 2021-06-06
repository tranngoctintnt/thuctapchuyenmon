
namespace QuanLy_CuaHang.SanPham
{
    partial class UC_GiaSP_TT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle22 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle23 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle24 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_GiaSP_TT));
            this.dgv_GiaSP = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_LamMoi_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Xoa_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Sua_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Them_GiaSP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Tim_giasp = new Guna.UI.WinForms.GunaCircleButton();
            this.txt_Tim_giasp = new Guna.UI.WinForms.GunaTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_giasp_from = new System.Windows.Forms.ComboBox();
            this.cbb_giasp_to = new System.Windows.Forms.ComboBox();
            this.ckb_LocSP = new Guna.UI.WinForms.GunaCheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaSP)).BeginInit();
            this.SuspendLayout();
            // 
            // dgv_GiaSP
            // 
            this.dgv_GiaSP.AllowUserToAddRows = false;
            this.dgv_GiaSP.AllowUserToDeleteRows = false;
            dataGridViewCellStyle22.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle22;
            this.dgv_GiaSP.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_GiaSP.BackgroundColor = System.Drawing.Color.White;
            this.dgv_GiaSP.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_GiaSP.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_GiaSP.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle23.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle23.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle23.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle23.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle23.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle23.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_GiaSP.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle23;
            this.dgv_GiaSP.ColumnHeadersHeight = 4;
            dataGridViewCellStyle24.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle24.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle24.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle24.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle24.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle24.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_GiaSP.DefaultCellStyle = dataGridViewCellStyle24;
            this.dgv_GiaSP.EnableHeadersVisualStyles = false;
            this.dgv_GiaSP.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.Location = new System.Drawing.Point(91, 62);
            this.dgv_GiaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgv_GiaSP.MultiSelect = false;
            this.dgv_GiaSP.Name = "dgv_GiaSP";
            this.dgv_GiaSP.ReadOnly = true;
            this.dgv_GiaSP.RowHeadersVisible = false;
            this.dgv_GiaSP.RowHeadersWidth = 51;
            this.dgv_GiaSP.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_GiaSP.Size = new System.Drawing.Size(1059, 546);
            this.dgv_GiaSP.TabIndex = 41;
            this.dgv_GiaSP.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_GiaSP.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_GiaSP.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_GiaSP.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_GiaSP.ThemeStyle.ReadOnly = true;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_GiaSP.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_GiaSP.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_GiaSP.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_GiaSP.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_GiaSP.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_GiaSP_CellContentClick);
            // 
            // btn_LamMoi_GiaSP
            // 
            this.btn_LamMoi_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_LamMoi_GiaSP.AnimationSpeed = 0.03F;
            this.btn_LamMoi_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_LamMoi_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_GiaSP.BorderSize = 1;
            this.btn_LamMoi_GiaSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_LamMoi_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LamMoi_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LamMoi_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi_GiaSP.Image")));
            this.btn_LamMoi_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_LamMoi_GiaSP.Location = new System.Drawing.Point(16, 162);
            this.btn_LamMoi_GiaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_LamMoi_GiaSP.Name = "btn_LamMoi_GiaSP";
            this.btn_LamMoi_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_LamMoi_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_GiaSP.OnHoverImage = null;
            this.btn_LamMoi_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_LamMoi_GiaSP.Size = new System.Drawing.Size(47, 43);
            this.btn_LamMoi_GiaSP.TabIndex = 40;
            this.btn_LamMoi_GiaSP.Click += new System.EventHandler(this.btn_LamMoi_GiaSP_Click);
            // 
            // btn_Xoa_GiaSP
            // 
            this.btn_Xoa_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_GiaSP.AnimationSpeed = 0.03F;
            this.btn_Xoa_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_Xoa_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_GiaSP.BorderSize = 1;
            this.btn_Xoa_GiaSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa_GiaSP.Image")));
            this.btn_Xoa_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_GiaSP.Location = new System.Drawing.Point(16, 112);
            this.btn_Xoa_GiaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Xoa_GiaSP.Name = "btn_Xoa_GiaSP";
            this.btn_Xoa_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_GiaSP.OnHoverImage = null;
            this.btn_Xoa_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_GiaSP.Size = new System.Drawing.Size(47, 43);
            this.btn_Xoa_GiaSP.TabIndex = 39;
            this.btn_Xoa_GiaSP.Click += new System.EventHandler(this.btn_Xoa_GiaSP_Click);
            // 
            // btn_Sua_GiaSP
            // 
            this.btn_Sua_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_GiaSP.AnimationSpeed = 0.03F;
            this.btn_Sua_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_Sua_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_GiaSP.BorderSize = 1;
            this.btn_Sua_GiaSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua_GiaSP.Image")));
            this.btn_Sua_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_GiaSP.Location = new System.Drawing.Point(16, 62);
            this.btn_Sua_GiaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Sua_GiaSP.Name = "btn_Sua_GiaSP";
            this.btn_Sua_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_GiaSP.OnHoverImage = null;
            this.btn_Sua_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_GiaSP.Size = new System.Drawing.Size(47, 43);
            this.btn_Sua_GiaSP.TabIndex = 38;
            this.btn_Sua_GiaSP.Click += new System.EventHandler(this.btn_Sua_GiaSP_Click);
            // 
            // btn_Them_GiaSP
            // 
            this.btn_Them_GiaSP.AnimationHoverSpeed = 0.07F;
            this.btn_Them_GiaSP.AnimationSpeed = 0.03F;
            this.btn_Them_GiaSP.BaseColor = System.Drawing.Color.White;
            this.btn_Them_GiaSP.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_GiaSP.BorderSize = 1;
            this.btn_Them_GiaSP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_GiaSP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_GiaSP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_GiaSP.ForeColor = System.Drawing.Color.White;
            this.btn_Them_GiaSP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_GiaSP.Image")));
            this.btn_Them_GiaSP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_GiaSP.Location = new System.Drawing.Point(16, 11);
            this.btn_Them_GiaSP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them_GiaSP.Name = "btn_Them_GiaSP";
            this.btn_Them_GiaSP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_GiaSP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_GiaSP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_GiaSP.OnHoverImage = null;
            this.btn_Them_GiaSP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_GiaSP.Size = new System.Drawing.Size(47, 43);
            this.btn_Them_GiaSP.TabIndex = 37;
            this.btn_Them_GiaSP.Click += new System.EventHandler(this.btn_Them_GiaSP_Click);
            // 
            // btn_Tim_giasp
            // 
            this.btn_Tim_giasp.AnimationHoverSpeed = 0.07F;
            this.btn_Tim_giasp.AnimationSpeed = 0.03F;
            this.btn_Tim_giasp.BaseColor = System.Drawing.Color.White;
            this.btn_Tim_giasp.BorderColor = System.Drawing.Color.Black;
            this.btn_Tim_giasp.BorderSize = 1;
            this.btn_Tim_giasp.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Tim_giasp.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Tim_giasp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Tim_giasp.ForeColor = System.Drawing.Color.White;
            this.btn_Tim_giasp.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim_giasp.Image")));
            this.btn_Tim_giasp.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Tim_giasp.Location = new System.Drawing.Point(1058, 9);
            this.btn_Tim_giasp.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim_giasp.Name = "btn_Tim_giasp";
            this.btn_Tim_giasp.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Tim_giasp.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Tim_giasp.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Tim_giasp.OnHoverImage = null;
            this.btn_Tim_giasp.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Tim_giasp.Size = new System.Drawing.Size(47, 43);
            this.btn_Tim_giasp.TabIndex = 43;
            // 
            // txt_Tim_giasp
            // 
            this.txt_Tim_giasp.BackColor = System.Drawing.Color.Transparent;
            this.txt_Tim_giasp.BaseColor = System.Drawing.Color.White;
            this.txt_Tim_giasp.BorderColor = System.Drawing.Color.Silver;
            this.txt_Tim_giasp.BorderSize = 1;
            this.txt_Tim_giasp.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tim_giasp.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Tim_giasp.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Tim_giasp.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Tim_giasp.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tim_giasp.Location = new System.Drawing.Point(823, 11);
            this.txt_Tim_giasp.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tim_giasp.Name = "txt_Tim_giasp";
            this.txt_Tim_giasp.PasswordChar = '\0';
            this.txt_Tim_giasp.Radius = 12;
            this.txt_Tim_giasp.SelectedText = "";
            this.txt_Tim_giasp.Size = new System.Drawing.Size(232, 37);
            this.txt_Tim_giasp.TabIndex = 42;
            this.txt_Tim_giasp.TextChanged += new System.EventHandler(this.txt_Tim_giasp_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(489, 28);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 17);
            this.label2.TabIndex = 47;
            this.label2.Text = "Đến";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(254, 28);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(25, 17);
            this.label1.TabIndex = 46;
            this.label1.Text = "Từ";
            // 
            // cbb_giasp_from
            // 
            this.cbb_giasp_from.Enabled = false;
            this.cbb_giasp_from.FormattingEnabled = true;
            this.cbb_giasp_from.Items.AddRange(new object[] {
            "0"});
            this.cbb_giasp_from.Location = new System.Drawing.Point(533, 24);
            this.cbb_giasp_from.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_giasp_from.Name = "cbb_giasp_from";
            this.cbb_giasp_from.Size = new System.Drawing.Size(160, 24);
            this.cbb_giasp_from.TabIndex = 45;
            this.cbb_giasp_from.SelectedIndexChanged += new System.EventHandler(this.cbb_giasp_from_SelectedIndexChanged);
            // 
            // cbb_giasp_to
            // 
            this.cbb_giasp_to.Enabled = false;
            this.cbb_giasp_to.FormattingEnabled = true;
            this.cbb_giasp_to.Items.AddRange(new object[] {
            "0"});
            this.cbb_giasp_to.Location = new System.Drawing.Point(301, 24);
            this.cbb_giasp_to.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_giasp_to.Name = "cbb_giasp_to";
            this.cbb_giasp_to.Size = new System.Drawing.Size(160, 24);
            this.cbb_giasp_to.TabIndex = 44;
            this.cbb_giasp_to.SelectedIndexChanged += new System.EventHandler(this.cbb_giasp_to_SelectedIndexChanged);
            // 
            // ckb_LocSP
            // 
            this.ckb_LocSP.BaseColor = System.Drawing.Color.White;
            this.ckb_LocSP.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckb_LocSP.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ckb_LocSP.FillColor = System.Drawing.Color.White;
            this.ckb_LocSP.Location = new System.Drawing.Point(114, 24);
            this.ckb_LocSP.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_LocSP.Name = "ckb_LocSP";
            this.ckb_LocSP.Size = new System.Drawing.Size(118, 20);
            this.ckb_LocSP.TabIndex = 48;
            this.ckb_LocSP.Text = "Lọc Sản Phẩm";
            this.ckb_LocSP.CheckedChanged += new System.EventHandler(this.ckb_LocSP_CheckedChanged);
            // 
            // UC_GiaSP_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckb_LocSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_giasp_from);
            this.Controls.Add(this.cbb_giasp_to);
            this.Controls.Add(this.btn_Tim_giasp);
            this.Controls.Add(this.txt_Tim_giasp);
            this.Controls.Add(this.dgv_GiaSP);
            this.Controls.Add(this.btn_LamMoi_GiaSP);
            this.Controls.Add(this.btn_Xoa_GiaSP);
            this.Controls.Add(this.btn_Sua_GiaSP);
            this.Controls.Add(this.btn_Them_GiaSP);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "UC_GiaSP_TT";
            this.Size = new System.Drawing.Size(1165, 630);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_GiaSP)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI.WinForms.GunaDataGridView dgv_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_LamMoi_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Xoa_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Sua_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_GiaSP;
        private Guna.UI.WinForms.GunaCircleButton btn_Tim_giasp;
        private Guna.UI.WinForms.GunaTextBox txt_Tim_giasp;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_giasp_from;
        private System.Windows.Forms.ComboBox cbb_giasp_to;
        private Guna.UI.WinForms.GunaCheckBox ckb_LocSP;
    }
}
