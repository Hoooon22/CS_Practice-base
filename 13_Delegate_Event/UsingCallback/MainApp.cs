﻿using System;

namespace UsingCallback
{
    delegate int Compare(int a, int b);

    class MainApp
    {
        static int AscendCompare(int a, int b)
        {
            if (a > b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static int DescendCompare(int a, int b)
        {
            if (a < b)
                return 1;
            else if (a == b)
                return 0;
            else
                return -1;
        }

        static void BubbleSort(int[] Dataset, Compare Comparer)
        {
            int i = 0;
            int j = 0;
            int temp = 0;

            for (i = 0; i < Dataset.Length-1; i++)
            {
                for (j = 0; j < Dataset.Length - (i+1); j++)
                {
                    if (Comparer(Dataset[j], Dataset[j+1]) > 0)
                    {
                        temp = Dataset[j + 1];
                    }
                }
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }   
}
