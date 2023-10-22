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
            MyList list = new MyList();
            list.AddLast(new IntNode(1));
            list.AddLast(new IntNode(2));
            list.AddLast(new IntNode(3));
            list.ShowList();
        }
    }
}
