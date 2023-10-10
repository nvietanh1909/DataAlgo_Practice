using DSLKDon;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Xml.Linq;

namespace DSLKDon
{
    internal class MyList
    {
        //Field
        IntNode first;
        IntNode last;
        int count = 0;
        //Properties
        public IntNode First { get => first; set => first = value; }
        public IntNode Last { get => last; set => last = value; }
        public int Count
        {
            get
            {
                var tmp = 0;
                for(var i = first; i != null; i = i.Next) tmp++;
                return count = tmp;
            }
        }
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
                if (SearchX(x) == null) AddLast(newNode);
                else Console.WriteLine($"{x} đã tồn tại trong Linked List, hãy nhập lại x!");
            } while (true);
        }
        public void ShowList()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            IntNode nodeFirst = first;
            while (nodeFirst != null)
            {
                Console.Write("{0} -> ", nodeFirst.Data);
                nodeFirst = nodeFirst.Next;
            }
            Console.WriteLine("null");
        }
        public IntNode SearchX(int x)
        {
            IntNode firstNode = first;
            while (firstNode != null)
            {
                if (firstNode.Data == x) return firstNode;
                firstNode = firstNode.Next;
            }
            if (firstNode == null) return null;
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
        public void RemoveAt(int i)
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            IntNode node = first;
            var tmp = 0;
            while (tmp != i) 
            { 
                tmp++; 
                node = node.Next;
                if(i < 0 || node == null) throw new Exception("Vị trí i không hợp lệ!");
            }
            RemoveX(node);
        }
        public void RemoveX(IntNode x)
        {
            if (first == last) first = last = null;
            else if (x == last)
            {
                IntNode prep = FindPrep(x);
                prep.Next = null;
                last = prep;
            }
            else
            {
                IntNode next1 = x.Next;
                IntNode next2 = next1.Next;
                x.Data = next1.Data;
                x.Next = next2;
            }
        }
        public IntNode FindPrep(IntNode p)
        {
            IntNode node = first;
            if (p == first) throw new Exception($"{p.Data} là phần tử đầu tiên của Linked List!");
            while(true)
            {
                if (node.Next == p)
                    return node;
                node = node.Next;
            }
        }
        public void InsertAt(int x, int i)
        {
            IntNode node = first;
            IntNode newNode = new IntNode(x);
            var tmp = 0;
            if(tmp == i)
            {
                AddFirst(newNode);
            }
            while (tmp != i)
            {
                tmp++;
                node = node.Next;
            }
            IntNode prep = FindPrep(node);
            prep.Next = newNode;
            newNode.Next = node;
        }
        public void InsertXAfterMin(IntNode x, IntNode min)
        {
            if (first == last) AddLast(x);
            else
            {
                x.Next = min.Next;
                min.Next = x;
            }
        }
        public void InsertXAfterY(IntNode x, IntNode y)
        {
            if (y == last) AddLast(x);
            else
            {
                x.Next = y.Next;
                y.Next = x;
            }
        }
        public void InsertXBeforeMax(IntNode x, IntNode max)
        {
            if (max == first) AddFirst(x);
            else
            {
                IntNode prep = FindPrep(max);
                prep.Next = x;
                x.Next = max;
            }
        }
        public void InsertXBeforeY(IntNode x, IntNode y)
        {
            if (y == first) AddFirst(x);
            else
            {
                IntNode prep = FindPrep(y);
                prep.Next = x;
                x.Next = y;
            }
        }
        public MyList ShiftLeft()
        {
            MyList newList = new MyList();
            IntNode prep = FindPrep(first.Next);
            first = first.Next;
            IntNode firstNode = first;
            RemoveX(prep);
            while (firstNode != null) { newList.AddLast(firstNode); firstNode = firstNode.Next; }
            return newList;
        }
        public MyList RShiftRight()
        {
            if (first == last == null) return this;
            MyList newList = new MyList();
            IntNode prep = FindPrep(last);
            IntNode lastNode = last;
            prep.Next = null;
            lastNode.Next = first;
            first = lastNode;
            IntNode firstNode = first;
            while (firstNode != null)
            {
                newList.AddLast(firstNode);
                firstNode = firstNode.Next;
            }
            return newList;
        }
        public void InterchangeSort()
        {      
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (first == null && last == null) throw new Exception("Mảng rỗng!");
            IntNode firstNode = first;
            for(var i = firstNode; i != null; i = i.Next)
                for (var j = i.Next; j != null; j = j.Next) 
                    if (i.Data > j.Data) Swap(i, j);
        }
        public void SelectionSort()
        {
            Console.OutputEncoding = System.Text.Encoding.Unicode;
            if (first == null && last == null) throw new Exception("Mảng rỗng!");
            IntNode firstNode = first;
            for (var i = firstNode; i != null; i = i.Next)
            {
                var min = i;
                for (var j = i.Next; j != null; j = j.Next) if (min.Data > j.Data) min = j;
                Swap(i, min);
            }
        }
        public MyList MergeList(MyList list1, MyList list2)
        {
            MyList list3 = new MyList();
            IntNode firstList1 = list1.first;
            IntNode firstList2 = list2.first;
            while(firstList1 != null && firstList2 != null)
            {
                if (firstList1.Data < firstList2.Data)
                {
                    list3.AddLast(firstList1);
                    firstList1 = firstList1.Next;
                }
                else
                {
                    list3.AddLast(firstList2);
                    firstList2 = firstList2.Next;
                }
            }
            while (firstList1 != null)
            {
                list3.AddLast(firstList1);
                firstList1 = firstList1.Next;
            }

            while (firstList2 != null)
            {
                list3.AddLast(firstList2);
                firstList2 = firstList2.Next;
            }
            return list3;
        }
        public void Swap(IntNode a, IntNode b)
        {
            var tmp = a.Data;
            a.Data = b.Data;
            b.Data = tmp;
        }
    }
}

