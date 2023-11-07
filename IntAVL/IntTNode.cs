using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace IntAVL
{
    internal class IntTNode
    {
        //Field
        int data;
        int height;
        IntTNode left;
        IntTNode right;
        //Properties
        public int Data { get => data; set => data = value; }
        public int Height { get => height; set => height = value; }
        public IntTNode Left { get => left; set => left = value; }
        public IntTNode Right { get => right; set => right = value; }
        //Constructor
        public IntTNode(int data = 0)
        {
            this.data = data;
            height = 1;
            left = right = null;
        }
        //Method
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
        public int GetBalance()
        {
            if (this == null)
                return 0;
            int hL = 0, hR = 0;
            if (left != null)
                hL = left.height;
            if (right != null)
                hR = right.height;
            return hL - hR;
        }
        public int Max(int LH, int RH) => LH > RH ? LH : RH;
        public IntTNode FindMin()
        {
            if (left == null) return this;
            return left.FindMin();
        }
        public IntTNode RightRotate()
        {
            var T1 = left;
            var RT1 = T1.right;
            T1.right = this;
            left = RT1;
            Height = Max(left.Height, right.Height) + 1;
            T1.Height = Max(T1.left.Height, T1.right.Height) + 1;
            return T1;
        }
        public IntTNode LeftRotate()
        {
            var T1 = right;
            var RT1 = T1.left;
            T1.left = this;
            right = RT1;
            Height = Max(left.Height, right.Height) + 1;
            T1.Height = Max(T1.left.Height, T1.right.Height) + 1;
            return T1;
        }
        public IntTNode InsertNode(int x, IntTNode cur)
        {
            if (data == x) return cur;
            if (x < data)
            {
                if (left == null) left = new IntTNode(x);
                else left = left.InsertNode(x, this);
            }
            else
            {
                if (right == null) right = new IntTNode(x);
                else right = right.InsertNode(x, this);
            }
            if (cur.left != null && cur.right != null) cur.Height = 1 + Max(cur.left.Height, cur.right.Height);
            else if (cur.left != null) cur.height = 1 + cur.left.height;
            else if (cur.right != null) cur.height = 1 + cur.right.height;
            var balance = cur.GetBalance();
            if (balance > 1 && x < cur.left.data) return cur.RightRotate();
            if (balance < -1 && x > cur.right.data) return cur.LeftRotate();
            if (balance > 1 && x > cur.left.data)
            {
                left = cur.left.LeftRotate();
                return cur.RightRotate();
            }
            if (balance < -1 && x < cur.right.data)
            {
                cur.right = cur.right.RightRotate();
                return cur.LeftRotate();
            }
            return cur;
        }
        public IntTNode DeleteNode(int x, IntTNode parent)
        {
            if (x < this.data)
            {
                if (left != null)
                    left = left.DeleteNode(x, this);
            }
            else if (x > this.data)
            {
                if (right != null)
                    right = right.DeleteNode(x, this);
            }
            else
            {
                if (left == null || right == null)
                {
                    IntTNode temp = null;
                    if (left == null)
                        temp = right;
                    else if (right == null)
                        temp = left;

                    if (temp == null)
                    {
                        temp = this;
                        if (parent.left == this)
                            parent.left = null;
                        else if (parent.right == this)
                            parent.right = null;
                    }
                    else 
                    {
                        if (parent.left == this)
                            parent.left = temp;
                        else if (parent.right == this)
                            parent.right = temp;
                    }
                    return temp;
                }
                else 
                {
                    IntTNode successor = right.FindMin();
                    this.data = successor.data;
                    right = right.DeleteNode(successor.data, this);
                }
            }

            Height = 1 + Max(left?.Height ?? 0, right?.Height ?? 0);
            int balance = GetBalance();
            if (balance > 1 && x < data)
                return RightRotate();
            if (balance < -1 && x > data)
                return LeftRotate();
            if (balance > 1 && x > data)
            {
                left = left.LeftRotate();
                return RightRotate();
            }
            if (balance < -1 && x < data)
            {
                right = right.RightRotate();
                return LeftRotate();
            }

            return this; 
        }
    }
}
