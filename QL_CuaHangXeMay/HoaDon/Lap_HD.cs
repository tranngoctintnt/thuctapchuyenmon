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

namespace QuanLy_CuaHang.HoaDon
{
    public partial class Lap_HD : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();

        public Lap_HD()
        {
            InitializeComponent();
        }
        public class thongtinHD
        {
            public static string ma;

        }
        int huhu = 0;

        private void Lap_HD_Load(object sender, EventArgs e)
        {
            huhu++;
            int i = 0;
            List<int> dem = new List<int>();
            foreach (var r in dt.HD_BanHangs)
            {
                dem.Add(r.ma_HD.GetHashCode());
                i++;
            }
            var a = dt.HD_BanHangs.FirstOrDefault();
            if (a == null)
            {
                lbMaHD.Text = "12000";
            }
            else
            {
                int max = dem[0];
                for (int j = 1; j < i; j++)
                {
                    if (max < dem[j])
                    {
                        max = dem[j];
                    }
                }
                if (max < 9)
                {
                    max = max + 1;
                    lbMaHD.Text = "" + max;
                }
                else if (max > 9)
                {
                    max = max + 1;
                    lbMaHD.Text = "" + max;
                }
            }
            cbbTenHang.DisplayMember = "ten_SP";
            cbbTenHang.ValueMember = "ma_SP";
            cbbTenHang.DataSource = dt.SanPhams.ToList();

            cbbKH.DisplayMember = "ten_hk";
            cbbKH.ValueMember = "ma_kh";
            cbbKH.DataSource = dt.KhachHangs.ToList();

            dgv_hd.AutoGenerateColumns = false;

        }


        private void btnThem_Click(object sender, EventArgs e)
        {
            var HDX = dt.selectHoaDon(Convert.ToInt32(lbMaHD.Text)).FirstOrDefault();
            if (txtSL.Text.Trim() == "" || txtSL.Text.Trim() == null)
            {
                MessageBox.Show("Bạn chưa nhập số lượng", "Thông báo");
            }
            else if (Convert.ToInt32(txtSL.Text) == 0)
            {
                MessageBox.Show("Số lượng phải lớn hơn 0");
            }
            else
            {
                if (HDX == null)
                {

                    dt.Insert_HoaDon(Convert.ToInt32(txtMaKh.Text), Form_LoginApp.TTNV.MaNV,
                        Convert.ToDateTime(DateTime.Now), false);
                    dt.INSERT_CTHD(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbTenHang.SelectedValue.ToString()), Convert.ToInt32(txtDongia.Text), Convert.ToInt32(txtSL.Text),
                                        (Convert.ToInt32(txtSL.Text) * Convert.ToInt32(txtDongia.Text)));
                    double thanhtien = 0;
                    foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                    {
                        thanhtien = thanhtien + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);

                    }
                   
                    //dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(thanhtien));
                    MessageBox.Show("Thêm thành công", "Thêm");
                    var sp = dt.selectSP(Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                    var cthd = dt.CTHD_BanHangs.Where(s => s.ma_HD == Convert.ToInt32(lbMaHD.Text)).Where(s => s.ma_SP == Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                    dt.updateSLT(Convert.ToInt32(cbbTenHang.SelectedValue.ToString()), sp.soluong_SP - cthd.soluong_SP);
                    label2.Text = sp.soluong_SP.ToString();

                }
                else if (HDX != null)
                {
                    var CTX = dt.selectAll_CTHD(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                    if (CTX == null)
                    {
                        dt.INSERT_CTHD(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbTenHang.SelectedValue.ToString()), Convert.ToInt32(txtDongia.Text), Convert.ToInt32(txtSL.Text),
                                        (Convert.ToInt32(txtSL.Text) * Convert.ToInt32(txtDongia.Text)));
                        double thanhtien = 0;
                        foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                        {
                            thanhtien = thanhtien + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);
                        }
                       

                        //dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(thanhtien));
                        MessageBox.Show("Thêm thành công", "Thêm");
                        var sp = dt.selectSP(Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                        var cthd = dt.CTHD_BanHangs.Where(s => s.ma_HD == Convert.ToInt32(lbMaHD.Text)).Where(s => s.ma_SP == Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                        dt.updateSLT(Convert.ToInt32(cbbTenHang.SelectedValue.ToString()), sp.soluong_SP - cthd.soluong_SP);
                        label2.Text = sp.soluong_SP.ToString();

                    }
                    else if (CTX != null)
                    {
                        dt.updateSL_CTHD(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbTenHang.SelectedValue.ToString()), Convert.ToInt32(txtDongia.Text), Convert.ToInt32(txtSL.Text) + CTX.soluong_SP,
                          Convert.ToInt32(CTX.tongtien_SP + (Convert.ToInt32(txtSL.Text) * Convert.ToInt32(txtDongia.Text))));
                        int thanhtien = 0;
                        foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                        {
                            thanhtien = thanhtien + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);
                        }
                        
                        //dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text),Convert.ToInt32(thanhtien));
                        MessageBox.Show("Thêm thành công", "Thêm");
                        var sp = dt.selectSP(Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                        var cthd = dt.CTHD_BanHangs.Where(s => s.ma_HD == Convert.ToInt32(lbMaHD.Text)).Where(s => s.ma_SP == Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                        dt.updateSLT(Convert.ToInt32(cbbTenHang.SelectedValue.ToString()), sp.soluong_SP - cthd.soluong_SP);
                        label2.Text = sp.soluong_SP.ToString();
                    }
                }
            }
            dgv_hd.DataSource = dt.selectCTHD(Convert.ToInt32(lbMaHD.Text));
            txtSL.ResetText();
            int TongTienHD = 0;
            foreach (var a in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
            {
                TongTienHD = TongTienHD + Convert.ToInt32(a.gia_SP) * Convert.ToInt32(a.soluong_SP);

            }
            //dt.UPDATE_TONGTIEN(Convert.ToInt32(lbMaHD.Text), TongTienHD);
            lbTongTien.Text = TongTienHD.ToString("N0");



        }

      
        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && !Char.IsControl(e.KeyChar))
            {
                DialogResult dtr = MessageBox.Show("Lỗi rồi", "Thông Báo", MessageBoxButtons.OK);
                if (dtr == DialogResult.OK)
                {
                    e.Handled = true;
                }
            }
        }

