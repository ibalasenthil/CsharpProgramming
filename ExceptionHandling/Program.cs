using System;

namespace ExceptionHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            
            try
            {
                int number = 10;
                int result = number / 0;
            }
            catch (Exception ex )
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error",ex.Message);
                
            }
            Console.WriteLine("Success");
        }
    }
}
