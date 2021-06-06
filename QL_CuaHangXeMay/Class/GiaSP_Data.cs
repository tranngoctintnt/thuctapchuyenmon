using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public class GiaSP_Data
    {
        public static List<Get_GiaSPListResult> Get_GiaSPList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Get_GiaSPList().ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static Gia_SP Get_GiaSP(int ma_Gia)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Gia_SPs.Where(p => p.ma_GiaSP == ma_Gia).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static int Get_MaGiaSP()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.Gia_SPs.Max(p => p.ma_GiaSP);
                }
            }
            catch (Exception)
            {
                return 10000;
            }
        }

        public static bool Add_GiaSP(Gia_SP gia_SP)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.Gia_SPs.InsertOnSubmit(gia_SP);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Delete_GiaSP(int maGiaSP)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Gia_SP giaSP = dt.Gia_SPs.Where(p => p.ma_GiaSP == maGiaSP).FirstOrDefault();
                    dt.Gia_SPs.DeleteOnSubmit(giaSP);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_GiaSP(Gia_SP gia_SP)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    Gia_SP giaSP = dt.Gia_SPs.Where(p => p.ma_GiaSP == gia_SP.ma_GiaSP).FirstOrDefault();
                    giaSP.ngay_BDSP = gia_SP.ngay_BDSP;
                    giaSP.gia_SP1 = gia_SP.gia_SP1;
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
