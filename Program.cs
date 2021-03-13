using System;

namespace Test11233333
{
    class Program
    {
        static byte[] array = { 1, 2, 3, 4, 1, 7, 8, 9,0 };
        static readonly int N = array.Length;
        static readonly int M = array.Length;
        static double result = 1;
        static Action<byte[], int>[] methods = new Action<byte[], int>[] { loop, dummy };
        static void loop(byte[] array, int i)
        {
            result *= array[i];
            i++;
            methods[i / M](array, i);
        }
        static void dummy(byte[] array, int i)
        {
        }
        static void Main(string[] args)
        {
            loop(array, 0);
            Console.WriteLine(new string[] { "yes", "no" }[(uint)(result / (result - 0.1))]);
        }
    }
}
