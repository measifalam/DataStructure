using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Sort
    {
        public void bubblesort(int[] A, int n)
        {
            for (int pass = n - 1; pass >= 0; pass--)
            {
                for (int i = 0; i < pass; i++)
                {
                    if (A[i] > A[i + 1])
                    {
                        int temp = A[i];
                        A[i] = A[i + 1];
                        A[i + 1] = temp;
                    }
                }
            }
        }

        public void display(int[] A, int n)
        {
            for (int i = 0; i < n; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine();
        }

        static void Main(string[] args)
        {
            Sort s = new Sort();
            int[] A = { 3, 5, 8, 9, 6, 2 };
            Console.WriteLine("Original Array:");
            s.display(A, 6);
            s.bubblesort(A, 6);
            Console.WriteLine("Sorted Array: ");
            s.display(A, 6);
            Console.ReadKey();
        }
    }
}
