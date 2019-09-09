using System;

namespace SortingAlgorithms.Algorithms.BinaryTreeSort
{
    public class BinaryTreeSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public void Sort(T items)
        {
            var tree = new BinarySearchTree<T>(items);
            tree.InOrder();
        }
    }
}
