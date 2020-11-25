select *
from HoaDon as h,ChiTietHoaDon as ch,SanPham as sp,KHACHHANG as kh,NHANVIEN as nv
where h.IDHD = ch.IDHD and ch.IDSP=sp.IDSP and h.IDKH=kh.IDKH and h.IDNV=nv.IDNV