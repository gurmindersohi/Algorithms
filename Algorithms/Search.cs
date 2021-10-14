using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithms
{
    public class Search
    {
        public static void Main()
        {

        }

        public int LinearSearch(int[] data, int key)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == key)
                { 
                    return i;
                }
            }
            return -1;
        }

        public int BinarySearch(int[] data, int key)
        {
            int left = 0;
            int right = data.Length - 1;

            while (left <= right)
            {
                int mid = (left + right) / 2;
                if (data[mid] == key)
                {
                    return mid;
                }
                if (data[mid] < key)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
            return -1;
        }

        public void RecursiveBinarySearch(int[] data, int target)
        { 
        
        }

    }
}
