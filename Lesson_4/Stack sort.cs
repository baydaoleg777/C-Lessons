using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication5
{
    class Program
    {

        // The program works with Stack buffer.

        static int top;

        static void Main(string[] args)
        {
            Console.WriteLine("\n Please wrire the size of array");                   // Customer enters array size.
            int size_array = Int32.Parse(Console.ReadLine());

            while (size_array == 0)                                                   // Checking for null array. 
            {
                Console.WriteLine("\n The array size must be greater than 0");
                Console.WriteLine("\n Please wrire the size of array");
                size_array = Int32.Parse(Console.ReadLine());
            }

            int[] our_array = new int[size_array];                                    // Create an array of length 'size_array'. 

            for (int i = 0; i < size_array; i++)                                      // Customer enters values for elements of array. 
            {
                Console.WriteLine("\n Please wrire " + i + " element of array", i + 1);
                our_array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("");
            Console.WriteLine("***************************************");
            Console.WriteLine("");
            Console.WriteLine("\n You have massive :");

            for (int i = 0; i < our_array.Length; i++)
            {
                Console.Write(our_array[i] + "  ");
            }
            
                top = our_array.Length;

                while (true)                                                          // Menu.
                {
                    Console.WriteLine("");
                    Console.WriteLine("\n What can you do with Stack ?");
                    Console.WriteLine("");
                    Console.WriteLine("\n 0 - Do we have an Empty stack ?");
                    Console.WriteLine("");
                    Console.WriteLine("\n 1 - Do we have a Fully stack ?");
                    Console.WriteLine("");
                    Console.WriteLine("\n 2 - Pop element");
                    Console.WriteLine("");
                    Console.WriteLine("\n 3 - Push element");
                    Console.WriteLine("");
                    Console.WriteLine("\n 4 - Jast to take the data from one cell");
                    Console.WriteLine("");

                    string user_select;

                    user_select = Console.ReadLine();

                    switch (user_select)
                    {
                        case "0": Empty_array(our_array); break;
                        case "1": Full_array(our_array); break;
                        case "2": Pop_array(our_array); break;
                        case "3": Push_array(our_array); break;
                        case "4": Peek_array(our_array); break;
                        default: Console.WriteLine("\n Please press correct variant"); break;
                    }
                    Console.ReadLine();
                }
            }


        static void Show_array(int[] our_array)                                   // Shows the Stack.
        {
            for (int i = 0; i < top; i++)
            {
                Console.Write(our_array[i] + "  ");
            }
        }


        static void Empty_array(int[] our_array)                                  // IsEmpty for Stack.
        {
            if (top <= 0)
            {
                Console.WriteLine("");
                Console.WriteLine("\n We have Empty stack");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("\n We don't have Empty stack");
            }
            Show_array(our_array);
        }


        static void Full_array(int[] our_array)                                   // IsFull for Stack.
        {
            if (top >= our_array.Length)
            {
                Console.WriteLine("");
                Console.WriteLine("\n We have Full stack");
            }
            else
            {
                Console.WriteLine("");
                Console.WriteLine("\n We don't have Full stack");
            }
            Show_array(our_array);
        }


        static void Pop_array(int[] our_array)                                    // Pop for Stack.
        {
            if (top > 0)
            {
                Console.WriteLine("\n We Pop the element " + our_array[top - 1]);
                top--;
            }
            else
            {
                Console.WriteLine("\n We have empty stack");
            }
            Show_array(our_array);
        }


        static void Push_array(int[] our_array)                                   // Push for Stack.
        {
            if (top < our_array.Length)
            {
                Console.WriteLine("");
                Console.WriteLine("\n Please write the new element");
                our_array[top] = Int32.Parse(Console.ReadLine());

                Console.WriteLine("\n We Push the element " + our_array[top]);
                top++;
            }
            else
            {
                Console.WriteLine("\n We have full stack");
            }
            Show_array(our_array);
        }


        static void Peek_array(int[] our_array)                                   // Peek for Stack.
        {
            if (top > 0)
            {
                Console.WriteLine("\n We have Peek value: " + our_array[top - 1]);
            }
            else
            {
                Console.WriteLine("\n We have problem with Peek value");
            }
            Show_array(our_array);
        }

        }
     
    }

