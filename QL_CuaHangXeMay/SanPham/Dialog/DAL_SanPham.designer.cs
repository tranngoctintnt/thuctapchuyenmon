
namespace QuanLy_CuaHang.SanPham.Dialog
{
    partial class DAL_SanPham
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAL_SanPham));
            this.label6 = new System.Windows.Forms.Label();
            this.nbr_Soluong = new Guna.UI.WinForms.GunaNumeric();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_Ten_SP = new Guna.UI.WinForms.GunaTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_Ma_SP = new Guna.UI.WinForms.GunaTextBox();
            this.cbb_Hang = new System.Windows.Forms.ComboBox();
            this.cbb_Loai = new System.Windows.Forms.ComboBox();
            this.cbb_DanhMuc = new System.Windows.Forms.ComboBox();
            this.btn_Huy = new Guna.UI.WinForms.GunaButton();
            this.btn_Luu = new Guna.UI.WinForms.GunaButton();
            this.btn_Them_Hang = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Them_Loai = new Guna.UI.WinForms.GunaCircleButton();
            this.btn_Them_DM = new Guna.UI.WinForms.GunaCircleButton();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(28, 116);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(64, 17);
            this.label6.TabIndex = 54;
            this.label6.Text = "Số lượng";
            // 
            // nbr_Soluong
            // 
            this.nbr_Soluong.BackColor = System.Drawing.Color.Transparent;
            this.nbr_Soluong.BaseColor = System.Drawing.Color.White;
            this.nbr_Soluong.BorderColor = System.Drawing.Color.Silver;
            this.nbr_Soluong.ButtonColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.nbr_Soluong.ButtonForeColor = System.Drawing.Color.White;
            this.nbr_Soluong.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.nbr_Soluong.ForeColor = System.Drawing.Color.Black;
            this.nbr_Soluong.Location = new System.Drawing.Point(100, 106);
            this.nbr_Soluong.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.nbr_Soluong.Maximum = ((long)(9999999));
            this.nbr_Soluong.Minimum = ((long)(0));
            this.nbr_Soluong.Name = "nbr_Soluong";
            this.nbr_Soluong.Radius = 12;
            this.nbr_Soluong.Size = new System.Drawing.Size(213, 30);
            this.nbr_Soluong.TabIndex = 53;
            this.nbr_Soluong.Value = ((long)(0));
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(49, 228);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 17);
            this.label5.TabIndex = 47;
            this.label5.Text = "Hãng";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(58, 158);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 17);
            this.label4.TabIndex = 46;
            this.label4.Text = "Tên";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(57, 194);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 17);
            this.label3.TabIndex = 45;
            this.label3.Text = "Loại";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 71);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 17);
            this.label2.TabIndex = 44;
            this.label2.Text = "Màu";
            // 
            // txt_Ten_SP
            // 
            this.txt_Ten_SP.BackColor = System.Drawing.Color.Transparent;
            this.txt_Ten_SP.BaseColor = System.Drawing.Color.White;
            this.txt_Ten_SP.BorderColor = System.Drawing.Color.Silver;
            this.txt_Ten_SP.BorderSize = 1;
            this.txt_Ten_SP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Ten_SP.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Ten_SP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Ten_SP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Ten_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Ten_SP.Location = new System.Drawing.Point(100, 62);
            this.txt_Ten_SP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Ten_SP.Name = "txt_Ten_SP";
            this.txt_Ten_SP.PasswordChar = '\0';
            this.txt_Ten_SP.Radius = 12;
            this.txt_Ten_SP.SelectedText = "";
            this.txt_Ten_SP.Size = new System.Drawing.Size(213, 37);
            this.txt_Ten_SP.TabIndex = 43;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 27);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 42;
            this.label1.Text = "Mã";
            // 
            // txt_Ma_SP
            // 
            this.txt_Ma_SP.BackColor = System.Drawing.Color.Transparent;
            this.txt_Ma_SP.BaseColor = System.Drawing.Color.White;
            this.txt_Ma_SP.BorderColor = System.Drawing.Color.Silver;
            this.txt_Ma_SP.BorderSize = 1;
            this.txt_Ma_SP.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txt_Ma_SP.FocusedBaseColor = System.Drawing.Color.White;
            this.txt_Ma_SP.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txt_Ma_SP.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txt_Ma_SP.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txt_Ma_SP.Location = new System.Drawing.Point(100, 17);
            this.txt_Ma_SP.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_Ma_SP.Name = "txt_Ma_SP";
            this.txt_Ma_SP.PasswordChar = '\0';
            this.txt_Ma_SP.Radius = 12;
            this.txt_Ma_SP.ReadOnly = true;
            this.txt_Ma_SP.SelectedText = "";
            this.txt_Ma_SP.Size = new System.Drawing.Size(213, 37);
            this.txt_Ma_SP.TabIndex = 41;
            // 
            // cbb_Hang
            // 
            this.cbb_Hang.FormattingEnabled = true;
            this.cbb_Hang.Location = new System.Drawing.Point(100, 224);
            this.cbb_Hang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_Hang.Name = "cbb_Hang";
            this.cbb_Hang.Size = new System.Drawing.Size(212, 24);
            this.cbb_Hang.TabIndex = 40;
            // 
            // cbb_Loai
            // 
            this.cbb_Loai.FormattingEnabled = true;
            this.cbb_Loai.Location = new System.Drawing.Point(100, 191);
            this.cbb_Loai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_Loai.Name = "cbb_Loai";
            this.cbb_Loai.Size = new System.Drawing.Size(212, 24);
            this.cbb_Loai.TabIndex = 39;
            // 
            // cbb_DanhMuc
            // 
            this.cbb_DanhMuc.FormattingEnabled = true;
            this.cbb_DanhMuc.Location = new System.Drawing.Point(100, 158);
            this.cbb_DanhMuc.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbb_DanhMuc.Name = "cbb_DanhMuc";
            this.cbb_DanhMuc.Size = new System.Drawing.Size(212, 24);
            this.cbb_DanhMuc.TabIndex = 38;
            // 
            // btn_Huy
            // 
            this.btn_Huy.AnimationHoverSpeed = 0.07F;
            this.btn_Huy.AnimationSpeed = 0.03F;
            this.btn_Huy.BackColor = System.Drawing.Color.Transparent;
            this.btn_Huy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Huy.BorderColor = System.Drawing.Color.Black;
            this.btn_Huy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Huy.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Huy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Huy.ForeColor = System.Drawing.Color.White;
            this.btn_Huy.Image = ((System.Drawing.Image)(resources.GetObject("btn_Huy.Image")));
            this.btn_Huy.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Huy.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Huy.Location = new System.Drawing.Point(201, 268);
            this.btn_Huy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Huy.Name = "btn_Huy";
            this.btn_Huy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Huy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Huy.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Huy.OnHoverImage = null;
            this.btn_Huy.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Huy.Radius = 12;
            this.btn_Huy.Size = new System.Drawing.Size(92, 37);
            this.btn_Huy.TabIndex = 52;
            this.btn_Huy.Text = "Hủy";
            this.btn_Huy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Huy.Click += new System.EventHandler(this.btn_Huy_Click);
            // 
            // btn_Luu
            // 
            this.btn_Luu.AnimationHoverSpeed = 0.07F;
            this.btn_Luu.AnimationSpeed = 0.03F;
            this.btn_Luu.BackColor = System.Drawing.Color.Transparent;
            this.btn_Luu.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btn_Luu.BorderColor = System.Drawing.Color.Black;
            this.btn_Luu.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Luu.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Luu.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Luu.ForeColor = System.Drawing.Color.White;
            this.btn_Luu.Image = ((System.Drawing.Image)(resources.GetObject("btn_Luu.Image")));
            this.btn_Luu.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Luu.ImageSize = new System.Drawing.Size(20, 20);
            this.btn_Luu.Location = new System.Drawing.Point(101, 268);
            this.btn_Luu.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Luu.Name = "btn_Luu";
            this.btn_Luu.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Luu.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Luu.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Luu.OnHoverImage = null;
            this.btn_Luu.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Luu.Radius = 12;
            this.btn_Luu.Size = new System.Drawing.Size(92, 37);
            this.btn_Luu.TabIndex = 51;
            this.btn_Luu.Text = "Lưu";
            this.btn_Luu.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btn_Luu.Click += new System.EventHandler(this.btn_Luu_Click);
            // 
            // btn_Them_Hang
            // 
            this.btn_Them_Hang.AnimationHoverSpeed = 0.07F;
            this.btn_Them_Hang.AnimationSpeed = 0.03F;
            this.btn_Them_Hang.BaseColor = System.Drawing.Color.White;
            this.btn_Them_Hang.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_Hang.BorderSize = 1;
            this.btn_Them_Hang.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_Hang.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_Hang.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_Hang.ForeColor = System.Drawing.Color.White;
            this.btn_Them_Hang.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_Hang.Image")));
            this.btn_Them_Hang.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_Them_Hang.Location = new System.Drawing.Point(321, 225);
            this.btn_Them_Hang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them_Hang.Name = "btn_Them_Hang";
            this.btn_Them_Hang.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_Hang.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_Hang.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_Hang.OnHoverImage = null;
            this.btn_Them_Hang.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_Hang.Size = new System.Drawing.Size(27, 25);
            this.btn_Them_Hang.TabIndex = 50;
            this.btn_Them_Hang.Click += new System.EventHandler(this.btn_Them_Hang_Click);
            // 
            // btn_Them_Loai
            // 
            this.btn_Them_Loai.AnimationHoverSpeed = 0.07F;
            this.btn_Them_Loai.AnimationSpeed = 0.03F;
            this.btn_Them_Loai.BaseColor = System.Drawing.Color.White;
            this.btn_Them_Loai.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_Loai.BorderSize = 1;
            this.btn_Them_Loai.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_Loai.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_Loai.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_Loai.ForeColor = System.Drawing.Color.White;
            this.btn_Them_Loai.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_Loai.Image")));
            this.btn_Them_Loai.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_Them_Loai.Location = new System.Drawing.Point(321, 191);
            this.btn_Them_Loai.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them_Loai.Name = "btn_Them_Loai";
            this.btn_Them_Loai.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_Loai.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_Loai.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_Loai.OnHoverImage = null;
            this.btn_Them_Loai.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_Loai.Size = new System.Drawing.Size(27, 25);
            this.btn_Them_Loai.TabIndex = 49;
            this.btn_Them_Loai.Click += new System.EventHandler(this.btn_Them_Loai_Click);
            // 
            // btn_Them_DM
            // 
            this.btn_Them_DM.AnimationHoverSpeed = 0.07F;
            this.btn_Them_DM.AnimationSpeed = 0.03F;
            this.btn_Them_DM.BaseColor = System.Drawing.Color.White;
            this.btn_Them_DM.BorderColor = System.Drawing.Color.Black;
            this.btn_Them_DM.BorderSize = 1;
            this.btn_Them_DM.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btn_Them_DM.FocusedColor = System.Drawing.Color.Empty;
            this.btn_Them_DM.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btn_Them_DM.ForeColor = System.Drawing.Color.White;
            this.btn_Them_DM.Image = ((System.Drawing.Image)(resources.GetObject("btn_Them_DM.Image")));
            this.btn_Them_DM.ImageSize = new System.Drawing.Size(18, 18);
            this.btn_Them_DM.Location = new System.Drawing.Point(321, 159);
            this.btn_Them_DM.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_Them_DM.Name = "btn_Them_DM";
            this.btn_Them_DM.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btn_Them_DM.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btn_Them_DM.OnHoverForeColor = System.Drawing.Color.White;
            this.btn_Them_DM.OnHoverImage = null;
            this.btn_Them_DM.OnPressedColor = System.Drawing.Color.Black;
            this.btn_Them_DM.Size = new System.Drawing.Size(27, 25);
            this.btn_Them_DM.TabIndex = 48;
            this.btn_Them_DM.Click += new System.EventHandler(this.btn_Them_DM_Click);
            // 
            // DAL_SanPham
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 331);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.nbr_Soluong);
            this.Controls.Add(this.btn_Huy);
            this.Controls.Add(this.btn_Luu);
            this.Controls.Add(this.btn_Them_Hang);
            this.Controls.Add(this.btn_Them_Loai);
            this.Controls.Add(this.btn_Them_DM);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txt_Ten_SP);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Ma_SP);
            this.Controls.Add(this.cbb_Hang);
            this.Controls.Add(this.cbb_Loai);
            this.Controls.Add(this.cbb_DanhMuc);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DAL_SanPham";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin sản phẩm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label6;
        private Guna.UI.WinForms.GunaNumeric nbr_Soluong;
        private Guna.UI.WinForms.GunaButton btn_Huy;
        private Guna.UI.WinForms.GunaButton btn_Luu;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_Hang;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_Loai;
        private Guna.UI.WinForms.GunaCircleButton btn_Them_DM;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private Guna.UI.WinForms.GunaTextBox txt_Ten_SP;
        private System.Windows.Forms.Label label1;
        private Guna.UI.WinForms.GunaTextBox txt_Ma_SP;
        private System.Windows.Forms.ComboBox cbb_Hang;
        private System.Windows.Forms.ComboBox cbb_Loai;
        private System.Windows.Forms.ComboBox cbb_DanhMuc;
    }
}