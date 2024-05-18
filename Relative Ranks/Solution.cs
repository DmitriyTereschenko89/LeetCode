using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Relative_Ranks
{
    internal class Solution
    {
        private class MaxHeap
        {
            private readonly List<int> _heap = [];

            private void SiftDown(int curIdx, int endIdx)
            {
                int childOneIdx = curIdx * 2 + 1;
                while (childOneIdx <= endIdx)
                {
                    int childTwoIdx = curIdx * 2 + 2;
                    int swapIdx = childOneIdx;
                    if (childTwoIdx <= endIdx && _heap[childTwoIdx] > _heap[childOneIdx])
                    {
                        swapIdx = childTwoIdx;
                    }
                    
                    if (_heap[swapIdx] > _heap[curIdx]) 
                    {
                        (_heap[swapIdx], _heap[curIdx]) = (_heap[curIdx], _heap[swapIdx]);
                        curIdx = swapIdx;
                        childOneIdx = curIdx * 2 + 1;
                    }
                    else
                    {
                        return;
                    }
                }
            }

        }

        public string[] FindRelativeRanks(int[] score)
        {
            int n = score.Length;
            string[] ranks = new string[n];
            (int, int)[] scorePair = new (int, int)[n];
            for (int i = 0; i < n; ++i)
            {
                scorePair[i] = (score[i], i);
            }

            Array.Sort(scorePair, (a, b) => b.Item1 - a.Item1);
            for (int i = 0; i < n; ++i)
            {
                ranks[scorePair[i].Item2] = i switch
                {
                    0 => "Gold Medal",
                    1 => "Silver Medal",
                    2 => "Bronze Medal",
                    _ => (i + 1).ToString(),
                };
            }
            return ranks;
        }
    }
}
