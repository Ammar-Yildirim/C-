namespace Personal_grind___29._10._2022
{
    struct students
    {
        public int year;
        public int month;
        public int day;
        public int start;
        public int graduate;
    }
    internal class Program
    {
        const int MaxN = 100;
        
        static void readData(out int N, students[] student)
        {
            N = Int32.Parse(Console.ReadLine());
            for(int i = 0; i < N; i++)
            {
                string[] tmp = Console.ReadLine().Split(" ");
                student[i].year = Int32.Parse(tmp[0]);
                student[i].month = Int32.Parse(tmp[1]);
                student[i].day = Int32.Parse(tmp[2]);
                student[i].start = Int32.Parse(tmp[3]);
                student[i].graduate = Int32.Parse(tmp[4]);
            }
        }

        static void checker(int N, students[] student, out int cntSpring,out int cntSummer,out int cntFall,out int cntWinter)
        {
            cntSpring = 0; cntSummer = 0; cntFall = 0; cntWinter = 0;
            for (int i = 0; i < N; i++)
            {
                if (student[i].month >= 1 && student[i].month <= 3)
                {
                    cntWinter++;
                }
                else if (student[i].month > 3 && student[i].month <= 6)
                {
                    cntSpring++;
                }
                else if (student[i].month > 6 && student[i].month <= 9)
                {
                    cntSummer++;
                }
                else if (student[i].month > 9 && student[i].month <= 12)
                {
                    cntFall++;
                }
            }
        }
        static void release(int summer, int spring, int fall, int winter)
        {
            Console.Write(summer + " ");
            Console.Write(spring + " ");
            Console.Write(fall + " ");
            Console.Write(winter + " ");


        }
        static void Main(string[] args)
        {
            ///Exercise 1 - Birth graduates by season 
            /// 

            ///Declaration
            ///
            int N;
            students[] student = new students[MaxN];
            int cntSpring = 0, cntSummer = 0, cntFall = 0, cntWinter = 0;

            ///Input
            ///
            readData(out N, student);

            checker(N,student, out cntSpring, out cntSummer, out cntFall, out cntWinter);
            ///Output
            ///
            release(cntSummer, cntSpring, cntFall, cntWinter);



        }
    }
}