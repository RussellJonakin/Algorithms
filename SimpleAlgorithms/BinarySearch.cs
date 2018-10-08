using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleAlgorithms
{
    /// <summary>
    /// Binary search operations over collections.
    /// </summary>
    public class BinarySearch
    {
        /// <summary>
        /// Seaches a sorted integer List for a number.
        /// </summary>
        /// <param name="numbers"></param>
        /// <param name="target"></param>
        /// <returns></returns>
        public static bool HasElement(List<int> numbers, int target)
        {
            int lowerBound = 0, upperBound = numbers.Count - 1;
            int searchPoint = ((upperBound - lowerBound) / 2) + lowerBound;
            while (lowerBound <= upperBound)
            {
                //get middle element.
                int searchElement = numbers[searchPoint];

                //check if target is found.
                if (searchElement == target)
                {
                    return true;
                }
                //Set to search larger half of list.
                else if (target > searchElement)
                {
                    lowerBound = searchPoint + 1;
                }
                //Set to search smaller half of list.
                else
                {
                    upperBound = searchPoint - 1;
                }

                //get next search point.
                searchPoint = ((upperBound - lowerBound) / 2) + lowerBound;
            }

            //target was not found.
            return false;
        }
    }
}
