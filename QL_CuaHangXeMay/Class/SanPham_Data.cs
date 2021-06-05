using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class SanPham_Data
    {
        public static List<Get_SanPhamList_ResultResult> Get_SanPhamList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Get_SanPhamList_Result().ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int Get_MaSanPham()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.SanPhams.Max(p => p.ma_SP);
                }
            }
            catch (Exception)
            {
                return 14000;
            }
        }

        public static SanPham Get_SanPham(int maSP)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.SanPhams.Where(p => p.ma_SP == maSP).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static bool Add_SanPham(SanPham sanPham)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.SanPhams.InsertOnSubmit(sanPham);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_SanPham(SanPham sanPham)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    SanPham san_Pham = dt.SanPhams.Where(p => p.ma_SP == sanPham.ma_SP).FirstOrDefault();
                    san_Pham.mau_SP = sanPham.mau_SP;
                    san_Pham.ma_Loai = sanPham.ma_Loai;
                    san_Pham.ma_Hang = sanPham.ma_Hang;
                    san_Pham.ma_DM = sanPham.ma_DM;
                    san_Pham.soluong_SP = sanPham.soluong_SP;
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_SanPham(int maSP)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    SanPham san_Pham = dt.SanPhams.Where(p => p.ma_SP == maSP).FirstOrDefault();
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        
    }
}
