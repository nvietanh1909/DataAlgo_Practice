using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDon
{
    internal class IntNode
    {
        //Field
        int data;
        IntNode next;
        IntNode head;
        //Properties
        public int Data { get => data; set => data = value; }
        public IntNode Next { get => next; set => next = value; }
        public IntNode Head { get => head; set => head = value; }
        //Constuctor
        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }
    }
}
