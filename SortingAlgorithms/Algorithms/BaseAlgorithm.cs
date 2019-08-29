using System;
using System.Collections.Generic;

namespace SortingAlgorithms.Algorithms
{
    public class BaseAlgorithm<T> where T : IComparable
    {
        public List<T> Items { get; set; } = new List<T>();

        public void Swap(int posOne, int posTwo)
        {
            if (posOne < Items.Count && posTwo < Items.Count)
            {
                var item = Items[posOne];
                Items[posOne] = Items[posTwo];
                Items[posTwo] = item;
            }
        }

        public virtual void Sort()
        {
            Items.Sort();
        }
    }
}