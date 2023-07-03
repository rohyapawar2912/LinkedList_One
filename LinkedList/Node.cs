using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinlListDemo
{
    //Linked list is a linear data structure which stores the element in the non-contiguous location
    //The node had element are linked with each other using pointer
    //Linked list class allows insertion and deletion of element from a list very fastly
    //Node-Node will be your Exact value 
    //next-reference of the next node
    public class Node
    {
        public int data;
        public Node next;
        public Node(int data) 
        {
            this.data = data;
        }
    }
}
