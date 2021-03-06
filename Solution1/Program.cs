using System;

namespace Solution1
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
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] >= num)
                {
                    return i;
                }
            }
            return arr.Length;
        }
    }
}
