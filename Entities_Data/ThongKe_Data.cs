using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public class ThongKe_Data
    {
        public static int Get_DoanhThu(int month, int year)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return (int)entities.ThongKe_Thang_Nam(month, year).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return 0;
            }
        }

        public static List<ThongKe_SPMuaNhieu_Result> Get_MuaNhieu(int month, int year)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.ThongKe_SPMuaNhieu(month, year).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }
}
