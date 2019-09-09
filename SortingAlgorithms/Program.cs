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

            #region InsertSort
            Console.WriteLine("Insert Sort:");
            var insert = new Algorithms.InsertSort<int>();

            Console.WriteLine("Unsorted list:");
            for (int i = 0; i < 10; i++)
            {
                insert.Items.Add(rnd.Next(0, 100));
                Console.Write(insert.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Result of sorting:");
            insert.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(insert.Items[i] + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region ShellSort
            Console.WriteLine("Shell Sort:");
            var shell = new Algorithms.ShellSort<int>();

            Console.WriteLine("Unsorted list:");
            for (int i = 0; i < 10; i++)
            {
                shell.Items.Add(rnd.Next(0, 100));
                Console.Write(shell.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Result of sorting:");
            shell.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(shell.Items[i] + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region BinaryTreeSort
            Console.WriteLine("Binary Tree Sort:");
            var tree = new Algorithms.BinaryTreeSort.BinaryTreeSort<int>();
            Console.WriteLine("Unsorted list:");
            for (int i = 0; i < 10; i++)
            {
                tree.Items.Add(rnd.Next(0, 100));
                Console.Write(tree.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Result of sorting:");
            tree.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(tree.Items[i] + " ");
            }
            Console.WriteLine('\n');
            #endregion

            #region HeapSort
            Console.WriteLine("Heap Sort:");
            var heap = new Algorithms.HeapSort.HeapSort<int>();
            Console.WriteLine("Unsorted list:");
            for (int i = 0; i < 10; i++)
            {
                heap.Items.Add(rnd.Next(0, 100));
                Console.Write(heap.Items[i] + " ");
            }
            Console.WriteLine();

            Console.WriteLine("Result of sorting:");
            heap.Sort();
            for (int i = 0; i < 10; i++)
            {
                Console.Write(heap.Items[i] + " ");
            }
            Console.WriteLine('\n');
            #endregion
        }
    }
}
