using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap
{
    internal class MyIntArray
    {
        private int[] arr;
        //Constructor
        public MyIntArray() { arr = new int[1]; arr[0] = 0; }
        public MyIntArray(int k)
        {
            var rd = new Random();
            arr = new int[k];
            for (var i = 0; i < arr.Length; i++)
            {
                arr[i] = rd.Next(1, 101);
            }
        }
        //Method
        public void PhatSinhTang()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            var rd = new Random();
            int n;
            Console.Write("Nhập số lượng phần tử: ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            arr[0] = rd.Next(1, 5);
            for (var i = 1; i < n; i++)
            {
                arr[i] = arr[i - 1] + rd.Next(1, 5);
            }
        }
        public void Nhap()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int n;
            Console.Write("Nhập kích thước mảng: ");
            n = int.Parse(Console.ReadLine());
            arr = new int[n];
            for (var i = 0; i < arr.Length; i++)
            {
                Console.Write($"a[{i}] = ");
                arr[i] = int.Parse(Console.ReadLine());
            }
        }
        public void Xuat()
        {
            foreach (var item in arr)
            {
                Console.Write(item + " ");
            }
        }
        
    }
}
