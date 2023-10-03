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
        private int data;
        private IntNode next;
        //Properties
        public int Data { get => data; set => data = value; }
        public IntNode Next { get => next; set => next = value; }
        //Constuctor
        public IntNode(int x = 0)
        {
            data = x;
            next = null;
        }
    }
}
