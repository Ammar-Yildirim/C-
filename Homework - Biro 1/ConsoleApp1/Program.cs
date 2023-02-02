namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Declaration
            int MaxN = 100;
            int N;
            int[] thickness = new int[MaxN];
            int count = 0;
            //Input
            Console.Error.WriteLine("Enter the count of measurments");
            N = Int32.Parse(Console.ReadLine());
            for (int j = 0; j < N; j++)
            {
                thickness[j] = Int32.Parse(Console.ReadLine());
            }
            //Algorithm
            for (int i = 0; i < N; i++)
            {
                if (thickness[i] > 0)
                {
                    count = count + 1;
                }
            }
            //Output
            Console.WriteLine(count);
        }
    }
}