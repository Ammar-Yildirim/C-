using System;

namespace homework3
{
    internal class Program
    {
        static void readData(out int N, out int M, out int[] data)
        {
            bool errorN, errorM, errorData;
            Console.Error.WriteLine("=== Input ===");
            do
            {
                Console.WriteLine("N=? M=?");
                string[] tmp;
                tmp = Console.ReadLine().Split(" ");
                errorN = (!Int32.TryParse(tmp[0], out N) || (N < 1) || (N > 1000000));
                errorM = (!Int32.TryParse(tmp[1], out M) || (M < 1) || (M > 1000000));
                if (errorN)
                {
                    Console.Error.WriteLine("Error! Wrong input for N. Please Input N & M again");
                }
                if (errorM)
                {
                    Console.Error.WriteLine("Error! Wrong input for M. Please Input N & M again");
                }
            } while (errorN || errorM);

            data = new int[N];
            for (int i = 0; i < N; i++)
            {
                do
                {
                    Console.Write("data " + (i+1) + ": ");
                    string tmp = Console.ReadLine();
                    errorData = (!Int32.TryParse(tmp, out data[i]) || data[i] > M || data[i] < 1);
                    if (errorData)
                    {
                        Console.Error.WriteLine("Error! Wrong input for Data. Please input data " + (i+1) + " again");
                    }
                } while (errorData);
            }
        }

        static void solve(int N, int M,int[] data, out int cnt, out int maxcount, out int[] counts, out int[] ind, out int[] val)
        {
            maxcount = 0;
            //Part 1 -> Create an array which contains the count of the input numbers
            counts = new int[M + 1];
            for (int i = 0; i < N; i++)
            {
                counts[data[i]]++;
            }
            //Part 2 -> Find maxcount, which is the the maximum occurrence a number can have
            for (int i = 0; i < M; ++i)
            {
                if (counts[i] > maxcount)
                {
                    maxcount = counts[i];
                }
            }
            //Part 3 -> Store the values and indexes of the numbers that have occurred “maxcount” times
            val = new int[N];
            ind = new int[N];
            cnt = 0;
            for (int i = 0; i < M; i++)
            {
                if (counts[i] == maxcount)
                {
                    val[cnt] = i;
                    for (int j = 0; j < N; j++)
                    {
                        if (i == data[j])
                        {
                            ind[cnt] = j;
                            break;
                        }
                    }
                    cnt++;
                }
            }
        }

        static void writeOutput(int cnt, int[] ind, int[] val, int maxcount)
        {
            Console.Error.WriteLine("=== Output ===");
            for (int i = 0; i < cnt; i++)
            {
                Console.WriteLine((ind[i] + 1) + " " + val[i] + " " + maxcount);
            }
        }

        static void Main(string[] args)
        {
            ///Declaration
            ///
            int N;
            int M;
            int[] data,counts, val, ind;
            int maxcount,cnt;

            ///Input
            ///
            readData(out N, out M, out data);

            ///Implementation
            /// 
            solve(N, M, data, out cnt, out maxcount, out counts, out ind, out val );

            ///Output
            ///
            writeOutput(cnt, ind, val, maxcount);
        }
    }
}
