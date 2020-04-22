using System;

namespace MergeSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = { 3, 4, 12, 32, 5, 1, 9 };
            MergeSort(arr);
            foreach (var item in arr)
            {
                Console.Write($"{item}, ");
            } 

        }

        public static void MergeSort(int[] arr)
        {
            int n = arr.Length;
            if(n > 1)
            {
                int mid = n / 2;
                int[] left = arr[0..mid];
                int[] right = arr[mid..n];

                MergeSort(left);
                MergeSort(right);
                Merge(left, right, arr);
            }
        }

        public static int[] Merge(int[] left, int[] right, int[] arr)
        {
            int i = 0;
            int j = 0;
            int k = 0;

            while(i < left.Length && j < right.Length)
            {
                if(left[i] <= right[j])
                {
                    arr[k] = left[i];
                    i = i + 1;
                }
                else
                {
                    arr[k] = right[j];
                    j = j + 1;
                }
                k = k + 1;
            }
            if(i == left.Length)
            {
                for (int x = k; x < arr.Length; x++)
                {
                    arr[x] = right[j++];
                }
            }
            else
            {
                for (int x = k; x < arr.Length; x++)
                {
                    arr[x] = left[i++];
                }
            }
            return arr;
        }
    }
}
