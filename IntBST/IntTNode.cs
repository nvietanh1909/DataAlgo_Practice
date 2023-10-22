using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntBST
{
    internal class IntTNode
    {
        //Field
        int data;
        IntTNode left;
        IntTNode right;
        //Properties
        public int Data { get => data; set => data = value; }
        public IntTNode Left { get => left; set => left = value; }
        public IntTNode Right { get => right; set => right = value; }
        //Constructor
        public IntTNode(int data = 0)
        {
            this.data = data;
            left = right = null;
        }
        //Method
        public bool InsertNode(int x)
        {
            if (data == x) throw new Exception("Duplicate variable error");
            if(data > x)
            {
                if (left == null) { left = new IntTNode(x); }
                else return left.InsertNode(x);
            }
            else
            {
                if (right == null) { right = new IntTNode(x); }
                else return right.InsertNode(x);
            }
            return true;
        }
    }
}
