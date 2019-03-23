using System;

namespace Solution4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetIndex(new int[] { 1, 2, 3 }, 1.5f));
            Console.WriteLine(GetIndex(new int[] { 20, 3, 5 }, 19));
            Console.WriteLine(GetIndex(new int[] { 40, 60 }, 50));
            Console.WriteLine(GetIndex(new int[] { 40, 60 }, 500));
        }

        static int GetIndex(int[] arr, float num)
        {
            Array.Sort(arr);
            int index = Array.FindIndex(arr, n => num <= n);
            return index == -1 ? arr.Length : index;
        }
    }
}
