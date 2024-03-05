namespace Exercise9
{
    internal class Program
    {
        static void Main(string[] args)
        { //Makeng rows and colums of * Problem 1

            Console.WriteLine("How many rows do you want");
            int row = int.Parse(Console.ReadLine());
            Console.WriteLine("How wide do you want each row to be");
            int with = int.Parse(Console.ReadLine());

            for(int i = 0; i < row; i ++ )
            {
                ;
                
                for (int j = 0; j < with; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("");
            }
            //Problem 2
            Console.WriteLine("How many * do you want");
            int numberOfAsteriks = int.Parse(Console.ReadLine());
            for( int i = 0; i < numberOfAsteriks; i++ )
            {
                Console.Write("*");
                for (int j = 0; j <= numberOfAsteriks; j++ )
                {
                    Console.WriteLine('*');
                }
            }
        }
        

        
    }
}