using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinlListDemo
{
    public class Stack_Demo
    {
        public void Element()
        {
            Stack stack = new Stack();
            stack.Push("Rohit");
            stack.Push("School");
            stack.Push(4);
            stack.Push(5.55);
            stack.Push('B');
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack :" + item);
            }
            Console.WriteLine("No of Elements" + stack.Count);
            Console.WriteLine(stack.Contains(33));
            Console.WriteLine(" Frist element " + stack.Peek());
            foreach (var item in stack)
            {
                Console.WriteLine("Elements in stack : " + item);
            }
            Console.WriteLine("Remove the top element " + stack.Pop());
            foreach (var item in stack)
            {
                Console.WriteLine("Element in stack :" + item);
            }


        }

    }
}
