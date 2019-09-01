using System;

namespace SortingAlgorithms.Algorithms
{
    public class InsertSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public override void Sort()
        {
            for (int i = 1; i < Items.Count; i++)
            {
                int j = i;
                while(j > 0 && Items[j].CompareTo(Items[j - 1]) < 0)
                {
                    Swap(j, j - 1);
                    j--;
                }
            }
        }
    }
}
