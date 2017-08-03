using System;

namespace Day1Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Exercise1");
            Console.WriteLine("Yi-Chieh Weng");
            Console.WriteLine("yichieh.weng@gmail.com");

            Console.WriteLine("**********************");
            Console.WriteLine("Exercise2");
            Console.WriteLine("Pleasr enter your name");
            string userName=Console.ReadLine();
            Console.WriteLine("Good Morning {0}",userName);

            Console.WriteLine("**********************");
            Console.WriteLine("Exercise3");
            Console.WriteLine("Pleasr enter an interger");
            int number =Convert.ToInt32( Console.ReadLine());
            Console.WriteLine(number*number);

            Console.WriteLine("**********************");
            Console.WriteLine("Exercise4");
            Console.WriteLine("Pleasr enter an number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine(number2 * number2);

            Console.WriteLine("**********************");
            Console.WriteLine("Exercise5");
            Console.WriteLine("Pleasr enter an number");
            double number3 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("{0:0.00}",number3);




        }
    }
}