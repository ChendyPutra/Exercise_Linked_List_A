﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercise_Linked_List_A
{
    internal class Program
    {
        class Node
        {
            public int rollNumber;
            public string name;
            public Node next;
        }
        class CircularList
        {
            Node LAST;

            public CircularList()
            {
                LAST = null;
            }
            public bool search(int rollNo,ref Node current, Node previous)
            {
                for (previous = current = LAST.next; current != LAST; previous = current, current = current.next)
                {
                    if (rollNo == current.rollNumber)
                        return (true);
                }
                if (rollNo == LAST.rollNumber)
                    return true;
                else
                    return (false);
            }
            public bool listEmpty()
            {
                if (LAST == null)
                    return true;
                else
                    return false;
            }
            public void traverse()
            {
                if (listEmpty())
                    Console.WriteLine("\n List is Empty");
                else
                {
                    Console.WriteLine("\n Records in the list are: \n");
                    Node currentNode;
                    currentNode = LAST.next;
                    while(currentNode != LAST)
                    {
                        Console.Write(currentNode.rollNumber + "    " + currentNode.name + "\n");
                        currentNode = currentNode.next;
                    }
                    Console.Write(LAST.rollNumber = "  " + LAST.name + "\n");
                }
            }
            public void firstNode()
            {
                if (listEmpty())
                    Console.WriteLine("\n The first record in the list is:\n\n" + LAST.next.rollNumber + "   " + LAST.next.name);
            }
            public void delete_linked_list()
            {

            }
            
        }
        static void Main(string[] args)
        {
            CircularList obj = new CircularList();
            while (true)
            {
                try
                {
                    Console.WriteLine("\nMenu");
                    Console.WriteLine("1. View all the records in the list");
                    Console.WriteLine("2. Search for a record in the list");
                    Console.WriteLine("3. Display the first record in the list");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\n Enter your choice (1-4): ");
                    char ch = Convert.ToChar(Console.ReadLine());
                    switch (ch)
                    {
                        case '1':
                            {
                                obj.traverse();
                            }
                            break;
                        case '2':
                            {
                                if (obj.listEmpty() == true)
                                {
                                    Console.WriteLine("\nList is empty");
                                    break;
                                }
                                Node prev, curr;
                                prev = curr = null;
                                Console.Write("\nEnter the roll number of the strudent whose record is to be searched: ");
                                int num = Convert.ToInt32(Console.ReadLine());
                                if (obj.search(num, ref prev, ref curr) == (false))
                                    Console.WriteLine("\nRecord not found");
                                else
                                {
                                    Console.WriteLine("\nRecord found");
                                    Console.WriteLine("\nRoll Number" + curr.rollNumber);
                                    Console.WriteLine("\nName: " + curr.name);

                                }
                            }
                            break;
                        case '3':
                            {
                                obj.firstNode();
                            }
                            break;
                        case '4':
                            return;
                        default:
                            {
                                Console.WriteLine("Invalid Option");
                                break;
                            }
                    }

                }
                catch (Exception e)
                {
                    Console.WriteLine(e.ToString());
                }
            }
        }
    }
}
