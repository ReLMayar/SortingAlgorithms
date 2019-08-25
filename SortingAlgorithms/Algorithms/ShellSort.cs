using System;
using System.Collections.Generic;
using System.Text;

namespace SortingAlgorithms.Algorithms
{
    public class ShellSort<T> : BaseAlgorithm<T> where T : IComparable
    {
        public override void Sort()
        {
            var step = Items.Count / 2;

            while (step > 0)
            {
                for (int i = step; i < Items.Count; i++)
                {
                    int j = i;
                    while (j >= step && Items[j - step].CompareTo(Items[j]) > 0)
                    {
                        Swap(j- step, j);
                        j -= step;
                    }
                }
                step /= 2;
            }
        }
    }
}
