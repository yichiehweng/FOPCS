using System;

namespace Day3
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Console.WriteLine("Quiz");
            Console.Write("Number to purchase:");
            int qty = Convert.ToInt32(Console.ReadLine());
            Excercise q1 = new Excercise();
            double total = q1.Quiz(qty);
            Console.WriteLine("The price would be ${0:0,0.00}",total);
             
            Excercise e1 = new Excercise();
            e1.ForLoop();
            e1.ForLoopForString();
            
            Console.WriteLine("While_Loop:");
            Console.Write("Please enter how many you want to repeat:");
            int j = Convert.ToInt32(Console.ReadLine());
            Excercise e2 = new Excercise();
            e2.WhileLoop(j);
            
            Console.WriteLine("Tryparse:");
            Excercise e3 = new Excercise();
            e3.TryParse();
            
            Console.WriteLine("Tryparse2:");
            Excercise e4 = new Excercise();
            e4.TryParse2();
            
            Console.WriteLine("RandomNumber:");
            Excercise e5 = new Excercise();
            e5.Random();
            
            Excercise e6 = new Excercise();
            e6.GuessGame();
            
            Excercise e7 = new Excercise();
            e7.StringComparedTo();
            e7.StringTrim();
            
            Excercise e8 = new Excercise();
            e8.StringSubstring();
            e8.StringInsert();
            e8.StringPad();
            e8.StringToLower();
            e8.StringToUpper();
            */
            Excercise e9 = new Excercise();
            e9.StringSplit();


        }
    }
    class Excercise {
        public double Quiz (int qty){
            double gedgetPrice = 500;
            
            double discount = 0;
            double total = qty * gedgetPrice;

            if (total <= 3000) // Consider the dicision tree which is faster!
            {
                if (total <= 2000)
                {
                    discount = 0;
                }
                else
                {
                    discount = 0.03;
                }
            }else if (total <= 6000)
            {
                discount = 0.05;
            }
            else
            {
                discount = 0.08;
            }
            total = total * (1 - discount);
            return total;



}
        public void ForLoop()
        {
            Console.WriteLine("For loop");
            //first,declare a new variable i,initialize with 0;
            //as long as I<10 we will repeat
            //at the end of every repeatition we will do i++
            //debug:F5 Start without debugging:Ctrl+F5 Next step: F10/F11 Stop:Ctrl+c
            //normally for counting
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
        }
        public void ForLoopForString()
        {
            Console.WriteLine("For loop for String");
            for (String s = ""; s.Length < 10; s = s + "*")
            {
                Console.WriteLine(s);
            }
        }
        public void WhileLoop(int j)
        {
            int i = 0;
            while (i < j)
            {
                Console.WriteLine(i);
                i++;
            }
        }
        public void TryParse() {
            
            bool isParsable = false;// user enter hasnt enter a interger
            bool nothing = false;//user hasnt enter anything
            int value=0;

            while (nothing==false ||isParsable == false) {
                
                Console.Write("Please enter a interger you want to parse:");
                string input = Console.ReadLine();
                nothing = true;
                isParsable = Int32.TryParse(input, out value);
            }
            Console.WriteLine("The value you enter is {0}", value);

            /*
           if (isParsable) {
               Console.WriteLine("The value you enter is {0}",value);
           }
           else
           {
               Console.WriteLine("you didn't enter a interger");
           }
           */
        }
        public void TryParse2()
        {
            //first has different message
            bool isParsable = false;// user enter hasnt enter a interger
            bool nothing = false;//user hasnt enter anything
            int value = 0;

            while (nothing == false || isParsable == false)
            {   
                if (nothing==false)
                {
                    Console.Write("Please enter a interger you want to parse:");  
                }
                else
                {
                    Console.Write("Please enter again a interger you want to parse:");
                }
                string input = Console.ReadLine();
                nothing = true;
                isParsable = Int32.TryParse(input, out value);

            }
            Console.WriteLine("The value you enter is {0}", value);

        }  
        public void Random() {
            Random r = new Random();
            for (int i = 0;i< 10; i++){
                int randomNumber = r.Next(0,100);
                Console.WriteLine(randomNumber);
            }
        }
        public void DoWhile()
        {
        }
        public void GuessGame()
        {
            Random r = new System.Random();
            int ans = r.Next(0, 10);
            bool correctGuess = false;
            do
            {
                Console.Write("Please guess(0-9):");
                int guess = Int32.Parse(Console.ReadLine());
                if (ans == guess)
                {
                    correctGuess = true;
                }
            } while (correctGuess == false);
            {
                Console.Write("Please guess again(0-9):");
                int guess = Int32.Parse(Console.ReadLine());
                if (ans == guess)
                {
                    correctGuess = true;
                }
                Console.WriteLine("Tour guess is true!");

            }
        }
        public void StringComparedTo() {
            Console.WriteLine("abc".CompareTo("xyz"));//-1
            Console.WriteLine("ABC".CompareTo("xyz"));//-1
            Console.WriteLine("abc".CompareTo("XYZ"));//-1
            Console.WriteLine("abc".CompareTo("ABC"));//-1
            Console.WriteLine("abc".CompareTo("abc"));//0
            Console.WriteLine("ABC".CompareTo("abc"));//1
            //Console.WriteLine("ABC".CompareTo(1));//Error!
        }
        public void StringTrim()
        {
            string s = " abc ";
            Console.WriteLine("*" + s + "*");
            string r = s.Trim();
            Console.WriteLine("*" + r + "*");

            string s2 = "$%$$abc%s%$";
            char[] c = new char[] { '$', '%' }; // character want to trim: char array
            Console.WriteLine("*" + s2 + "*");
            string r2 = s.Trim(c);              // only trim from left and right, cannot trim middle character 
            Console.WriteLine("*" + r2 + "*");
            Console.WriteLine(c);
            string r3 = s.TrimStart(c);
            string r4 = s.TrimEnd(c);
        }
        public void StringSubstring()
        {
            string s = "Venkatraman";
            string r = s.Substring(4, 3);
            Console.WriteLine(r);
            Console.WriteLine(s.Substring(6, 4));
            string s1 = "Hello";
            string last = s1.Substring(s1.Length - 1, 1);
            Console.WriteLine(last);
        }
        public void StringInsert() {
            string s = "Institute Systems Science";
            string r = s.Insert(10, "of ");
            Console.WriteLine(s);
            Console.WriteLine(r);
        }
        public void StringPad()
        {
            string s = "ABC";
            string r = s.PadLeft(7, 'c');// only single ''
            Console.WriteLine(s);
            Console.WriteLine(r);
            Console.WriteLine(s.PadRight(6, 'z'));
        }
        public void StringToUpper() {
            string s = "Venkat";
            string r = s.ToUpper();
            Console.WriteLine(s);
            Console.WriteLine(r);
        }
        public void StringToLower() {
            string s = "Venkat";
            string r = s.ToLower();
            Console.WriteLine(s);
            Console.WriteLine(r);
        }
        public void StringSplit()
        {
            int i;
            string a ="Institute of Systems Science";
            string a2= "Institute  of Systems Science";
            char[] chars = new char[] { ' ', 'i', '%' };
            string[] s = a.Split(' ');
            string[] s2 = a2.Split(chars);
            for (i = 0; i <= s.Length - 1; i++)
                Console.WriteLine(s[i]);
            for (i = 0; i <= s2.Length - 1; i++)
                Console.WriteLine(s2[i]);
        }
    }
}