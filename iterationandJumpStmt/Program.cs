using System;

namespace iterationandJumpStmt
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            //for (int i = 0; i < 5; i++)
            //{
            //    Console.WriteLine("printing is {0}",i);
            //}
            //for (int i = 5; i > 0; i--)
            //{
            //    Console.WriteLine("printing i is {0}",i);
            //}
            //int length = 5;
            //for (int i = 0; i < length; i++)
            //{
            //    Console.WriteLine($"printing i as {i}");
            //    for (int J = i+1; J < length; J++)
            //    {
            //        Console.WriteLine($"printing j as {J}");
            //    }
            //}
            //jump
            start:
            do
            {
                Console.WriteLine("This will execute compulsory");
            } while (false);
            Console.WriteLine("Do you want to Start ?");
            string YesOrNo = Console.ReadLine();
            if (YesOrNo == "Yes")
            {
                goto start;
            }

            object[] array = new object[2];
            array[0] = 1;
            array[1] = "string";
        }
    }
}
