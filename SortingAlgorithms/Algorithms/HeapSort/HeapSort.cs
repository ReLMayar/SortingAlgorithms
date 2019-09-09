using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Algorithms.HeapSort
{
    public class HeapSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public void Sort(T items)
        {
            var heap = new BinaryHeap<T>(items as List<T>);
            heap.ResultedSort();
        }
    }
}
