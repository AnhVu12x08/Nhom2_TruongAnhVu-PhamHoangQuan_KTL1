using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Nhom2_TruongAnhVu_PhamHoangQuan_KTL1
{
    internal class HoaDon
    {
        List<ChiTietBH> dsChiTiet;
        string maHD;
        string tenKH;
        public HoaDon()
        {
            dsChiTiet = new List<ChiTietBH>();
            maHD = "HD0000";
            tenKH = "Chua xac dinh";
        }
        public HoaDon(string maHD, string tenKH)
        {
            dsChiTiet = new List<ChiTietBH>();
            this.maHD = maHD;
            this.tenKH = tenKH;
        }
        public double TongTien()
        {
            double tong = 0;
            foreach (ChiTietBH ct in dsChiTiet)
            {
                tong += ct.ThanhTien();
            }
            return tong;
        }
        public void DocXML(string filepath) 
        {
            XmlDocument read = new XmlDocument();
            read.Load(filepath);
            XmlNodeList list = read.SelectNodes("/hoadon/mahd/ctbh");
        }
        
        public void Xuat()
        {
            Console.WriteLine("Ma hoa don: " + maHD);
            Console.WriteLine("Ten khach hang: " + tenKH);
            Console.WriteLine("Danh sach san pham: ");
            foreach (ChiTietBH ct in dsChiTiet)
            {
                ct.Xuat();
            }
        }

    }
}
