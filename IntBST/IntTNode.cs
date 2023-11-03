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
            if (data == x) return false;
            if (data > x)
            {
                if (left == null) left = new IntTNode(x);
                else return left.InsertNode(x);
            }
            else
            {
                if (right == null) right = new IntTNode(x);
                else return right.InsertNode(x);
            }
            return true;
        }
        public void NLR()
        {
            Console.Write(data + " ");
            if (left != null) left.NLR();
            if (right != null) right.NLR();
        }
        public void LNR()
        {
            if (left != null) left.LNR();
            Console.Write(data + " ");
            if (right != null) right.LNR();
        }
        public void LRN()
        {
            if (left != null) left.LRN();
            if (right != null) right.LRN();
            Console.Write(data + " ");
        }
        public int CountLeafBST()
        {
            if (this == null)
            {
                return 0;
            }
            else if (left == null && right == null)
            {
                return 1;
            }
            else
            {
                int leftLeafs = (left != null) ? left.CountLeafBST() : 0;
                int rightLeafs = (right != null) ? right.CountLeafBST() : 0;
                return leftLeafs + rightLeafs;
            }
        }
        public IntTNode SearchX(int x)
        {
            if (this.data == x) return this;
            if (this.data > x)
            {
                if (left == null) return null;
                return left.SearchX(x);
            }
            if (this.data < x)
            {
                if (right == null) return null;
                return right.SearchX(x);
            }
            return null;
        }
        public IntTNode SearchMin()
        {
            if (left == null) return this;
            return left.SearchMin();
        }
        public IntTNode SearchMax()
        {
            if (right == null) return this;
            return right.SearchMax();
        }
        public bool DeleteX(int x, IntTNode parent)
        {
            if (x < this.data)
            {
                if (left != null)
                    return left.DeleteX(x, this);
                else
                    return false;
            }
            else if (x > this.Data)
            {
                if (right != null)
                    return right.DeleteX(x, this);
                else
                    return false;
            }
            else
            {
                if (left != null && right != null)
                {
                    this.data = right.SearchMin().data;
                    right.DeleteX(this.Data, this);
                }
                else if (parent.left == this)
                    parent.left = (left != null) ? left : right;
                else if (parent.right == this)
                    parent.right = (left != null) ? left : right;
                return true;
            }
        }
    }
}