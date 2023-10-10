using System;
using System.Threading;
using System.Collections;
using static System.Collections.Specialized.BitVector32;

namespace DSLKDon
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            try
            {
                MyList list = new MyList();
                MyList list2 = new MyList();
                MyList list3 = new MyList();
                Console.WriteLine("List 1:");
                list.Input();
                list.ShowList();
                //Console.WriteLine("List 2:");
                //list2.Input();
                //list2.ShowList();
                //Console.WriteLine("List 3:");
                //list3.Input();
                //list3.ShowList();
                //Console.WriteLine("Xóa phần tử thứ 3 của list 1");
                //list.RemoveAt(3);
                //list.ShowList();
                //IntNode x = list.SearchX(2);
                //Console.WriteLine("Xóa node có giá trị x(2) trong list 1");
                //list.RemoveX(x);
                //list.ShowList();
                //Console.WriteLine("Chèn x vào vị trí thứ 2");
                //list.InsertAt(999, 2);
                //list.ShowList();
                //Console.WriteLine("Chèn 888 sau min");
                //IntNode min = list.GetMin();
                //IntNode x1 = new IntNode(888);
                //list.InsertXAfterMin(x1, min);
                //list.ShowList();
                //Console.WriteLine("Chèn 111 sau node 7");
                //IntNode x2 = new IntNode(111);
                //IntNode t = list.SearchX(7);
                //list.InsertXAfterY(x2, t);
                //list.ShowList();
                //Console.WriteLine("Chèn 123 trước max");
                //IntNode max = list.GetMax();
                //IntNode x3 = new IntNode(123);
                //list.InsertXBeforeMax(x3, max);
                //list.ShowList();
                //Console.WriteLine("Chèn 16 trước 8");
                //IntNode x4 = new IntNode(16);
                //IntNode t1 = list.SearchX(8);
                //list.InsertXBeforeY(x4, t1);
                //list.ShowList();
                Console.WriteLine("Trả về danh sách khi dịch trái");
                list.ShiftLeft();
                list.ShowList();
                Console.WriteLine("Trả về danh sách sau khi dịch phải xoay vòng");
                list.RShiftRight();
                list.ShowList();
                Console.WriteLine("Sắp xếp tăng dần");
                list.SelectionSort();
                list.ShowList();
                //list2.SelectionSort();
                //list2.ShowList();
                //list3.MergeList(list, list2);
                //Console.WriteLine("Tạo danh sách list3 từ list1 và list2 đã sắp xếp sao cho list3 k cần sắp xếp lại");
                //list3.ShowList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
