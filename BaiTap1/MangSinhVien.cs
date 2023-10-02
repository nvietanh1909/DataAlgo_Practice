using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace BaiTap1
{
    internal class MangSinhVien
    {
        //Field
        private SinhVien[] a;
        //Properties
        public SinhVien this[int index]
        {
            get => a[index];
            set => a[index] = value;
        }
        public SinhVien[] A { get => a; set => a = value; }

        //Constructor
        public MangSinhVien() => a = new SinhVien[0];
        public MangSinhVien(int n)
        {
            a = new SinhVien[n];
        }
        public MangSinhVien(MangSinhVien obj)
        {
            a = new SinhVien[obj.a.Length];
            for (int i = 0; i < a.Length; i++)
            {
                this.a[i] = new SinhVien(obj.a[i]);
            }
        }
        public bool TonTai(string msx, int vt)
        {
            for (int i = 0; i < vt; i++)
            {
                if (a[i].MaSo.CompareTo(msx) == 0)
                    return true;
            }
            return false;
        }
        //Method
        
        public void Nhap()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            Console.Write("Nhập số lượng sinh viên: ");
            A = new SinhVien[int.Parse(Console.ReadLine())];
            for(var i = 0; i < a.Length; i++)
            {
                a[i] = new SinhVien();
                Console.WriteLine($"Sinh viên: {i + 1}");
                a[i].Nhap();
            }
        }
        public void Xuat()
        {
            foreach(var item in a)
            {
                if(item != null)
                {
                    item.Xuat();
                }
            }
        }
        public void InsertionSort()
        {
            for (var i = 1; i < arr.Length; i++)
            {
                var x = arr[i];
                var pos = i - 1;
                while (pos >= 0 && arr[pos] > x)
                {
                    arr[pos + 1] = arr[pos];
                    pos = pos - 1;
                }
                arr[pos + 1] = x;
            }
        }
    }
}
