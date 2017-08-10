using System;

namespace Day4
{
    class Program
    {
        static void Main(string[] args)
        {
            Lecture e1 = new Lecture();
            //e1.Quiz();
            //e1.QuizVersion2();
            //e1.BreakExample();
            //e1.ContinueExample();
            //e1.DoubleLoopContinueExample();
            //e1.DoubleLoopBreakExample();
            //e1.SelectionSort();
            //e1.ArrayResize();
            Exercise e2 = new Exercise();
            //e2.SectionF_Q3();
            //e2.SectionF_Q4();
            //e2.SectionF_Q5();
            //e2.SectionF_Q6();
            //e2.SectionG_Q1();
            //e2.SectionG_Q2();
            //e2.SectionG_Q3();
            //e2.test();
        }
    }

    class Lecture
    {
        public void Quiz()
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            string correctPIN = "123456";
            Console.Write("Please enter your PIN:");
            string enterPIN = Console.ReadLine();
            for (int i = 0; i < 2; i++)
            {
                
                if (correctPIN == enterPIN)
                {
                    Console.WriteLine("PIN accepted. You can access your account now."); return;
                }
                else
                {
                    Console.Write("Incorrect PIN.Please try again:");
                    enterPIN = Console.ReadLine();
                }
            }
            Console.WriteLine("Too many wrong enters. Your account is now locked.");

        }
        public void QuizVersion2()
        {
            Console.WriteLine("Welcome to the Bank of ISS");
            int numReteies = 0;
            bool correctPIN = false;
            string PIN = "123456";
            Console.Write("Please enter your PIN:");
            do
            {
                string input = Console.ReadLine();
                numReteies++;
                if (input == PIN)
                {
                    correctPIN = true;
                }else if(!correctPIN&& numReteies < 3)
                {
                    Console.Write("Incorrect PIN.Please try again:");
                }

               
            } while (numReteies<3&& correctPIN==false);
            if (correctPIN)
            {
                Console.WriteLine("PIN accepted. You can access your account now.");
            }
            else
            {
                Console.WriteLine("Too many wrong enters. Your account is now locked.");
            }
            
           
        }
        public void BreakExample()//Break:break away from the currect loop
        {
            for (int i=0;i<5;i++)
                {
                if (i == 3)
                {
                    break;
                }
                Console.WriteLine(i);
                }
            Console.WriteLine("End of Program.");
        }
        public void ContinueExample()//Continue: continue to the next loop
        {
            for (int i = 0; i < 5; i++)
            {
                if (i == 3)
                {
                    continue;
                }
                Console.WriteLine(i);
            }
            Console.WriteLine("End of Program.");
        }
        public void DoubleLoopContinueExample()
        {
            for(int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 3)
                    {
                        continue;
                    }
                    Console.WriteLine("{0}-{1}",j,i);
                }
            }  
            Console.WriteLine("End of Program.");
        }
        public void DoubleLoopBreakExample()
        {
            for (int j = 0; j < 3; j++)
            {
                for (int i = 0; i < 5; i++)
                {
                    if (i == 3)
                    {
                        break;
                    }
                    Console.WriteLine("{0}-{1}", j, i);
                }
            }
            Console.WriteLine("End of Program.");
        }
        public void Arrays()
        {
            int[] A;
            int[] Sales;
            int[] C, D;
            double[] E;
            string[] EmployeeName;
            A = new int[5];
            Sales = new int[12];
            C = new int[10];
            D = new int[10];
            EmployeeName = new string[25];
            E = new double[5];
        }
        public void Arrays2() {
            int[] A = new int[5] { 12, 3, 8, 45, 2 };
            double[] E = new double[5] { 10.0, 5.3, 6.9, 0.0, 2 };
            string[] EmpName = new string[3] { "Venkat", "John", "Sabina" };
            Console.WriteLine(A[5]);
            A[5] = 20;
            Console.WriteLine(A[5]);
            
        }
        public void Arrays3()
        {
            int[] Marks = new int[5];
            string[] StudentName = new string[3]{"Venkat", "John", "Sabina"};
            int i;
            double ClassAvg;
            Marks[0] = 35;
            Marks[1] = 82;
            Marks[2] = 67;
            ClassAvg = (Marks[0] + Marks[1] + Marks[2]) / 3.0;
            for (i = 0; i <= 2; i++)
            {
                Console.WriteLine("{0}\t{1}\t{2}", i, StudentName[i], Marks[i]);
            }     
            Console.WriteLine("Average Marks for Class is {0}", ClassAvg);
        }
        public void SelectionSort()//selects the smallest element and places it in the first element by swapping the elements
        {
            int[] items = new int[] { 34, 72, 24, 16, 95, 43, 34, 67, 22, 51 };
            for(int green=0; green <= items.Length - 1; green ++)
            {
                for(int red=green+1;red<=items.Length-1;red++)
                {
                    if (items[green] > items[red])
                    {
                        //swap
                        int changer = items[green];
                        items[green] = items[red];
                        items[red] = changer;
                    }
                }
            }
            for(int i=0; i <= items.Length - 1; i++)
            {
                Console.Write("{0}",items[i]);
                if (i < items.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
        public void ArrayResize()
        {
            int[] A = new int[5] { 12, 3, 8, 45, 2 };
            //A[6]=9: Error Out of Bound
            //change of arraysize
            Array.Resize<int>(ref A, 7);
            A[6] = 9;
            Console.WriteLine(A[6]);

        }
        public void MutiDimentionalArray()
        {
            int[,] Marks = new int[3, 2];
            Marks[0, 0] = 35; Marks[0, 1] = 82;
            Marks[1, 0] = 67; Marks[1, 1] = 45;
            Marks[2, 0] = 62; Marks[2, 1] = 77;

            int[,] Marks2 = new int[,] { { 35, 82 }, 
                                         { 67, 45 }, 
                                         { 62, 77 } }; 
        }
    }

    class Exercise
    {
        public void SectionF_Q3()
        {
            Console.Write("Please enter a phase:");
            String input = Console.ReadLine();
            /*
            string[] c = { " ",",","."};
            foreach(string  i in c)
            {
                phase = phase.Replace(i, string.Empty).ToLower();
            }
            */
            char[] c = { ' ', ',', '.' };
            string[] s = input.Split(c);
            string output = "";
            for (int i = 0; i < s.Length; i++)
            {
                output = output + s[i];
            }
            string phase = output.ToLower();
            string first = phase.Substring(0, phase.Length / 2);
            char[] arr = phase.ToCharArray();
            Array.Reverse(arr);
            string temp = new string(arr);
            string second = temp.Substring(0, temp.Length / 2); 
            Console.WriteLine(first.Equals(second));
        }
        public void SectionF_Q4()
        {
            Console.Write("Please enter a phase you would like to convert:");
            string s = Console.ReadLine();
            string[] ss = s.Split(' ');

            for (int i = 0; i <= ss.Length - 1; i++)
            {
                string b = ss[i].Substring(0, 1).ToUpper() + ss[i].Substring(1);
                Console.Write("{0} ", b);
            }




        }
        public void SectionF_Q5()
        {
            string[] names = new string[] { "John", "Venkat", "Mary", "Victor", "Betty" };
            int[] marks = new int[] { 63, 29, 75, 82, 55 };
            Console.WriteLine("sorted Student marks:");
            Array.Sort(marks);
            for (int i = marks.Length - 1; i >= 0; i--)
            {
                Console.Write("{0},", marks[i]);
            }
            Console.WriteLine("sorted Student names:");
            Array.Sort(names);
            for (int i = 0; i < names.Length; i++)
            {
                Console.Write("{0},", names[i]);
            }
        }
        public void SectionF_Q6()
        {
            Console.Write("Please enter your matriculation number:");
            string input = Console.ReadLine().ToUpper();
            bool validatiion = false;
            if (input.Length == 7)
            {

                int number1 = Convert.ToInt32(input.Substring(1, 1));
                int number2 = Convert.ToInt32(input.Substring(2, 1));
                int number3 = Convert.ToInt32(input.Substring(3, 1));
                int number4 = Convert.ToInt32(input.Substring(4, 1));
                int number5 = Convert.ToInt32(input.Substring(5, 1));
                int sum = number1 * 6 + number2 * 5 + number3 * 4 + number4 * 3 + number5 * 2;
                int reminder = sum % 5;
                string chectSum = input.Substring(6, 1);
                switch (reminder)
                {
                    default: validatiion = true;break;
                    case 0: if (chectSum == "O")
                        {
                            validatiion = true;
                        }
                        else
                        {
                            validatiion = false;
                        }break;
                    case 1:
                        if (chectSum == "P")
                        {
                            validatiion = true;
                        }
                        else
                        {
                            validatiion = false;
                        }
                        break;
                    case 2:
                        if (chectSum == "Q")
                        {
                            validatiion = true;
                        }
                        else
                        {
                            validatiion = false;
                        }
                        break;
                    case 3:
                        if (chectSum == "R")
                        {
                            validatiion = true;
                        }
                        else
                        {
                            validatiion = false;
                        }
                        break;
                    case 4:
                        if (chectSum == "S")
                        {
                            validatiion = true;
                        }
                        else
                        {
                            validatiion = false;
                        }
                        break;

                }
            }
            else
            {
                validatiion = false; return;
            }
            if (validatiion == true)
            {
                Console.WriteLine("Valid");
            }
            else
            {
                Console.WriteLine("Invalid");
            }
        }
        public bool Tryparse(String s)
        {
            int value = 0;
            bool isParsable = Int32.TryParse(s, out value);
            return isParsable;
        }
        public void SectionG_Q1()
        {
            string[] months = new string[] { "Jan", "Feb", "Mar", "Apr", "May","Jun","Jul","Aug","Set","Oct","Nov","Dec" };
            int[] qtys = new int[12];
           
            Console.WriteLine("Please take in the sales for the 12 months");
                for (int i = 0; i < qtys.Length; i++)
            {
                qtys[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int green = 0; green <= qtys.Length - 1; green++)
            {
                for (int red = green + 1; red <= qtys.Length - 1; red++)
                {
                    if (qtys[green] > qtys[red])
                    {
                        //swap
                        int changer = qtys[green];
                        qtys[green] = qtys[red];
                        qtys[red] = changer;

                        string changer2 = months[green];
                        months[green] = months[red];
                        months[red] = changer2;
                    }
                }
            }


            double sum = 0;
            for (int i = 0; i < qtys.Length; i++)
            {
                sum = sum + qtys[i];
            }
            double sumAvg = sum / qtys.Length;

            Console.WriteLine("Maximum Sales:{0} aty:{1}",qtys[qtys.Length-1],months[months.Length-1]);
            Console.WriteLine("Minimum Sales:{0} aty:{1}", qtys[0], months[0]);
            Console.WriteLine("the average monthly sales would be:{0}",sumAvg);

        }
        public void SectionG_Q2()
        {
            int[] items = new int[] { 34, 72, 24, 16, 95, 43, 34, 67, 22, 51 };
            for (int green = 0; green <= items.Length - 1; green++)
            {
                for (int red = green + 1; red <= items.Length - 1; red++)
                {
                    if (items[green] < items[red])
                    {
                        //swap
                        int changer = items[green];
                        items[green] = items[red];
                        items[red] = changer;
                    }
                }
            }
            for (int i = 0; i <= items.Length - 1; i++)
            {
                Console.Write("{0}", items[i]);
                if (i < items.Length - 1)
                {
                    Console.Write(",");
                }
            }
        }
        public void SectionG_Q3()
        {
            Console.WriteLine("Please enter the subject number:");
            int subjectNumber=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the student number:");
            int studentNumber = Convert.ToInt32(Console.ReadLine());
            double[,] marks= new double[studentNumber, subjectNumber];
           for(int j = 0; j < subjectNumber; j++)
            {
                for(int i = 0;i < studentNumber; i++)
                {
                    Console.WriteLine("Please enter subject{0}'s marks for student{1}:",j+1,i+1);
                    marks[i, j] = Convert.ToDouble(Console.ReadLine());
                }
            }
            //Compute the total marks obtained each student
            double[] sum = new double[studentNumber];
            
            for(int j=0; j < subjectNumber; j++)
            {
                for (int i = 0; i < studentNumber; i++)
                {
                    sum[i] = sum[i] + marks[i, j];
                }   
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine("Student{0}'s total marks would be {1}.",i+1,sum[i]);
            }
            //Compute the class average of Marks for each student.
            double[] average = new double[studentNumber];
            for (int i = 0; i < average.Length; i++)
            {
                average[i] = sum[i] / subjectNumber;
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine("Student{0}'s average marks would be {1}.", i + 1, average[i]);
            }

            //Compute the standard deviation of Marks for each student.
            double[] var = new double[studentNumber];
            for (int i = 0; i < studentNumber; i++)
            {
                for (int j = 0; j < subjectNumber; j++)
                {
                    var[i] = var[i]+Math.Pow(marks[i, j] - average[i], 2);
                }
            }
            double[] sd = new double[studentNumber];
            for (int i = 0; i < average.Length; i++)
            {
                sd[i] = Math.Sqrt(var[i] / subjectNumber);
            }
            for (int i = 0; i < sum.Length; i++)
            {
                Console.WriteLine("Student{0}'s sd would be {1}.", i + 1, sd[i]);
            }

            //overall average of marks for the whole class for each subject
            double[] subjectAverage = new double[subjectNumber];
            double[] subjectSum = new double[subjectNumber];
            for (int i = 0; i < studentNumber; i++)
            {
                for (int j = 0; j < subjectNumber; j++)
                {
                    subjectSum[j] = subjectSum[j] + marks[i, j];
                }
            }
            for (int i = 0; i < subjectAverage.Length; i++)
            {
                subjectAverage[i] = subjectSum[i] / studentNumber;
            }
            for (int i = 0; i < subjectSum.Length; i++)
            {
                Console.WriteLine("Subject{0}'s average marks would be {1}.", i + 1, subjectAverage[i]);
            }



        }
        public void test()
        {
            Console.Write("Please enter a phase:");
            String phase = Console.ReadLine();
            char[] c = { ' ', ',', '.' };
            string[] s=phase.Split(c);
            string output = "";
            for(int i = 0; i < s.Length; i++)
            {
                output = output + s[i];
            }
            Console.WriteLine(output.ToLower());
            
        }
    }
}