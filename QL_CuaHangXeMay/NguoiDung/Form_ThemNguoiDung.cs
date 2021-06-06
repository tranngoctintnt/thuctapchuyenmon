using QL_CuaHangXeMay;
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

namespace QuanLy_CuaHang.QL_NguoiDung
{
    public partial class Form_ThemNguoiDung : Form
    {
        public Form_ThemNguoiDung()
        {
            InitializeComponent();
            Get_MaNhanVien();
        }
        private void Get_MaNhanVien()
        {
            txt_MaNV.Text = NguoiDung_Data.Get_MaNhanVien() + 1 + "";
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txt_TenNV.Text.Trim() != "" && txt_SDT.Text.Trim() != "" && txt_Mail.Text.Trim() != "")
            {
                NguoiDung_Data.Add_NguoiDung(
                new NhanVien()
                {
                    ma_NV = int.Parse(txt_MaNV.Text.Trim()),
                    ten_NV = txt_TenNV.Text.ToString(),
                    mail_NV = txt_Mail.Text.ToString(),
                    sdt_NV = txt_SDT.Text.ToString(),
                    mk_dangnhap = MD5_Data.CreateMD5Hash(txtPass.Text.ToString())
                });

                bool ql_SP = ckb_QLSP.Checked;
                bool ql_HD = ckb_QLHD.Checked;
                bool ql_KH = ckb_QLKH.Checked;
                bool ql_TK = ckb_ThongKe.Checked;
                bool ql_ND = ckb_QLND.Checked;

                NguoiDung_Data.Add_Quyen(
                    new CT_Quyen()
                    {
                        ma_NV = int.Parse(txt_MaNV.Text.Trim()),
                        ma_CN = 5000,
                        stas  = ql_SP
                    });
                NguoiDung_Data.Add_Quyen(
                    new CT_Quyen()
                    {
                        ma_NV = int.Parse(txt_MaNV.Text.Trim()),
                        ma_CN = 5001,
                        stas = ql_HD
                    });
                NguoiDung_Data.Add_Quyen(
                    new CT_Quyen()
                    {
                        ma_NV = int.Parse(txt_MaNV.Text.Trim()),
                        ma_CN = 5002,
                        stas = ql_TK
                    });
                NguoiDung_Data.Add_Quyen(
                    new CT_Quyen()
                    {
                        ma_NV = int.Parse(txt_MaNV.Text.Trim()),
                        ma_CN = 5003,
                        stas = ql_KH
                    });
                NguoiDung_Data.Add_Quyen(
                    new CT_Quyen()
                    {
                        ma_NV = int.Parse(txt_MaNV.Text.Trim()),
                        ma_CN = 5004,
                        stas = ql_ND
                    });

                this.Close();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
