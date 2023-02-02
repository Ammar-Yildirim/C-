using System;

namespace ConsoleApp1
{
    struct travels
    {
        public int distance;
        public int price;
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            ///Declaration
            ///
            int N;
            const int MaxN = 100;
            travels[] travel = new travels[MaxN];
            int count;


            ///Input
            ///
            N = Int32.Parse(Console.ReadLine());
            if (N >= 0 && N <= 100)
            {
                for (int i = 0; i < N; i++)
                {
                    string[] tmp = Console.ReadLine().Split(" ");
                    if (Int32.Parse(tmp[0]) >= 0 && Int32.Parse(tmp[0]) <= 20000)
                    {
                        travel[i].distance = Int32.Parse(tmp[0]);
                    }
                    if (Int32.Parse(tmp[0]) >= 0 && Int32.Parse(tmp[0]) <= 2000000)
                    {
                        travel[i].price = Int32.Parse(tmp[1]);
                    }
                }
            }

            ///Algorithm    
            ///
            count = 0;
            for (int i = 0; i < N; i++)
            {
                if (travel[i].distance != 0 && (travel[i].price / travel[i].distance) >= 100)
                {
                    count++;
                }
            }


            ///Output
            ///
            Console.Write($"{count} ");
            for (int i = 0; i < N; i++)
            {
                if ((travel[i].price / travel[i].distance) >= 100)
                {
                    Console.Write($"{i+1} ");
                }
            }




        }
    }
}