using QL_CuaHangXeMay;
using QL_CuaHangXeMay.HoaDon;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.HoaDon
{
    public partial class HD_PhieuNhap : UserControl
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public HD_PhieuNhap()
        {
            InitializeComponent();
        }
        public class thongtinHD
        {
            public static string ma;

        }

        private void HD_PhieuNhap_Load(object sender, EventArgs e)
        {
            dgv_HDpn.DataSource = dt.hd_phieunhappppp();
            dgv_HDpn.AutoGenerateColumns = false;
        }

        private void dgv_HDpn_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtID.Enabled = false;
                txtTenNV.Enabled = false;
                txtTenncc.Enabled = false;
                datepn.Enabled = false;
                int i;

                if (dgv_HDpn.Columns[e.ColumnIndex].Name == "chitiet")
                {
                    thongtinHD.ma = txtID.Text;
                    ViewPN view = new ViewPN();
                    view.Show();
                }

                i = dgv_HDpn.CurrentRow.Index;
                txtID.Text = dgv_HDpn.Rows[i].Cells[1].Value.ToString();
                txtTenNV.Text = dgv_HDpn.Rows[i].Cells[2].Value.ToString();
                txtTenncc.Text = dgv_HDpn.Rows[i].Cells[3].Value.ToString();
                datepn.Text = dgv_HDpn.Rows[i].Cells[4].Value.ToString();

            }
            catch (Exception)
            {

            }
        }

        private void btn_Tim_pn_Click(object sender, EventArgs e)
        {
            HD_PhieuNhap_Load(sender, e);
            if (txt_Tim_pn.Text.Trim() == "")
            {
                dgv_HDpn.DataSource = dt.hd();
            }
            dgv_HDpn.AutoGenerateColumns = false;
            dgv_HDpn.DataSource = dt.search_hdpn(txt_Tim_pn.Text);
        }

        private void txt_Tim_pn_TextChanged(object sender, EventArgs e)
        {
            HD_PhieuNhap_Load(sender, e);
            if (txt_Tim_pn.Text.Trim() == "")
            {
                dgv_HDpn.DataSource = dt.hd_phieunhappppp();
            }
            dgv_HDpn.AutoGenerateColumns = false;
            dgv_HDpn.DataSource = dt.search_hdpn(txt_Tim_pn.Text);
        }
    }
}
