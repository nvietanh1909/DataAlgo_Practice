using System;
using System.Collections.Generic;
using System.Drawing;
using System.Runtime.Intrinsics.Arm;

namespace IntQueue;
class Program
{
    //Array Queue
    public static void InputArrayQueue(ref ArrayQueue arrayQueue)
    {
        int n, x;
        Console.Write("So luong phan tu queue = ");
        int.TryParse(Console.ReadLine(), out n);
        arrayQueue = new ArrayQueue(n);
        for (int i = 1; i <= n; i++)
        {
            Console.Write(">>> Gia tri queue = ");
            int.TryParse(Console.ReadLine(), out x);
            if (arrayQueue.EnQueue(x) == false)
            {
                Console.WriteLine("*********** Queue day, ket thuc nhap!!!");
                break;
            }
            else
                Console.WriteLine("\t--> Da them {0} vao queue", x);
        }
    }
    public static void OutputArrayQueue(ref ArrayQueue arrayQueue)
    {
        int x, i = 0;
        Console.WriteLine("\n+ Test phuong thuc GetFront()");
        if (arrayQueue.GetFront(out x) == false)
        {
            Console.WriteLine("************ Queue rong, ket thuc");
            return;
        }
        else
            Console.WriteLine("<<< Gia tri front queue = " + x);
        Console.WriteLine("\n+ Test phuong thuc GetRear()");
        if (arrayQueue.GetRear(out x) == false)
        {
            Console.WriteLine("************ Queue rong, ket thuc");
            return;
        }
        else
            Console.WriteLine("<<< Gia tri rear queue = " + x);
        Console.WriteLine("\n+ Test phuong thuc DeQueue()");
        Console.WriteLine("Cac gia tri trong queue:");
        while (arrayQueue.DeQueue(out x) == true)
        {
            Console.WriteLine("<<< Gia tri thu {0} = {1}", i, x);
            i++;
        }
    }
    public static void TestArrayQueue()
    {
        ArrayQueue arrayQueue = new ArrayQueue();
        InputArrayQueue(ref arrayQueue);
        OutputArrayQueue(ref arrayQueue);
    }
    //List Queue
    public static void InputListQueue(ref ListQueue listQueue)
    {
        do
        {
            Console.Write(">>> Nhap gia tri queue = ");
            int.TryParse(Console.ReadLine(), out int x);
            if (x == null || x == 0) return;
            if (listQueue.EnQueue(x) == false)
            {
                Console.WriteLine("*********** Queue rong, ket thuc nhap!!!");
                break;
            }
            else
                Console.WriteLine("\t--> Da them {0} vao queue", x);
        } while (true);
    }
    public static void OutputListQueue(ref ListQueue listQueue)
    {
        Console.WriteLine("\n+ Test phuong thuc GetFront()");
        if(!listQueue.GetFront(out int top))
        {
            Console.WriteLine("************ Queue rong, ket thuc");
        }
        var i = 0;
        Console.WriteLine("Front: " + top);
        Console.WriteLine("\n+ Test phuong thuc GetRear()");
        listQueue.GetRear(out int bottom);
        Console.WriteLine("Rear: " + bottom);
        while (listQueue.DeQueue(out int x))
        {
            Console.WriteLine("<<< Gia tri thu {0} = {1}", i, x);
            i++;
        }
    }
    public static void TestListQueue()
    {
        ListQueue listQueue = new ListQueue();
        InputListQueue(ref listQueue);
        OutputListQueue(ref listQueue);
    }
    static void Main()
    {
        Console.WriteLine("<--------------------ArrayQueue-------------------->");
        TestArrayQueue();
        Console.WriteLine("\n<--------------------ListQueue-------------------->");
        TestListQueue();
    }
}