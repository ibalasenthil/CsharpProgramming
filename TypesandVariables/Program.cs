using System;
using System.Text;

namespace TypesandVariables
{
    struct Emp
    {
        public int age;
        public string name;
        public bool isEmployee;
    }
    class Program
    {
        static void Main(string[] args)
        {
            //int age = 27;
            //string name = "bala";
            //bool isEmployee = true;
            //Console.WriteLine(name + " is" + age + "years old");
            //Console.WriteLine("is he employees of the company "+(isEmployee ? "yes" : "no"));

            //Emp emp;
            //emp.age = 29;
            //emp.name = "alab";
            //emp.isEmployee = false;
            //Console.WriteLine(emp.name + " is and" + emp.age + " years old");


            ////Concatination
            //string first = "Edward";
            //string second = "adam";
            //string result = first + second;
            ////Console.WriteLine(result);
            //StringBuilder sb = new StringBuilder();
            //sb.Append(first);
            //sb.Append(second);
            //string appendedString = sb.ToString();
            //Console.WriteLine(appendedString);

            //string formatting
            //Console.WriteLine("What is your name");
            //string uname = Console.ReadLine();
            //Console.WriteLine("\n what is your age");
            //int age = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine(string.Format("Hello Mr."+uname+"and your age is"+age, uname,age));
            //Console.WriteLine(string.Format("Hello this is string format \t"+
            //    "Hello Mr.{0}, Welcome to the club and your age is {1}" , uname,age
            //    ));
            //decimal price  =2.5m;
            //Console.WriteLine(string.Format("Currency Format:{0:C2}",price));

            DateTime todaydate = DateTime.Now;
            Console.WriteLine(string.Format("Today's date is:{0}",todaydate));


        }
    }
}
