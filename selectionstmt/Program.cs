using System;

namespace selectionstmt
{
    class Program
    {
        static void Main(string[] args)
        {
            //bool flag = false;
            //if (flag == true)
            //{
            //    Console.WriteLine("this is success");
            //}
            //else if ((1 > 2) || (1==1))
            //{
            //    Console.WriteLine("if 1 is greater than 2");
            //}
            //else if ((5 > 10) && (5==5))
            //{
            //    Console.WriteLine("if 5 is greater than 10");
            //}
            //else
            //{
            //    Console.WriteLine("this is else block");
            //}
            Console.WriteLine("Enter your Education");
            string Edu = Console.ReadLine().ToUpper();
            switch (Edu)
            {
                case "B.SC in Computers":
                    Console.WriteLine("You will get job in IT if you good at programming or computers");
                    break;
                case "B.COM":
                    Console.WriteLine("you can get job in Accounts or try CA");
                    break;
                case "diplamo":
                    Console.WriteLine("get some hands on training in skills");
                    break;
            }
        }
    }
}
