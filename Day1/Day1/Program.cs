using System;

namespace Day1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("***********");
            Console.WriteLine("*          *");
            Console.WriteLine("************");

            Console.WriteLine("Please enter your name");
            string userName = Console.ReadLine();
            Console.WriteLine("Please enter your age");
            string age = Console.ReadLine();
            Console.WriteLine("Hi {0}! You are {1} years old", userName,age);

            int i = 10;
            Console.WriteLine("{0}*4={1}", i, i * 4);

            Console.WriteLine("Please enter your salary");
            double salary = Convert.ToDouble(Console.ReadLine());                                     // Convert string to double
            double tax = 0.05 * salary;
            Console.WriteLine("Your salary is {0:0,0.00}, your tax is {1:0,0.00}",salary,tax);        //format
            Console.WriteLine("Your salary is {0:0,0.##}, your tax is {1:0,0.##}", salary, tax);      //##:optional
            Console.WriteLine("Your salary is {0:#,###.00}, your tax is {1:#,###.00}", salary, tax);
            Console.WriteLine("Your salary is {0:c}, your tax is {1:c}", salary, tax);



        }
    }
}