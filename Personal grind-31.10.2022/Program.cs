using System;

namespace Personal_31._10._2022
{
    struct travels
    {
        public int distance;
        public int price;
    }

    internal class Program
    {
        static void input(out int N, travels[] travel)
        {

            N = Int32.Parse(Console.ReadLine());
            if (N >= 0 && N <= 100)
            {
                for(int i = 0; i < N; i++)
                {
                    string[] tmp = Console.ReadLine().Split(" ");
                    if (Int32.Parse(tmp[0])>= 0 && Int32.Parse(tmp[0]) <= 20000)
                    {
                        travel[i].distance = Int32.Parse(tmp[0]);
                    }
                    if (Int32.Parse(tmp[0]) >= 0 && Int32.Parse(tmp[0]) <= 2000000)
                    {
                        travel[i].price = Int32.Parse(tmp[1]);
                    }
                }
            } 
        }
        static void calculate (int N, travels[] travel, out int count )
        {
            count = 0;
            for (int i = 0; i < N; i++)
            {
                if (travel[i].distance != 0 && (travel[i].price / travel[i].distance) >= 100)
                {
                    count++;
                }
            }
        }

        static void output(int count, travels[] travel, int N)
        {
            Console.Write(count + " ");
            for (int i = 0; i < N; i++)
            { 
                if ((travel[i].price / travel[i].distance) >= 100)
                {
                    Console.Write((i + 1) + " ");
                }
            }
        }

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
            input(out N, travel);

            ///Algorithm
            ///
            calculate(N, travel, out count);
            ///Output
            ///
            output(count, travel , N);
            
        }
    }
}