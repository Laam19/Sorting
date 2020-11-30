using System;
using System.Collections.Generic;

namespace Sort
{
    class Program
    {
        static void Main(string[] args)
        {
            //// int[] UnsortedArray = new[] { 1, 5, 6, 2, 4, 3 };
            //List<int> UnSortedArray = new List<int>() { 1, 2, 5, 7, 8, 10 };
            //Console.WriteLine(UnSortedArray[0]);
            //Console.WriteLine(UnSortedArray);
            //List<int> SortedArray = new List<int>();
            //SortedArray = SortDotNet<int>.Sort(UnSortedArray, SortType.Bubble, SortOrder.Decending);
            int[] UnsortedArray = new[] { 1, 5, 6, 2, 4, 3 };
            int [] SortedArray1=SortDotNet<int>.Sort(UnsortedArray, SortType.Bubble, SortOrder.Decending);
            Console.WriteLine("Normal Sorting::");
            for (int i = 0; i < SortedArray1.Length; i++)
            {
                Console.WriteLine(SortedArray1[i]);
            }

            Product product = new Product();
            
            int[] SortedArray2 = SortDotNet<int>.Sort(product.ProductPrice, SortType.Bubble, SortOrder.Decending);
            Console.WriteLine("Object Based Sorting Sorting::");
            for (int i = 0; i < SortedArray2.Length; i++)
            {
                Console.WriteLine(SortedArray2[i]);
            }
        }
    }
}
