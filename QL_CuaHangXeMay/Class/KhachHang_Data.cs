using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class KhachHang_Data
    {
        public static List<KhachHang> Get_KhachHangList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.KhachHangs.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_KhachHang(KhachHang khachHang)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.KhachHangs.InsertOnSubmit(khachHang);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_KhachHang(KhachHang khachHang)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    KhachHang khach_Hang = dt.KhachHangs.Where(p => p.ma_KH == khachHang.ma_KH).FirstOrDefault();
                    khach_Hang.ten_HK = khachHang.ten_HK;
                    khach_Hang.mail_KH = khachHang.mail_KH;
                    khach_Hang.sdt_KH = khachHang.sdt_KH;
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_KhachHang(int maKH)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    KhachHang khach_Hang = dt.KhachHangs.Where(p => p.ma_KH == maKH).FirstOrDefault();
                    dt.KhachHangs.DeleteOnSubmit(khach_Hang);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static int Get_MaKhachHang()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.KhachHangs.Max(p => p.ma_KH);
                }
            }
            catch (Exception)
            {
                return 7000;
            }
        }

        public static KhachHang Get_KhachHang(int maKH)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.KhachHangs.Where(p => p.ma_KH == maKH).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static List<KhachHang> Search_KhachHang(string key)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.KhachHangs.Where(p => p.ten_HK.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

    }

}
