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
    public partial class DAL_GiaSP : Form
    {
        private int ma_GiaSP;
        public DAL_GiaSP(int ma_Gia = -1)
        {
            InitializeComponent();
            this.ma_GiaSP = ma_Gia;
            Load_Combobox();
            Load_Data();
        }
        private void Load_Combobox()
        {
            cbb_TenSP.DataSource = SanPham_Data.Get_SanPhamList();
            cbb_TenSP.DisplayMember = "ten_sp";
            cbb_TenSP.ValueMember = "ma_sp";
        }

        private void Load_Data()
        {
            if (this.ma_GiaSP != -1)
            {
                Gia_SP gia_SP = GiaSP_Data.Get_GiaSP(this.ma_GiaSP);

                cbb_TenSP.SelectedValue = gia_SP.ma_SP;
                txt_MaGiaSP.Text = gia_SP.ma_GiaSP.ToString();
                dtp_NgayApDung.Value = (DateTime)gia_SP.ngay_BDSP;
                txt_Gia.Text = gia_SP.gia_SP1.ToString();
            }
            else
            {
                txt_MaGiaSP.Text = GiaSP_Data.Get_MaGiaSP() + 1 + "";
            }
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {

            if (txt_Gia.Text.Trim() != "")
            {
                if (this.ma_GiaSP != -1)
                {
                    GiaSP_Data.Update_GiaSP(new Gia_SP()
                    {
                        ma_GiaSP = int.Parse(txt_MaGiaSP.Text.Trim()),
                        ma_SP = int.Parse(cbb_TenSP.SelectedValue.ToString()),
                        gia_SP1 = int.Parse(txt_Gia.Text.Trim()),
                        ngay_BDSP = dtp_NgayApDung.Value
                    });
                }
                else
                {
                    GiaSP_Data.Add_GiaSP(new Gia_SP()
                    {
                        ma_GiaSP = int.Parse(txt_MaGiaSP.Text.Trim()),
                        ma_SP = int.Parse(cbb_TenSP.SelectedValue.ToString()),
                        gia_SP1 = int.Parse(txt_Gia.Text.Trim()),
                        ngay_BDSP = dtp_NgayApDung.Value
                    });
                }
                this.Close();
            }
            else
            {
                MessageBox.Show("Chưa nhập giá!", "Chú ý", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_Huy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
