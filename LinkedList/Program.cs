﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinlListDemo
{
    public class Program
    {
        static void Main(string[] args)
        {



            while (true)
            {
                Console.WriteLine("select any one option");
                Console.WriteLine("1 - linkedlistDemo");
                Console.WriteLine("2 - StackDemo");
                Console.WriteLine("3 - LinkedList_Node");

                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        Stack_Demo stack = new Stack_Demo();
                        stack.Element();
                        break;
                    case 2:
                        Linked linked_List_Demo = new Linked();
                        linked_List_Demo.Demo();
                        break;

                    case 3:

                        //Linked list using user defined
                        LinKedList_Node linKedList_Node = new LinKedList_Node();
                        linKedList_Node.Add(4);
                        linKedList_Node.Add(55);
                        linKedList_Node.Add(23);
                        break;

                        default:
                        Console.WriteLine("Invalid option");
                        break;







                }

            }
        }
    }
}
