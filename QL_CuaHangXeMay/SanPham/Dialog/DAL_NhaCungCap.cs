﻿using QL_CuaHangXeMay;
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
    public partial class DAL_NhaCungCap : Form
    {
        public int ma_Ncc;
        public DAL_NhaCungCap(int ma_NCC = -1)
        {
            InitializeComponent();
            this.ma_Ncc = ma_NCC;
            Load_Data();
        }

        private void Load_Data()
        {
            txt_MaNCC.ReadOnly = true;
            if (this.ma_Ncc == -1)
            {
                try
                {
                    txt_MaNCC.Text = NhaCungCap_Data.Get_MaNhaCungCap() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    Nha_CungCap ncc = NhaCungCap_Data.Get_NhaCungCap(this.ma_Ncc);
                    txt_MaNCC.Text = ncc.ma_NCC.ToString();
                    txt_TenNCC.Text = ncc.ten_NCC.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.ma_Ncc == -1)
            {
                NhaCungCap_Data.Add_NhaCungCap(new Nha_CungCap()
                {
                    ma_NCC = int.Parse(txt_MaNCC.Text.Trim()),
                    ten_NCC = txt_TenNCC.Text
                });
            }
            else
            {
                NhaCungCap_Data.Update_NhaCungCap(new Nha_CungCap()
                {
                    ma_NCC = int.Parse(txt_MaNCC.Text.Trim()),
                    ten_NCC = txt_TenNCC.Text
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
