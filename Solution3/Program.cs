using System;
using System.Linq;

namespace Solution3
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
            var res = arr.Select(i => (float)i).ToList();
            res.Add(num);
            res.Sort();
            return res.IndexOf(num);
        }
    }
}
