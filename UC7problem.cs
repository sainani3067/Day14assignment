using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedListAssignment
{
    class UC7problem
    {
        internal Node head;
        internal void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = (Node)temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine("{0} insterd into Linked List", node.Data);
        }
        internal void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = (Node)temp.next;
            }
        }
        internal Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.Data == value)
                {
                    Console.WriteLine("\n Your Element found");
                    return temp;
                }
                temp = (Node)temp.next;
            }
            return null;
        }
    }
}
 
