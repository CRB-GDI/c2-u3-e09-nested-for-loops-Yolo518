namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        { //Makeng rows and colums of *

            Console.WriteLine("How many rows do you want");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("How wide do you want each row to be");
            int with = int.Parse(Console.ReadLine());

            for(int i = 0; i <= with; i ++ )
            {
                Console.Write("*");
                for (int j = 1; j <= row; j++)
                {
                    Console.WriteLine("*");
                }
            }
        }
    }
}