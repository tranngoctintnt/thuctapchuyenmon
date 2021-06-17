
namespace QuanLy_CuaHang.HoaDon
{
    partial class PhieuNhap
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnHuy = new Guna.UI.WinForms.GunaButton();
            this.txtSLXe = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDGXe = new System.Windows.Forms.TextBox();
            this.cbxXe = new System.Windows.Forms.ComboBox();
            this.cbxNCC = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnThemXe = new Guna.UI.WinForms.GunaButton();
            this.lbTongTien = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.dgvXe = new System.Windows.Forms.DataGridView();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SLNHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONGIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.THANHTIEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Xoa = new System.Windows.Forms.DataGridViewButtonColumn();
            this.lbMaPN = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnIn = new Guna.UI.WinForms.GunaButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnHuy);
            this.groupBox1.Controls.Add(this.txtSLXe);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.txtDGXe);
            this.groupBox1.Controls.Add(this.cbxXe);
            this.groupBox1.Controls.Add(this.cbxNCC);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.btnThemXe);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(5, 73);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1096, 201);
            this.groupBox1.TabIndex = 52;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Nhập xe";
            // 
            // btnHuy
            // 
            this.btnHuy.AnimationHoverSpeed = 0.07F;
            this.btnHuy.AnimationSpeed = 0.03F;
            this.btnHuy.BackColor = System.Drawing.Color.Transparent;
            this.btnHuy.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnHuy.BorderColor = System.Drawing.Color.Black;
            this.btnHuy.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnHuy.FocusedColor = System.Drawing.Color.Empty;
            this.btnHuy.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHuy.ForeColor = System.Drawing.Color.White;
            this.btnHuy.Image = null;
            this.btnHuy.ImageSize = new System.Drawing.Size(20, 20);
            this.btnHuy.Location = new System.Drawing.Point(435, 142);
            this.btnHuy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnHuy.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnHuy.OnHoverForeColor = System.Drawing.Color.White;
            this.btnHuy.OnHoverImage = null;
            this.btnHuy.OnPressedColor = System.Drawing.Color.Black;
            this.btnHuy.Radius = 10;
            this.btnHuy.Size = new System.Drawing.Size(132, 52);
            this.btnHuy.TabIndex = 43;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // txtSLXe
            // 
            this.txtSLXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSLXe.Location = new System.Drawing.Point(185, 85);
            this.txtSLXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtSLXe.Name = "txtSLXe";
            this.txtSLXe.Size = new System.Drawing.Size(296, 30);
            this.txtSLXe.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(24, 34);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(42, 25);
            this.label2.TabIndex = 31;
            this.label2.Text = "Xe ";
            // 
            // txtDGXe
            // 
            this.txtDGXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDGXe.Location = new System.Drawing.Point(737, 89);
            this.txtDGXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtDGXe.Name = "txtDGXe";
            this.txtDGXe.Size = new System.Drawing.Size(315, 30);
            this.txtDGXe.TabIndex = 36;
            this.txtDGXe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDGXe_KeyPress);
            // 
            // cbxXe
            // 
            this.cbxXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxXe.FormattingEnabled = true;
            this.cbxXe.Location = new System.Drawing.Point(185, 31);
            this.cbxXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxXe.Name = "cbxXe";
            this.cbxXe.Size = new System.Drawing.Size(296, 33);
            this.cbxXe.TabIndex = 37;
            this.cbxXe.SelectedIndexChanged += new System.EventHandler(this.cbxXe_SelectedIndexChanged);
            // 
            // cbxNCC
            // 
            this.cbxNCC.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbxNCC.FormattingEnabled = true;
            this.cbxNCC.Location = new System.Drawing.Point(737, 31);
            this.cbxNCC.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbxNCC.Name = "cbxNCC";
            this.cbxNCC.Size = new System.Drawing.Size(317, 33);
            this.cbxNCC.TabIndex = 30;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(607, 96);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 25);
            this.label6.TabIndex = 35;
            this.label6.Text = "Đơn giá";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(552, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(133, 25);
            this.label1.TabIndex = 29;
            this.label1.Text = "Nhà cung cấp";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(11, 86);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 25);
            this.label5.TabIndex = 33;
            this.label5.Text = "Số lượng";
            // 
            // btnThemXe
            // 
            this.btnThemXe.AnimationHoverSpeed = 0.07F;
            this.btnThemXe.AnimationSpeed = 0.03F;
            this.btnThemXe.BackColor = System.Drawing.Color.Transparent;
            this.btnThemXe.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnThemXe.BorderColor = System.Drawing.Color.Black;
            this.btnThemXe.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnThemXe.FocusedColor = System.Drawing.Color.Empty;
            this.btnThemXe.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThemXe.ForeColor = System.Drawing.Color.White;
            this.btnThemXe.Image = null;
            this.btnThemXe.ImageSize = new System.Drawing.Size(20, 20);
            this.btnThemXe.Location = new System.Drawing.Point(185, 142);
            this.btnThemXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThemXe.Name = "btnThemXe";
            this.btnThemXe.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnThemXe.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnThemXe.OnHoverForeColor = System.Drawing.Color.White;
            this.btnThemXe.OnHoverImage = null;
            this.btnThemXe.OnPressedColor = System.Drawing.Color.Black;
            this.btnThemXe.Radius = 10;
            this.btnThemXe.Size = new System.Drawing.Size(132, 52);
            this.btnThemXe.TabIndex = 41;
            this.btnThemXe.Text = "Thêm";
            this.btnThemXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnThemXe.Click += new System.EventHandler(this.btnThemXe_Click);
            // 
            // lbTongTien
            // 
            this.lbTongTien.AutoSize = true;
            this.lbTongTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbTongTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbTongTien.Location = new System.Drawing.Point(847, 583);
            this.lbTongTien.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbTongTien.Name = "lbTongTien";
            this.lbTongTien.Size = new System.Drawing.Size(31, 33);
            this.lbTongTien.TabIndex = 51;
            this.lbTongTien.Text = "0";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(653, 585);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(127, 31);
            this.label10.TabIndex = 50;
            this.label10.Text = "Tổng tiền";
            // 
            // dgvXe
            // 
            this.dgvXe.AllowUserToAddRows = false;
            this.dgvXe.AllowUserToDeleteRows = false;
            this.dgvXe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvXe.BackgroundColor = System.Drawing.Color.White;
            this.dgvXe.ColumnHeadersHeight = 40;
            this.dgvXe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaSP,
            this.TenSP,
            this.SLNHAP,
            this.DONGIANHAP,
            this.THANHTIEN,
            this.Xoa});
            this.dgvXe.Location = new System.Drawing.Point(5, 281);
            this.dgvXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvXe.Name = "dgvXe";
            this.dgvXe.ReadOnly = true;
            this.dgvXe.RowHeadersVisible = false;
            this.dgvXe.RowHeadersWidth = 51;
            this.dgvXe.Size = new System.Drawing.Size(1096, 267);
            this.dgvXe.TabIndex = 49;
            this.dgvXe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvXe_CellClick);
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "ma_SP";
            this.MaSP.HeaderText = "Mã xe";
            this.MaSP.MinimumWidth = 6;
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            // 
            // TenSP
            // 
            this.TenSP.DataPropertyName = "ten_SP";
            this.TenSP.HeaderText = "Tên Xe";
            this.TenSP.MinimumWidth = 6;
            this.TenSP.Name = "TenSP";
            this.TenSP.ReadOnly = true;
            // 
            // SLNHAP
            // 
            this.SLNHAP.DataPropertyName = "soluong_sp";
            this.SLNHAP.HeaderText = "Số lượng";
            this.SLNHAP.MinimumWidth = 6;
            this.SLNHAP.Name = "SLNHAP";
            this.SLNHAP.ReadOnly = true;
            // 
            // DONGIANHAP
            // 
            this.DONGIANHAP.DataPropertyName = "gianhap_SP";
            this.DONGIANHAP.HeaderText = "Đơn giá";
            this.DONGIANHAP.MinimumWidth = 6;
            this.DONGIANHAP.Name = "DONGIANHAP";
            this.DONGIANHAP.ReadOnly = true;
            // 
            // THANHTIEN
            // 
            this.THANHTIEN.DataPropertyName = "tongtien_SP";
            this.THANHTIEN.HeaderText = "Thành tiền";
            this.THANHTIEN.MinimumWidth = 6;
            this.THANHTIEN.Name = "THANHTIEN";
            this.THANHTIEN.ReadOnly = true;
            // 
            // Xoa
            // 
            this.Xoa.DataPropertyName = "Xoa";
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.NullValue = "Xóa";
            this.Xoa.DefaultCellStyle = dataGridViewCellStyle1;
            this.Xoa.HeaderText = "Xóa";
            this.Xoa.MinimumWidth = 6;
            this.Xoa.Name = "Xoa";
            this.Xoa.ReadOnly = true;
            this.Xoa.Text = "Xóa";
            // 
            // lbMaPN
            // 
            this.lbMaPN.AutoSize = true;
            this.lbMaPN.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbMaPN.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbMaPN.Location = new System.Drawing.Point(727, 11);
            this.lbMaPN.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbMaPN.Name = "lbMaPN";
            this.lbMaPN.Size = new System.Drawing.Size(2, 33);
            this.lbMaPN.TabIndex = 48;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(453, 11);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 25);
            this.label3.TabIndex = 47;
            this.label3.Text = "Phiếu nhập";
            // 
            // btnIn
            // 
            this.btnIn.AnimationHoverSpeed = 0.07F;
            this.btnIn.AnimationSpeed = 0.03F;
            this.btnIn.BackColor = System.Drawing.Color.Transparent;
            this.btnIn.BaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.btnIn.BorderColor = System.Drawing.Color.Black;
            this.btnIn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.btnIn.FocusedColor = System.Drawing.Color.Empty;
            this.btnIn.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIn.ForeColor = System.Drawing.Color.White;
            this.btnIn.Image = null;
            this.btnIn.ImageSize = new System.Drawing.Size(20, 20);
            this.btnIn.Location = new System.Drawing.Point(245, 576);
            this.btnIn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnIn.Name = "btnIn";
            this.btnIn.OnHoverBaseColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.btnIn.OnHoverBorderColor = System.Drawing.Color.Black;
            this.btnIn.OnHoverForeColor = System.Drawing.Color.White;
            this.btnIn.OnHoverImage = null;
            this.btnIn.OnPressedColor = System.Drawing.Color.Black;
            this.btnIn.Radius = 10;
            this.btnIn.Size = new System.Drawing.Size(132, 52);
            this.btnIn.TabIndex = 53;
            this.btnIn.Text = "In hóa đơn";
            this.btnIn.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // PhieuNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1108, 654);
            this.Controls.Add(this.btnIn);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lbTongTien);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.dgvXe);
            this.Controls.Add(this.lbMaPN);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "PhieuNhap";
            this.Text = "PhieuNhap";
            this.Load += new System.EventHandler(this.PhieuNhap_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvXe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtSLXe;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDGXe;
        private System.Windows.Forms.ComboBox cbxXe;
        private System.Windows.Forms.ComboBox cbxNCC;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private Guna.UI.WinForms.GunaButton btnThemXe;
        private System.Windows.Forms.Label lbTongTien;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.DataGridView dgvXe;
        private System.Windows.Forms.Label lbMaPN;
        private System.Windows.Forms.Label label3;
        private Guna.UI.WinForms.GunaButton btnHuy;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SLNHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONGIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn THANHTIEN;
        private System.Windows.Forms.DataGridViewButtonColumn Xoa;
        private Guna.UI.WinForms.GunaButton btnIn;
    }
}