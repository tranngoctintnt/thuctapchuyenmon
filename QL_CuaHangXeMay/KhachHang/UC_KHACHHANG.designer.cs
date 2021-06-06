
namespace QuanLy_CuaHang.KhachHang
{
    partial class UC_KHACHHANG
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
            this.tabQLKH = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabQLKH.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabQLKH
            // 
            this.tabQLKH.Controls.Add(this.tabPage1);
            this.tabQLKH.Controls.Add(this.tabPage2);
            this.tabQLKH.ItemSize = new System.Drawing.Size(58, 30);
            this.tabQLKH.Location = new System.Drawing.Point(0, 0);
            this.tabQLKH.Name = "tabQLKH";
            this.tabQLKH.SelectedIndex = 0;
            this.tabQLKH.Size = new System.Drawing.Size(894, 561);
            this.tabQLKH.TabIndex = 1;
            this.tabQLKH.Click += new System.EventHandler(this.tabQLKH_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.Location = new System.Drawing.Point(4, 34);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(886, 523);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Thông tin khách hàng";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(886, 523);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Gửi Mail";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // UC_KHACHHANG
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.tabQLKH);
            this.Name = "UC_KHACHHANG";
            this.Size = new System.Drawing.Size(894, 561);
            this.tabQLKH.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabQLKH;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
    }
}
