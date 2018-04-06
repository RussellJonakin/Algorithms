using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSandbox
{
    public partial class Sort
    {
        public static void MergeSort(int[] array)
        {
            MergeSort(array, 0, array.Length - 1);
        }

        private static void MergeSort(int[] array, int leftStart, int rightEnd)
        {
            if (leftStart >= rightEnd)
                return;

            int mid = (leftStart + rightEnd) / 2;

            MergeSort(array, leftStart, mid);
            MergeSort(array, mid + 1, rightEnd);
            MergeHalves(array, leftStart, mid, rightEnd);
        }

        private static void MergeHalves(int[] array, int leftStart, int mid, int rightEnd)
        {
            int[] temp = new int[array.Length];

            // iteration index starting points.
            int tempIndex = leftStart;
            int leftIndex = leftStart;
            int rightIndex = mid + 1;

            // merge two haves together as sorted list into temp[].
            while (leftIndex <= mid && rightIndex <= rightEnd)
                temp[tempIndex++] = (array[leftIndex] < array[rightIndex]) ? array[leftIndex++] : array[rightIndex++];

            // fill in items remaining in left side if needed.
            while (leftIndex <= mid)
                temp[tempIndex++] = array[leftIndex++];

            // fill in items remaining in right side if needed.
            while (rightIndex <= rightEnd)
                temp[tempIndex++] = array[rightIndex++];

            // copy temp into the main array.
            for (int i = leftStart; i <= rightEnd; i++)
                array[i] = temp[i];
        }
    }
}
