using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication6
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("");
                Console.Write("\n Enter the your choise:");
                Console.Write("\n 0  Is queue empty ?");
                Console.Write("\n 1  Is queue full ?");
                Console.Write("\n 2  Insertion");
                Console.Write("\n 3  Deletion");
                Console.Write("\n");
                int user_select = Convert.ToInt32(Console.ReadLine());
                switch (user_select)
                {
                    case 0:
                        if (Empty() == true)
                        {
                            Console.Write("\n Queue is empty");
                        }
                        else
                        {
                            Console.Write("\n Queue is not empty");
                        }
                        break;

                    case 1:
                        if (Full() == true)
                        {
                            Console.Write("\n Queue is full");
                        }
                        else
                        {
                            Console.Write("\n Queue is not full");
                        }
                        break;
                    case 2:
                        Console.WriteLine("Enter the value to inser:");
                        Enqueue(Convert.ToInt32(Console.ReadLine()));
                        Console.WriteLine("");
                        Console.WriteLine("\n Now we have queue:");
                        Show();
                        break;
                    case 3:
                        int number = Dequeue();
                        Console.WriteLine(number);
                        Console.WriteLine("");
                        Console.WriteLine("\n Now we have queue:");
                        Show();
                        break;
                    default: Console.WriteLine("\n Please press correct variant"); break;
                }

            }
        }

        static int front = -1;
        static int back = -1;
        static int[] our_array = new int[8];
        static int size_array = 8;


        static bool Empty()
        {
            if (front == -1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static bool Full()
        {
            if ((front == 0 && back == size_array - 1) || (front == back + 1))
            {
                return true;
            }
            else
            {
                return false;
            }
        }


        static void Enqueue(int Element)
        {
            if (Full() == true)
            {
                Console.Write("\n Queueu is Full");
            }
            else
            {
                if (front == -1)
                {
                    front = 0;
                }

                if (back == size_array - 1)
                {
                    back = 0;
                }
                else
                {
                    back = back + 1;
                }

                our_array[back] = Element;
            }
        }


        static int Dequeue()
        {
            int element = 0;

            if (Empty() == true)
            {
                Console.Write("\n Queue is empty");
            }

            if (front == back)
            {
                front = -1;
                back = -1;
            }
            else if (front == size_array - 1)
            {
                front = 0;
            }
            else
                front = front + 1;

            return element;
        }


        static void Show()
        {
            if (Empty() == true)
            {
                Console.Write("\n Queue is empty \n");
            }
            else
            {
                int i = front;
                if (front <= back)
                {
                    while (i <= back)
                    {
                        Console.Write(our_array[i] + " ");
                        i++;
                    }
                }

                else
                {
                    while (i <= size_array - 1)
                    {
                        Console.Write(our_array[i] + " ");
                        i++;
                    }

                    i = 0;
                    while (i <= back)
                    {
                        Console.Write(our_array[i] + " ");
                        i++;
                    }
                }
            }
        }
    }
}
