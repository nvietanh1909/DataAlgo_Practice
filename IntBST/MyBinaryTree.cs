using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    internal class MyBinaryTree
    {
        //Field
        int count;
        IntTNode root;
        //Properties
        public int Count { get => count; set => count = value; }
        public IntTNode Root { get => root; set => root = value; }
        //Constructor
        public MyBinaryTree() { root = null; count = 0; }
        //Method
        public bool IsEmpty() => root == null;
        public bool Insert(int x)
        {
            if (IsEmpty()) { root = new IntTNode(x); count++; }
            else { if (!root.InsertNode(x)) return false; count++;} return true;
        }
        public void Input()
        {
            do
            {
                Console.Write("Enter value of BinaryTree: ");
                int.TryParse(Console.ReadLine(), out int x);
                if (x == 0 || x == null) return;
                try { if (Insert(x)) Console.WriteLine("Success\n"); }
                catch (Exception e) { Console.WriteLine($"Error: { e.Message}\n"); }
            } while (true);
        }
    }
}
