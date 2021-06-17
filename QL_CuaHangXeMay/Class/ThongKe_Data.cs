using QL_CuaHangXeMay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public class ThongKe_Data
    {
        //public static int Get_DoanhThu(int month, int year)
        //{
        //    try
        //    {
        //        using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
        //        {
        //            //return (int)dt.ThongKe_Thang_Nam(month, year).FirstOrDefault();
        //        }
        //    }
        //    catch (Exception)
        //    {
        //        return 0;
        //    }
        //}

        public static List<ThongKe_SPMuaNhieuResult> Get_MuaNhieu(int month, int year)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.ThongKe_SPMuaNhieu(month, year).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
