using System;
namespace BaiTap2;
class Program
{
    static void TestBubbleSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        objTam.BubbleSort();
        Console.WriteLine("\n>>Bubble Sort:");
        objTam.Xuat();
    }
    static void TestInterchangeSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        objTam.InterchangeSort();
        Console.WriteLine("\n>>Interchange Sort:");
        objTam.Xuat();
    }
    static void TestInsertionSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        objTam.InsertionSort();
        Console.WriteLine("\n>>Insertion Sort:");
        objTam.Xuat();
    }
    static void TestQuickSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        objTam.QuickSort(0, objTam.Size - 1);
        Console.WriteLine("\n>>Quick Sort:");
        objTam.Xuat();
    }
    static void TestShellSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        objTam.ShellSort();
        Console.WriteLine("\n>>Sell Sort:");
        objTam.Xuat();
    }
    static void TestSnakeSort(IntArray obj)
    {
        //Copy ojb sang objTam để sắp xếp
        IntArray objTam = new IntArray(obj);
        Console.WriteLine("\n>>Mang ban dau:");
        objTam.Xuat();
        objTam.SnakerSort();
        Console.WriteLine("\n>>Snake Sort:");
        objTam.Xuat();
    }
    //Test những phương pháp sắp xếp khác
    static void Main(string[] args)
    {
        IntArray obj = new IntArray(10);
        TestBubbleSort(obj);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        TestInterchangeSort(obj);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        TestInsertionSort(obj);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        TestQuickSort(obj);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        TestShellSort(obj);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        TestSnakeSort(obj);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
    }
}