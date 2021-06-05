using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class HangSanXuat_Data
    {
        public static List<Hang_SX> Get_HangSanXuatList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Hang_SXes.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int Get_MaHangSX()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Hang_SXes.Max(p => p.ma_Hang);
                }
            }
            catch (Exception)
            {
                return 3000;
            }
        }

        public static Hang_SX Get_HangSX(int ma_Hang)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Hang_SXes.Where(p => p.ma_Hang == ma_Hang).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_HangSX(Hang_SX hangSX)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.Hang_SXes.InsertOnSubmit(hangSX);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_HangSX(Hang_SX hangSX)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Hang_SX hangSx = dt.Hang_SXes.Where(p => p.ma_Hang == hangSX.ma_Hang).FirstOrDefault();
                    hangSx.ten_Hang = hangSX.ten_Hang;
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete_HangSX(int ma_Hang)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Hang_SX hang_SX = dt.Hang_SXes.Where(p => p.ma_Hang == ma_Hang).FirstOrDefault();
                    dt.Hang_SXes.DeleteOnSubmit(hang_SX);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Hang_SX> Search_HangSX(string key)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Hang_SXes.Where(p => p.ten_Hang.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
