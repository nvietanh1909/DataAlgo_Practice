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
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            int x;
            do
            {
                Console.Write("Nhập giá trị cho Linked List: ");
                int.TryParse(Console.ReadLine(), out x);
                if (x == 0 || x == null)
                    return;
                IntNode newNode = new IntNode(x);
                AddLast(newNode);
            } while (true);
        }
        public void ShowList()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
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
            IntNode firstNode = first;
            while (firstNode != null)
            {
                if (firstNode == x) return firstNode;
                firstNode = firstNode.Next;
            }
            return firstNode;
        }
        public IntNode GetMax()
        {
            IntNode max = first;
            IntNode next = max.Next;
            while (next != null)
            {
                if (max.Data < next.Data) max = next;
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
        public MyList JoinList(MyList list2)
        {
            IntNode firstList1 = first;
            IntNode firstList2 = list2.first;
            MyList list3 = new MyList();
            while (firstList1 != null)
            {
                list3.AddLast(firstList1);
                firstList1 = firstList1.Next;
            }
            while(firstList2 != null)
            {
                list3.AddLast(firstList2);
                firstList2 = firstList2.Next;
            }
            return list3;
        }
    }
}
