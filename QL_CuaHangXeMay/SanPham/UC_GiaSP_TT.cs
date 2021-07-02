using QL_CuaHangXeMay;
using QL_CuaHangXeMay.Class;
using QuanLy_CuaHang.SanPham.Dialog;
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
    public partial class UC_GiaSP_TT : UserControl
    {
        public UC_GiaSP_TT()
        {
            InitializeComponent();
            Load_Data();
            Load_Combobox();

            dgv_GiaSP.ColumnHeadersHeight = 24;

            dgv_GiaSP.Columns[0].HeaderText = "Mã";
            dgv_GiaSP.Columns[1].HeaderText = "Sản phẩm";
            dgv_GiaSP.Columns[2].HeaderText = "Giá";
            dgv_GiaSP.Columns[3].HeaderText = "Ngày";
        }
        private void Load_Data()
        {
            dgv_GiaSP.DataSource = GiaSP_Data.Get_GiaSPList();
        }

        private void Load_Combobox()
        {
            try
            {
                cbb_giasp_to.DataSource = GiaSP_Data.Get_GiaSPList();
                cbb_giasp_to.DisplayMember = "gia_sp";
                cbb_giasp_to.ValueMember = "ma_giasp";
                cbb_giasp_to.SelectedIndex = -1;


                cbb_giasp_from.DataSource = GiaSP_Data.Get_GiaSPList();
                cbb_giasp_from.DisplayMember = "gia_sp";
                cbb_giasp_from.ValueMember = "ma_giasp";
                cbb_giasp_from.SelectedIndex = -1;
            }
            catch (Exception) { }
        }

        private void btn_Sua_GiaSP_Click(object sender, EventArgs e)
        {
            Sua_GiaSP();
        }
        private void Sua_GiaSP()
        {

            if (Get_IdGiaSP() != null)
            {
                Dialog.DAL_GiaSP dAL_GiaSP = GetDAL_GiaSP();
                dAL_GiaSP.ShowDialog();

                Load_Data();
            }
        }

        private DAL_GiaSP GetDAL_GiaSP()
        {
            return new Dialog.DAL_GiaSP(int.Parse(Get_IdGiaSP()));
        }

        private string Get_IdGiaSP()
        {
            if (dgv_GiaSP.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_GiaSP.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_GiaSP.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void btn_LamMoi_GiaSP_Click(object sender, EventArgs e)
        {
            Load_Data();

        }

        private void btn_Xoa_GiaSP_Click(object sender, EventArgs e)
        {
            
            if (Get_IdGiaSP() != null)
            {
                GiaSP_Data.Delete_GiaSP(int.Parse(Get_IdGiaSP()));
                try
                {
                    dgv_GiaSP.DataSource = GiaSP_Data.Get_GiaSPList();
                }
                catch (Exception) { }
            }

        }

        private void dgv_GiaSP_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Sua_GiaSP();

        }

        private void btn_Them_GiaSP_Click(object sender, EventArgs e)
        {
            Dialog.DAL_GiaSP dAL_GiaSP = new Dialog.DAL_GiaSP();
            dAL_GiaSP.ShowDialog();
            Load_Data();
        }

        private void cbb_giasp_to_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_giasp_to.SelectedIndex > -1)
            {
                string a = cbb_giasp_to.SelectedValue.ToString();
                Filter_Data();
            }
        }

        private void cbb_giasp_from_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbb_giasp_to.SelectedIndex > -1)
            {
                string a = cbb_giasp_to.SelectedValue.ToString();
                Filter_Data();
            }
        }

        DataClassesQLDataContext dt = new DataClassesQLDataContext();

        private void Filter_Data()
        {
            if (cbb_giasp_to.SelectedIndex > -1 && cbb_giasp_from.SelectedIndex > 0)
            {
                dgv_GiaSP.DataSource = dt.get_giasp_Price_lonhon(int.Parse(cbb_giasp_to.Text.ToString()));
            }
                if (cbb_giasp_to.SelectedIndex > -1 && cbb_giasp_from.SelectedIndex > -1)
            {
                dgv_GiaSP.DataSource = dt.get_giasp_Price(int.Parse(cbb_giasp_to.Text.ToString()),int.Parse(cbb_giasp_from.Text.ToString()));
                //if (iDataSource.Select("ten_Loai = '" + cbb_LoaiSP.Text.ToString() + "'").Count() > 0)
                //{
                //    dt = iDataSource.Select("ten_Loai = '" + cbb_LoaiSP.Text.ToString() + "'").CopyToDataTable();
                //    dgv_SanPham.DataSource = dt;
                //}
            }
        }

        private void ckb_LocSP_CheckedChanged(object sender, EventArgs e)
        {
            if (ckb_LocSP.Checked)
            {
                cbb_giasp_to.Enabled = cbb_giasp_from.Enabled = true;

            }
            else
            {
                cbb_giasp_to.Enabled = cbb_giasp_from.Enabled = false;
            }

            Load_Data();
        }

        private void txt_Tim_giasp_TextChanged(object sender, EventArgs e)
        {
            dgv_GiaSP.DataSource = dt.searh_giasp(txt_Tim_giasp.Text.ToString());
        }
    }
}
