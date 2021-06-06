﻿using QL_CuaHangXeMay.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.SanPham
{
    public partial class UC_NhaCC_HangSX : UserControl
    {
        public UC_NhaCC_HangSX()
        {
            InitializeComponent();
            Load_Data();

            dgv_NhaCC.ColumnHeadersHeight = 24;
            dgv_NhaCC.Columns[0].HeaderText = "Mã";
            dgv_NhaCC.Columns[1].HeaderText = "Tên";
            dgv_NhaCC.Columns[0].Width = 50;

            dgv_HangSX.ColumnHeadersHeight = 24;
            dgv_HangSX.Columns[0].HeaderText = "Mã";
            dgv_HangSX.Columns[1].HeaderText = "Tên";
            dgv_HangSX.Columns[0].Width = 50;
        }

        private void Load_Data()
        {
            try
            {
                dgv_NhaCC.DataSource = NhaCungCap_Data.Get_NhaCungCapList();
                dgv_HangSX.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
            }
            catch (Exception) { }
        }

        private void btn_Them_NCC_Click(object sender, EventArgs e)
        {
            Dialog.DAL_NhaCungCap dAL_NhaCungCap = new Dialog.DAL_NhaCungCap();
            dAL_NhaCungCap.ShowDialog();
            try
            {
                dgv_NhaCC.DataSource = NhaCungCap_Data.Get_NhaCungCapList();
            }
            catch (Exception) { }
        }

        private void btn_LamMoi_NCC_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_NhaCC.DataSource = NhaCungCap_Data.Get_NhaCungCapList();
            }
            catch (Exception) { }
        }

        private void btn_LamMoi_HSX_Click(object sender, EventArgs e)
        {
            try
            {
                dgv_HangSX.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
            }
            catch (Exception) { }
        }

        private void btn_Them_HSX_Click(object sender, EventArgs e)
        {
            Dialog.DAL_HangSX dAL_HangSX = new Dialog.DAL_HangSX();
            dAL_HangSX.ShowDialog();
            try
            {
                dgv_HangSX.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
            }
            catch (Exception) { }
        }

        private void dgv_NhaCC_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sua_NCC();
        }
        private string Get_IdNCC()
        {
            if (dgv_NhaCC.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_NhaCC.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_NhaCC.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void dgv_HangSX_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sua_HSX();
        }
        private string Get_IdHSX()
        {
            if (dgv_HangSX.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_HangSX.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_HangSX.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void btn_Sua_NCC_Click(object sender, EventArgs e)
        {
            Sua_NCC();
        }
        private void Sua_NCC()
        {
            if (Get_IdNCC() != null)
            {
                Dialog.DAL_NhaCungCap dAL_NhaCungCap = new Dialog.DAL_NhaCungCap(int.Parse(Get_IdNCC()));
                dAL_NhaCungCap.ShowDialog();

                try
                {
                    dgv_NhaCC.DataSource = NhaCungCap_Data.Get_NhaCungCapList();
                }
                catch (Exception) { }
            }
        }

        private void btn_Sua_HSX_Click(object sender, EventArgs e)
        {
            Sua_HSX();
        }

        private void Sua_HSX()
        {
            if (Get_IdHSX() != null)
            {
                Dialog.DAL_HangSX hangSX = new Dialog.DAL_HangSX(int.Parse(Get_IdHSX()));
                hangSX.ShowDialog();

                try
                {
                    dgv_HangSX.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
                }
                catch (Exception) { }
            }
        }

        private void btn_Xoa_NCC_Click(object sender, EventArgs e)
        {
            if (Get_IdNCC() != null)
            {
                NhaCungCap_Data.Delete_NhaCungCap(int.Parse(Get_IdNCC()));
                try
                {
                    dgv_NhaCC.DataSource = NhaCungCap_Data.Get_NhaCungCapList();
                }
                catch (Exception) { }
            }
        }

        private void btn_Xoa_HSX_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa giá trị?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (Get_IdHSX() != null)
                {
                    HangSanXuat_Data.Delete_HangSX(int.Parse(Get_IdHSX()));
                    try
                    {
                        dgv_HangSX.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
                    }
                    catch (Exception) { }
                }
            }
        }

        private void btn_Tim_NCC_Click(object sender, EventArgs e)
        {
            if (txt_Tim_NCC.Text.Trim() != "")
            {
                dgv_NhaCC.DataSource = NhaCungCap_Data.Search_NhaCC(txt_Tim_NCC.Text.ToString());
            }
            else
            {
                try
                {
                    dgv_NhaCC.DataSource = NhaCungCap_Data.Get_NhaCungCapList();
                }
                catch (Exception) { }
            }
        }

        private void btn_Tim_HSX_Click(object sender, EventArgs e)
        {
            //if (txt_Tim_HSX.Text.Trim() != "")
            //{
            //    dgv_HangSX.DataSource = HangSanXuat_Data.Search_HangSX(txt_Tim_NCC.Text.ToString());
            //}
            //else
            //{
            //    try
            //    {
            //        dgv_HangSX.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
            //    }
            //    catch (Exception) { }
            //}
        }

 
        private void txt_Tim_HSX_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tim_HSX.Text.Trim() != "")
            {
                dgv_HangSX.DataSource = HangSanXuat_Data.Search_HangSX(txt_Tim_HSX.Text.ToString());
            }
            else
            {
                try
                {
                    dgv_HangSX.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
                }
                catch (Exception) { }
            }
        }

        private void txt_Tim_NCC_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tim_NCC.Text.Trim() != "")
            {
                dgv_NhaCC.DataSource = NhaCungCap_Data.Search_NhaCC(txt_Tim_NCC.Text.ToString());
            }
            else
            {
                try
                {
                    dgv_NhaCC.DataSource = NhaCungCap_Data.Get_NhaCungCapList();
                }
                catch (Exception) { }
            }
        }
    }
}
