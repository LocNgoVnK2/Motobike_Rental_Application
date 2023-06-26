using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class BillShowDTO
    {
            public int MaHoaDon { get; set; }
            public DateTime NgayLap { get; set; }
            public string TenKhachHang { get; set; }
            public DateTime NgayThue { get; set; }
            public DateTime NgayTra { get; set; }
            public string TenXe { get; set; }
            public int DonGia { get; set; }
            public string NVLapPhieu { get; set; }
            public int TongTien { get; set; }

            public BillShowDTO(int maHoaDon, DateTime ngayLap, string tenKhachHang,
                               DateTime ngayThue, DateTime ngayTra, string tenXe,
                               int donGia, string nvLapPhieu, int tongTien)
            {
                MaHoaDon = maHoaDon;
                NgayLap = ngayLap;
                TenKhachHang = tenKhachHang;
                NgayThue = ngayThue;
                NgayTra = ngayTra;
                TenXe = tenXe;
                DonGia = donGia;
                NVLapPhieu = nvLapPhieu;
                TongTien = tongTien;
            }
        }

    
}
