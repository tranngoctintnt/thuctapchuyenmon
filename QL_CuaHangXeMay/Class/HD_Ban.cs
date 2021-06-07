using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class HD_Ban
    {
        public static List<HD_BanHang> Get_ListHD()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.HD_BanHangs.ToList();
                }
            }catch(Exception)
            {
                return null;
            }
        }
        public static bool Delete_CTPN(int CTPN, int masp)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    CT_PhieuNhap CTPN_tt = dt.CT_PhieuNhaps.Where(p => p.ma_PN == CTPN).Where(s => s.ma_SP == masp).FirstOrDefault();
                    dt.CT_PhieuNhaps.DeleteOnSubmit(CTPN_tt);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static bool Delete_CTHD(int cthd, int masp)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    CTHD_BanHang cthd_tt = dt.CTHD_BanHangs.Where(p => p.ma_HD == cthd).Where(s => s.ma_SP == masp).FirstOrDefault();
                    dt.CTHD_BanHangs.DeleteOnSubmit(cthd_tt);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }
        public static List<string> Get_YearList()
        {
            using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
            {
                return dt.HD_BanHangs.Select(p => p.ngaylap_HD.Value.Year.ToString()).ToList();
            }
        }

        //public static List<hd_Result> Search_HoaDonList(string value)
        //{
        //    using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
        //    {
        //        return dt.hd().Where(p=> p.ten_HK.Contains(value)).ToList();
        //    }
        //}

    }
}
