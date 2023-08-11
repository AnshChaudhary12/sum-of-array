using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sum_of_array
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //write a program in c# pto find the sum of all elements in an integer array using a loop.
            int[] arr = { 1, 4, 6, 8, 9 };
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum = sum + arr[i];
            }
            Console.WriteLine(sum);
            // Write a program that calculates the average of values in a floating-point array using a loop.
            float[] a ={1.3f, 2.4f, 3.5f, 5.6f, 7.8f, 8.9f};
            float sum1 = 0;
            for(int i = 0; i < a.Length; i++)
            {
                sum1 = sum1 + a[i];
            }
            float avg = sum1 / a.Length;

            Console.WriteLine(avg);
            // write a program in c# that finds the largest element in an integer array using a loop and if-else statement

            int[] array = { 1, 2, 3, 4 };
            int s = 0;
            for (int i = 0; i < array.Length; i++)
            {
                for(int j = 0; j < array.Length; j++)
                {
                    if (array[i] > array[j]){
                        s = array[i];
                        

                    }
                }
                Console.WriteLine(s);
                
            }
             }
    }
}
