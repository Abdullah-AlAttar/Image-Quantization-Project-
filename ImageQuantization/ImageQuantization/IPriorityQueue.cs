using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ImageQuantization
{
    class IPriorityQueue
    {
        int maxN, curN;
        int[] heap, idx;
        double[] keys;
        public IPriorityQueue(int maxN)
        {
            this.maxN = maxN;
            curN = 0;
            heap = new int[maxN + 5];
            idx = new int[maxN + 5];
            keys = new double[maxN + 5];
            for (int i = 0; i < maxN + 5; ++i)
                idx[i] = -1;
        }
        /// <summary>
        /// checks if the IPQ is empty Takes O(1)
        /// </summary>
        /// <returns></returns>
        public bool IsEmpty()
        {
            return (curN == 0);
        }
        /// <summary>
        /// checks if the IPQ contains element X Takes O(1)
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>
        public bool Contains(int x)
        {
            return (idx[x] != -1);
        }
        /// <summary>
        /// Insertes element in the IPQ Takes O(Log(N))
        /// </summary>
        /// <param name="i"></param>
        /// <param name="key"></param>
        public void Insert(int i, double key)
        {
            curN++;
            idx[i] = curN;
            heap[curN] = i;
            keys[i] = key;
            BubbleUp(curN);
        }
        /// <summary>
        /// deletes the minimum elemnts in the IPQ takes O(Log(N))
        /// </summary>
        /// <returns></returns>
        public int DeleteMin()
        {
            int min = heap[1];
            Swap(1, curN--);
            BubbleDown(1);
            idx[min] = -1;
            heap[curN + 1] = -1;
            return min;
        }
        /// <summary>
        /// Decreases the value of the index by key Takes O(Log(key))
        /// </summary>
        /// <param name="i"></param>
        /// <param name="key"></param>
        public void DecreaseKey(int i, double key)
        {
            keys[i] = key;
            BubbleUp(idx[i]);
        }
        private void BubbleUp(int k)
        {
            while (k > 1 && keys[heap[k / 2]] > keys[heap[k]])
            {
                Swap(k, k / 2);
                k = k / 2;
            }
        }
        private void Swap(int i, int j)
        {
            int t = heap[i]; heap[i] = heap[j]; heap[j] = t;
            idx[heap[i]] = i; idx[heap[j]] = j;
        }
        private void BubbleDown(int k)
        {
            int j;
            while (2 * k <= curN)
            {
                j = 2 * k;
                if (j < curN && keys[heap[j]] > keys[heap[j + 1]])
                    ++j;
                if (keys[heap[k]] <= keys[heap[j]])
                    break;
                Swap(k, j);
                k = j;
            }
        }
    }
}
