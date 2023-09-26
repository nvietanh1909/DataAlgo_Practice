using System;
namespace BaiTap1;
class Program
{
    static void TestMangSinhVien()
    {
        MangSinhVien dssv = new MangSinhVien();
        dssv.Nhap();
        Console.WriteLine("Danh sach sinh vien:");
        dssv.Xuat();
    }
    static void Main(string[] args)
    {
        TestMangSinhVien();
    }
}