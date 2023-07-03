using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinlListDemo
{
    public class LinKedList_Node
    {
        public Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (head == null) 
            {
                head = node;
            }
            else
            {
                Node temp = head;
                while(temp.next!= null)
                {
                    temp = temp.next;
                   
                }
                temp.next = node;
            }
            Console.WriteLine("Linked list is " + data);
        }
        public void Display()
        {
            Node temp = head;
            if(temp == null)
            {
                Console.WriteLine("List is empty");
            }
            while(temp != null)
            {
                Console.WriteLine(temp.data);
                temp = temp.next;
            }

        }
        public void Reverse_Order(int data)
        {
            Node node = new Node(data);
            if(head == null)
            {
                head = node;
            }
            else
            {
                Node temp = head;
                head = node;
                head.next = temp;
            }
        }
        public void Remove_Frist()
        {
            if(head == null)
            {
                Console.WriteLine("List is Empty");
            }
            head = head.next;
            Console.WriteLine("Frist element deleted successfully");
        }

    }
}
