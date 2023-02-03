using System;

namespace C2Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            <YILDIRIM AMMAR>, <FA27QM>
            This solution was prepared and submitted by the student stated above for the
            assignment of the Programming course. I declare that this solution is my own
            work. I have not copied or used third party solutions. I have not passed my
            solution to my classmates, neither made it public.
            Students’ regulation of Eötvös Loránd University (ELTE Regulations Vol. II.
            74/C.§) states that as long as a student presents another student’s work -
            or at least the significant part of it - as his/her own performance, it will
            count as a disciplinary fault. The most serious consequence of a disciplinary
            fault can be dismissal of the student from the University.
            */
            ///Declaration
            ///
            const int MaxN = 1000;
            const int MaxR = 1000;

            int N;
            int M;

            int[,] miles = new int[MaxN + 1, MaxR + 1];
            int cnt40 = 0;
            int[] distance = new int[MaxN + 1];
            int biggest = 0;

            int cntMoreThanM = 0;
            int[] moreThanM = new int[MaxN + 1];

            int[] shorts = new int[MaxN + 1];
            bool lessThanShortest = false;

            ///Input
            ///

            string[] tmp = Console.ReadLine().Split(" ");
            N = Int32.Parse(tmp[0]);
            M = Int32.Parse(tmp[1]);

            for (int i = 0; i < N; i++)
            {
                string[] tmps = Console.ReadLine().Split();
                int R = Int32.Parse(tmps[0]);
                shorts[i] = 9999999;
                for (int j = 0; j < R; j++)
                {
                    miles[i, j] = Int32.Parse(tmps[j + 1]);

                    //Solution for task 1
                    if (miles[i, j] == 40)
                    {
                        cnt40++;
                    }
                    //
                    distance[i] += miles[i, j];
                    //
                    if (miles[i, j] < shorts[i])
                    {
                        shorts[i] = miles[i, j];
                    }

                }
            }


            ///Algorithm
            ///

            //Solve task 2
            for (int i = 1; i < N; i++)
            {
                if (distance[i] > distance[biggest])
                {
                    biggest = i;
                }
            }
            //Solve task 3
            for (int i = 0; i < N; i++)
            {
                if (distance[i] > M)
                {
                    moreThanM[cntMoreThanM++] = i + 1;
                }
            }
            //Solve task 4
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < N; j++)
                {
                    if (shorts[i] > distance[j])
                    {
                        lessThanShortest = true;
                    }
                }
            }

            ///Output
            ///
            Console.WriteLine(cnt40);
            Console.WriteLine(biggest + 1);
            Console.Write(cntMoreThanM);
            for (int i = 0; i < cntMoreThanM; i++)
            {
                Console.Write(" " + moreThanM[i]);
            }
            Console.WriteLine();
            if (lessThanShortest == true)
            {
                Console.WriteLine("YES");
            }
            else
            {
                Console.WriteLine("NO");
            }
        }
    }
}