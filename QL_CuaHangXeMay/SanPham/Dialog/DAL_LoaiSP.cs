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

namespace QuanLy_CuaHang.SanPham.Dialog
{
    public partial class DAL_LoaiSP : Form
    {
        private int maLoai;
        public DAL_LoaiSP(int maLoai = -1)
        {
            InitializeComponent();
            this.maLoai = maLoai;
            Load_Data();
        }

        private void Load_Data()
        {
            txt_MaLoai.ReadOnly = true;
            if (this.maLoai == -1)
            {
                try
                {
                    txt_MaLoai.Text = LoaiSP_Data.Get_MaLoaiSP() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    Loai_SP loaisp = LoaiSP_Data.Get_LoaiSP(this.maLoai);
                    txt_MaLoai.Text = loaisp.ma_Loai.ToString();
                    txt_TenLoai.Text = loaisp.ten_Loai.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.maLoai == -1)
            {
                LoaiSP_Data.Add_HangSX(new Loai_SP()
                {
                    ma_Loai = int.Parse(txt_MaLoai.Text.Trim()),
                    ten_Loai = txt_TenLoai.Text
                });
            }
            else
            {
                LoaiSP_Data.Update_LoaiSP(new Loai_SP()
                {
                    ma_Loai = int.Parse(txt_MaLoai.Text.Trim()),
                    ten_Loai = txt_TenLoai.Text
                });
            }
            this.Close();
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
