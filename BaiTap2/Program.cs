using System;
namespace BaiTap2;
class Program
{
    static void TestTimTuanTu()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        int k, x, kq;
        try
        {
            Console.Write("Nhập kích thước mảng: ");
            k = int.Parse(Console.ReadLine());
            IntArray obj = new IntArray(k);
            Console.WriteLine("Các phần tử của mảng:");
            obj.Xuat();
            Console.Write("\nGiá trị x cần tim = ");
            int.TryParse(Console.ReadLine(), out x);
            kq = obj.TimTuanTu(x);
            if (kq == -1)
                Console.WriteLine($"Không tìm thấy {x}!");
            else
                Console.WriteLine($"Có {x} tại vị trí {kq}");
        } catch(Exception e)
        {
            Console.WriteLine("Lỗi: {0}", e.Message);
        }
    }
    public static void TestTimNhiPhan()
    {
        try
        {
            IntArray obj = new IntArray();
            obj.PhatSinhTang();
            obj.Xuat();
            Console.Write("\nGiá trị x cần tìm = ");
            int x = int.Parse(Console.ReadLine());
            int kq = obj.TimNhiPhan(x);
            if (kq == -1)
                Console.WriteLine($"Không tồn tại {x} trong mảng!");
            else
                Console.WriteLine($"Có {x} tại vị trí {kq}");
        }
        catch (Exception e)
        {
            Console.WriteLine("Lỗi: {0}", e.Message);
        }

    }
    static void Main(string[] args)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        Console.WriteLine("Tìm kiếm nhị phân");
        TestTimTuanTu();
        Console.WriteLine("-------------------------------------------------");
        Console.WriteLine("Tìm kiếm tuần tự");
        TestTimNhiPhan();
    }
}