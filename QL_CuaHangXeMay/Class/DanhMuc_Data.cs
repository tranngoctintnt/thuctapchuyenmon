using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class DanhMuc_Data
    {
        public static List<DanhMuc> Get_DanhMucList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.DanhMucs.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int Get_MaDanhMuc()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.DanhMucs.Max(p => p.ma_DM);
                }
            }
            catch (Exception)
            {
                return 4000;
            }
        }

        public static DanhMuc Get_DanhMuc(int maDM)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.DanhMucs.Where(p => p.ma_DM == maDM).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_DanhMuc(DanhMuc danhMuc)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.DanhMucs.InsertOnSubmit(danhMuc);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_DanhMuc(DanhMuc danh_Muc)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    DanhMuc danhMuc = dt.DanhMucs.Where(p => p.ma_DM == danh_Muc.ma_DM).FirstOrDefault();
                    danhMuc.ten_DM = danh_Muc.ten_DM;
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete_DanhMuc(int ma_DanhMuc)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    DanhMuc danhMuc = dt.DanhMucs.Where(p => p.ma_DM == ma_DanhMuc).FirstOrDefault();
                    dt.DanhMucs.DeleteOnSubmit(danhMuc);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<DanhMuc> Search_DanhMuc(string key)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.DanhMucs.Where(p => p.ten_DM.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
