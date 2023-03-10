using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace IACSD_DEMO
{
    public class Heap
    {
        List<int> Elements { get; set; } = new List<int>();


        public void AddNewElement(int element)
        {
            Elements.Add(element);

            BalanceTheHeap();
        }
        public int Count() => Elements.Count;

        public int Top() => Elements[0];

        private void swap(int index1, int index2)
        {
            int temp = Elements[index1];
            Elements[index1] = Elements[index2];
            Elements[index2] = temp;
        }
        public void ReplaceRootElement(int element)
        {
            int parentIndex = 0;
            if (parentIndex >= Elements.Count) return;

            Elements[parentIndex] = element;

            while (true)
            {

                if (parentIndex >= Elements.Count) break;

                int leftChildIndex = parentIndex * 2 + 1;
                int rightChildIndex = parentIndex * 2 + 2;

                if (leftChildIndex >= Elements.Count) break;
                int minIndex = parentIndex;
                if (Elements[minIndex] < Elements[leftChildIndex])
                {
                    minIndex = leftChildIndex;
                }

                if (rightChildIndex < Elements.Count)
                {
                    if (Elements[minIndex] < Elements[rightChildIndex])
                    {
                        minIndex = rightChildIndex;
                    }
                }

                if (minIndex == parentIndex) { break; }

                swap(minIndex, parentIndex);
                parentIndex = minIndex;
            }
        }

        private void BalanceTheHeap()
        {
            int childIndex = Elements.Count - 1;

            int parentIndex = (childIndex - 1) / 2;

            while(childIndex > 0)
            {
                if (Elements[childIndex] > Elements[parentIndex])
                {
                    int temp = Elements[childIndex];
                    Elements[childIndex] = Elements[parentIndex];
                    Elements[parentIndex] = temp;
                }
                childIndex = parentIndex;
                parentIndex = (childIndex - 1) / 2;
            }
        }

        public void PrintTheHeap()
        {
            foreach(int element in Elements)
            {
                Console.Write(element + ", ");
            }
        }


    }
}
