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
    public partial class DAL_DanhMuc : Form
    {
        private int ma_DM;
        public DAL_DanhMuc(int maDM = -1)
        {
            InitializeComponent();
            this.ma_DM = maDM;
            Load_Data();
        }
        private void Load_Data()
        {
            txt_MaDM.ReadOnly = true;
            if (this.ma_DM == -1)
            {
                try
                {
                    txt_MaDM.Text = DanhMuc_Data.Get_MaDanhMuc() + 1 + "";
                }
                catch (Exception) { }
            }
            else
            {
                try
                {
                    DanhMuc dm = DanhMuc_Data.Get_DanhMuc(this.ma_DM);
                    txt_MaDM.Text = dm.ma_DM.ToString();
                    txt_TenDM.Text = dm.ten_DM.ToString();
                }
                catch (Exception) { }
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            if (this.ma_DM == -1)
            {
                DanhMuc_Data.Add_DanhMuc(new DanhMuc()
                {
                    ma_DM = int.Parse(txt_MaDM.Text.Trim()),
                    ten_DM = txt_TenDM.Text
                });
            }
            else
            {
                DanhMuc_Data.Update_DanhMuc(new DanhMuc()
                {
                    ma_DM = int.Parse(txt_MaDM.Text.Trim()),
                    ten_DM = txt_TenDM.Text
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
