using QuanLy_CuaHang.KhachHang1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.KhachHang
{
    public partial class UC_KHACHHANG : UserControl
    {
        public UC_KHACHHANG()
        {
            InitializeComponent();
            Check_Tab();
        }
        private void Check_Tab()
        {
            switch (tabQLKH.SelectedIndex)
            {
                case 0:
                    this.tabPage1.Controls.Clear();
                    this.tabPage1.Controls.Add(new UC_TT_KhachHang());
                    break;
                case 1:
                    Mail mail = new Mail();
                    mail.TopLevel = false;
                    tabPage2.Controls.Add(mail);
                    mail.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
                    mail.Dock = DockStyle.Fill;
                    mail.Show();
                    break;
            }
        }

        private void tabQLKH_Click(object sender, EventArgs e)
        {
            Check_Tab();
        }
    }
}