        private void gunaButton1_Click(object sender, EventArgs e)
        {
            thongtinHD.ma = lbMaHD.Text;
            //HoaDon hd = new HoaDon();
            //hd.Show();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            txtMaKh.Text = "";
            txtEmail.Text = "";
            txtSDT.Text = "";
            txtSL.Text = "";

            txtDongia.Text = "";
            Lap_HD_Load(sender, e);
            dgv_hd.ClearSelection();
            dgv_hd.DataSource = "";

        }
        private string Get_Id()
        {
            if (dgv_hd.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_hd.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_hd.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }
        private void dgvHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgv_hd.Columns[e.ColumnIndex].Name == "xoa")
            {
                DialogResult a = MessageBox.Show(" Ban co muon xoa khong?", "Xoa", MessageBoxButtons.YesNo);
                if (a == DialogResult.Yes)
                {
                    //var HDX = dt.selectHoaDon(lbMaHD.Text).FirstOrDefault();
                    var sp = dt.SanPhams.Where(p => p.ma_SP == Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                    var cthd = dt.CTHD_BanHangs.Where(s => s.ma_HD == Convert.ToInt32(lbMaHD.Text)).Where(s => s.ma_SP == Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                    //dt.delete_cthd(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(cbbTenSP.SelectedValue.ToString()));
                    HD_Ban.Delete_CTHD(Convert.ToInt32(lbMaHD.Text), int.Parse(Get_Id()));
                    //dt.UPDATE_ThanhTien(Convert.ToInt32(lbMaHD.Text), Convert.ToInt32(THANHTIEN));
                    dt.updateSLT(Convert.ToInt32(cbbTenHang.SelectedValue.ToString()), sp.soluong_SP + cthd.soluong_SP);
                    dgv_hd.DataSource = dt.selectCTHD(Convert.ToInt32(lbMaHD.Text));
                    txtSL.ResetText();
                    label2.Text = sp.soluong_SP.ToString();
                    int TongTienHD = 0;
                    //double TongTienDiscount = 0;
                    foreach (var c in dt.selectCTHD(Convert.ToInt32(lbMaHD.Text)))
                    {
                        TongTienHD = TongTienHD + Convert.ToInt32(c.gia_SP) * Convert.ToInt32(c.soluong_SP);

                    }
                    //dt.UPDATE_TONGTIEN(Convert.ToInt32(lbMaHD.Text), TongTienHD);
                    lbTongTien.Text = TongTienHD.ToString("N0");

                }
            }
        }

        private void cbbKH_SelectedIndexChanged(object sender, EventArgs e)
        {
            QL_CuaHangXeMay.KhachHang kh = dt.KhachHangs.Where(s => s.ma_KH == Convert.ToInt32(cbbKH.SelectedValue.ToString())).FirstOrDefault();
            txtMaKh.Text = kh.ma_KH.ToString();
            txtEmail.Text = kh.mail_KH.ToString();
            txtSDT.Text = kh.sdt_KH.ToString();
        }

        private void cbbTenHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            Gia_SP gia = dt.Gia_SPs.Where(s => s.ma_SP == Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
            txtDongia.Text = gia.gia_SP1.ToString();
        }

        private void cbbTenHang_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                if (huhu == 1)
                {
                    cbbTenHang.DisplayMember = "ten_SP";
                    cbbTenHang.ValueMember = "ma_SP";
                    cbbTenHang.DataSource = dt.SanPhams.ToList();
                }

                var sp = dt.selectSP(Convert.ToInt32(cbbTenHang.SelectedValue.ToString())).FirstOrDefault();
                label2.Text = sp.soluong_SP.ToString();
                huhu++;
            }
            catch (Exception)
            {
            }
        }
    }
}
