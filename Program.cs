using System;

namespace Массивы1
{
    class Program
    {
        static void Main(string[] args)
        {
            int N = 1;
            Console.WriteLine("Введите количество оригинального массива");
            N = Convert.ToInt32(Console.ReadLine());
            int[] M1 = new int[N];
            Vvod(M1);
            Vivod(M1, "Оригинальный массив");
            int M = 1;
            Console.WriteLine("Введите количество массива вставки");
            M = Convert.ToInt32(Console.ReadLine());
            int[] M2 = new int[M];
            Vvod(M2);
            Vivod(M2, "Массив вставки");

            int[] M3 = new int[M + N];
            int K = 0;
            Console.WriteLine("Введите индекс вставки");
            K = Convert.ToInt32(Console.ReadLine());
            Array.Copy(M1, M3, K);
            Array.Copy(M2, 0, M3, K, M2.Length);
            Array.Copy(M1, K, M3, K + M2.Length, M1.Length - K);
            Vivod(M3, "Массив результат");
        }

        static void Vvod(int[] M)
        {
            Random r = new Random();

            for (int i = 0; i < M.Length; i++)
            {
                M[i] = r.Next(100);
            }
        }

        static void Vivod(int[] M, string msg)
        {
            if (M == null)
                return;
            else
            {
                Console.WriteLine(msg + ":");
                foreach (int el in M)
                {
                    Console.Write(el.ToString() + " ");
                }
                Console.WriteLine();
            }
        }

    }

}
