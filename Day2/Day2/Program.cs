using System;

namespace Day2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Hello World!");
            Console.WriteLine("a \n b \n c \n d \n");             //New line:\n
            Console.WriteLine("No \t Name");                      // horizontal Tab:\t
            Console.WriteLine("Install your file in C:\\ drive"); //backslash :C:\\ not C:\
            Console.WriteLine("The monther says:\"Stop!\"");      // \": Double Quote

            int x = 20;
            int y = 3;
            Console.WriteLine("20/3={0}",x/y);                   // output=6 (integer division)
            Console.WriteLine(1.0*x / y);                        //become double division
            Console.WriteLine("reminder:{0}",x%y);               //output=2 (remainder)
            double xx = 20.0;
            double yy = 3.0;
            Console.WriteLine(xx / yy);                          // output=6.6(double division)
            Console.WriteLine(xx % yy);

            int a = 1;
            Console.WriteLine(a);
            Console.WriteLine(a++);                             //write,then increasement output=1
            Console.WriteLine(++a);                             // increasement, the write output=2

            //round example
            double xxx= 3.298423;
            Console.WriteLine(Math.Round(xxx, 2));              //2 decimal
            Console.WriteLine(Math.Round(xxx, 1));
            Console.WriteLine(Math.Round(xxx, 0));
            Console.WriteLine(Math.Round(xxx, 5));

            Console.WriteLine(Math.Floor(xxx));                // no decimal
            Console.WriteLine(Math.Floor(10*xxx)/10);          // if want floor to 1 decimal
            */

            //ifelse
            /*
           Console.WriteLine("Please entr a number below 10");
           int number =Int32.Parse(Console.ReadLine());
           if (number < 10){                                  //recommadation
               Console.WriteLine("True");
           }
           else {
               Console.WriteLine("Error!!");
           }

           if (number < 10)                                   // not allow second line          
               Console.WriteLine("True");
           else 
               Console.WriteLine("Error!!");
           */
            /*
             //More than one condition
             Console.Write("Please enter your grade:");
             double noGrade = Double.Parse(Console.ReadLine());
             string grade="";
             if (noGrade > 85){
                 grade = "A+";
             }else if (noGrade >= 80){
                 grade = "A";
             }else if (noGrade >= 75){
                 grade = "A-";
             }else if (noGrade >= 70){
                 grade = "B+";
             } else if (noGrade >= 65){
                 grade = "B";
             }else{
                 grade = "F";
             }
             Console.WriteLine("your grade is {0}",grade);
             */
            //Switch-case
            Console.Write("Enter a number:(0-6)");
            int no = Int32.Parse(Console.ReadLine());
            string day = "";
            switch (no) {
                case 0: day = "Sunday";break;
                case 1: day = "Monday"; break;
                case 2: day = "Tuesday"; break;
                case 3: day = "Wednesday"; break;
                case 4: day = "Thursday"; break;
                case 5: day = "friday"; break;
                case 6: day = "Saturday"; break;
                default: day = "NA"; break;
            }
            Console.WriteLine(day);





        }
    }
}