using System;
using System.Collections.Generic;
using System.Runtime.Intrinsics.Arm;
namespace IntBST;
class Program
{
    static void Main()
    {
        MyBinaryTree tree = new MyBinaryTree();
        tree.Input();
        Console.WriteLine(tree.Count);
    }
}