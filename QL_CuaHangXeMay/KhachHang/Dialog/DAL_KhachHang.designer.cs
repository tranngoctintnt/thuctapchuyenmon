
namespace QuanLy_CuaHang.KhachHang1.Dialog
{
    partial class DAL_KhachHang
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DAL_KhachHang));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtMa_kh = new Guna.UI.WinForms.GunaTextBox();
            this.txtTenKH = new Guna.UI.WinForms.GunaTextBox();
            this.txtEmail = new Guna.UI.WinForms.GunaTextBox();
            this.txtSDT = new Guna.UI.WinForms.GunaTextBox();
            this.btnSave = new Guna.UI.WinForms.GunaButton();
            this.btnHuy = new Guna.UI.WinForms.GunaButton();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mã Khách Hàng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 79);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tên Khách Hàng";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 178);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Số Điện Thoại";
            // 
            // txtMa_kh
            // 
            this.txtMa_kh.BackColor = System.Drawing.Color.Transparent;
            this.txtMa_kh.BaseColor = System.Drawing.Color.White;
            this.txtMa_kh.BorderColor = System.Drawing.Color.Silver;
            this.txtMa_kh.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMa_kh.FocusedBaseColor = System.Drawing.Color.White;
            this.txtMa_kh.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtMa_kh.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtMa_kh.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtMa_kh.Location = new System.Drawing.Point(126, 12);
            this.txtMa_kh.Name = "txtMa_kh";
            this.txtMa_kh.PasswordChar = '\0';
            this.txtMa_kh.Radius = 10;
            this.txtMa_kh.Size = new System.Drawing.Size(188, 30);
            this.txtMa_kh.TabIndex = 4;
            // 
            // txtTenKH
            // 
            this.txtTenKH.BackColor = System.Drawing.Color.Transparent;
            this.txtTenKH.BaseColor = System.Drawing.Color.White;
            this.txtTenKH.BorderColor = System.Drawing.Color.Silver;
            this.txtTenKH.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenKH.FocusedBaseColor = System.Drawing.Color.White;
            this.txtTenKH.FocusedBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.txtTenKH.FocusedForeColor = System.Drawing.SystemColors.ControlText;
            this.txtTenKH.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtTenKH.Location = new System.Drawing.Point(126, 62);
            this.txtTenKH.Name = "txtTenKH";
            this.txtTenKH.PasswordChar = '\0';
            this.txtTenKH.Radius = 10;
            this.txtTenKH.Size = new System.Drawing.Size(188, 30);
            this.txtTenKH.TabIndex = 5;
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
            this.txtEmail.Location = new System.Drawing.Point(126, 112);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.PasswordChar = '\0';
            this.txtEmail.Radius = 10;
            this.txtEmail.Size = new System.Drawing.Size(188, 30);
            this.txtEmail.TabIndex = 6;
            this.txtEmail.TextChanged += new System.EventHandler(this.gunaTextBox3_TextChanged);
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
            this.txtSDT.Location = new System.Drawing.Point(126, 161);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.PasswordChar = '\0';
            this.txtSDT.Radius = 10;
            this.txtSDT.Size = new System.Drawing.Size(188, 30);
            this.txtSDT.TabIndex = 7;
            // 
            // btnSave
            // 
            this.btnSave.AnimationHoverSpeed = 0.07F;
            this.btnSave.AnimationSpeed = 0.03F;
            this.btnSave.BackColor = System.Drawing.Color.Transparent;
            this.btnSave.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnSave.BorderColor = System.Drawing.Color.Black;
            this.btnSave.FocusedColor = System.Drawing.Color.Empty;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
            this.btnSave.ImageSize = new System.Drawing.Size(20, 20);
            this.btnSave.Location = new System.Drawing.Point(95, 217);
            this.btnSave.Name = "btnSave";
            this.btnSave.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnSave.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnSave.OnHoverForeColor = System.Drawing.Color.White;
            this.btnSave.OnHoverImage = null;
            this.btnSave.OnPressedColor = System.Drawing.Color.Black;
            this.btnSave.Radius = 10;
            this.btnSave.Size = new System.Drawing.Size(76, 37);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Lưu";
            this.btnSave.Click += new System.EventHandler(this.gunaButton1_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = ((System.Drawing.Image)(resources.GetObject("btnHuy.Image")));
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(218, 217);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Radius = 10;
            this.btnHuy.Size = new System.Drawing.Size(76, 37);
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // DAL_KhachHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(336, 276);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtTenKH);
            this.Controls.Add(this.txtMa_kh);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "DAL_KhachHang";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Thông tin khách hàng";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private Guna.UI.WinForms.GunaTextBox txtMa_kh;
        private Guna.UI.WinForms.GunaTextBox txtTenKH;
        private Guna.UI.WinForms.GunaTextBox txtEmail;
        private Guna.UI.WinForms.GunaTextBox txtSDT;
        private Guna.UI.WinForms.GunaButton btnSave;
        private Guna.UI.WinForms.GunaButton btnHuy;
    }
}