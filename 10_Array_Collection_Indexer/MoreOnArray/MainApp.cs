using System;

namespace MoreOnArray
{
    class MainApp
    {
        private static bool CheckPassed(int score)
        {
            return score >= 60;
        }

        private static void Print(int value)
        {
            Console.Write($"{value} ");
        }

        static void Main(string[] args)
        {
            int[] scores = new int[] { 80, 74, 81, 90, 34 };

            foreach (int score in scores)
                Console.Write($"{score} ");
            Console.WriteLine();

            Array.Sort(scores);
            Array.ForEach<int>(scores, new Action<int>(Print));
            Console.WriteLine();

            Console.WriteLine($"Number of dimensions : {scores.Rank}");

            Console.WriteLine($"Binary Search :  81 is at " +
                $"{Array.BinarySearch<int>(scores, 81)}");

            Console.WriteLine($"Linear Search :  90 is at " +
                $"{Array.IndexOf<int>(scores, 90)}");

            Console.WriteLine($"EveryOne passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");

            int index = Array.FindIndex<int>(scores, (score) => score < 60);

            scores[index] = 61;
            Console.WriteLine($"EveryOne passed ? : " +
                $"{Array.TrueForAll<int>(scores, CheckPassed)}");
        }
    }
}
