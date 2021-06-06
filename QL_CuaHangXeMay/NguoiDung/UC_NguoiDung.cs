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

namespace QuanLy_CuaHang.QL_NguoiDung
{
    public partial class UC_QLNguoiDung : UserControl
    {
        public UC_QLNguoiDung()
        {
            InitializeComponent();
            Load_Data();

            dgv_TTNhanVien.ColumnHeadersHeight = 24;

            dgv_TTNhanVien.ColumnHeadersHeight = 24;

            dgv_TTNhanVien.Columns[0].HeaderText = "Mã";
            dgv_TTNhanVien.Columns[1].HeaderText = "Họ tên";
            dgv_TTNhanVien.Columns[2].HeaderText = "Mail";
            dgv_TTNhanVien.Columns[3].HeaderText = "Số điện thoại";

            dgv_TTNhanVien.Columns[0].Width = 50;
            dgv_TTNhanVien.Columns[3].Width = 100;

            dgv_TTNhanVien.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(52, 128, 235);
            dgv_TTNhanVien.EnableHeadersVisualStyles = false;

            dgv_TTNhanVien.Columns[4].Visible = false;
        }

        private void Load_Data()
        {
            dgv_TTNhanVien.DataSource = NguoiDung_Data.Get_NhanVienList();
        }

        private void btn_ThemNguoiDung_Click(object sender, EventArgs e)
        {
            Form_ThemNguoiDung form_ThemNguoiDung = new Form_ThemNguoiDung();
            form_ThemNguoiDung.ShowDialog();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            Load_Data();
        }

        private void btn_ThemNguoiDung_Click_1(object sender, EventArgs e)
        {
            Form_ThemNguoiDung form_ThemNguoiDung = new Form_ThemNguoiDung();
            form_ThemNguoiDung.ShowDialog();
            Load_Data();
        }
        private string Get_Id()
        {
            if (dgv_TTNhanVien.SelectedCells.Count > 0)
            {
                int selectedrowindex = dgv_TTNhanVien.SelectedCells[0].RowIndex;
                DataGridViewRow selectedRow = dgv_TTNhanVien.Rows[selectedrowindex];
                return Convert.ToString(selectedRow.Cells[0].Value);
            }
            return null;
        }

        private void dgv_TTNhanVien_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            NhanVien nhanVien = NguoiDung_Data.Get_NhanVien(int.Parse(Get_Id()));
            txt_ma_NV.Text = nhanVien.ma_NV.ToString();
            txt_tenNV.Text = nhanVien.ten_NV.ToString();
            txt_Sdt.Text = nhanVien.sdt_NV.ToString();
            txt_Mail.Text = nhanVien.mail_NV.ToString();

            List<CT_Quyen> lst = NguoiDung_Data.Get_CTQuyenList(int.Parse(Get_Id()));

            if (lst[0].stas == true) this.ckb_QLSP.Checked = true;
            else this.ckb_QLSP.Checked = false;
            if (lst[1].stas == true) this.ckb_QLHD.Checked = true;
            else this.ckb_QLHD.Checked = false;
            if (lst[2].stas == true) this.ckb_ThongKe.Checked = true;
            else this.ckb_ThongKe.Checked = false;
            if (lst[3].stas == true) this.ckb_QLKH.Checked = true;
            else this.ckb_QLKH.Checked = false;
            if (lst[4].stas == true) this.ckb_QLND.Checked = true;
            else this.ckb_QLND.Checked = false;
        }

        private void gunaCircleButton3_Click(object sender, EventArgs e)
        {
            NguoiDung_Data.Delete_NguoiDung(int.Parse(Get_Id()));
            Load_Data();
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            NguoiDung_Data.ResetPass(int.Parse(Get_Id()));
            MessageBox.Show("Đã đắt mật khâu về lại mặc định: 123456");
        }

        private void gunaCircleButton2_Click(object sender, EventArgs e)
        {
            if (txt_tenNV.Text.Trim() != "" && txt_Sdt.Text.Trim() != "" && txt_Mail.Text.Trim() != "")
            {
                NguoiDung_Data.Update_NhanVien(new NhanVien()
                {
                    ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                    ten_NV = txt_tenNV.Text.ToString(),
                    mail_NV = txt_Mail.Text.ToString(),
                    sdt_NV = txt_Sdt.Text.ToString(),
                    mk_dangnhap = ""
                });

                if (ckb_QLSP.Checked)
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5000,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = true
                    });
                }
                else
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5000,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = false
                    });
                }

                if (ckb_QLHD.Checked)
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5001,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = true
                    });
                }
                else
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5001,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = false
                    });
                }

                if (ckb_ThongKe.Checked)
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5002,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = true
                    });
                }
                else
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5002,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = false
                    });
                }

                if (ckb_QLKH.Checked)
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5003,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = true
                    });
                }
                else
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5003,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = false
                    });
                }

                if (ckb_QLND.Checked)
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5004,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = true
                    });
                }
                else
                {
                    NguoiDung_Data.Update_Quyen(new CT_Quyen()
                    {
                        ma_CN = 5004,
                        ma_NV = int.Parse(txt_ma_NV.Text.ToString()),
                        stas = false
                    });
                }
                MessageBox.Show("Đã cập nhật thay đổi!");
                Load_Data();
            }
            else
            {
                MessageBox.Show("Hãy nhập đầy đủ thông tin!");
            }
        }
    }
    
}
