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

namespace QuanLy_CuaHang.ThongKe
{
    public partial class UC_ThongKe_Tab : UserControl
    {
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

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Them_DM_Click(object sender, EventArgs e)
        {
            int nam = int.Parse(cbb_Nam.Text.Trim());
            this.panel1.Controls.Add(new UC_ThongKeDaonhSo()
            {
                //month_1 = ThongKe_Data.Get_DoanhThu(1, nam),
                //month_2 = ThongKe_Data.Get_DoanhThu(2, nam),
                //month_3 = ThongKe_Data.Get_DoanhThu(3, nam),
                //month_4 = ThongKe_Data.Get_DoanhThu(4, nam),
                //month_5 = ThongKe_Data.Get_DoanhThu(5, nam),
                //month_6 = ThongKe_Data.Get_DoanhThu(6, nam),
                //month_7 = ThongKe_Data.Get_DoanhThu(7, nam),
                //month_8 = ThongKe_Data.Get_DoanhThu(8, nam),
                //month_9 = ThongKe_Data.Get_DoanhThu(9, nam),
                //month_10 = ThongKe_Data.Get_DoanhThu(10, nam),
                //month_11 = ThongKe_Data.Get_DoanhThu(11, nam),
                //month_12 = ThongKe_Data.Get_DoanhThu(12, nam),
            });
        }

        private void gunaCircleButton1_Click(object sender, EventArgs e)
        {
            this.panel2.Controls.Clear();
            this.panel2.Controls.Add(new UC_ThongKeMuaNhieu()
            {
                lst = ThongKe_Data.Get_MuaNhieu(
                        int.Parse(cbb_Thang.Text.Trim()),
                        int.Parse(cbb_Nam_MuaNhieu.Text.Trim())
                    )

                //lst = ThongKe_Data.Get_MuaNhieu
                //(
                //    int.Parse(cbb_Thang.Text.Trim()),
                //    int.Parse(cbb_Nam_MuaNhieu.Text.Trim())
                //)
            });
        }
    }
}
