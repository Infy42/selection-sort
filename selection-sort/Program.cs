using System;

namespace selection_sort
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] unsortedList = { 2, 5, 3, 1, 6, 9, 4 };

            int minIndex = 0;
            int minValueFound = 0;

            Console.WriteLine("Before Selection Sort:");

            for (int index = 0; index < unsortedList.Length; index++)
            {
                Console.Write(unsortedList[index] + " ");
            }

            for (int mainIndex = 0; mainIndex < unsortedList.Length; mainIndex++)
            {
                minIndex = mainIndex;

                for(int RemainIndex = mainIndex + 1; RemainIndex < unsortedList.Length; RemainIndex++)
                {
                    if (unsortedList[RemainIndex] < unsortedList[minIndex])
                    {
                        minIndex = RemainIndex;
                    }
                }

                minValueFound = unsortedList[minIndex];
                unsortedList[minIndex] = unsortedList[mainIndex];
                unsortedList[mainIndex] = minValueFound;
            }

            Console.WriteLine("\nAfter Selection Sort:");

            for (int index = 0; index < unsortedList.Length; index++)
            {
                Console.Write(unsortedList[index] + " ");
            }

            Console.ReadLine();
        }
    }
}
