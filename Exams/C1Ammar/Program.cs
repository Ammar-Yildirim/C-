using System.Diagnostics.CodeAnalysis;
using System.Xml.Linq;

namespace C1Ammar
{
    struct Array
    {
        public string name;
        public int count;
    }
    internal class Program
    {
        static void readData(out int N, out Array[] candies)
        {
            string tmp;
            string tmps;
            bool error, error40;
            error40 = true;

            do
            {
                Console.Write("N: ");
                tmp = Console.ReadLine();
                error = (!Int32.TryParse(tmp, out N) || (N<1));
                if (error)
                {
                    Console.Error.WriteLine("ERROR!Count can not be 0");
                }
            } while (error);

            candies = new Array[N + 1];
            do
            {
                for (int i = 1; i <= N; i++)
                {
                    Console.WriteLine("Enter Data " + i);
                    Console.WriteLine("Enter name: ");
                    candies[i].name = Console.ReadLine();
                    do
                    {
                        Console.WriteLine("Enter count");
                        tmps = Console.ReadLine();
                        error = (!Int32.TryParse(tmps, out candies[i].count));
                        if (error)
                        {
                            Console.Error.WriteLine("ERROR!Please put an integer as the count of candies");
                        }
                        if(candies[i].count > 40)
                        {
                            error40 = false;
                        }
                    } while (error);
                }
                if (error40)
                {
                    Console.Error.WriteLine("ERROR!At least one candy should have more than 40, Start over");
                }
            } while (error40);
        }
        static void task1(int N, Array[] candies, out string name)
        {
            int i = 1;
            while (candies[i].count <= 40)
            {
                i++;
            }
            name = candies[i].name;
        }
        static void task2(int N, Array[] candies, out float remainedPercent)
        {
            int s = 0;
            int s_t = 0;

            for (int i = 1; i <= N; i++)
            {
                s = s + candies[i].count;
                if (candies[i].name != "teasers")
                {
                    s_t = s_t + candies[i].count;
                }
            }
            remainedPercent = 100 * s_t / s;
        }

        static void writeData(string name, float remainedPercent)
        {
            Console.WriteLine(name + " has more than 40");
            Console.WriteLine(remainedPercent + "% remain");
        }

        static void Main(string[] args)
        {
            Console.WriteLine("C1 Coding Test : Ammar Yildirim FA27QM");
            ///Declaration
            ///
            int N;
            Array[] candies;

            string name;
            float remainedPercent;

            ///Input
            ///
            readData(out N, out candies);

            ///Implementation
            ///
            task1(N, candies, out name);
            task2(N, candies, out remainedPercent);

            ///Output
            ///
            writeData(name, remainedPercent);

        }
    }
}