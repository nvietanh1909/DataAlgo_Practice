using System;
using System.Runtime.Intrinsics.Arm;

namespace IntStack;
class Program
{
    static void Input(ArrayStack arrStack)
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        do
        {
            Console.Write("Nhập giá trị cho arrStack: ");
            int.TryParse(Console.ReadLine(), out int x);
            if (arrStack.Push(x) == false)
            {
                Console.WriteLine("arrStack đã đầy!");
                return;
            }
        } while (true);
    }
    static void Output(ArrayStack arrStack)
    {
        while (arrStack.Pop(out int x) == true)
        {
            Console.Write(x + " ");
        }
    }
    static void TestArrayStack()
    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        ArrayStack arrStack = new ArrayStack(5);
        Input(arrStack);
        Console.WriteLine("Các giá trị trong stack:");
        Output(arrStack);
    }
    static void Input(ListStack arrStack)

    {
        Console.OutputEncoding = System.Text.Encoding.Unicode;
        do
        {
            Console.Write("Nhập giá trị cho arrStack: ");
            int.TryParse(Console.ReadLine(), out int x);
            if (x == null || x == 0) return;
            else arrStack.Push(x);
        } while (true);

    }
    static void Output(ListStack arrStack)
    {
        arrStack.GetTop(out int top);
        Console.WriteLine("Top: " + top);
        while (arrStack.Pop(out int x))
        {
            Console.Write(x + " ");
        }
    }
    static void TestListStack()

    {
        ListStack arrStack = new ListStack();
        Input(arrStack);
        Console.WriteLine("Cac gia tri trong Stack:");
        Output(arrStack);
    }
    static void Main(string[] args)
    {
        TestListStack();
    }
}