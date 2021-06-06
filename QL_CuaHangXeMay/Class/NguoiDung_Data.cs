using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QL_CuaHangXeMay.Class
{
    public static class NguoiDung_Data
    {
        public static List<NhanVien> Get_NhanVienList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.NhanViens.ToList();
                }
            }
            catch(Exception)
            {
                return null;
            }            
        }
        public static NhanVien Get_NhanVien(int maNV)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.NhanViens.Where(p => p.ma_NV == maNV).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static List<CT_Quyen> Get_QuyenList(int maNV)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.CT_Quyens.Where(p => p.ma_NV == maNV).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static int Get_MaNhanVien()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.NhanViens.Max(prop => prop.ma_NV);
                }
            }
            catch (Exception)
            {
                return 6000;
            }
        }
        public static List<ChucNang> Get_ChucNangList()
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.ChucNangs.ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }

        public static List<CT_Quyen> Get_CTQuyenList(int ma_NV)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    return dt.CT_Quyens.Where(p => p.ma_NV == ma_NV).ToList();
                }
            }
            catch (Exception)
            {
                return null;
            }
        }
        public static bool Add_NguoiDung(NhanVien nhanVien)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.NhanViens.InsertOnSubmit(nhanVien);
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Update_NhanVien(NhanVien nv)
        {
            using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
            {
                NhanVien nhanVien = dt.NhanViens.Where(p => p.ma_NV == nv.ma_NV).FirstOrDefault();
                nhanVien.mk_dangnhap = nv.mk_dangnhap;
                nhanVien.ten_NV = nv.ten_NV;
                nhanVien.sdt_NV = nv.sdt_NV;
                nhanVien.mail_NV = nv.mail_NV;
                dt.SubmitChanges();


                return true;
            }
        }

        public static bool Update_Quyen(CT_Quyen cT_Quyen)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    CT_Quyen cT_Quyen1 = dt.CT_Quyens.Where(p => p.ma_NV == cT_Quyen.ma_NV && p.ma_CN == cT_Quyen.ma_CN).FirstOrDefault(); 
                    dt.SubmitChanges();
                    cT_Quyen1.stas = cT_Quyen.stas;
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool ResetPass(int maNV)
        {
            using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
            {
                NhanVien nhanVien = dt.NhanViens.Where(p => p.ma_NV == maNV).FirstOrDefault();
                nhanVien.mk_dangnhap = "E10ADC3949BA59ABBE56E057F20F883E";
                dt.SubmitChanges();
                return true;
            }
        }

        public static bool Delete_NguoiDung(int maND)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.NhanViens.DeleteOnSubmit(dt.NhanViens.Where(p => p.ma_NV == maND).FirstOrDefault());
                    dt.CT_Quyens.DeleteOnSubmit(dt.CT_Quyens.Where(p => p.ma_NV == maND).FirstOrDefault());
                    dt.SubmitChanges();
                    return true;
                }
            }
            catch (Exception)
            {
                return false;
            }
        }

        public static bool Add_Quyen(CT_Quyen cT_Quyen)
        {
            try
            {
                using (DataClassesQLDataContext dt = new DataClassesQLDataContext())
                {
                    dt.CT_Quyens.InsertOnSubmit(cT_Quyen);
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
