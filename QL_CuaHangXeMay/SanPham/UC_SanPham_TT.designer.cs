
namespace QuanLy_CuaHang.SanPham
{
    partial class UC_SanPham_TT
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UC_SanPham_TT));
            this.ckb_LocSP = new Guna.UI.WinForms.GunaCheckBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cbb_LoaiSP = new System.Windows.Forms.ComboBox();
            this.cbb_SP = new System.Windows.Forms.ComboBox();
            this.txt_Tim_SP = new Guna.UI.WinForms.GunaTextBox();
            this.dgv_SanPham = new Guna.UI.WinForms.GunaDataGridView();
            this.btn_Tim_SP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_LamMoi_SP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Xoa_SP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Sua_SP = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Them_SP = new Guna.UI.WinForms.GunaCircleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // ckb_LocSP
            // 
            this.ckb_LocSP.BaseColor = System.Drawing.Color.White;
            this.ckb_LocSP.CheckedOffColor = System.Drawing.Color.Gray;
            this.ckb_LocSP.CheckedOnColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.ckb_LocSP.FillColor = System.Drawing.Color.White;
            this.ckb_LocSP.Location = new System.Drawing.Point(115, 21);
            this.ckb_LocSP.Margin = new System.Windows.Forms.Padding(4);
            this.ckb_LocSP.Name = "ckb_LocSP";
            this.ckb_LocSP.Size = new System.Drawing.Size(118, 20);
            this.ckb_LocSP.TabIndex = 38;
            this.ckb_LocSP.Text = "Lọc Sản Phẩm";
            this.ckb_LocSP.CheckedChanged += new System.EventHandler(this.ckb_LocSP_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(515, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 37;
            this.label2.Text = "Loại";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(280, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 17);
            this.label1.TabIndex = 36;
            this.label1.Text = "Hãng";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cbb_LoaiSP
            // 
            this.cbb_LoaiSP.Enabled = false;
            this.cbb_LoaiSP.FormattingEnabled = true;
            this.cbb_LoaiSP.Location = new System.Drawing.Point(559, 21);
            this.cbb_LoaiSP.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_LoaiSP.Name = "cbb_LoaiSP";
            this.cbb_LoaiSP.Size = new System.Drawing.Size(160, 24);
            this.cbb_LoaiSP.TabIndex = 35;
            this.cbb_LoaiSP.SelectedIndexChanged += new System.EventHandler(this.cbb_LoaiSP_SelectedIndexChanged);
            // 
            // cbb_SP
            // 
            this.cbb_SP.Enabled = false;
            this.cbb_SP.FormattingEnabled = true;
            this.cbb_SP.Location = new System.Drawing.Point(327, 21);
            this.cbb_SP.Margin = new System.Windows.Forms.Padding(4);
            this.cbb_SP.Name = "cbb_SP";
            this.cbb_SP.Size = new System.Drawing.Size(160, 24);
            this.cbb_SP.TabIndex = 34;
            this.cbb_SP.SelectedIndexChanged += new System.EventHandler(this.cbb_SP_SelectedIndexChanged);
            // 
            // txt_Tim_SP
            // 
            this.txt_Tim_SP.BackColor = System.Drawing.Color.Transparent;
            this.txt_Tim_SP.BaseColor = System.Drawing.Color.White;
            this.txt_Tim_SP.BorderColor = System.Drawing.Color.Silver;
            this.txt_Tim_SP.BorderSize = 1;
            this.txt_Tim_SP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Tim_SP.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Tim_SP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Tim_SP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Tim_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Tim_SP.Location = new System.Drawing.Point(887, 16);
            this.txt_Tim_SP.Margin = new System.Windows.Forms.Padding(4);
            this.txt_Tim_SP.Name = "txt_Tim_SP";
            this.txt_Tim_SP.PasswordChar = '\0';
            this.txt_Tim_SP.Radius = 12;
            this.txt_Tim_SP.SelectedText = "";
            this.txt_Tim_SP.Size = new System.Drawing.Size(213, 37);
            this.txt_Tim_SP.TabIndex = 32;
            this.txt_Tim_SP.TextChanged += new System.EventHandler(this.txt_Tim_SP_TextChanged);
            // 
            // dgv_SanPham
            // 
            this.dgv_SanPham.AllowUserToAddRows = false;
            this.dgv_SanPham.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dgv_SanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgv_SanPham.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_SanPham.BackgroundColor = System.Drawing.Color.White;
            this.dgv_SanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgv_SanPham.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgv_SanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dgv_SanPham.ColumnHeadersHeight = 4;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgv_SanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.dgv_SanPham.EnableHeadersVisualStyles = false;
            this.dgv_SanPham.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.Location = new System.Drawing.Point(91, 64);
            this.dgv_SanPham.Margin = new System.Windows.Forms.Padding(4);
            this.dgv_SanPham.Name = "dgv_SanPham";
            this.dgv_SanPham.ReadOnly = true;
            this.dgv_SanPham.RowHeadersVisible = false;
            this.dgv_SanPham.RowHeadersWidth = 51;
            this.dgv_SanPham.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_SanPham.Size = new System.Drawing.Size(1059, 546);
            this.dgv_SanPham.TabIndex = 31;
            this.dgv_SanPham.Theme = Guna.UI.WinForms.GunaDataGridViewPresetThemes.Guna;
            this.dgv_SanPham.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SanPham.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.dgv_SanPham.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.dgv_SanPham.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.dgv_SanPham.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.dgv_SanPham.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SanPham.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgv_SanPham.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_SanPham.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.dgv_SanPham.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.dgv_SanPham.ThemeStyle.HeaderStyle.Height = 4;
            this.dgv_SanPham.ThemeStyle.ReadOnly = true;
            this.dgv_SanPham.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.dgv_SanPham.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.dgv_SanPham.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI", 10.5F);
            this.dgv_SanPham.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SanPham.ThemeStyle.RowsStyle.Height = 22;
            this.dgv_SanPham.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.dgv_SanPham.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.dgv_SanPham.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_SanPham_CellContentClick);
            // 
            // btn_Tim_SP
            // 
            this.btn_Tim_SP.AnimationHoverSpeed = 0.07F;
            this.btn_Tim_SP.AnimationSpeed = 0.03F;
            this.btn_Tim_SP.BaseColor = System.Drawing.Color.White;
            this.btn_Tim_SP.BorderColor = System.Drawing.Color.Black;
            this.btn_Tim_SP.BorderSize = 1;
            this.btn_Tim_SP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Tim_SP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Tim_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Tim_SP.ForeColor = System.Drawing.Color.White;
            this.btn_Tim_SP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Tim_SP.Image")));
            this.btn_Tim_SP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Tim_SP.Location = new System.Drawing.Point(1103, 14);
            this.btn_Tim_SP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Tim_SP.Name = "btn_Tim_SP";
            this.btn_Tim_SP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Tim_SP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Tim_SP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Tim_SP.OnHoverImage = null;
            this.btn_Tim_SP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Tim_SP.Size = new System.Drawing.Size(47, 43);
            this.btn_Tim_SP.TabIndex = 33;
            // 
            // btn_LamMoi_SP
            // 
            this.btn_LamMoi_SP.AnimationHoverSpeed = 0.07F;
            this.btn_LamMoi_SP.AnimationSpeed = 0.03F;
            this.btn_LamMoi_SP.BaseColor = System.Drawing.Color.White;
            this.btn_LamMoi_SP.BorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_SP.BorderSize = 1;
            this.btn_LamMoi_SP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_LamMoi_SP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_LamMoi_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_LamMoi_SP.ForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_SP.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamMoi_SP.Image")));
            this.btn_LamMoi_SP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_LamMoi_SP.Location = new System.Drawing.Point(16, 165);
            this.btn_LamMoi_SP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_LamMoi_SP.Name = "btn_LamMoi_SP";
            this.btn_LamMoi_SP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_LamMoi_SP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_LamMoi_SP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_LamMoi_SP.OnHoverImage = null;
            this.btn_LamMoi_SP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_LamMoi_SP.Size = new System.Drawing.Size(47, 43);
            this.btn_LamMoi_SP.TabIndex = 30;
            this.btn_LamMoi_SP.Click += new System.EventHandler(this.btn_LamMoi_SP_Click);
            // 
            // btn_Xoa_SP
            // 
            this.btn_Xoa_SP.AnimationHoverSpeed = 0.07F;
            this.btn_Xoa_SP.AnimationSpeed = 0.03F;
            this.btn_Xoa_SP.BaseColor = System.Drawing.Color.White;
            this.btn_Xoa_SP.BorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_SP.BorderSize = 1;
            this.btn_Xoa_SP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Xoa_SP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Xoa_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Xoa_SP.ForeColor = System.Drawing.Color.White;
            this.btn_Xoa_SP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Xoa_SP.Image")));
            this.btn_Xoa_SP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Xoa_SP.Location = new System.Drawing.Point(16, 114);
            this.btn_Xoa_SP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Xoa_SP.Name = "btn_Xoa_SP";
            this.btn_Xoa_SP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Xoa_SP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Xoa_SP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Xoa_SP.OnHoverImage = null;
            this.btn_Xoa_SP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Xoa_SP.Size = new System.Drawing.Size(47, 43);
            this.btn_Xoa_SP.TabIndex = 29;
            this.btn_Xoa_SP.Click += new System.EventHandler(this.btn_Xoa_SP_Click);
            // 
            // btn_Sua_SP
            // 
            this.btn_Sua_SP.AnimationHoverSpeed = 0.07F;
            this.btn_Sua_SP.AnimationSpeed = 0.03F;
            this.btn_Sua_SP.BaseColor = System.Drawing.Color.White;
            this.btn_Sua_SP.BorderColor = System.Drawing.Color.Black;
            this.btn_Sua_SP.BorderSize = 1;
            this.btn_Sua_SP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Sua_SP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Sua_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Sua_SP.ForeColor = System.Drawing.Color.White;
            this.btn_Sua_SP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Sua_SP.Image")));
            this.btn_Sua_SP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Sua_SP.Location = new System.Drawing.Point(16, 64);
            this.btn_Sua_SP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Sua_SP.Name = "btn_Sua_SP";
            this.btn_Sua_SP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Sua_SP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Sua_SP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Sua_SP.OnHoverImage = null;
            this.btn_Sua_SP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Sua_SP.Size = new System.Drawing.Size(47, 43);
            this.btn_Sua_SP.TabIndex = 28;
            this.btn_Sua_SP.Click += new System.EventHandler(this.btn_Sua_SP_Click);
            // 
            // btn_Them_SP
            // 
            this.btn_Them_SP.AnimationHoverSpeed = 0.07F;
            this.btn_Them_SP.AnimationSpeed = 0.03F;
            this.btn_Them_SP.BaseColor = System.Drawing.Color.White;
            this.btn_Them_SP.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_SP.BorderSize = 1;
            this.btn_Them_SP.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_SP.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_SP.ForeColor = System.Drawing.Color.White;
            this.btn_Them_SP.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_SP.Image")));
            this.btn_Them_SP.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Them_SP.Location = new System.Drawing.Point(16, 14);
            this.btn_Them_SP.Margin = new System.Windows.Forms.Padding(4);
            this.btn_Them_SP.Name = "btn_Them_SP";
            this.btn_Them_SP.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_SP.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_SP.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_SP.OnHoverImage = null;
            this.btn_Them_SP.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_SP.Size = new System.Drawing.Size(47, 43);
            this.btn_Them_SP.TabIndex = 27;
            this.btn_Them_SP.Click += new System.EventHandler(this.btn_Them_SP_Click);
            // 
            // UC_SanPham_TT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ckb_LocSP);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbb_LoaiSP);
            this.Controls.Add(this.cbb_SP);
            this.Controls.Add(this.btn_Tim_SP);
            this.Controls.Add(this.txt_Tim_SP);
            this.Controls.Add(this.dgv_SanPham);
            this.Controls.Add(this.btn_LamMoi_SP);
            this.Controls.Add(this.btn_Xoa_SP);
            this.Controls.Add(this.btn_Sua_SP);
            this.Controls.Add(this.btn_Them_SP);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "UC_SanPham_TT";
            this.Size = new System.Drawing.Size(1167, 631);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_SanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI.WinForms.GunaCheckBox ckb_LocSP;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbb_LoaiSP;
        private System.Windows.Forms.ComboBox cbb_SP;
        private Guna.UI.WinForms.GunaCircleButton btn_Tim_SP;
        private Guna.UI.WinForms.GunaTextBox txt_Tim_SP;
        private Guna.UI.WinForms.GunaDataGridView dgv_SanPham;
        private Guna.UI.WinForms.GunaCircleButton btn_LamMoi_SP;
        private Guna.UI.WinForms.GunaCircleButton btn_Xoa_SP;
        private Guna.UI.WinForms.GunaCircleButton btn_Sua_SP;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_SP;
    }
}
