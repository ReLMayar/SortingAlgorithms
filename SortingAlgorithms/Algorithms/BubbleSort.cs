using System;

namespace SortingAlgorithms.Algorithms
{
    public class BubbleSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public override void Sort()
        {
            var count = Items.Count;

            for (int j = 0; j < count; j++)
            {
                for (int i = 0; i < count - 1 - j; i++)
                {
                    var posOne = Items[i];
                    var posTwo = Items[i + 1];
                    if (posOne.CompareTo(posTwo) > 0)
                    {
                        Swap(i, i + 1);
                    }
                }
            }
        }
    }
}