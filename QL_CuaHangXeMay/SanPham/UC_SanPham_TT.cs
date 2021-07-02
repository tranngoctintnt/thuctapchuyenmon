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

namespace QuanLy_CuaHang.SanPham
{
    public partial class UC_SanPham_TT : UserControl
    {
        private DataTable iDataSource = null;

        DataClassesQLDataContext db = new DataClassesQLDataContext();
        public UC_SanPham_TT()
        {
            InitializeComponent();
            Load_Data();
            Load_Combobox();

            dgv_SanPham.ColumnHeadersHeight = 24;

            dgv_SanPham.Columns[0].HeaderText = "Mã";
            dgv_SanPham.Columns[1].HeaderText = "Tên";
            dgv_SanPham.Columns[2].HeaderText = "Loại";
            dgv_SanPham.Columns[3].HeaderText = "Hãng";
            dgv_SanPham.Columns[4].HeaderText = "Số lượng";

            dgv_SanPham.Columns[0].Width = 65;
            dgv_SanPham.Columns[1].Width = 300;
        }

        private void Load_Combobox()
        {
            try
            {
                cbb_SP.DataSource = HangSanXuat_Data.Get_HangSanXuatList();
                cbb_SP.DisplayMember = "ten_Hang";
                cbb_SP.ValueMember = "ma_Hang";
                cbb_SP.SelectedIndex = -1;


                cbb_LoaiSP.DataSource = LoaiSP_Data.Get_LoaiSPList();
                cbb_LoaiSP.DisplayMember = "ten_Loai";
                cbb_LoaiSP.ValueMember = "ma_Loai";
                cbb_LoaiSP.SelectedIndex = -1;
            }
            catch (Exception) { }
        }

        private void Load_Data()
        {
            try
            {
                dgv_SanPham.DataSource = iDataSource = ConvertToDataTable(SanPham_Data.Get_SanPhamList());
            }
            catch (Exception) { }
        }

        private DataTable ConvertToDataTable<T>(IList<T> data)
        {
            PropertyDescriptorCollection properties =
               TypeDescriptor.GetProperties(typeof(T));
            DataTable table = new DataTable();
            foreach (PropertyDescriptor prop in properties)
                table.Columns.Add(prop.Name, Nullable.GetUnderlyingType(prop.PropertyType) ?? prop.PropertyType);
            foreach (T item in data)
            {
                DataRow row = table.NewRow();
                foreach (PropertyDescriptor prop in properties)
                    row[prop.Name] = prop.GetValue(item) ?? DBNull.Value;
                table.Rows.Add(row);
            }
            return table;

        }

        private void ckb_LocSP_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_LocSP.Checked)
            {
                cbb_LoaiSP.Enabled = cbb_SP.Enabled = true;
                txt_Tim_SP.Enabled = btn_Tim_SP.Enabled = false;

            }
            else
            {
                cbb_LoaiSP.Enabled = cbb_SP.Enabled = false;
                txt_Tim_SP.Enabled = btn_Tim_SP.Enabled = true;
            }

            Load_Data();
        }

        private void dgv_SanPham_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sua_SanPham();
        }

        private void cbb_LoaiSP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_LoaiSP.SelectedIndex > -1)
            {
                string a = cbb_LoaiSP.SelectedValue.ToString();
                Filter_Data();
            }
        }

        private void cbb_SP_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_SP.SelectedIndex > -1)
            {
                string a = cbb_SP.Text.ToString();
                Filter_Data();
            }
        }

        private void Filter_Data()
        {
            DataTable dt;
            if (cbb_SP.SelectedIndex > -1 && ckb_LocSP.Checked == true && cbb_LoaiSP.SelectedIndex < 0)
            {
                if (iDataSource.Select("ten_Hang = '" + cbb_SP.Text.ToString() + "'").Count() > 0)
                {
                    dt = iDataSource.Select("ten_Hang = '" + cbb_SP.Text.ToString() + "'").CopyToDataTable();
                    dgv_SanPham.DataSource = dt;
                }
            }
            if (cbb_SP.SelectedIndex < 0 && ckb_LocSP.Checked == true && cbb_LoaiSP.SelectedIndex > -1)
            {
                if (iDataSource.Select("ten_Loai = '" + cbb_LoaiSP.Text.ToString() + "'").Count() > 0)
                {
                    dt = iDataSource.Select("ten_Loai = '" + cbb_LoaiSP.Text.ToString() + "'").CopyToDataTable();
                    dgv_SanPham.DataSource = dt;
                }
            }

            if (cbb_SP.SelectedIndex > -1 && ckb_LocSP.Checked == true && cbb_LoaiSP.SelectedIndex > -1)
            {
                dgv_SanPham.DataSource = db.get_Hang_Loai(cbb_SP.Text.ToString(), cbb_LoaiSP.Text.ToString());
                //if (iDataSource.Select("ten_Loai = '" + cbb_LoaiSP.Text.ToString() + "'").Count() > 0)
                //{
                //    dt = iDataSource.Select("ten_Loai = '" + cbb_LoaiSP.Text.ToString() + "'").CopyToDataTable();
                //    dgv_SanPham.DataSource = dt;
                //}
            }
        }

        private void btn_Them_SP_Click(object sender, EventArgs e)
        {
            Dialog.DAL_SanPham dAL_SanPham = new Dialog.DAL_SanPham();
            dAL_SanPham.ShowDialog();
            Load_Data();
        }

        private void btn_Sua_SP_Click(object sender, EventArgs e)
        {
            Sua_SanPham();
        }
        private void Sua_SanPham()
        {

            if (Get_IdSP() != null)
            {
                string a = Get_IdSP();
                Dialog.DAL_SanPham dAL_SanPham = new Dialog.DAL_SanPham(int.Parse(Get_IdSP()));
                dAL_SanPham.ShowDialog();

                Load_Data();
            }
        }
        private string Get_IdSP()
        {
            if (dgv_SanPham.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_SanPham.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_SanPham.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void btn_LamMoi_SP_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_Xoa_SP_Click(object sender, EventArgs e)
        {
            if (Get_IdSP() != null)
            {
                SanPham_Data.Delete_SanPham(int.Parse(Get_IdSP()));
                try
                {
                    dgv_SanPham.DataSource = SanPham_Data.Get_SanPhamList();
                }
                catch (Exception) { }
            }
           

        }

        private void txt_Tim_SP_TextChanged(object sender, EventArgs e)
        {
            dgv_SanPham.DataSource = db.search_SP(txt_Tim_SP.Text.ToString());
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
