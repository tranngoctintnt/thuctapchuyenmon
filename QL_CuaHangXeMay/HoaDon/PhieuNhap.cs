using QL_CuaHangXeMay;
using QL_CuaHangXeMay.Class;
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
    public partial class PhieuNhap : Form
    {
        int hehe = 0;

        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        public PhieuNhap()
        {
            InitializeComponent();
        }

        private void PhieuNhap_Load(object sender, EventArgs e)
        {
            int i = 0;
            List<int> demso = new List<int>();
            foreach (var r in dt.PhieuNhaps)
            {
                demso.Add(r.ma_PN.GetHashCode());
                i++;
            }
            var a = dt.PhieuNhaps.FirstOrDefault();
            if (a == null)
            {
                lbMaPN.Text = "11000";
            }
            else
            {
                int max = demso[0];
                for (int j = 1; j < i; j++)
                {
                    if (max < demso[j])
                    {
                        max = demso[j];
                    }
                }
                if (max < 9)
                {
                    max = max + 1;
                    lbMaPN.Text = "" + max;
                }
                else if (max > 9)
                {
                    max = max + 1;
                    lbMaPN.Text = "" + max;
                }
            }
            hehe = 1;

            cbxXe.DisplayMember = "ten_SP";
            cbxXe.ValueMember = "ma_SP";
            cbxXe.DataSource = dt.SanPhams.ToList();

            cbxNCC.DisplayMember = "ten_NCC";
            cbxNCC.ValueMember = "ma_NCC";
            cbxNCC.DataSource = dt.Nha_CungCaps;

            dgvXe.AutoGenerateColumns = false;
        }

        private void btnThemXe_Click(object sender, EventArgs e)
        {
            var HDN = dt.selectPN(Convert.ToInt32(lbMaPN.Text)).FirstOrDefault();
            if (txtDGXe.Text.Trim() == "" || txtSLXe.Text.Trim() == "" || txtDGXe.Text == null || txtSLXe.Text == null)
            {
                MessageBox.Show("Chưa nhập đủ", "Thông Báo");
            }
            else if (Convert.ToInt32(txtSLXe.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0", "Lỗi");
            }
            else if (Convert.ToInt64(txtDGXe.Text) == 0)
            {
                MessageBox.Show("Đơn giá phải lớn hơn 0", "Lỗi");
            }
            else
            {
                if (HDN == null)
                {
                    dt.INSERT_PNHAP(int.Parse(cbxNCC.SelectedValue.ToString()), Form_LoginApp.TTNV.MaNV, Convert.ToDateTime(DateTime.Now), false);
                    //insert CTPNXE + update slt
                    dt.INSERT_CTPNHAPXE(Convert.ToInt32(lbMaPN.Text), Convert.ToInt32(cbxXe.SelectedValue.ToString()), Convert.ToInt32(txtDGXe.Text), Convert.ToInt32(txtSLXe.Text),
                                        (Convert.ToInt32(txtDGXe.Text) * Convert.ToInt32(txtSLXe.Text)));
                    int tongtien = 0;
                    foreach (var a in dt.selectCTPNxe(Convert.ToInt32(lbMaPN.Text)))
                    {
                        tongtien = tongtien + Convert.ToInt32(a.gianhap_SP) * Convert.ToInt32(a.soluong_SP);
                    }

                    MessageBox.Show("Thêm thành công", "Thêm");
                }
                else if (HDN != null)
                {
                    var CTPNX = dt.selectCTPN(Convert.ToInt32(lbMaPN.Text), Convert.ToInt32(cbxXe.SelectedValue.ToString())).FirstOrDefault();
                    if (CTPNX == null)
                    {
                        dt.INSERT_CTPNHAPXE(Convert.ToInt32(lbMaPN.Text), Convert.ToInt32(cbxXe.SelectedValue.ToString()), Convert.ToInt32(txtDGXe.Text), Convert.ToInt32(txtSLXe.Text),
                            (Convert.ToInt32(txtDGXe.Text) * Convert.ToInt32(txtSLXe.Text)));
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNxe(Convert.ToInt32(lbMaPN.Text)))
                        {
                            tongtien = tongtien + Convert.ToDouble(a.gianhap_SP) * Convert.ToDouble(a.soluong_SP);
                        }
                        MessageBox.Show("Thêm thành công", "Thêm");
                        //dt.UPDATE_TIENNHAPXE(lbMaPN.Text, tongtien);
                    }
                    else if (CTPNX != null)
                    {

                        dt.updateSLTCTPNX(Convert.ToInt32(lbMaPN.Text), Convert.ToInt32(cbxXe.SelectedValue.ToString()), Convert.ToInt32(txtDGXe.Text), Convert.ToInt32(txtSLXe.Text) + CTPNX.soluong_SP,
                            CTPNX.tongtien_SP + (Convert.ToInt32(txtSLXe.Text) * Convert.ToInt32(txtDGXe.Text)));
                        double tongtien = 0;
                        foreach (var a in dt.selectCTPNxe(Convert.ToInt32(lbMaPN.Text)))
                        {
                            tongtien = tongtien + Convert.ToDouble(a.gianhap_SP) * Convert.ToDouble(a.soluong_SP);
                        }
                        MessageBox.Show("Thêm thành công", "Thêm");
                        //dt.UPDATE_TIENNHAPXE(lbMaPN.Text, tongtien);
                    }
                }
                dgvXe.DataSource = dt.selectCTPNxe(Convert.ToInt32(lbMaPN.Text));
                txtDGXe.Enabled = false;
                txtSLXe.ResetText();
                double TongTienHD = 0;
                foreach (var a in dt.selectCTPNxe(Convert.ToInt32(lbMaPN.Text)))
                {
                    TongTienHD = TongTienHD + Convert.ToDouble(a.gianhap_SP) * Convert.ToDouble(a.soluong_SP);
                }
                lbTongTien.Text = TongTienHD.ToString("N0");

            }
        }

        private void cbxXe_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                var sp = dt.SanPhams.FirstOrDefault();
                if (hehe == 1)
                {
                    cbxXe.DisplayMember = "ten_SP";
                    cbxXe.ValueMember = "ma_SP";
                    cbxXe.DataSource = dt.SanPhams.ToList();
                    cbxXe.SelectedValue = sp.ma_SP;
                    hehe++;
                }
                var CTPNX = dt.selectCTPN(Convert.ToInt32(lbMaPN.Text), Convert.ToInt32(cbxXe.SelectedValue.ToString())).FirstOrDefault();
                if (CTPNX == null)
                {
                    if (hehe == 2)
                    {
                        txtDGXe.ResetText();
                    }

                    txtDGXe.Enabled = true;
                }
                else if (CTPNX != null)
                {
                    txtDGXe.Text = CTPNX.gianhap_SP.ToString();
                    txtDGXe.Enabled = false;
                }
            }
            catch (Exception)
            {

            }
        }

        private void txtDGXe_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Mời bạn nhập số", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtSLXe.Text = "";
            txtSLXe.Text = "0";


            PhieuNhap_Load(sender, e);
            dgvXe.ClearSelection();
            dgvXe.DataSource = "";
        }

        private string Get_Id()
        {
            if (dgvXe.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgvXe.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgvXe.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }
        //private string Get_Masp()
        //{
        //    if (dgvXe.SelectedCells.Count > 0)
        //    {
        //        int selectedrowindex = dgvXe.SelectedCells[0].RowIndex;
        //        DataGridViewRow selectedRow = dgvXe.Rows[selectedrowindex];
        //        return Convert.ToString(selectedRow.Cells[1].Value);
        //    }
        //    return null;
        //}
        private void dgvXe_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvXe.Columns[e.ColumnIndex].Name == "Xoa")
            {
                DialogResult a = MessageBox.Show(" Ban co muon xoa khong?", "Xoa", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    //var HDX = dt.selectHoaDon(lbMaHD.Text).FirstOrDefault();
                    var sp = dt.selectSP(Convert.ToInt32(cbxXe.SelectedValue.ToString())).FirstOrDefault();
                    var ctpn = dt.CT_PhieuNhaps.Where(s => s.ma_PN == Convert.ToInt32(lbMaPN.Text)).Where(s => s.ma_SP == Convert.ToInt32(cbxXe.SelectedValue.ToString())).FirstOrDefault();
                    //dt.delete_PhieuNhap(Convert.ToInt32(lbMaPN.Text), Convert.ToInt32(cbxXe.SelectedValue.ToString()));
                    //Entities_Data.HD_Ban.Delete_CTHD(int.Parse(Get_Id()), int.Parse(Get_Masp()));
                    //dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(THANHTIEN));
                    HD_Ban.Delete_CTPN(Convert.ToInt32(lbMaPN.Text), int.Parse(Get_Id()));
                    dt.updateSLT(Convert.ToInt32(cbxXe.SelectedValue.ToString()), sp.soluong_SP - ctpn.soluong_SP);
                    dgvXe.DataSource = dt.selectCTPNxe(Convert.ToInt32(lbMaPN.Text));
                    txtSLXe.ResetText();
                    int TongTienHD = 0;
                    //double TongTienDiscount = 0;
                    foreach (var c in dt.selectCTPNxe(Convert.ToInt32(lbMaPN.Text)))
                    {
                        TongTienHD = TongTienHD + Convert.ToInt32(c.gianhap_SP) * Convert.ToInt32(c.soluong_SP);

                    }
                    //dt.UPDATE_TONGTIEN(Convert.ToInt32(lbMaHD.Text), TongTienHD);
                    lbTongTien.Text = TongTienHD.ToString("N0");

                }
            }

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            
        }
        public class thongtinHD
        {
            public static string ma;

        }
        private void btnIn_Click(object sender, EventArgs e)
        {
            thongtinHD.ma = lbMaPN.Text;
            ViewPN view = new ViewPN();
            view.Show();
        }
    }
}
