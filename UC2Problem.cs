using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Assignment
{
    class UC2Problem
    {
        private Day14StackNQueueAssg.Node top;
        public static void UC2_PeekNPopStack()
        {
            this.top = null;
        }
        internal void Push(int value)
        {
            Day14StackNQueueAssg.Node node = new Day14StackNQueueAssg.Node(value);
            if (this.top == null)
                node.next = null;
            else
                node.next = this.top;
            this.top = node;
            Console.WriteLine("{0} inserted into Stack LinkedList", value);
        }
        internal void Display()
        {
            Day14StackNQueueAssg.Node temp = this.top;
            while (temp != null)
            {
                Console.Write(temp.data + " ");
                temp = temp.next;
            }
        }
        internal void Peek()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty");
                return;
            }
            Console.WriteLine("{0} is in the top of stack", this.top.data);
        }
        internal void Pop()
        {
            if (this.top == null)
            {
                Console.WriteLine("Stack is empty,Deletion is not Possible");
                return;
            }
            Console.WriteLine("Value Poped is {0}", this.top.data);
            this.top = this.top.next;
        }
        internal void IsEmpty()
        {
            while (this.top != null)
            {
                Peek();
                Pop();
            }
        }
    }
}

