using System;

namespace LargestSubarraySum
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = 20;
            int[] T = new int[n];
            Random rand = new Random();

            for (int i = 0; i < n; i++)
            {
                T[i] = rand.Next(-99, 100);
            }

            Console.WriteLine("Tablica:");
            foreach (var num in T)
            {
                Console.Write(num + " ");
            }
            Console.WriteLine();

            int ms = int.MinValue;
            int ip = 0, ik = 0;
            int bs, start, end;

            for (start = 0; start < n; start++)
            {
                bs = 0;
                for (end = start; end < n; end++)
                {
                    bs += T[end];
                    if (bs > ms)
                    {
                        ms = bs;
                        ip = start;
                        ik = end;
                    }
                }
            }

            Console.WriteLine($"Największa suma podciągu: {ms}");
            Console.WriteLine($"Podciąg zaczyna się na indeksie: {ip}");
            Console.WriteLine($"Podciąg kończy się na indeksie: {ik}");
            Console.Write("Podciąg: ");
            for (int k = ip; k <= ik; k++)
            {
                Console.Write(T[k] + " ");
            }
            Console.WriteLine();
        }
    }
}
