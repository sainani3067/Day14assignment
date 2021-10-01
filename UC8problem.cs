using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day14LinkedListAssignment
{
    class UC8problem
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
            if (head == null)
            {
                Console.Write("Linked list is Empty");
                return;
            }
            while (temp != null)
            {
                Console.Write(temp.Data + " ");
                temp = (Node)temp.next;
            }
        }
        internal Node InsertAtParticularPosition(int position, int data)
        {
            if (position < 1)
                Console.WriteLine("Invalid position");
            if (position == 1)
            {
                var newNode = new Node(data);
                newNode.next = (Node)this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                while (position-- != 0)
                {
                    Node node = new Node(data);
                    node.next = (Node)this.head.next;
                    head.next = node;
                    break;
                }
                temp = (Node)temp.next;
            }
            if (position != 1)
                Console.WriteLine("Position out of range");
            return head;
        }
        internal Node Search(int value)
        {
            Node temp = this.head;
            while (temp != null)
            {
                if (temp.Data == value)
                {
                    Console.WriteLine("\n Your element found");
                    return temp;
                }
                temp = (Node)temp.next;
            }
            return null;
        }
    }
}
