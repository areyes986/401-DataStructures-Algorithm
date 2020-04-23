using System;

namespace QuickSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] arr = {8,4,23,42,16,15};
            QuickSort(arr, 0, arr.Length - 1);
            Console.WriteLine(String.Join(",",arr));

    
        }

        public static void QuickSort(int[]arr, int left, int right)
        {
            if(left < right)
            {
                int position = Partition(arr, left, right);
                QuickSort(arr, left, position - 1);

                QuickSort(arr, position + 1, right);

            }
        }

        public static int Partition(int[]arr, int left, int right)
        {
            int pivot = arr[right];
            int low = left - 1;

            for (int i = left; i < right; i++)
            {
                if(arr[i] <= pivot)
                {
                    low++;
                    Swap(arr, i, low);
                }
            }
            Swap(arr, right, low + 1);
            return low + 1;           
        }

        public static void Swap(int[]arr, int i, int low)
        {
            int temp;
            temp = arr[i];
            arr[i] = arr[low];
            arr[low] = temp;
        }
    }
}
