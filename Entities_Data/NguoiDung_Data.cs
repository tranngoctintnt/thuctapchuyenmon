using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities_Data
{
    public static class NguoiDung_Data
    {
        public static List<NhanVien> Get_NhanVienList()
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.NhanViens.ToList();
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
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.NhanViens.Where(p => p.ma_NV == maNV).FirstOrDefault();
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
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.CT_Quyen.Where(p => p.ma_NV == maNV).ToList();
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
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.NhanViens.Max(prop => prop.ma_NV);
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
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.ChucNangs.ToList();
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
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    return entities.CT_Quyen.Where(p => p.ma_NV == ma_NV).ToList();
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
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.NhanViens.Add(nhanVien);
                    entities.SaveChanges();
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
            using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
            {
                NhanVien nhanVien = entities.NhanViens.Where(p => p.ma_NV == nv.ma_NV).FirstOrDefault();
                nhanVien.mk_DangNhap = nv.mk_DangNhap;
                nhanVien.ten_NV = nv.ten_NV;
                nhanVien.sdt_NV = nv.sdt_NV;
                nhanVien.mail_NV = nv.mail_NV;
                entities.SaveChanges();


                return true;
            }
        }

        public static bool Update_Quyen(CT_Quyen cT_Quyen)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    CT_Quyen cT_Quyen1 = entities.CT_Quyen.Where(p => p.ma_NV == cT_Quyen.ma_NV && p.ma_CN == cT_Quyen.ma_CN).FirstOrDefault(); 
                    entities.SaveChanges();
                    cT_Quyen1.stas = cT_Quyen.stas;
                    entities.SaveChanges();
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
            using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
            {
                NhanVien nhanVien = entities.NhanViens.Where(p => p.ma_NV == maNV).FirstOrDefault();
                nhanVien.mk_DangNhap = "E10ADC3949BA59ABBE56E057F20F883E";
                entities.SaveChanges();
                return true;
            }
        }

        public static bool Delete_NguoiDung(int maND)
        {
            try
            {
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.NhanViens.Remove(entities.NhanViens.Where(p => p.ma_NV == maND).FirstOrDefault());
                    entities.CT_Quyen.RemoveRange(entities.CT_Quyen.Where(p => p.ma_NV == maND).ToList());
                    entities.SaveChanges();
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
                using (CuaHang_XeMayEntities entities = new CuaHang_XeMayEntities())
                {
                    entities.CT_Quyen.Add(cT_Quyen);
                    entities.SaveChanges();
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
