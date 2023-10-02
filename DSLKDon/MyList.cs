using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DSLKDon
{
    internal class MyList
    {
        //Field
        private IntNode first;
        private IntNode last;
        //Properties
        public IntNode First { get => first; set => first = value; }
        public IntNode Last { get => last; set => last = value; }
        //Constructor
        public MyList() => first = last = null;
        //Method
        public bool IsEmpty() => first == null;
        public void AddFirst(IntNode newNode)
        {
            if (IsEmpty()) first = last = newNode;
            else
            {
                newNode.Next = first;
                first = newNode;
            }
        }
        public void AddLast(IntNode newNode)
        {
            if (IsEmpty()) first = last = newNode;
            else
            {
                last.Next = newNode;
                last = newNode;
            }
        }
        public void Input()
        {
            int x;
            do
            {
                Console.Write("Gia tri: ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0 || x == null)
                    return;
                IntNode newNode = new IntNode(x);
                AddLast(newNode);
            } while (true);
        }
        public void ShowList()
        {
            IntNode p = first;
            while (p != null)
            {
                Console.Write("{0} -> ", p.Data);
                p = p.Next;
            }
            Console.WriteLine("null");
        }
        public IntNode SearchX(IntNode x)
        {
            while(first != null)
            {
                if (first == x) return first;
                else first = first.Next;
            }
            return first;
        }
        public IntNode GetMax()
        {
            IntNode max = first;
            IntNode next = max.Next;
            while(next != null)
            {
                if(max.Data < next.Data) max = next;
                next = next.Next;
            }
            return max;
        }
        public IntNode GetMin()
        {
            IntNode min = first;
            IntNode next = min.Next;
            while (next != null)
            {
                if (min.Data > next.Data) min = next;
                next = next.Next;
            }
            return min;
        }
        public MyList GetEvenList()
        {
            MyList evenList = new MyList();
            IntNode nodeFirst = first;
            while (nodeFirst != null)
            {
                if (nodeFirst.Data % 2 == 0)
                {
                    IntNode newNode = new IntNode(nodeFirst.Data);
                    evenList.AddLast(newNode);
                }
                nodeFirst = nodeFirst.Next;
            }
            return evenList;
        }
        public MyList GetOddList()
        {
            MyList oddList = new MyList();
            IntNode nodeFirst = first;
            while (nodeFirst != null)
            {
                if (nodeFirst.Data % 2 != 0)
                {
                    IntNode newNode = new IntNode(nodeFirst.Data);
                    oddList.AddLast(newNode);
                }
                nodeFirst = nodeFirst.Next;
            }
            return oddList;
        }
    }
}
