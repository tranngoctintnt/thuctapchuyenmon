using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_CuaHangXeMay.ThongKe
{
    public partial class TonKho : UserControl
    {
        DataClassesQLDataContext dt = new DataClassesQLDataContext();

        public TonKho()
        {
            InitializeComponent();
        }

        private void TonKho_Load(object sender, EventArgs e)
        {
            using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
            {
                chart1.DataSource = dt.SanPhams.ToList();
                chart1.Series["Series1"].XValueMember = "ten_Sp";
                chart1.Series["Series1"].XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
                chart1.Series["Series1"].YValueMembers = "soluong_SP";
                chart1.Series["Series1"].YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Int32;
            }
        }
    }
}
