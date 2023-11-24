using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nhom2_TruongAnhVu_PhamHoangQuan_KTL1
{
    internal class ChiTietBH
    {
        string maSP;
        string tenSP;
        double gia;
        int soLuong;
        static double tyleThue = 0.1;
        string MaSP 
        {
            get => maSP;
            set
            {
                if (value.Length ==6 && value.StartsWith("SP"))
                {
                    maSP = value;
                }
                else
                {
                    maSP = "SP0000";
                }
            }
        }
        double Gia
        {
            get => gia;
            set
            {
                if (value > 0)
                {
                    gia = value;
                }
                else
                {
                    throw new Exception("Gia san pham khong hop le");
                }
            }
        }
        int SoLuong
        {
            get => soLuong;
            set
            {
                if (value > 0)
                {
                    soLuong = value;
                }
                else
                {
                    throw new Exception("So luong san pham khong hop le");
                }
            }
        }
        public ChiTietBH()
        {
            MaSP = "SP0010";
            tenSP = "May tinh Dell";
            Gia = 15000;
            SoLuong = 2;
        }
        public ChiTietBH(ChiTietBH ct)
        {
            MaSP = ct.MaSP;
            tenSP = ct.tenSP;
            Gia = ct.Gia;
            SoLuong = ct.SoLuong;
        }
        public ChiTietBH(string maSP, string tenSP, double gia, int soLuong)
        {
            MaSP = maSP;
            this.tenSP = tenSP;
            Gia = gia;
            SoLuong = soLuong;
        }
        public double ThanhTien()
        {
            return soLuong * gia * (1 + ChiTietBH.tyleThue);
        }
        public void Xuat()
        {
            Console.WriteLine("Ma san pham la {0}",maSP);
            Console.WriteLine("Ten san pham la {0}", tenSP);
            Console.WriteLine("Gia san pham la {0}", gia);
            Console.WriteLine("So luong san pham la {0}", soLuong);
            Console.WriteLine("Thanh tien la {0}", ThanhTien());
        }

    }
}
