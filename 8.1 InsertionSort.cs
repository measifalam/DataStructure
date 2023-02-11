using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LearnDSAlgorithms
{
    class Sort
    {
        public void insertionsort(int[] A, int n)
        {
            for (int i = 1; i < n; i++)
            {
                int temp = A[i];
                int position = i;
                while (position > 0 && A[position - 1] > temp)
                {
                    A[position] = A[position - 1];
                    position = position - 1;
                }
                A[position] = temp;
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
            Console.WriteLine("Original Array: ");
            s.display(A, 6);
            s.insertionsort(A, 6);
            Console.WriteLine("Sorted Array:");
            s.display(A, 6);
            Console.ReadKey();
        }
    }
}
