using System;

namespace SampleConsole
{
    class Program
    {
        static void Swap(ref int l, ref int r)
        {
            var tmp = l;
            l = r;
            r = tmp;
        }

        static void Main(string[] args)
        {
            // コメントテスト
            int l = 1, r = -1;
            Console.WriteLine($"left= {l}, right= {r}"); // <- ここに Break point
            Swap(ref l, ref r);
            Console.WriteLine($"left= {l}, right= {r}");
        }
    }
}