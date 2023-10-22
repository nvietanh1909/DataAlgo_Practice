using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;

namespace IntQueue;
class Program
{
    static void Main()
    {
        ListQueue list = new ListQueue();
        list.EnQueue(1);
        list.EnQueue(2);
        list.EnQueue(3);
        list.EnQueue(4);
        list.DeQueue(out int x);
        list.DeQueue(out int x1);
        list.DeQueue(out int x2);
        list.DeQueue(out int x3);
        list.DeQueue(out int x4);
        list.EnQueue(999);
        list.DeQueue(out int x5);
        Console.WriteLine(x5);
    }
}