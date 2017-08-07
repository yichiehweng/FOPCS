using System;

namespace Day3Exercise
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Excercise1");
            Console.Write("Please enter a number:");
            string input = Console.ReadLine();
            Excercise e1 = new Excercise();
            e1.Excercise1(input);
            
            Console.WriteLine("Excercise2");
            Console.Write("Please enter a numberA:");
            int inputA = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter a numberB:");
            int inputB = Convert.ToInt32(Console.ReadLine());
            Excercise e2 = new Excercise();
            int LCM = e2.EuclidAlgorithm(inputA, inputB);
            Console.WriteLine("LCM is {0}", LCM);
            
            Console.WriteLine("Excercise3");
            Excercise e3 = new Excercise();
            e3.GuessGame();
            
            Console.WriteLine("Excercise4");
            Excercise e4 = new Excercise();
            e4.SquareRootFinder();
            
            Console.WriteLine("Excercise1");
            Excercise e5 = new Excercise();
            e5.Factorial();
            e5.Factorial2();
            
            Console.WriteLine("Excercise2");
            Excercise e6 = new Excercise();
            e6.Printer();
            
            Console.WriteLine("Excercise3");
            Excercise e7 = new Excercise();
            Console.Write("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPrime = e7.CalcIsPrime(number);
            Console.WriteLine(isPrime);
            
            Console.WriteLine("Excercise4");
            Excercise e8 = new Excercise();
            Console.Write("Please enter a number:");
            int number = Convert.ToInt32(Console.ReadLine());
            bool isPerfect = e8.CalcIsPerfect(number);
            Console.WriteLine(isPerfect);
            
            Excercise e9 = new Excercise();
            e9.PrimePrinter();
            
            Excercise e10 = new Excercise();
            e10.PerfectPrinter();
            
            Excercise e11 = new Excercise();
            Console.WriteLine("Please enter a phase:");
            string input = Console.ReadLine();
            e11.VowelCounter(input);
            
            Excercise e12 = new Excercise();
            Console.WriteLine("Please enter a phase:");
            string input = Console.ReadLine();
            bool ans = e12.Palindrome(input);
            Console.WriteLine(ans);
            */

        }
        class Excercise
        {
            public void Excercise1(string input)
            {
                while (input != "88")
                {
                    Console.Write("Please enter a number again:");
                    input = Console.ReadLine();
                }
                Console.WriteLine("Lucky you...");
            }
            public int EuclidAlgorithm(int inputA, int inputB)
            {
                int A = inputA;
                int B = inputB;
                int LCM = 0;
                int HCF = 0;
                while (inputA != inputB)
                {
                    int changer = Math.Abs(inputA - inputB);
                    if (inputA > inputB)
                    {
                        inputA = changer;
                    }
                    else
                    {
                        inputB = changer;
                    }
                }
                HCF = inputA;
                return LCM = (A * B) / HCF;
            }
            public void GuessGame()
            {
                Random rnd = new Random();
                int ans = rnd.Next(0, 10);
                int i = 0;
                bool currectGuess= false;
                do
                {
                    Console.Write("Please enter a number you guess(0-9):");
                    int number = Convert.ToInt32(Console.ReadLine());
                    if (ans == number)
                    {
                        currectGuess = true;
                    }
                    i++;

                }
                while (currectGuess == false);


                if (i <= 2)
                {
                    Console.WriteLine("Correct!You are a Wizard!");
                }
                else if (i <= 5)
                {
                    Console.WriteLine("Correct!You are a good guess.");
                }
                else if (i <= 8)
                {
                    Console.WriteLine("Correct!You are lousy!");
                }
                else
                {
                    Console.WriteLine("Correct!");
                }


            }
            public void SquareRootFinder() {
                Console.Write("Please enter number:");
                int N = Convert.ToInt32(Console.ReadLine());
                Random rnd = new Random();
                bool isCorrect = false;
                
                    for (int i = 0; i < N; i++)
                    {
                        if (i * i == N)
                        {
                            Console.WriteLine(i);return;
                        }
                    }
                
                while (isCorrect == false)
                {
                    double G = rnd.NextDouble() * (N - 1) + 1;
                    double formula = Math.Abs(G - (G + N / G) / 2);
                    double number=Math.Round(formula*10000)/10000;
                    if (number == 0)
                    {
                        isCorrect = true; 
                    }
                    if (isCorrect == true)
                    {
                        Console.WriteLine("{0:,0.000}", G);
                    }
                }
                
                

            }
            public void Factorial() {
                Console.Write("Please enter an integer:");
                int number = Convert.ToInt32(Console.ReadLine());
                int ans = 1;
                for(int i = 1; i <= number; i++)
                {
                    ans=ans*i;
                }
                Console.WriteLine(ans);
            }
            public void Factorial2()
            {
                Console.Write("Please enter an integer:");
                int number = Convert.ToInt32(Console.ReadLine());
                int ans = 1;
                for (int i = number; i>0; i--)
                {
                    ans = ans * i;
                }
                Console.WriteLine(ans);
            }
            public void Printer() {
                Console.Write("Please enter an integer:");
                int number = Convert.ToInt32(Console.ReadLine());
                for (int i = 1;i<= number; i++) {
                    double inverse=1/(double)i;
                    double squareRoot = Math.Sqrt(i);
                    double square = Math.Pow(i, 2);
                    Console.WriteLine("number:{0},inverse number:{1},squareQoot:{2},square:{3}",i,inverse,squareRoot,square);
                }
            }
            public bool CalcIsPrime(int number)
            {

                if (number == 1) return false;
                if (number == 2) return true;

                if (number % 2 == 0) return false; // Even number     

                for (int i = 2; i < number; i++)
                { // Advance from two to include correct calculation for '4'
                    if (number % i == 0) return false;
                }

                return true;

            }
            public bool CalcIsPerfect(int number) {
                bool isPerfect = false;
                int k = 0;
                for(int i = 1; i < number; i++)
                {
                    if (number % i == 0)
                    {
                        k=k + i;
                    }
                }
                if (k == number)
                {
                    isPerfect = true;
                }
                return isPerfect;
            }
            public void PrimePrinter()
            {
                
                for (int i = 5; i<= 1000; i=i+2) {
                    bool isPrime = true;
                    for (int j = 3; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            isPrime = false;break;
                        }
                    }
                    if (isPrime == true)
                    {
                        Console.WriteLine(i);
                    }
                }
            }
            public void PerfectPrinter()
            {
                for (int i=1; i <= 1000; i++)
                {
                    bool isPerfect = false;
                    int k = 0;
                    for (int j = 1; j < i; j++)
                    {
                        if (i % j == 0)
                        {
                            k = k + j;
                        }
                    }
                    if (k == i)
                    {
                        isPerfect = true;
                    }
                    if (isPerfect == true)
                    {
                        Console.WriteLine(i);
                    }
                    
                }
            }
            public void VowelCounter(string phase) {
                char[] chars = phase.ToCharArray();
                int counterA = 0,counterE=0,counterI=0,counterO=0,counterU=0,total=0;
                for (int i = 0; i< chars.Length; i++)
                {
                    if(chars[i] =='A'|| chars[i] == 'a')
                    {
                        counterA++;
                    }
                }
                Console.WriteLine(counterE);
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 'E' || chars[i] == 'e')
                    {
                        counterE++;
                    }
                }
                Console.WriteLine(counterE);
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 'I' || chars[i] == 'i')
                    {
                        counterI++;
                    }
                }
                Console.WriteLine(counterI);
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 'O' || chars[i] == 'o')
                    {
                        counterO++;
                    }
                }
                Console.WriteLine(counterO);
                for (int i = 0; i < chars.Length; i++)
                {
                    if (chars[i] == 'U' || chars[i] == 'u')
                    {
                        counterU++;
                    }
                }
                Console.WriteLine(counterU);
                total = counterA + counterE + counterI + counterO + counterU;
                Console.WriteLine(total);


            }
            public bool Palindrome(string phase)
            {
                string first = phase.Substring(0, phase.Length / 2);
                char[] arr = phase.ToCharArray();
                Array.Reverse(arr);
                string temp = new string(arr);
                string second = temp.Substring(0, temp.Length / 2);
                return first.Equals(second);

            }


        }
    }
}