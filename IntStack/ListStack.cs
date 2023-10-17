using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class ListStack
    {
        Node top;
        internal Node Top { get => top; set => top = value; }
        public ListStack() => top = null;
        public bool IsEmpty => top == null;
        public bool Push(int x)
        {
            Node dataX = new Node(x);
            if (IsEmpty)
            {
                top = dataX;
            }
            else 
            {
                dataX.Next = top;
                top = dataX;
            }
            return true;
        }
        public bool Pop(out int outItem)
        {
            Node topNode = top;
            outItem = -1;
            if (IsEmpty) { outItem = 0; return false; }
            else
            {
                Node deleteNode = top;
                outItem = deleteNode.Data;
                top = top.Next;
                deleteNode = null;
                return true;
            }
            
        }
        public bool GetTop(out int outItem)
        {
            if (IsEmpty)
            {
                outItem = 0;
                return false;
            }
            else
            {
                outItem = top.Data;
                return true;
            }
        }
    }
}
