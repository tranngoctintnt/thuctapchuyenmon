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
    public partial class ViewPN : Form
    {
        public ViewPN()
        {
            InitializeComponent();
        }

        private void ViewPN_Load(object sender, EventArgs e)
        {
            string ma = QuanLy_CuaHang.HoaDon.HD_PhieuNhap.thongtinHD.ma;
            // TODO: This line of code loads data into the 'DataSetPN.inPN' table. You can move, or remove it, as needed.
            this.inPNTableAdapter.Fill(this.DataSetPN.inPN, Convert.ToInt32(ma));

            this.reportViewer1.RefreshReport();
        }
    }
}
