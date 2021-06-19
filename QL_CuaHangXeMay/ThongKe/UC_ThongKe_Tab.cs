using QL_CuaHangXeMay;
using QL_CuaHangXeMay.Class;
using QL_CuaHangXeMay.ThongKe;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLy_CuaHang.ThongKe
{
    public partial class UC_ThongKe_Tab : UserControl
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();

        public UC_ThongKe_Tab()
        {
            InitializeComponent();
            Load_Combobox();
        }

        private void Load_Combobox()
        {
            //cbb_Nam.DataSource = Entities_Data.HD_Ban.Get_YearList();
            cbb_Nam.Radius = cbb_Nam_MuaNhieu.Radius = cbb_Thang.Radius = 12;
            cbb_Nam.BorderSize = cbb_Nam_MuaNhieu.BorderSize = cbb_Thang.BorderSize = 1;

            List<string> lst_Year = HD_Ban.Get_YearList();
            for (int i = 0; i < lst_Year.Count; i++)
            {
                for (int j = i; j < lst_Year.Count; j++)
                {
                    if (lst_Year[i] == lst_Year[j])
                    {
                        lst_Year.RemoveAt(j);
                        i = j = 0;
                    }
                }
            }
            cbb_Nam.DataSource = cbb_Nam_MuaNhieu.DataSource = lst_Year;
            cbb_Thang.SelectedIndex = 0;
        }

        private void checkedtab()
        {
            switch(tabControl1.SelectedIndex)
            {
                case 2:
                    this.tabPage3.Controls.Clear();
                    this.tabPage3.Controls.Add(new TonKho());
                    break;
            }
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {
            checkedtab();
        }

        private void btn_Them_DM_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(cbb_Nam.Text.Trim());
            this.panel1.Controls.Add(new UC_ThongKeDaonhSo()
            {
                month_1 = ThongKe_Data.Get_DoanhThu(1, nam),
                month_2 = ThongKe_Data.Get_DoanhThu(2, nam),
                month_3 = ThongKe_Data.Get_DoanhThu(3, nam),
                month_4 = ThongKe_Data.Get_DoanhThu(4, nam),
                month_5 = ThongKe_Data.Get_DoanhThu(5, nam),
                month_6 = ThongKe_Data.Get_DoanhThu(6, nam),
                month_7 = ThongKe_Data.Get_DoanhThu(7, nam),
                month_8 = ThongKe_Data.Get_DoanhThu(8, nam),
                month_9 = ThongKe_Data.Get_DoanhThu(9, nam),
                month_10 = ThongKe_Data.Get_DoanhThu(10, nam),
                month_11 = ThongKe_Data.Get_DoanhThu(11, nam),
                month_12 = ThongKe_Data.Get_DoanhThu(12, nam),
            });
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(new UC_ThongKeMuaNhieu()
            {
                lst = ThongKe_Data.Get_MuaNhieu
                (
                    int.Parse(cbb_Thang.Text.Trim()),
                    int.Parse(cbb_Nam_MuaNhieu.Text.Trim())
                )
            });
        }

        private void UC_ThongKe_Tab_Load(object sender, EventArgs e)
        {

            int a = 0;
            foreach (var r in dt.KhachHangs)
            {

                a = a + 1;
            }
            lbTongKH.Text = a.ToString();
            decimal b = 0;
            foreach (var doanht in dt.tongdoanhthu())
            {
                b = b + Convert.ToDecimal(doanht.Column1);
            }
            lbDoanhTHu.Text = b.ToString("N0");
        }

        private void bt_XuatFile_Click(object sender, EventArgs e)
        {
            data_ThongTin.DataSource = dt.xuatdata();
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets["Sheet1"];
            worksheet = workbook.ActiveSheet;
            app.Visible = true;
            // Dua du lieu vao excel
            worksheet.Cells[1, 4] = "Bảng Thống Kê Hóa Đơn ";
            worksheet.Cells[2, 3] = "";
            worksheet.Cells[3, 1] = "STT";
            worksheet.Cells[3, 2] = "Mã HD";
            worksheet.Cells[3, 3] = "Tên khách hàng";
            worksheet.Cells[3, 4] = "Số điện thoại";
            worksheet.Cells[3, 5] = "Mail";
            worksheet.Cells[3, 6] = "Tên nhân viên";
            worksheet.Cells[3, 7] = "Ngày lập hóa đơn";
            worksheet.Cells[3, 8] = "Mã sản phẩm";
            worksheet.Cells[3, 9] = "Tên sản phẩm";
            worksheet.Cells[3, 10] = "Gía sản phẩm";
            worksheet.Cells[3, 11] = "Số lượng sản phẩm";
            worksheet.Cells[3, 12] = "Tổng tiền";

            for (int i = 0; i < data_ThongTin.RowCount - 1; i++)
            {
                for (int j = 0; j < 11; j++)
                {
                    worksheet.Cells[i + 4, 1] = i + 1;
                    worksheet.Cells[i + 4, j + 2] = data_ThongTin.Rows[i].Cells[j].Value;
                }
            }
            int dem = data_ThongTin.RowCount - 1;

            // Định dạng trang
            worksheet.PageSetup.Orientation = Microsoft.Office.Interop.Excel.XlPageOrientation.xlPortrait;
            worksheet.PageSetup.PaperSize = Microsoft.Office.Interop.Excel.XlPaperSize.xlPaperA4;
            worksheet.PageSetup.LeftMargin = 0;
            worksheet.PageSetup.RightMargin = 0;
            worksheet.PageSetup.TopMargin = 0;
            worksheet.PageSetup.BottomMargin = 0;

            // Đinh dạng cột
            worksheet.Range["A1"].ColumnWidth = 7;
            worksheet.Range["B1"].ColumnWidth = 20;
            worksheet.Range["C1"].ColumnWidth = 45;
            worksheet.Range["D1"].ColumnWidth = 25;
            worksheet.Range["E1"].ColumnWidth = 40;
            worksheet.Range["F1"].ColumnWidth = 45;
            worksheet.Range["G1"].ColumnWidth = 23;
            worksheet.Range["H1"].ColumnWidth = 23;
            worksheet.Range["I1"].ColumnWidth = 23;
            worksheet.Range["J1"].ColumnWidth = 23;
            worksheet.Range["K1"].ColumnWidth = 23;
            worksheet.Range["L1"].ColumnWidth = 23;


            // Định dạng font chữ
            //     worksheet.Range["A1", "J100"].Font.Name = "";
            worksheet.Range["A1", "A100"].Font.Size = 24;
            worksheet.Range["A3", "L100"].Font.Size = 16;
            worksheet.Range["A1", "L1"].MergeCells = true;
            worksheet.Range["A1", "L1"].Font.Bold = true;

            //worksheet.Range["A3", "J3"].MergeCells = true;
            worksheet.Range["A3", "L3"].Font.Bold = true;

            // kẻ bảng
            worksheet.Range["A3", "L" + (dem + 3)].Borders.LineStyle = 1;


            //Định dạng dòng text
            worksheet.Range["A1", "L1"].HorizontalAlignment = 3;
            worksheet.Range["A3", "L3"].HorizontalAlignment = 3;
            worksheet.Range["A4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["B4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["C4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["D4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["E4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["F4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["G4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["H4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["I4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["J4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["K4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["L4", "L" + (dem + 4)].HorizontalAlignment = 3;
            worksheet.Range["M4", "L" + (dem + 4)].HorizontalAlignment = 3;
        }
    }
}
