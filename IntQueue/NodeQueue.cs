using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntQueue
{
    internal class NodeQueue
    {
        //Field
        int data;
        NodeQueue next;
        //Properties
        public int Data { get => data; set => data = value; }
        public NodeQueue Next { get => next; set => next = value; }
        //Constructor
        public NodeQueue(int data = 0)
        {
            this.data = data;
            next = null;
        }
    }
}
