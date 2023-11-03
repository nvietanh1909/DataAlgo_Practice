using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntStack
{
    internal class ArrayStack
    {
        //Fields
        int[] stkArray;
        int stkMax;
        int stkTop;
        //Properties
        public int StkMax { get => stkMax; set => stkMax = value; }
        public int StkTop { get => stkTop; set => stkTop = value; }
        //Constructor
        public ArrayStack(int max = 0)
        {
            stkMax = max;
            stkArray = new int[max];
            stkTop = -1;
        }
        public bool IsEmpty() => stkTop == -1;
        public bool IsFull() => stkTop == stkMax - 1;
        public bool Push(int x)
        {
            if (IsFull()) return false;
            stkTop++;
            stkArray[stkTop] = x;
            return true;
        }
        public bool Pop(out int outItem)
        {
            if(IsEmpty())
            {
                outItem = 0;
                return false;
            }
            outItem = stkArray[stkTop];
            stkTop--;
            return true;
        }
        public bool GetTop(out int topItem)
        {
            if(IsEmpty())
            {
                topItem = 0;
                return false;
            }
            topItem = stkArray[stkTop];
            return true;
        }
    }
}
