using QL_CuaHangXeMay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.KhachHang1.Dialog
{
    public partial class DAL_KhachHang : Form
    {
        private int ma_kh;
        public DAL_KhachHang(int makh= -1)
        {
            InitializeComponent();
            this.ma_kh = makh;
            Load_Data();
        }
        private void Load_Data()
        {
            txtMa_kh.ReadOnly = true;
            if (this.ma_kh == -1)
            {
                try
                {
                    txtMa_kh.Text = KhachHang_Data.Get_MaKhachHang() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    QL_CuaHangXeMay.KhachHang kh = KhachHang_Data.Get_KhachHang(this.ma_kh);
                    txtMa_kh.Text = kh.ma_KH.ToString();
                    txtTenKH.Text = kh.ten_HK.ToString();
                    txtEmail.Text = kh.ma_KH.ToString();
                    txtSDT.Text = kh.sdt_KH.ToString();
                }
                catch (Exception) { }
            }
        }

        private void gunaTextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            if (this.ma_kh == -1)
            {
                KhachHang_Data.Add_KhachHang(new QL_CuaHangXeMay.KhachHang()
                {
                    ma_KH = int.Parse(txtMa_kh.Text.Trim()),
                    ten_HK = txtTenKH.Text,
                    mail_KH = txtEmail.Text,
                    sdt_KH = txtSDT.Text
                }) ;
            }
            else
            {
                KhachHang_Data.Update_KhachHang(new QL_CuaHangXeMay.KhachHang()
                {
                    ma_KH = int.Parse(txtMa_kh.Text.Trim()),
                    ten_HK = txtTenKH.Text,
                    mail_KH = txtEmail.Text,
                    sdt_KH = txtSDT.Text
                });
            }
            this.Close();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
