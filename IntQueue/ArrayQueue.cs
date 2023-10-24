using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntQueue
{
    internal class ArrayQueue
    {
        //Field
        int[] array;
        int max;
        int front;
        int rear;
        //Properties
        public int Front { get => front; set => front = value; }
        public int Rear { get => rear; set => rear = value; }
        //Constructor
        public ArrayQueue(int max = 0)
        {
            array = new int[max];
            this.max = array.Length;
            front = rear = -1;
        }
        //Method
        public bool IsEmpty() => front == -1 && rear == -1;
        public bool IsFull() => (rear + 1) % max == front;
        public bool EnQueue(int x)
        {
            if (IsFull()) return false;
            else if (IsEmpty()) front = rear = 0;
            else rear = (rear + 1) % max;
            array[rear] = x;
            return true;
        }
        public bool DeQueue(out int outItem)
        {
            outItem = 0;
            if (IsEmpty()) return false;
            outItem = array[front];
            if (front == rear) front = rear = -1;
            else front = (front + 1) % max;
            return true;
        }
        public bool GetFront(out int frontItem)
        {
            frontItem = 0;
            if (IsEmpty()) return false;
            frontItem = array[front];
            return true;
        }
        public bool GetRear(out int rearItem)
        {
            rearItem = 0;
            if (IsEmpty()) return false;
            rearItem = array[rear];
            return true;
        }
    }
}
