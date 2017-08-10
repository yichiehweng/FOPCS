using System;

namespace Day5
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture lecture = new Lecture();
            //lecture.Quiz();
            //lecture.MethodExample1();
            //lecture.MethodExample2();
            //lecture.MethodExample3();
            //lecture.MethodExample4();
            //lecture.MethodExample5();
            //lecture.MethodExample6();
            Excercise e = new Excercise();
            //e.SectionHQ1();
            //e.SectionHQ2();
            //e.SectionHQ3();
            //e.SectionHQ4();
            //e.SectionHQ5();
            //e.SectionHQ6();
            //e.SectionHQ7();
            //e.SectionHQ8();
            //e.SectionHQ9();
            //e.SectionHQ10();
            //e.SectionHQ11();
        }
        
    }
    class Lecture
    {
        public void Quiz()
        {
            int[,] theArray = new int[,]
            {
                {5,3},{2,9},{2,9},{5,1},{7,1},{8,3},{0,3},{2,2},{9,7}
            };
            int count = 0;
            Console.Write("Please enter a number (0-9):");
            int input = Convert.ToInt32(Console.ReadLine());
            //Remember to use variable "input" 
            //Length=total element(18 in this case)
            //getLength(0),getLength(1):9,1
            //i=row j=col
            for(int i = 0; i < theArray.GetLength(0); i++)
            {
                for(int j = 0; j < theArray.GetLength(1); j++)
                {
                    if (input == theArray[i, j])
                    {
                        count++;
                    }
                }
            }
           

            if (count<= 0) {
                Console.WriteLine("There is no {0} in the array.", input);
            } else {
                Console.WriteLine("The number of {0} is {1}.",input,count);
            }
        }
        public void MethodExample1()
        {
            int[,] theArray = new int[,]
           {
                {5,3},{2,9},{2,9},{5,1},{7,1},{8,3},{0,3},{2,2},{9,7}
           };

            Methods method = new Methods();
            int input = method.GetInput();
            int count = method.CounterInArray(theArray, input);
            method.PrintOutput(count, input);
        }
        public void MethodExample2()//Passing Arguments -By Value
        {
            int number = 100;
            Console.WriteLine("Number={0}", number);//number=100;
            Methods method = new Methods();
            method.Number(number);
            Console.WriteLine("Number={0}", number);//number=100; because no assignment
            number=method.Number(number);
            Console.WriteLine("Number={0}", number);//number=5;


        }
        public void MethodExample3()//Passing Arguments -By reference
        {
            int number = 100;
            Console.WriteLine("Number={0}", number);//number=100;
            Methods method = new Methods();
            method.Number(ref number);
            Console.WriteLine("Number={0}", number);//number=5;
            number = method.Number(number);
            Console.WriteLine("Number={0}", number);//number=5;


        }
        public void MethodExample4()//Passing Arguments -By reference for output
        {
            int number = 100;
            Console.WriteLine("Number={0}", number);//number=100;
            Methods method = new Methods();
            method.Number2(out number);
            Console.WriteLine("Number={0}", number);//number=5;
            number = method.Number(number);
            Console.WriteLine("Number={0}", number);//number=5;


        }
        public void MethodExample5()
        {
            Console.WriteLine("by value(Array)");
            int[] x = new int[] { 100, 200, 300, 400, 500 };
            Console.WriteLine(x[0]);
            Methods method = new Methods();
            method.Array(x);
            Console.WriteLine(x[0]);
            Console.WriteLine("Replace the entire content of areference-type variable.");
            int[] x2 = new int[] { 100, 200, 300, 400, 500 };
            Console.WriteLine(x2[0]);
            method.Array2(x2);
            Console.WriteLine(x2[0]);


        }
        static double taxRate = 0.07;// class variable
        public void MethodExample6()
        {
            Methods methods = new Methods();
            int amount = methods.ReadInteger("Please enter the amount:");
            Console.Write("enter tax rate:");
            taxRate = Double.Parse(Console.ReadLine());
            double total = TaxCalculator(amount);
            Console.WriteLine("total amount:{0}",total);
        }//class variables example
        public double TaxCalculator(double amount)
        {
            return amount * taxRate+amount; 
        }
    }
    class Excercise
    {
        public void SectionHQ1()
        {
            Methods method = new Methods();
            int output = method.IntergerChecker("Please enter a interger:");
            Console.WriteLine(output);

        }
        public void SectionHQ2()
        {
            Methods method = new Methods();
            int[] outputArray=method.ArrayReader();
            method.PrintArray(outputArray);
        }
        public void SectionHQ3()
        {
            Methods method = new Methods();
            string s1 = method.StringReader("Please enter String1");
            string s2 = method.StringReader("Please enter String2");
            bool inString = method.InString(s1, s2);
            Console.WriteLine(inString);
        }
        public void SectionHQ4()
        {
            Methods method = new Methods();
            string s1 = method.StringReader("Please enter String1");
            string s2 = method.StringReader("Please enter String2");
            int index = method.FindWord(s1, s2);
            Console.WriteLine(index);

        }
        public void SectionHQ5()
        {
            Methods method = new Methods();
            int x = method.IntergerChecker("Please enter a integer:");
            string ans = method.Hexadecimal(x);
            Console.WriteLine(ans);

        }
        public void SectionHQ6()
        {
            Methods method = new Methods();
            string s = method.StringReader("Please enter a string:");
            char c1 = method.CharReader("Please enter a char you would like to replace:");
            char c2 = method.CharReader("Please enter the replace char:");
            string output = method.Substitute(s, c1, c2);
            Console.WriteLine(output);
        }
        public void SectionHQ7()
        {
            Methods method = new Methods();
            int[] output = method.ArrayReader();
            method.PrintArray(output);
        }
        public void SectionHQ8()
        {
            Methods method = new Methods();
            int[] input = method.ArrayReader();
            int newSize = method.IntergerChecker("Please enter a new size:");
            int[] newArray = method.ResizeArray(input, newSize);
            method.PrintArray(newArray);

        }
        public void SectionHQ9()
        {
            Methods method = new Methods();
            int number = method.IntergerChecker("Please anter the number:");
            bool isPrime = method.CalcIsPrime(number);
            Console.WriteLine(isPrime);
            method.PrimePrinter();
        }
        public void SectionHQ10()
        {
            Methods method = new Methods();
            int[,] A = method.MatrixReader();
            int[,] B = method.MatrixReader();
            int[,] C = method.MatrixMultiplication(A,B);
            method.MatrixPrinter(C);


        }
        public void SectionHQ11()
        {
            Methods method = new Methods();
            double[] input = method.ArrayReaderDouble();
            double[] output = method.ProcessArray(input,method.DoubleSqrt);
            method.PrintArray(output);

        }
    }
    class Methods
    {
        public int IntergerChecker(string message)
        {
            bool isParsible = false;
            int output = 0;
            do
            {
                Console.Write(message);
                string input = Console.ReadLine();
                isParsible = Int32.TryParse(input, out output);
            }while(isParsible == false);

            return output;
        }
        public int GetInput()
        {
            Console.Write("Please enter a number (0-9):");
            int input = Convert.ToInt32(Console.ReadLine());
            return input;
        }
        public  void PrintOutput(int count, int input) {
            if (count <= 0)
            {
                Console.WriteLine("There is no {0} in the array.", input);
            }
            else
            {
                Console.WriteLine("The number of {0} is {1}.", input, count);
            }
        }
        public int CounterInArray(int[,] theArray, int input)
        {
            int count = 0;
            for (int i = 0; i < theArray.GetLength(0); i++)
            {
                for (int j = 0; j < theArray.GetLength(1); j++)
                {
                    if (input == theArray[i, j])
                    {
                        count++;
                    }
                }
            }
            return count;
        }
        public int ReadInteger(string massage)
        {
            bool isParsible = false;
            int output;
            do {
                Console.Write(massage);
                string input = Console.ReadLine();
                isParsible = Int32.TryParse(input, out output);
            } while (isParsible==false);
            return output;
        }
        public int Number(int x)
        {
            x = 5;
            return x;
        }//by value
        public int Number(ref int x)
        {
            x = 5;
            return x;
        }// by reference
        public int Number2(out int x)// by reference for output
        {
            //Console.WriteLine(x);// connot run
            x = 5;
            return x;
        }// by reference
        public void Array(int[] A)//by value (array)
        {
            Console.WriteLine(A[0]);
            A[0] = 5;                // it will change the value of original values!!!Dangerous, avoid to use it.
            Console.WriteLine(A[0]);
        }
        public void Array2(int[] A)//Replace the entire content of areference-type variable. (array)
        {
            Console.WriteLine(A[0]);
            A = new int[] { 5, 6, 7, 8, 9, 10 };
            Console.WriteLine(A[0]);
        }
        public int[] ArrayReader()
        {
            Console.Write("Please enter the length of the array:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            int[] outputArray = new int[arrayLength];
            for(int i = 0; i < arrayLength; i++)
            {
                Console.Write("Please enter element{0}:", i + 1);
                outputArray[i] = Convert.ToInt32(Console.ReadLine());
            }
            return outputArray;
        }
        public double[] ArrayReaderDouble()
        {
            Console.Write("Please enter the length of the array:");
            int arrayLength = Convert.ToInt32(Console.ReadLine());
            double[] outputArray = new double[arrayLength];
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write("Please enter element{0}:", i + 1);
                outputArray[i] = Convert.ToDouble(Console.ReadLine());
            }
            return outputArray;
        }
        public void PrintArray(int[] arr)
        {
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element {0} is {1}.",i+1,arr[i]);
            }
        }
        public void PrintArray(double[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine("Element {0} is {1}.", i + 1, arr[i]);
            }
        }
        public string StringReader(string message)
        {
            Console.WriteLine(message);
            string outputString = Console.ReadLine();
            return outputString;
        }
        public bool InString(string s1, string s2)
        {
            bool isIn = false;
            s1 = StringTrimer(s1);
            s2 = StringTrimer(s2);
            string[] comparedAarray=new string[s1.Length - s2.Length + 1];
            for(int i = 0; i < comparedAarray.Length; i++)
            {
                comparedAarray[i]=s1.Substring(i,s2.Length);
            }
            for(int i = 0; i < comparedAarray.Length; i++)
            {
                if (s2 == comparedAarray[i])
                {
                    isIn = true; break;
                }
            }

            return isIn; 
        }
        public string StringTrimer(string input)
        {
            string output = "";
            char[] c = {',', '.' };
            string[] s = input.Split(c);
            for (int i = 0; i < s.Length; i++)
            {
                output = output + s[i];
            }
            string phase = output.ToLower();
            return phase;
        }
        public int FindWord(string s1, string s2)
        {
            int index = -1;
            s1 = StringTrimer(s1);
            s2 = StringTrimer(s2);
            string[] comparedAarray = new string[s1.Length - s2.Length + 1];
            for (int i = 0; i < comparedAarray.Length; i++)
            {
                comparedAarray[i] = s1.Substring(i, s2.Length);
            }

            for (int i = 0; i < comparedAarray.Length; i++)
            {
                if (s2 == comparedAarray[i])
                {
                    index = i ;break;
                }
            }
            return index;
        }
        public string Hexadecimal(int input)
        {
            string ans = "0";
           
            if (input ==0)
            {
                ans = "0";
            }
            else {
                int reminder = input % 16;
                int multiply=input / 16;
                switch (reminder)
                {
                    case 0:
                    case 1:
                    case 2:
                    case 3:
                    case 4:
                    case 5:
                    case 6:
                    case 7:
                    case 8:
                    case 9:
                        ans = multiply.ToString() + reminder.ToString();break;
                    case 10:
                        ans = multiply.ToString() + "A"; break;
                    case 11:
                        ans = multiply.ToString() + "B"; break;
                    case 12:
                        ans = multiply.ToString() + "C"; break;
                    case 13:
                        ans = multiply.ToString() + "D"; break;
                    case 14:
                        ans = multiply.ToString() + "E"; break;
                    case 15:
                        ans = multiply.ToString() + "F"; break;

                }
            }
            return ans;
        }
        public string Substitute(string s, char c1, char c2)
        {
            string output=s.Replace(c1, c2);
            return output;
        }
        public char CharReader(string message)
        {
            Console.WriteLine(message);
           char output = Convert.ToChar(Console.ReadLine());
            return output;
        }
        public int[] ResizeArray(int[] arr, int newSize)
        {
            int[] output=new int[newSize];
            if (arr.Length <= output.Length)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    output[i] = arr[i];
                }
            }
            else
            {
                for (int i = 0; i < output.Length; i++)
                {
                    output[i] = arr[i];
                }
            }
            
            return output;
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
        public void PrimePrinter()
        {
            for (int i = 5; i <= 1000; i = i + 2)
            {
                bool isPrime = true;
                for (int j = 3; j < i; j++)
                {
                    if (i % j == 0)
                    {
                        isPrime = false; break;
                    }
                }
                if (isPrime == true)
                {
                    Console.WriteLine(i);
                }
            }
        }
        public int[,] MatrixReader()
        {
            Console.WriteLine("Please enter the column number:");
            int colNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the row number:");
            int rowNumber = Convert.ToInt32(Console.ReadLine());
            int[,] matrix = new int[rowNumber, colNumber];
            for (int j = 0; j < colNumber; j++)
            {
                for (int i = 0; i < rowNumber; i++)
                {
                    Console.WriteLine("Please enter cilumn{0}'s number for row{1}:", j + 1, i + 1);
                    matrix[i, j] = Convert.ToInt32(Console.ReadLine());
                }
            }
            return matrix;
        }
        public int[,] MatrixMultiplication(int[,] A, int[,] B)
        {
            int[,] output=new int[A.GetLength(0),B.GetLength(1)];
           

            for (int j = 0; j < output.GetLength(0); j++)
            {
                for (int i = 0; i < output.GetLength(1); i++)
                {
                    output[i, j] = 0;
                    for (int k = 0; k < A.GetLength(1); k++)
                    {
                        output[i, j] +=A[i, k] * B[k, j];
                    }

                }
            }
            return output;

        }
        public void MatrixPrinter(int[,] A)
        {
            for (int i = 0; i < A.GetLength(0); i++)
            {
                for (int j = 0; j <A.GetLength(1); j++)
                {
                    Console.Write(A[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
        public double DoubleSqrt(double x)
        {
            double output = Math.Sqrt(x);
            return output;
        }
        public delegate double DoubleOps(double x);
        public double[] ProcessArray(double[] arr, DoubleOps ops)
        {
            double[] output = new double [arr.Length];
            for(int i=0;i<output.Length;i++)
            {
                output[i] = ops(arr[i]);
            }
            return output;
        }
        public void HexChanger()
        {
            // Store integer 182
            int intValue = 182;
            // Convert integer 182 as a hex in a string variable
            string hexValue = intValue.ToString("X");
            // Convert the hex string back to the number
            int intAgain = int.Parse(hexValue, System.Globalization.NumberStyles.HexNumber);
            Console.WriteLine(hexValue);
        }
    }
}