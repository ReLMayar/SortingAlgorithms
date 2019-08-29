using System;

namespace SortingAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            #region BubbleSort
            Console.WriteLine("Bubble Sort:");
            var bubble = new Algorithms.BubbleSort<int>();
            var rnd = new Random();

            Console.WriteLine("Unsorted list:");
            for (int i = 0; i < 10; i++)
            {
                bubble.Items.Add(rnd.Next(0, 100));
                Console.Write(bubble.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Result of sorting:");
            bubble.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(bubble.Items[i] + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region ShakerSort
            Console.WriteLine("Shaker Sort:");
            var shaker = new Algorithms.ShakerSort<int>();

            Console.WriteLine("Unsorted list:");
            for (int i = 0; i < 10; i++)
            {
                shaker.Items.Add(rnd.Next(0, 100));
                Console.Write(shaker.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Result of sorting:");
            shaker.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(shaker.Items[i] + " ");
            }
            Console.WriteLine('\n');
            #endregion
        }
    }
}
