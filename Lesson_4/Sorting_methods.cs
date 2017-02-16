using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Sorting_methods
    {
        // The program sorting the array with using two methods:
        // Bubble sort and Insertion sort.

        static void Main(string[] args)
        {
            Console.WriteLine("Please wrire the size of array");                     // Customer enters array size.
            int size_array = Int32.Parse(Console.ReadLine());

            while (size_array == 0)                                                  // Checking for null array. 
            {
                Console.WriteLine("The array size must be greater than 0");
                Console.WriteLine("Please wrire the size of array");
                size_array = Int32.Parse(Console.ReadLine());
            }

            int[] our_array = new int[size_array];                                   // Create an array of length 'size_array'. 

            for (int i = 0; i < size_array; i++)                                     // Customer enters values for elements of array. 
            {
                Console.WriteLine("Please wrire " + i + " element of array", i + 1);
                our_array[i] = Int32.Parse(Console.ReadLine());
            }

            Console.WriteLine("***************************************");

            int[] Bubble_sort_result = Bubble_Sort(our_array);
            int[] Insertion_sort_result = Insertion_Sort(our_array);

            
            
            Console.WriteLine("The sorting with Bubble method");
            
            for (int i = 0; i < our_array.Length; i++)
            {
                Console.WriteLine(Bubble_sort_result[i]);
            }

            Console.WriteLine("***************************************");

            Console.WriteLine("The sorting with Insertion method");                 

            for (int i = 0; i < our_array.Length; i++)
            {
                Console.WriteLine(Insertion_sort_result[i]);
            }

            Console.ReadLine();
        
        }

            static int[] Swap(int[] incoming_array, int i, int j)                  // The Swap method takes array of int and two indexes for change their places. 
            {
                   int n = incoming_array[i];
                   incoming_array[i] = incoming_array[j];
                   incoming_array[j] = n;

                   return incoming_array;
            }

        
            static int[] Bubble_Sort(int[] internal_array)                        // The Bubble sort.
            {
                bool use = true;
                
                for (int i = 0; i < internal_array.Length; i++)
               {
                   if (use == false)
                   {
                       break;
                   }
                    
                    for (int j = 0; j < internal_array.Length - i - 1; j++)
                   {

                      use = false;
                       
                       if (internal_array[j] > internal_array[j + 1])
                       {
                           internal_array = Swap(internal_array, j, j+1);         // Include Swap method
                           use = true;
                       }
                   }
               }
                return internal_array;
            }
        
        
            static int[] Insertion_Sort(int[] internal_array)                     // The Insertion sort.
            {
                int[] Ins_sort = new int[internal_array.Length];

                for (int i = 0; i < internal_array.Length; i++)
                {
                     int j = i;
                     while (j < 0 && Ins_sort[j + 1] < internal_array[i])
                     {
                        internal_array = Swap(internal_array, j, j + 1);          // Include Swap method
                        j++;
                     }
                     Ins_sort[j] = internal_array[i];
                }
                  return Ins_sort;
            }
         
  
        }
    }

