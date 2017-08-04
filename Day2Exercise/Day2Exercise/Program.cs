using System;

namespace Day2Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Day 2 Exercises");
            Console.WriteLine("SectionB");
            Console.WriteLine("Exercise1");
            Console.WriteLine("Please enter a number");
            double number = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the square root of the number is {0}",Math.Sqrt(number));
                       
            Console.WriteLine("Exercise2");
            Console.WriteLine("Please enter a number");
            double number2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("the square root of the number is {0:0.000}", Math.Sqrt(number2));
            
            
            Console.WriteLine("Exercise3");
            Console.WriteLine("Please enter your salary");
            double salary = Convert.ToDouble(Console.ReadLine());
            double income = salary + 0.1 * salary + 0.03 * salary;
            Console.WriteLine("Your income is {0}", income);
            
            
            Console.WriteLine("Exercise4");
            Console.WriteLine("Please enter a temperature (Centigrade scale)");
            double TempC = Convert.ToDouble(Console.ReadLine());
            double TempF = TempC * 1.8 + 32;
            Console.WriteLine("The Tempertaure of Fahrenheit is {0}", TempF);

            
            Console.WriteLine("Exercise5");
            Console.WriteLine("Please enter a number");
            double number5 = Convert.ToDouble(Console.ReadLine());
            double output = Math.Pow(number5, 2) * 5 - 4 * number5 + 3;
            Console.WriteLine("The output is {0}",output);
            

            Console.WriteLine("Exercise6");
            Console.WriteLine("Please enter your x1");
            double x1= Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your y1");
            double y1 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your x2");
            double x2 = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter your y2");
            double y2 = Convert.ToDouble(Console.ReadLine());
            double pow1 = Math.Pow((x1 - x2), 2);
            double pow2 = Math.Pow((y1 - y2), 2);
            double distance = Math.Sqrt(pow1+pow2);
            Console.WriteLine("The distance is {0}",distance);
            
            
            Console.WriteLine("Exercise7");
            Console.WriteLine("Please enter the distance you travalled (km)");
            double meter = Convert.ToDouble(Console.ReadLine());
            double fare = 2.40 + 0.4 * meter;
            Console.WriteLine("Your fare would be ${0}",fare);
            
            
            Console.WriteLine("Exercise8");
            Console.WriteLine("Please enter the distance you travalled (km)");
            double meter2 = Convert.ToDouble(Console.ReadLine());
            double fare2 = Math.Round ((2.4 + 0.4 * meter2),1);
            Console.WriteLine("Your fare would be ${0:0.00}", fare2);
                      
            Console.WriteLine("Exercise9");
            Console.WriteLine("Please enter the distance you travalled (km)");
            double meter3 = Convert.ToDouble(Console.ReadLine());

            double fare3 = Math.Ceiling (10*(2.4 + 0.4 * meter3))/10;
            Console.WriteLine("Your fare would be ${0:0.00}", fare3);
            
            
            Console.WriteLine("Exercise10");
            Console.WriteLine("Please enter a");
            double a = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter b");
            double b = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter c");
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) / 2;

            if (s * (s - a) * (s - b) * (s - c) >= 0)
            {
                Console.WriteLine("The area is{0}", Math.Sqrt(s * (s - a) * (s - b) * (s - c)));
            }else {
                Console.WriteLine("NaN");
            }
            
            
            Console.WriteLine("SectionC");
            Console.WriteLine("Exercise1");
            Console.Write("Please enter yur name");
            string name = Console.ReadLine();
            Console.Write("Please enter your gender M/F:");
            string gender = Console.ReadLine();
            if (gender == "M")
            {
                Console.WriteLine("Good Morning Mr.{0}", name);
            }
            else if (gender == "F")
            {
                Console.WriteLine("Good Morning Ms.{0}", name);
            }
            else {
                Console.WriteLine("Error!");
            }
            
            Console.WriteLine("Exercise2");
            Console.Write("Please enter yur name");
            string name2 = Console.ReadLine();
            Console.Write("Please enter your gender M/F:");
            string gender2 = Console.ReadLine();
            Console.Write("Please enter your age:");
            int age2 = Convert.ToInt32(Console.ReadLine());
            if (gender2 == "M")
            {
                if (age2>=40) {
                    Console.WriteLine("Good Morning Uncle {0}", name2);
                } else {
                    Console.WriteLine("Good Morning Mr.{0}", name2);
                }
                
            }
            else if (gender2 == "F")
            {
                if (age2 >= 40)
                {
                    Console.WriteLine("Good Morning Aunty {0}", name2);
                }
                else
                {
                    Console.WriteLine("Good Morning Ms.{0}", name2);
                }
            }
            else
            {
                Console.WriteLine("Error!");
            }
            
            Console.WriteLine("Exercise3");
            Console.WriteLine("Please enter your mark");
            double mark = Convert.ToDouble(Console.ReadLine());
            if (mark > 100 || mark < 0)
            {
                Console.WriteLine("Error!");
            }
            else if (mark >= 80)
            {
                Console.WriteLine("A");
            }
            else if (mark >= 60)
            {
                Console.WriteLine("B");
            }
            else if (mark >= 40)
            {
                Console.WriteLine("C");
            }
            else {
                Console.WriteLine("F");
            }
            */
            
            Console.WriteLine("Exercise4");
            Console.WriteLine("Please enter your meter");
            double meter4 = Convert.ToDouble(Console.ReadLine());
            Calculator cal = new Calculator();
            double fare4 = cal.FareCalculator(meter4);
            Console.WriteLine(fare4);

            /*
            Console.WriteLine("Exercise5");
            Console.WriteLine("Please enter a 3-digit number");
            string input = Console.ReadLine();
            int digit1= Convert.ToInt32(input.Substring(0, 1));
            int digit2 = Convert.ToInt32(input.Substring(1, 1));
            int digit3 = Convert.ToInt32(input.Substring(2, 1));
            int number5 = Convert.ToInt32(input);
            Console.WriteLine("{0},{1},{2}",digit1,digit2,digit3);           
            double b = Math.Pow(digit1, 3);
            double c = Math.Pow(digit2, 3);
            double d = Math.Pow(digit3, 3);
            if (number5 == b + c + d)
            {
                Console.WriteLine("True");
            }
            else
            {
                Console.WriteLine("False");
            }
            */






































        }
    }
    class Calculator
    {
        public double FareCalculator(double meter)
        {
            double fare = 0;
            if (meter <= 0.5)
            {
                fare = 2.4;
            }
            else if (meter <= 9)
            {
                fare = 2.4 + 0.04 * (10*(meter - 0.5));
            }
            else
            {
                fare = 2.4 + 0.04 *85 + (meter* 10 - 90) * 0.05;
            }
            return fare;
        }
    }

    

       
    
        
        
           
    }

    
