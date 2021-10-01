using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Assignment
{
    class UC1problem
    {
        private Day14StackNQueueAssg.Node top;
        private static object uC1problem;

        public static void CreateUC1problem()
        {
            UC1problem uC1problem1 = this;
            uC1problem1.top = null;
        }
        internal void Push(int Value)
        {
            Day14StackNQueueAssg.Node node = new Day14StackNQueueAssg.Node(Value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} inserted into Stack", Value);
        }
        internal void Display()
        {
            Day14StackNQueueAssg.Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = (Day14StackNQueueAssg.Node)temp.next;
            }
        }
    }
}

