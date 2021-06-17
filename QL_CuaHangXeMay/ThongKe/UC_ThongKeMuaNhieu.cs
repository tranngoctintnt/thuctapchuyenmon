using QL_CuaHangXeMay;
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
    public partial class UC_ThongKeMuaNhieu : UserControl
    {
        public List<ThongKe_SPMuaNhieuResult> lst { get; set; }
        public UC_ThongKeMuaNhieu()
        {
            InitializeComponent();
        }

        private void UC_SanPham_Load(object sender, EventArgs e)
        {
            if (this.lst.Count >= 5)
            {
                chart1.Series["Series1"].Points.AddXY("", this.lst[0].SL.Value);
                chart1.Series["Series2"].Points.AddXY("", this.lst[1].SL.Value);
                chart1.Series["Series3"].Points.AddXY("", this.lst[2].SL.Value);
                chart1.Series["Series4"].Points.AddXY("", this.lst[3].SL.Value);
                chart1.Series["Series5"].Points.AddXY("", this.lst[4].SL.Value);

                chart1.Series["Series1"].Name = this.lst[0].Ten_SP;
                chart1.Series["Series2"].Name = this.lst[1].Ten_SP;
                chart1.Series["Series3"].Name = this.lst[2].Ten_SP;
                chart1.Series["Series4"].Name = this.lst[3].Ten_SP;
                chart1.Series["Series5"].Name = this.lst[4].Ten_SP;
            }
        }
    }    
}
