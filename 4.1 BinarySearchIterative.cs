using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Search
    {
        public int binarysearch(int[] A, int n, int key)
        {
            int l = 0;
            int r = n - 1;
            while (l <= r)
            {
                int mid = (l + r) / 2;
                if (key == A[mid])
                    return mid;
                else if (key < A[mid])
                    r = mid - 1;
                else if (key > A[mid])
                    l = mid + 1;
            }
            return -1;
        }

        static void Main(string[] args)
        {
            Search s = new Search();
            int[] A = { 15, 21, 47, 84, 96 };
            int found = s.binarysearch(A, 5, 96);
            //int found = s.binarysearch(A, 5, 21);
            //int found = s.binarysearch(A, 5, 100);
            Console.WriteLine("Result: " + found);
            Console.ReadKey();
        }
    }
}
