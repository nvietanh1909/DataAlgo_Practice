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
            try
            {
                MyList list = new MyList();
                list.Input();
                list.ShowList();
                IntNode nodeF = list.First;
                list.ShowList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
