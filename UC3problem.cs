using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14Assignment
{
    class UC3problem
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
            Console.WriteLine("{0} Inserted in Queue Linked list", node.Data);
        }
        internal void Display()
        {
            Day14StackNQueueAssg.Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("Queue is Empty");
                return;
            }
            while (temp != null)
            {
                Console.WriteLine(temp.Data + " ");
                temp = temp.next;
            }
        }
    }
}

