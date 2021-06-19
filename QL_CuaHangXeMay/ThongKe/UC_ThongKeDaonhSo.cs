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
    public partial class UC_ThongKeDaonhSo : UserControl
    {
        public int month_1 { get; set; }
        public int month_2 { get; set; }
        public int month_3 { get; set; }
        public int month_4 { get; set; }
        public int month_5 { get; set; }
        public int month_6 { get; set; }
        public int month_7 { get; set; }
        public int month_8 { get; set; }
        public int month_9 { get; set; }
        public int month_10 { get; set; }
        public int month_11 { get; set; }
        public int month_12 { get; set; }

        public UC_ThongKeDaonhSo()
        {
            InitializeComponent();
        }

        private void UC_DanhSo_Load(object sender, EventArgs e)
        {
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 1", this.month_1);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 2", this.month_2);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 3", this.month_3);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 4", this.month_4);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 5", this.month_5);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 6", this.month_6);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 7", this.month_7);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 8", this.month_8);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 9", this.month_9);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 10", this.month_10);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 11", this.month_11);
            chart1.Series["Danh số các tháng"].Points.AddXY("Tháng 12", this.month_12);
        }
    }
}
