using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Guna.UI.WinForms;
using QL_CuaHangXeMay;
using QL_CuaHangXeMay.Class;
using YoutubeMacDemo;

namespace QuanLy_CuaHang
{
    public partial class Form_MainApp : Form
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();
        private int ma_NV;
        public Form_MainApp(int maNV)
        {
            InitializeComponent();
            UC_Dashboard uC_ = new UC_Dashboard();
            addUserControl(uC_);
            this.ma_NV = maNV;
            PhanQuyen();
        }
        private void addUserControl(UserControl uc)
        {
            pnl_NoiDung.Controls.Clear();
            uc.Dock = DockStyle.Fill;
            uc.BringToFront();
            pnl_NoiDung.Controls.Add(uc);
        }

        private void PhanQuyen()
        {
            List<CT_Quyen> lst = NguoiDung_Data.Get_QuyenList(this.ma_NV);
            if (lst[0].stas == false) this.btn_SANPHAM.Visible = false;
            if (lst[1].stas == false) this.btn_HOADON.Visible = false;
            if (lst[2].stas == false) this.btn_THONGKE.Visible = false;
            if (lst[3].stas == false) this.btn_KHACHHANG.Visible = false;
            if (lst[4].stas == false) this.btn_NGUOIDUNG.Visible = false;
            btn_DATA.Enabled = false;
            btn_DATA.Visible = false;
        }

        private void gunaTileButton2_Click(object sender, EventArgs e)
        {
            Form_LoginApp f1 = new Form_LoginApp();
            this.Hide();
            f1.Show();

        }

        private void gunaTileButton1_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void btn_ChucNang_Click(object sender, EventArgs e)
        {
            GunaButton button = sender as GunaButton;
            pnl_Select.Visible = true;
            pnl_NoiDung.Controls.Clear();
            switch (button.Name)
            {
                //case "btn_HOADON":
                //    pnl_NoiDung.Controls.Add(new HoaDon.UC_HoaDon());
                //    pnl_Select.Location = new Point(0, btn_HOADON.Location.Y+183);
                //    break;
                //case "btn_THONGKE":
                //    pnl_NoiDung.Controls.Add(new ThongKe.UC_ThongKe_Tab());
                //    pnl_Select.Location = new Point(0, btn_THONGKE.Location.Y+183);
                //    break;
                case "btn_SANPHAM":
                    pnl_NoiDung.Controls.Add(new SanPham.UC_SanPham_Tab());
                    pnl_Select.Location = new Point(0, btn_SANPHAM.Location.Y + 183);
                    break;
                case "btn_KHACHHANG":
                    pnl_NoiDung.Controls.Add(new KhachHang.UC_KHACHHANG());
                    pnl_Select.Location = new Point(0, btn_KHACHHANG.Location.Y + 183);
                    break;
                case "btn_NGUOIDUNG":
                    pnl_NoiDung.Controls.Add(new QL_NguoiDung.UC_QLNguoiDung());
                    pnl_Select.Location = new Point(0, btn_NGUOIDUNG.Location.Y + 183);
                    break;
                    //case "btn_DATA":
                    //    pnl_NoiDung.Controls.Add(new QL_SaoLuu.UC_QLSaoLuu());
                    //    pnl_Select.Location = new Point(0, btn_DATA.Location.Y+183);
                    //    break;
            }
        }

        private void gunaImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void gunaTileButton4_Click(object sender, EventArgs e)
        {
            Mail f = new Mail();
            f.Visible = true;
        }

        private void Form_MainApp_Load(object sender, EventArgs e)
        {
            NhanVien nv = dt.NhanViens.Where(s => s.ma_NV == Convert.ToInt32(Form_LoginApp.TTNV.MaNV.ToString())).FirstOrDefault();
            lbl_NguoiDung.Text = "Xin Chào," + nv.ten_NV;
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            UC_Dashboard uC_ = new UC_Dashboard();
            addUserControl(uC_);
        }
    }
}
