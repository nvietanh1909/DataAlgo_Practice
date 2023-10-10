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
                list.InterchangeSort();
                MyList list2 = new MyList();
                list2.Input();
                list2.ShowList();
                list2.InterchangeSort();
                MyList list3 = new MyList();
                MyList newList = list3.MergeList(list, list2);
                newList.ShowList();
            }
            catch (Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }
        }
    }
}
