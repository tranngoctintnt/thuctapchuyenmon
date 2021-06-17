using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangXeMay.HoaDon
{
    public partial class inHoaDon : Form
    {
        public inHoaDon()
        {
            InitializeComponent();
        }

        private void inHoaDon_Load(object sender, EventArgs e)
        {
            string ma = QuanLy_CuaHang.HoaDon.Lap_HD.thongtinHD.ma;
            // TODO: This line of code loads data into the 'DataSetHD.inHd' table. You can move, or remove it, as needed.
            this.inHdTableAdapter.Fill(this.DataSetHD.inHd, Convert.ToInt32(ma));

            this.reportViewer1.RefreshReport();
        }
    }
}
