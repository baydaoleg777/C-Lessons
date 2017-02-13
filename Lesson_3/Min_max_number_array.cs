using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Min_max_number_array
    {
        // The program finds min and max numbers from array.
        // The user enters size and content of the array.

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

            int result_min = Min_number(our_array, size_array);
            int result_max = Max_number(our_array, size_array);

            Console.WriteLine("The minimun number is " + result_min);
            Console.WriteLine("The maximum number is " + result_max);

            Console.ReadLine();


        }


        static int Min_number(int[] our_array, int size_array)                   // We find minimum value from array.
        {
            int min_number = our_array[0];

            for (int i = 0; i < size_array; i++)
            {
                if (min_number > our_array[i])
                    min_number = our_array[i];
            }
            return min_number;
        }


        static int Max_number(int[] our_array, int size_array)                   // We find maximum value from array.
        {
            int max_number = our_array[0];

            for (int i = 0; i < size_array; i++)
            {
                if (max_number < our_array[i])
                    max_number = our_array[i];
            }
            return max_number;
        }
    }
} 
    

