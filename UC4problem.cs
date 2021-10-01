using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Assignment
{
    class UC4problem
    {
        Day14StackNQueueAssg.Node head = null;
        internal void Enqueue(int data)
        {
            Day14StackNQueueAssg.Node node = new Day14StackNQueueAssg.Node(data);
            if (head == null)
                head = node;
            else
            {
                Day14StackNQueueAssg.Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} inserted into Queue", node.Data);
        }
        internal void Dequeue()
        {
            if (head == null)
            {
                Console.WriteLine("\nQueue is Empty");
            }
            else
            {
                Console.Write("\n{0} Dequeued For Queue", head.Data);
                head = head.next;
            }
        }
        internal void Display()
        {
            Day14StackNQueueAssg.Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = temp.next;
            }
        }
    }
}

