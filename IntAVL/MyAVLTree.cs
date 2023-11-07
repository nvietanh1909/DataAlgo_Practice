using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntAVL
{
    internal class MyAVLTree
    {
        //Field
        int count = 0;
        IntTNode root;
        //Properties
        public int Count { get => count; set => count = value; }
        public IntTNode Root { get => root; set => root = value; }
        //Constructor
        public MyAVLTree() { root = null; count = 0; }
        //Method
        public bool IsEmpty() => root == null;
        public bool Insert(int x)
        {
            if (IsEmpty())
            {
                root = new IntTNode(x);
                return true;
            }
            if (root.InsertNode(x, null) != null) return true;
            return false;
        }
        public void PreOrder()
        {
            if (root == null) return;
            root.NLR();
        }
        public void Input()
        {
            do
            {
                int x;
                Console.Write("Nhap vao gia tri: ");
                int.TryParse(Console.ReadLine(), out x);
                if (Insert(x) == true)
                    Console.WriteLine("Da them gia tri vao cay");
                else
                {
                    Console.WriteLine("Gia tri bi trung, ket thuc");
                    return;
                }
            } while (true);
        }
        public IntTNode FindX(int x)
        {
            if (root == null) return null;
            return root.SearchX(x);
        }
        public bool Remove(int x)
        {
            if (root == null)
                return false;
            if (root.Data == x)
            {
                var tmp = new IntTNode(0);
                tmp.Left = root;
                var kq = root.DeleteNode(x, tmp);
                root = tmp.Left;
                if (kq != null) return true;
            }
            if(root.DeleteNode(x, null) != null) return true;
            return true;
        }
    }
}
