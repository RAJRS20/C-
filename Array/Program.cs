using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayDemo
{
    public class Program
    {
        static void Main(string[] args)
        {

            int[] arr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            Console.WriteLine("Original Array: ");
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(" " + arr[i] );
            }

            Console.WriteLine(" ");

            void slicearr(int Startindex, int Endindex)
            {
                Console.WriteLine("\nSliced array is :");

                for (int i = Startindex; i <= Endindex; i++)
                {
                    Console.Write(" " + arr[i]);
                }

                Console.WriteLine(" ");
            }



            void reverseArr(int[] arr1)
            {
                Console.WriteLine("\nReverse Array: ");

                for (int i = arr1.Length - 1; i >= 0; i--)
                {
                    Console.Write(" " + arr1[i]);
                }

                Console.WriteLine(" ");
            }



            void updateElement(int[] arr2, int index, int value)
            {
                Console.WriteLine("\nUpdate the Number 5 to 500: ");
                for (int i = 0; i < arr2.Length - 1; i++)
                {
                    if (i == index)
                    {
                        arr[i] = value;
                    }
                    Console.Write(" " + arr2[i]);
                }

            }

            slicearr(4, 6);
            reverseArr(arr);
            updateElement(arr, 4, 500);


            Console.ReadLine();
        }
    }

}