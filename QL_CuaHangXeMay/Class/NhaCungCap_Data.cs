using QL_CuaHangXeMay;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class NhaCungCap_Data
    {
        public static List<Nha_CungCap> Get_NhaCungCapList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Nha_CungCaps.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int Get_MaNhaCungCap()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Nha_CungCaps.Max(p => p.ma_NCC);
                }
            }
            catch (Exception)
            {
                return 1000;
            }
        }

        public static Nha_CungCap Get_NhaCungCap(int ma_NCC)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Nha_CungCaps.Where(p => p.ma_NCC == ma_NCC).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_NhaCungCap(Nha_CungCap ncc)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.Nha_CungCaps.InsertOnSubmit(ncc);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_NhaCungCap(Nha_CungCap ncc)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Nha_CungCap nha_CungCap = dt.Nha_CungCaps.Where(p => p.ma_NCC == ncc.ma_NCC).FirstOrDefault();
                    nha_CungCap.ten_NCC = ncc.ten_NCC;
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_NhaCungCap(int ma_NCC)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Nha_CungCap nha_CungCap = dt.Nha_CungCaps.Where(p => p.ma_NCC == ma_NCC).FirstOrDefault();
                    dt.Nha_CungCaps.DeleteOnSubmit(nha_CungCap);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<Nha_CungCap> Search_NhaCC(string key)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Nha_CungCaps.Where(p => p.ten_NCC.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
