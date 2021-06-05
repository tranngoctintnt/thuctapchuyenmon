using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class LoaiSP_Data
    {
        public static List<Loai_SP> Get_LoaiSPList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Loai_SPs.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int Get_MaLoaiSP()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Loai_SPs.Max(p => p.ma_Loai);
                }
            }
            catch (Exception)
            {
                return 2000;
            }
        }

        public static Loai_SP Get_LoaiSP(int maLoai)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Loai_SPs.Where(p => p.ma_Loai == maLoai).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_HangSX(Loai_SP loaiSP)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.Loai_SPs.InsertOnSubmit(loaiSP);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_LoaiSP(Loai_SP loaiSP)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Loai_SP loai_SP = dt.Loai_SPs.Where(p => p.ma_Loai == loaiSP.ma_Loai).FirstOrDefault();
                    loai_SP.ten_Loai = loaiSP.ten_Loai;
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete_LoaiSP(int maLoai)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Loai_SP loai_SP = dt.Loai_SPs.Where(p => p.ma_Loai == maLoai).FirstOrDefault();
                    dt.Loai_SPs.DeleteOnSubmit(loai_SP);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static List<Loai_SP> Search_LoaiSP(string key)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Loai_SPs.Where(p => p.ten_Loai.Contains(key)).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
    }
}
