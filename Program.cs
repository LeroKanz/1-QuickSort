using System;

namespace QuickSort
{
    class Program
    {
        static void Main(string[] args)
        {            
            int[] array = { 44, 22, 33, 55, 12, 3, 7 };
            QuickSort(array);            
            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
        }

        public static void QuickSort(int[] array)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }
            Quick(array, 0, array.Length - 1);
        }

        public static void Quick(int[] array, int left, int right)
        {
            if (array is null)
            {
                throw new ArgumentNullException(nameof(array));
            }

            if (left < right)
            {
                int pivot = Partition(array, left, right);
                Quick(array, left, pivot - 1);
                Quick(array, pivot + 1, right);
            }
        }

        private static int Partition(int[] array, int left, int right)
        {
            int pivot = array[right];
            int small = left;
            int temp;

            for (int big = left; big <= right; big++)
            {
                if (array[big] < pivot)
                {
                    temp = array[small];
                    array[small] = array[big];
                    array[big] = temp;
                    small++;
                }
            }

            temp = array[right];
            array[right] = array[small];
            array[small] = temp;
            return small;
        }
    }
}
