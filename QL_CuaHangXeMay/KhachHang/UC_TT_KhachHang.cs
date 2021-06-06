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

namespace QuanLy_CuaHang.KhachHang1
{
    public partial class UC_TT_KhachHang : UserControl
    {
        public UC_TT_KhachHang()
        {
            InitializeComponent();
            Load_Data();

            dgv_KhachHang.ColumnHeadersHeight = 24;

            dgv_KhachHang.Columns[0].HeaderText = "Mã";
            dgv_KhachHang.Columns[1].HeaderText = "Tên";
            dgv_KhachHang.Columns[2].HeaderText = "Mail";
            dgv_KhachHang.Columns[3].HeaderText = "Điện thoại";

            dgv_KhachHang.Columns[0].Width = 65;
            dgv_KhachHang.Columns[1].Width = 300;
        }

        public void Load_Data()
        {
            dgv_KhachHang.DataSource = KhachHang_Data.Get_KhachHangList();
        }

        private void btn_LamMoi_KH_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_Them_HK_Click(object sender, EventArgs e)
        {
            Dialog.DAL_KhachHang dAL_Khach = new Dialog.DAL_KhachHang();
            dAL_Khach.ShowDialog();
            try
            {
                dgv_KhachHang.DataSource = KhachHang_Data.Get_KhachHangList();
            }
            catch (Exception) { }
        }
        private string Get_IdKH()
        {
            if (dgv_KhachHang.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_KhachHang.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_KhachHang.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }
        private void Sua_KH()
        {
            if (Get_IdKH() != null)
            {
                Dialog.DAL_KhachHang kh = new Dialog.DAL_KhachHang(int.Parse(Get_IdKH()));
                kh.ShowDialog();

                try
                {
                    dgv_KhachHang.DataSource = KhachHang_Data.Get_KhachHangList();
                }
                catch (Exception) { }
            }
        }
        private void btn_Sua_KH_Click(object sender, EventArgs e)
        {
            Sua_KH();
        }

        private void btn_Xoa_KH_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Bạn muốn xóa giá trị?", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialogResult == DialogResult.Yes)
            {
                if (Get_IdKH() != null)
                {
                    KhachHang_Data.Delete_KhachHang(int.Parse(Get_IdKH()));
                    try
                    {
                        dgv_KhachHang.DataSource = KhachHang_Data.Get_KhachHangList();
                    }
                    catch (Exception) { }
                }
            }
        }

        private void btn_Tim_KH_Click(object sender, EventArgs e)
        {
            if (txt_Tim_KH.Text.Trim() != "")
            {
                dgv_KhachHang.DataSource = KhachHang_Data.Search_KhachHang(txt_Tim_KH.Text.ToString());
            }
            else
            {
                try
                {
                    dgv_KhachHang.DataSource = KhachHang_Data.Get_KhachHangList();
                }
                catch (Exception) { }
            }
        }

        private void dgv_KhachHang_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            Sua_KH();
        }

        private void txt_Tim_KH_TextChanged(object sender, EventArgs e)
        {
            if (txt_Tim_KH.Text.Trim() != "")
            {
                dgv_KhachHang.DataSource = KhachHang_Data.Search_KhachHang(txt_Tim_KH.Text.ToString());
            }
            else
            {
                try
                {
                    dgv_KhachHang.DataSource = KhachHang_Data.Get_KhachHangList();
                }
                catch (Exception) { }
            }
        }
    }
}
