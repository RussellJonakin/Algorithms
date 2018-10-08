using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    public partial class Sort
    {
        public static void QuickSort(int[] array)
        {
            QuickSort(array, 0, array.Length - 1);
        }

        private static void QuickSort(int[] array, int left, int right)
        {
            if (left >= right)
                return;

            int pivot = array[(left + right) / 2];
            int partitionPoint = Partition(array, left, right, pivot);
            QuickSort(array, left, partitionPoint - 1);
            QuickSort(array, partitionPoint, right);
        }

        private static int Partition(int[] array, int left, int right, int pivot)
        {
            while (left <= right)
            {
                // Find number on left that is larger than pivot.
                while (array[left] < pivot)
                    left++;

                // Find number on right that is smaller than pivot.
                while (array[right] > pivot)
                    right--;

                // Swap values and move index pointers to the next element.
                if (left <= right)
                {
                    Swap(array, left, right);
                    left++;
                    right--;
                }
            }

            return left;
        }
        
        private static void Swap(int[] array, int a, int b)
        {
            int temp = array[a];
            array[a] = array[b];
            array[b] = temp;
        }
    }
}
