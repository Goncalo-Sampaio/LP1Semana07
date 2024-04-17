using System;

namespace StructWithRef
{
    public class Program
    {
        private static void Main()
        {
            Wrapper w = new Wrapper();
            w.nums = new int[3] { 10, 20, 30 };
            UpdateArray(w);
            PrintArray(w);
            NewArray(w);
            PrintArray(w);
        }

        private static void UpdateArray(Wrapper w)
        {
            w.nums[1] = 200;
        }

        private static void NewArray(Wrapper w)
        {
            w.nums = new int[3] { 1, 2, 3 };
        }

        private static void PrintArray(Wrapper w)
        {
            foreach (int i in w.nums)
            {
                Console.Write(i + " ");
            }
            Console.WriteLine();
        }
    }
}
