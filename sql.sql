USE [CuaHang_XeMay_OFMain]
GO
/****** Object:  Table [dbo].[CT_PhieuNhap]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_PhieuNhap](
	[ma_PN] [int] NOT NULL,
	[ma_SP] [int] NOT NULL,
	[gianhap_SP] [int] NULL,
	[soluong_SP] [int] NULL,
	[tongtien_SP] [int] NULL,
 CONSTRAINT [PK_CT_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ma_PN] ASC,
	[ma_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CT_Quyen]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CT_Quyen](
	[ma_NV] [int] NOT NULL,
	[ma_CN] [int] NOT NULL,
	[stas] [bit] NULL,
 CONSTRAINT [PK_CT_Quyen] PRIMARY KEY CLUSTERED 
(
	[ma_NV] ASC,
	[ma_CN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD_BanHang]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD_BanHang](
	[ma_HD] [int] NOT NULL,
	[ma_SP] [int] NOT NULL,
	[gia_SP] [int] NULL,
	[soluong_SP] [int] NULL,
	[tongtien_SP] [int] NULL,
 CONSTRAINT [PK_CTHD_BanHang] PRIMARY KEY CLUSTERED 
(
	[ma_HD] ASC,
	[ma_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[CTHD_DichVu]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[CTHD_DichVu](
	[ma_HDDV] [int] NOT NULL,
	[ma_DV] [int] NOT NULL,
	[gia_DV] [int] NULL,
	[soluong_DV] [int] NULL,
	[tongtien_DV] [int] NULL,
 CONSTRAINT [PK_CTHD_DichVu] PRIMARY KEY CLUSTERED 
(
	[ma_HDDV] ASC,
	[ma_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[ChucNang]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[ChucNang](
	[ma_CN] [int] IDENTITY(5000,1) NOT NULL,
	[ten_CN] [nvarchar](max) NULL,
	[ma_UI] [int] NULL,
 CONSTRAINT [PK_ChucNang] PRIMARY KEY CLUSTERED 
(
	[ma_CN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DanhMuc]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DanhMuc](
	[ma_DM] [int] IDENTITY(4000,1) NOT NULL,
	[ten_DM] [nvarchar](max) NULL,
 CONSTRAINT [PK_DanhMuc] PRIMARY KEY CLUSTERED 
(
	[ma_DM] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[DichVu]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[DichVu](
	[ma_DV] [int] IDENTITY(8000,1) NOT NULL,
	[ten_DV] [nvarchar](max) NULL,
	[mota_DV] [nvarchar](max) NULL,
 CONSTRAINT [PK_DichVu] PRIMARY KEY CLUSTERED 
(
	[ma_DV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gia_DV]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gia_DV](
	[ma_GiaDV] [int] IDENTITY(9000,1) NOT NULL,
	[ma_DV] [int] NULL,
	[gia_DV] [int] NULL,
	[ngay_DBDV] [date] NULL,
	[ngay_KTDV] [date] NULL,
 CONSTRAINT [PK_Gia_DV] PRIMARY KEY CLUSTERED 
(
	[ma_GiaDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Gia_SP]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Gia_SP](
	[ma_GiaSP] [int] IDENTITY(10000,1) NOT NULL,
	[ma_SP] [int] NULL,
	[gia_SP] [int] NULL,
	[ngay_BDSP] [date] NULL,
	[ngay_KTSP] [date] NULL,
 CONSTRAINT [PK_Gia_SP] PRIMARY KEY CLUSTERED 
(
	[ma_GiaSP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Hang_SX]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Hang_SX](
	[ma_Hang] [int] IDENTITY(3000,1) NOT NULL,
	[ten_Hang] [nvarchar](max) NULL,
 CONSTRAINT [PK_Hang_SX] PRIMARY KEY CLUSTERED 
(
	[ma_Hang] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_BanHang]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_BanHang](
	[ma_HD] [int] IDENTITY(12000,1) NOT NULL,
	[ma_KH] [int] NULL,
	[ma_NV] [int] NULL,
	[ngaylap_HD] [date] NULL,
	[isDelete] [bit] NULL,
 CONSTRAINT [PK_HD_BanHang] PRIMARY KEY CLUSTERED 
(
	[ma_HD] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[HD_DichVu]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[HD_DichVu](
	[ma_HDDV] [int] IDENTITY(13000,1) NOT NULL,
	[ma_KH] [int] NULL,
	[ma_NV] [int] NULL,
	[isDelete] [bit] NULL,
 CONSTRAINT [PK_HD_DichVu] PRIMARY KEY CLUSTERED 
(
	[ma_HDDV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[KhachHang]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[KhachHang](
	[ma_KH] [int] IDENTITY(7000,1) NOT NULL,
	[ten_HK] [nvarchar](max) NULL,
	[mail_KH] [varchar](max) NULL,
	[sdt_KH] [char](10) NULL,
 CONSTRAINT [PK_KhachHang] PRIMARY KEY CLUSTERED 
(
	[ma_KH] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Loai_SP]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Loai_SP](
	[ma_Loai] [int] IDENTITY(2000,1) NOT NULL,
	[ten_Loai] [nvarchar](max) NULL,
 CONSTRAINT [PK_Loai_SP] PRIMARY KEY CLUSTERED 
(
	[ma_Loai] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[Nha_CungCap]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[Nha_CungCap](
	[ma_NCC] [int] IDENTITY(1000,1) NOT NULL,
	[ten_NCC] [nvarchar](max) NULL,
 CONSTRAINT [PK_Nha_CungCap] PRIMARY KEY CLUSTERED 
(
	[ma_NCC] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[NhanVien]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[NhanVien](
	[ma_NV] [int] IDENTITY(6000,1) NOT NULL,
	[ten_NV] [nvarchar](max) NULL,
	[mail_NV] [varchar](max) NULL,
	[sdt_NV] [char](10) NULL,
	[mk_dangnhap] [varchar](max) NULL,
 CONSTRAINT [PK_NhanVien] PRIMARY KEY CLUSTERED 
(
	[ma_NV] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
/****** Object:  Table [dbo].[PhieuNhap]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[PhieuNhap](
	[ma_PN] [int] IDENTITY(11000,1) NOT NULL,
	[ma_NCC] [int] NULL,
	[ma_NV] [int] NULL,
	[ngaylap_PN] [date] NULL,
	[isDelete] [bit] NULL,
 CONSTRAINT [PK_PhieuNhap] PRIMARY KEY CLUSTERED 
(
	[ma_PN] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  Table [dbo].[SanPham]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[SanPham](
	[ma_SP] [int] IDENTITY(14000,1) NOT NULL,
	[ma_DM] [int] NULL,
	[ma_Loai] [int] NULL,
	[ma_Hang] [int] NULL,
	[Ten_SP] [nvarchar](max) NULL,
	[soluong_SP] [int] NULL,
 CONSTRAINT [PK_SanPham] PRIMARY KEY CLUSTERED 
(
	[ma_SP] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY] TEXTIMAGE_ON [PRIMARY]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ctpn_pn] FOREIGN KEY([ma_PN])
REFERENCES [dbo].[PhieuNhap] ([ma_PN])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [fk_ctpn_pn]
GO
ALTER TABLE [dbo].[CT_PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_ctpn_sp] FOREIGN KEY([ma_SP])
REFERENCES [dbo].[SanPham] ([ma_SP])
GO
ALTER TABLE [dbo].[CT_PhieuNhap] CHECK CONSTRAINT [fk_ctpn_sp]
GO
ALTER TABLE [dbo].[CT_Quyen]  WITH CHECK ADD  CONSTRAINT [fk_ctq_cn] FOREIGN KEY([ma_CN])
REFERENCES [dbo].[ChucNang] ([ma_CN])
GO
ALTER TABLE [dbo].[CT_Quyen] CHECK CONSTRAINT [fk_ctq_cn]
GO
ALTER TABLE [dbo].[CT_Quyen]  WITH CHECK ADD  CONSTRAINT [fk_ctq_nv] FOREIGN KEY([ma_NV])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[CT_Quyen] CHECK CONSTRAINT [fk_ctq_nv]
GO
ALTER TABLE [dbo].[CTHD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_cthd_sp] FOREIGN KEY([ma_SP])
REFERENCES [dbo].[SanPham] ([ma_SP])
GO
ALTER TABLE [dbo].[CTHD_BanHang] CHECK CONSTRAINT [fk_cthd_sp]
GO
ALTER TABLE [dbo].[CTHD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_cthdbh_hdbh] FOREIGN KEY([ma_HD])
REFERENCES [dbo].[HD_BanHang] ([ma_HD])
GO
ALTER TABLE [dbo].[CTHD_BanHang] CHECK CONSTRAINT [fk_cthdbh_hdbh]
GO
ALTER TABLE [dbo].[CTHD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_cthddv_dv] FOREIGN KEY([ma_DV])
REFERENCES [dbo].[DichVu] ([ma_DV])
GO
ALTER TABLE [dbo].[CTHD_DichVu] CHECK CONSTRAINT [fk_cthddv_dv]
GO
ALTER TABLE [dbo].[CTHD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_cthddv_hddv] FOREIGN KEY([ma_HDDV])
REFERENCES [dbo].[HD_DichVu] ([ma_HDDV])
GO
ALTER TABLE [dbo].[CTHD_DichVu] CHECK CONSTRAINT [fk_cthddv_hddv]
GO
ALTER TABLE [dbo].[Gia_DV]  WITH CHECK ADD  CONSTRAINT [fk_gdv_dv] FOREIGN KEY([ma_DV])
REFERENCES [dbo].[DichVu] ([ma_DV])
GO
ALTER TABLE [dbo].[Gia_DV] CHECK CONSTRAINT [fk_gdv_dv]
GO
ALTER TABLE [dbo].[Gia_SP]  WITH CHECK ADD  CONSTRAINT [fk_gsp_sp] FOREIGN KEY([ma_SP])
REFERENCES [dbo].[SanPham] ([ma_SP])
GO
ALTER TABLE [dbo].[Gia_SP] CHECK CONSTRAINT [fk_gsp_sp]
GO
ALTER TABLE [dbo].[HD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_hdbh_bh] FOREIGN KEY([ma_KH])
REFERENCES [dbo].[KhachHang] ([ma_KH])
GO
ALTER TABLE [dbo].[HD_BanHang] CHECK CONSTRAINT [fk_hdbh_bh]
GO
ALTER TABLE [dbo].[HD_BanHang]  WITH CHECK ADD  CONSTRAINT [fk_hdbh_kh] FOREIGN KEY([ma_NV])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[HD_BanHang] CHECK CONSTRAINT [fk_hdbh_kh]
GO
ALTER TABLE [dbo].[HD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_hddv_kh] FOREIGN KEY([ma_KH])
REFERENCES [dbo].[KhachHang] ([ma_KH])
GO
ALTER TABLE [dbo].[HD_DichVu] CHECK CONSTRAINT [fk_hddv_kh]
GO
ALTER TABLE [dbo].[HD_DichVu]  WITH CHECK ADD  CONSTRAINT [fk_hddv_nv] FOREIGN KEY([ma_NV])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[HD_DichVu] CHECK CONSTRAINT [fk_hddv_nv]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_pn_ncc] FOREIGN KEY([ma_NCC])
REFERENCES [dbo].[Nha_CungCap] ([ma_NCC])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [fk_pn_ncc]
GO
ALTER TABLE [dbo].[PhieuNhap]  WITH CHECK ADD  CONSTRAINT [fk_pn_nv] FOREIGN KEY([ma_NV])
REFERENCES [dbo].[NhanVien] ([ma_NV])
GO
ALTER TABLE [dbo].[PhieuNhap] CHECK CONSTRAINT [fk_pn_nv]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_sp_dm] FOREIGN KEY([ma_DM])
REFERENCES [dbo].[DanhMuc] ([ma_DM])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_sp_dm]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_sp_hang] FOREIGN KEY([ma_Hang])
REFERENCES [dbo].[Hang_SX] ([ma_Hang])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_sp_hang]
GO
ALTER TABLE [dbo].[SanPham]  WITH CHECK ADD  CONSTRAINT [fk_sp_loai] FOREIGN KEY([ma_Loai])
REFERENCES [dbo].[Loai_SP] ([ma_Loai])
GO
ALTER TABLE [dbo].[SanPham] CHECK CONSTRAINT [fk_sp_loai]
GO
/****** Object:  StoredProcedure [dbo].[CTHD]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[CTHD]
as
begin
	select hd.ma_HD,nv.ten_NV,kh.ten_HK, dm.ten_DM, ct.soluong_SP , ct.gia_SP, ct.tongtien_SP 
	from HD_BanHang hd, CTHD_BanHang ct, SanPham sp, DanhMuc dm, NhanVien nv, KhachHang kh
	where ct.ma_HD = hd.ma_HD and sp.ma_SP = ct.ma_SP and sp.ma_DM = dm.ma_DM and hd.ma_NV = nv.ma_NV and hd.ma_KH = kh.ma_KH
end
GO
/****** Object:  StoredProcedure [dbo].[DeleteLoaiSP]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[DeleteLoaiSP]
(@maloai int)
as
begin
	delete from Loai_SP where ma_Loai = @maloai
end
GO
/****** Object:  StoredProcedure [dbo].[get_giasp_Price]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[get_giasp_Price]
(@giatu int, @giaden int)
as
begin
select gia.ma_GiaSP, sp.ten_sp, gia.gia_SP, gia.ngay_BDSP 
	from Gia_SP gia, SanPham sp where gia.ma_SP = sp.ma_SP
	AND @giatu <= gia.gia_SP and gia.gia_SP <= @giaden
end
GO
/****** Object:  StoredProcedure [dbo].[get_giasp_Price_lonhon]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[get_giasp_Price_lonhon]
(@giatu int)
as
begin
select gia.ma_GiaSP, sp.ten_sp, gia.gia_SP, gia.ngay_BDSP 
	from Gia_SP gia, SanPham sp where gia.ma_SP = sp.ma_SP
	AND @giatu <= gia.gia_SP
end
GO
/****** Object:  StoredProcedure [dbo].[Get_GiaSPList]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Get_GiaSPList]
as
begin
	select gia.ma_GiaSP, sp.ten_sp, gia.gia_SP, gia.ngay_BDSP 
	from Gia_SP gia, SanPham sp where gia.ma_SP = sp.ma_SP
end
GO
/****** Object:  StoredProcedure [dbo].[get_Hang_Loai]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[get_Hang_Loai]
(@tenhang nvarchar(max), @tenloai nvarchar(max))
as
begin
	select sp.ma_SP, dm.ten_DM, sp.Ten_SP, l.ten_Loai, h.ten_Hang , sp.soluong_SP from SanPham sp, DanhMuc dm, Loai_SP l, Hang_SX h
	where sp.ma_DM = dm.ma_DM and sp.ma_Hang = h.ma_Hang and sp.ma_Loai = l.ma_Loai
	AND h.ten_Hang = @tenhang and l.ten_Loai = @tenloai
end
GO
/****** Object:  StoredProcedure [dbo].[Get_SanPhamList_Result]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[Get_SanPhamList_Result]
as
begin
	select sp.ma_SP, sp.ten_SP, l.ten_Loai, h.ten_Hang , sp.soluong_SP from SanPham sp, DanhMuc dm, Loai_SP l, Hang_SX h
	where sp.ma_DM = dm.ma_DM and sp.ma_Hang = h.ma_Hang and sp.ma_Loai = l.ma_Loai
end
GO
/****** Object:  StoredProcedure [dbo].[getDanhMucList]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getDanhMucList]
as
begin
	select * from DanhMuc
end
GO
/****** Object:  StoredProcedure [dbo].[getLoaiSPList]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[getLoaiSPList]
as
begin
	select * from Loai_SP
end
GO
/****** Object:  StoredProcedure [dbo].[getMaSP]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[getMaSP]
(@masp int)
as
begin
select * from SanPham where ma_SP = @masp
end
GO
/****** Object:  StoredProcedure [dbo].[hd]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[hd]
as
select hd.ma_HD, nv.ten_NV, kh.ten_HK, hd.ngaylap_HD 
from HD_BanHang hd, NhanVien nv, KhachHang kh
where nv.ma_NV = hd.ma_NV and hd.ma_KH = kh.ma_KH 
GO
/****** Object:  StoredProcedure [dbo].[hd_phieunhappppp]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[hd_phieunhappppp]
as
begin
	select pn.ma_PN, nv.ten_NV, ncc.ten_NCC, pn.ngaylap_PN 
	from PhieuNhap pn,NhanVien nv, Nha_CungCap ncc, CT_PhieuNhap ct
	where pn.ma_NV = nv.ma_NV and pn.ma_NCC = ncc.ma_NCC and pn.ma_PN = ct.ma_PN
end
GO
/****** Object:  StoredProcedure [dbo].[inHd]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[inHd]
(@mahd int)
as
select hd.ma_HD, kh.ten_HK,kh.sdt_KH,kh.mail_KH, nv.ten_NV, hd.ngaylap_HD, sp.ma_SP, sp.Ten_SP, 
ct.gia_SP, ct.soluong_SP, ct.tongtien_SP
from HD_BanHang hd, NhanVien nv, KhachHang kh, CTHD_BanHang ct, SanPham sp
where hd.ma_NV = nv.ma_NV and hd.ma_KH = hd.ma_KH and hd.ma_HD = ct.ma_HD and ct.ma_SP = sp.ma_SP
and hd.ma_HD = @mahd
GO
/****** Object:  StoredProcedure [dbo].[inPN]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[inPN]
(@mapn int)
as
begin
	select pn.ma_PN, nv.ten_NV, pn.ngaylap_PN, sp.ma_SP, sp.Ten_SP, ncc.ten_NCC, ct.gianhap_SP, 
	ct.soluong_SP, ct.tongtien_SP
	from PhieuNhap pn,NhanVien nv, Nha_CungCap ncc, CT_PhieuNhap ct, SanPham sp
	where pn.ma_NV = nv.ma_NV and pn.ma_NCC = ncc.ma_NCC and pn.ma_PN = ct.ma_PN
	and ct.ma_SP = sp.ma_SP and pn.ma_PN = 11000
end
GO
/****** Object:  StoredProcedure [dbo].[INSERT_CTPNHAPXE]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create PROC [dbo].[INSERT_CTPNHAPXE](
@MAPN int,
@MASP int,
@DONGIANHAPXE int,
@SLNHAPXE INT,
@THANHTIEN int
)
AS 
INSERT INTO CT_PhieuNhap VALUES (@MAPN, @MASP, @DONGIANHAPXE, @SLNHAPXE, @THANHTIEN) 
UPDATE SANPHAM SET soluong_SP= soluong_SP +@SLNHAPXE where ma_SP=@MASP
GO
/****** Object:  StoredProcedure [dbo].[INSERT_CTHD]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[INSERT_CTHD]
(@mahd int,@masp int, @giasp int, @soluong int, @tongtien int)
as
begin
	INSERT INTO CTHD_BanHang VALUES (@mahd, @masp, @giasp, @soluong, @tongtien)
end
GO
/****** Object:  StoredProcedure [dbo].[Insert_HoaDon]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[Insert_HoaDon]
( @makh int, @manv int, @ngaylap date, @isdelete bit)
as
begin
	INSERT INTO HD_BanHang VALUES (@makh, @manv, @ngaylap, @isdelete)
end
GO
/****** Object:  StoredProcedure [dbo].[INSERT_PNHAP]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROC [dbo].[INSERT_PNHAP](
@MANHACUNGCAP int,
@MANHANVIEN int,
@NGAYNHAP date, @isdelete bit
)
AS
INSERT INTO PhieuNhap VALUES(@MANHACUNGCAP, @MANHANVIEN, @NGAYNHAP, @isdelete)
GO
/****** Object:  StoredProcedure [dbo].[search_hdBan]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[search_hdBan]
(@search nvarchar(max))
as
select hd.ma_HD, nv.ten_NV, kh.ten_HK, hd.ngaylap_HD 
from HD_BanHang hd, NhanVien nv, KhachHang kh
where nv.ma_NV = hd.ma_NV and hd.ma_KH = kh.ma_KH
and CONCAT(hd.ma_HD, nv.ten_NV, kh.ten_HK, hd.ngaylap_HD) like '%'+@search+'%'

GO
/****** Object:  StoredProcedure [dbo].[search_hdpn]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[search_hdpn]
(@search nvarchar(max))
as
begin
	select pn.ma_PN, nv.ten_NV, ncc.ten_NCC, pn.ngaylap_PN 
	from PhieuNhap pn,NhanVien nv, Nha_CungCap ncc, CT_PhieuNhap ct
	where pn.ma_NV = nv.ma_NV and pn.ma_NCC = ncc.ma_NCC and pn.ma_PN = ct.ma_PN
	and CONCAT(pn.ma_PN, nv.ten_NV, ncc.ten_NCC, pn.ngaylap_PN) like '%'+@search+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[search_SP]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[search_SP]
(@search nvarchar(max))
as
begin
	select sp.ma_SP, sp.ten_SP, l.ten_Loai, h.ten_Hang , sp.soluong_SP 
	from SanPham sp, DanhMuc dm, Loai_SP l, Hang_SX h
	where sp.ma_DM = dm.ma_DM and sp.ma_Hang = h.ma_Hang and sp.ma_Loai = l.ma_Loai and
	CONCAT(sp.ma_SP, sp.ten_SP, l.ten_Loai, h.ten_Hang , sp.soluong_SP) like '%'+@search+'%'
end
GO
/****** Object:  StoredProcedure [dbo].[searh_giasp]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[searh_giasp]
(@search nvarchar(max))
as
select gia.ma_GiaSP, sp.ten_sp, gia.gia_SP, gia.ngay_BDSP 
	from Gia_SP gia, SanPham sp where sp.ma_SP = gia.ma_SP
	and CONCAT(gia.ma_GiaSP, sp.ten_sp, gia.gia_SP, gia.ngay_BDSP) like '%'+@search+'%'
GO
/****** Object:  StoredProcedure [dbo].[select_giasp]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[select_giasp]
as
begin
	select * from SanPham sp , Gia_SP where sp.ma_SP = Gia_SP.ma_SP
end
GO
/****** Object:  StoredProcedure [dbo].[selectAll_CTHD]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectAll_CTHD] (@maHD int, @masp int)
as
select * from CTHD_BanHang where ma_HD = @maHD and ma_SP = @masp
GO
/****** Object:  StoredProcedure [dbo].[selectCTPN]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[selectCTPN] (@mapn int, @masp int)
as
select * from CT_PhieuNhap where ma_PN = @mapn and ma_SP = @masp
GO
/****** Object:  StoredProcedure [dbo].[selectCTPNxe]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectCTPNxe] (@ma int)
as
select CTPN.ma_SP, SP.Ten_SP, CTPN.soluong_SP, CTPN.gianhap_SP, CTPN.tongtien_SP   
from CT_PhieuNhap CTPN, SANPHAM SP where ma_PN = @ma and CTPN.ma_SP = SP.ma_SP
GO
/****** Object:  StoredProcedure [dbo].[selectCTHD]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[selectCTHD]
(@mahd int)
as
begin
	select sp.ma_SP, sp.Ten_SP, ct.gia_SP, ct.soluong_SP, ct.tongtien_SP from CTHD_BanHang ct, SanPham sp where ct.ma_SP = sp.ma_SP and ma_HD = @mahd
end
GO
/****** Object:  StoredProcedure [dbo].[selectHoaDon]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[selectHoaDon]
(@mahd int)
as
begin
	select * from HD_BanHang where ma_HD = @mahd
end
GO
/****** Object:  StoredProcedure [dbo].[selectPN]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

CREATE proc [dbo].[selectPN]
(@mapn int)
as
begin
	select * from PhieuNhap where ma_PN = @mapn
end
GO
/****** Object:  StoredProcedure [dbo].[selectSP]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[selectSP]
(@masp int)
as
begin
	select * from SanPham where ma_SP = @masp
	end
GO
/****** Object:  StoredProcedure [dbo].[tongdoanhthu]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
create proc [dbo].[tongdoanhthu]
as
begin
SELECT sum(ct.tongtien_sp) FROM dbo.CTHD_BanHang CT, dbo.HD_BanHang HD
	WHERE CT.ma_HD = HD.ma_HD 
end
GO
/****** Object:  StoredProcedure [dbo].[ThongKe_SPMuaNhieu]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongKe_SPMuaNhieu]
	@month_Value int,
	@year_Value int
AS
BEGIN
	SELECT TOP 5 SP.ma_SP,sum(ct.soluong_SP) AS 'SL', SP.Ten_SP FROM dbo.CTHD_BanHang CT, dbo.HD_BanHang HD, dbo.SanPham SP, dbo.DanhMuc DM
	WHERE CT.ma_HD = HD.ma_HD and SP.ma_SP = CT.ma_SP
			and DM.ma_DM = SP.ma_DM
			and MONTH(HD.ngaylap_HD) = @month_Value and YEAR(HD.ngaylap_HD) = @year_Value
	GROUP BY SP.ma_SP, SP.Ten_SP
	ORDER BY SL DESC
END;
GO
/****** Object:  StoredProcedure [dbo].[ThongKe_Thang_Nam]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE PROCEDURE [dbo].[ThongKe_Thang_Nam]
	@month_Value int,
	@year_Value int
AS
BEGIN
	SELECT sum(ct.tongtien_sp) FROM dbo.CTHD_BanHang CT, dbo.HD_BanHang HD
	WHERE CT.ma_HD = HD.ma_HD 
		AND MONTH(HD.ngaylap_HD) = @month_Value
		AND YEAR(HD.ngaylap_HD) = @year_Value
END;
GO
/****** Object:  StoredProcedure [dbo].[updateSL_CTHD]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[updateSL_CTHD] (@ma int, @masp int, @gia int, @soluong int, @THANHTIEN int)
as
update CTHD_BanHang set gia_SP = @gia, soluong_SP = @soluong, tongtien_SP = @THANHTIEN where ma_HD = @ma and ma_SP = @masp
GO
/****** Object:  StoredProcedure [dbo].[updateSLT]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO

create proc [dbo].[updateSLT] (@masp int, @soluong int)
as 
update SANPHAM set soluong_SP = @soluong where ma_SP =@masp
GO
/****** Object:  StoredProcedure [dbo].[updateSLTCTPNX]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[updateSLTCTPNX] (@ma int, @masp int,@gia int, @soluong int, @THANHTIEN int)
as
update CT_PhieuNhap set gianhap_SP = @gia, soluong_SP = @soluong, tongtien_SP = @THANHTIEN 
where ma_PN = @ma and ma_SP = @masp
GO
/****** Object:  StoredProcedure [dbo].[xuatdata]    Script Date: 6/19/2021 4:23:14 PM ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE proc [dbo].[xuatdata]
as
select hd.ma_HD, kh.ten_HK,kh.sdt_KH,kh.mail_KH, nv.ten_NV, hd.ngaylap_HD, sp.ma_SP, sp.Ten_SP, 
ct.gia_SP, ct.soluong_SP, ct.tongtien_SP
from HD_BanHang hd, NhanVien nv, KhachHang kh, CTHD_BanHang ct, SanPham sp
where hd.ma_HD = ct.ma_HD and ct.ma_SP = sp.ma_SP and nv.ma_NV = hd.ma_NV and kh.ma_KH = hd.ma_KH
GO
