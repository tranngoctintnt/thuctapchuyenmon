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
    public partial class DAL_HangSX : Form
    {
        private int ma_HangSX;
        public DAL_HangSX(int hsx = -1)
        {
            InitializeComponent();
            this.ma_HangSX = hsx;
            Load_Data();
        }
        private void Load_Data()
        {
            txt_MaHangSX.ReadOnly = true;
            if (this.ma_HangSX == -1)
            {
                try
                {
                    txt_MaHangSX.Text = HangSanXuat_Data.Get_MaHangSX() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    Hang_SX hsx = HangSanXuat_Data.Get_HangSX(this.ma_HangSX);
                    txt_MaHangSX.Text = hsx.ma_Hang.ToString();
                    txt_TenHangSX.Text = hsx.ten_Hang.ToString();
                }
                catch (Exception) { }
            }
        } 

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.ma_HangSX == -1)
            {
                HangSanXuat_Data.Add_HangSX(new Hang_SX()
                {
                    ma_Hang = int.Parse(txt_MaHangSX.Text.Trim()),
                    ten_Hang = txt_TenHangSX.Text
                });
            }
            else
            {
                HangSanXuat_Data.Update_HangSX(new Hang_SX()
                {
                    ma_Hang = int.Parse(txt_MaHangSX.Text.Trim()),
                    ten_Hang = txt_TenHangSX.Text
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
