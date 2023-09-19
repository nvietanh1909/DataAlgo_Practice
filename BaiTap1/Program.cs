using System;
namespace BaiTap1;
class Program
{
    static void TestMangSinhVien()
    {
        SinhVien svB = new SinhVien("18DH001","Lam Thanh Ngoc","CNPM", 2000, 7.6F);
        SinhVien svC = new SinhVien(svB);
        svC.HoTen = "Nguyen Van A";
        svC.DiemTB = 10;
        svB.Xuat();
        svC.Xuat();
    }
    static void Main(string[] args)
    {
        TestMangSinhVien();
    }
}