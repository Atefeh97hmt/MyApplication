using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            bool showMenu = true;
            while (showMenu)
            {
                showMenu = MainMenu();
            }
        }
        private static bool MainMenu()
        {
            Console.Clear();
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1) Print a String");
            Console.WriteLine("2) Add two numbers");
            Console.WriteLine("3) Add two numbers that user enter");
            Console.WriteLine("4) Average of five numbers that user enter");
            Console.WriteLine("5) Average of five numbers that user enter with loop");
            Console.WriteLine("6) Average of n user input numbers");
            Console.WriteLine("7) Sum Of Two Numbers");
            Console.WriteLine("8) User Input Output");
            Console.WriteLine("9) Sum Of Two int Numbers");
            Console.WriteLine("10) Operators and simple calculator");
            Console.WriteLine("11) Exit");

            switch (Console.ReadLine())
            {
                case "1":
                    PrintString();
                    return true;
                case "2":
                    AddTwoNumbers();
                    return true;
                case "3":
                    AddTwoUserEnterNumbers();
                    return true;
                case "4":
                    AverageOfFiveNumbersThatUserEnter();
                    return true;
                case "5":
                    AverageOfFiveNumbersThatUserEnterWithLoop();
                    return true;
                case "6":
                    AverageOfNNumbersThatUserEnter();
                    return true;
                case "7":
                    SumOfTwoNumbers();
                    return true;
                case "8":
                    UserInputOutput();
                    return true;
                case "9":
                    SumOfTwoIntNumber();
                    return true;
                case "10":
                    Calculator();
                    return true;
                default:
                    return false;
            }
        }


        /////////////////////////print string///////////////////////////
        //private static void PrintString()
        //{
        //    Console.Write("atefeh");
        //    Console.ReadKey();

        //}
        private static void PrintString()
        {
            string name = "atefeh";
            Console.Write("the name is " + name);
            Console.ReadKey();
        }

        ////////////////////////Add two numbers///////////////////////////
        private static void AddTwoNumbers()
        {
            int a = 100;
            int b = 60;
            int sum = a + b;
            Console.WriteLine(sum);
            Console.ReadKey();

        }

        ////////////////////////Add two numbers that user enter///////////////////////////


        private static void AddTwoUserEnterNumbers()
        {
            //int number1;
            //int number2;
            Console.WriteLine("please enter the number1");
                int number1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("please enter the number2");
                int number2 = Convert.ToInt32(Console.ReadLine());
                int result = number1 + number2;
            Console.WriteLine("sum of two numbers:" + result.ToString());
            Console.ReadKey();
            }



        //////////////////////average of five numbers that user enter///////////////////////////

        private static void AverageOfFiveNumbersThatUserEnter()
            {
                //int number1;
                //int number2;
                Console.WriteLine("Please enter the number1");
                int number1 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the number2");
                int number2 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the number3");
                int number3 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the number4");
                int number4 = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter the number5");
                int number5 = Convert.ToInt32(Console.ReadLine());
                int average = (number1 + number2 + number3 + number4 + number5) / 5;
                Console.WriteLine("average of five numbers:" + average.ToString());
                Console.ReadKey();
            }


        ////////////////////////average of five numbers that user enter with loop///////////////////////////

        private static void AverageOfFiveNumbersThatUserEnterWithLoop()
        {

                int[] number = new int[5];
                for (int i = 0; i < number.Length; i++)
                {
                    Console.WriteLine("please enter a number:");
                    number[i] = Convert.ToInt32(Console.ReadLine());
                }

                int sum = 0;
                for (int i = 0; i < number.Length; ++i)
                {
                    sum += number[i];
                }

                Console.WriteLine("average of five numbers is: {0}", sum / number.Length);
                Console.ReadKey();

            }


        ////////////////////////average of n user input numbers///////////////////////////

        private static void AverageOfNNumbersThatUserEnter()
        {
            int Total, Sum = 0;
                int Average;

                Console.WriteLine("How many numbers do you want the average of? ");
                Total = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < Total; i++)
                {
                    Console.WriteLine("Please enter a number: ");
                    int Value = Convert.ToInt32(Console.ReadLine());
                    Sum += Value;
                }

                Average = Sum / Total;

                Console.WriteLine("The average is: " + Average);
                Console.ReadKey();
            }

        ////////////////////////Sum Of Two Numbers///////////////////////////


        private static void SumOfTwoNumbers()
        {
            Console.Write("please enter first number ");
            float a = float.Parse(Console.ReadLine());

            Console.Write("please enter second number ");
            float b = float.Parse(Console.ReadLine());

            float c = a + b;

            Console.Write("the sum of {0} and {1} is {2}", a, b, c);

            Console.ReadKey();
        }


        ////////////////////////User Input Output///////////////////////////

        private static void UserInputOutput()
        {
            Console.Write("please enter your firstname ");
            string name = Console.ReadLine();

            Console.Write("please enter your lastname ");
            string lastname = Console.ReadLine();

            //Console.Write("the firstname is " + name);
            //Console.Write(" and,the lastname is " + lastname);

            //Console.Write(name + " " + lastname);

            Console.Write("{0} {1}", name, lastname);

            Console.ReadKey();
        }
        ////////////////////////Sum Of Two int Numbers///////////////////////////

        private static void SumOfTwoIntNumber()
        {
            Console.Write("please enter first number ");
            int a = int.Parse(Console.ReadLine());

            Console.Write("please enter second number ");
            int b = int.Parse(Console.ReadLine());

            int c = a + b;

            Console.Write("the sum of {0} and {1} is {2}", a, b, c);

            Console.ReadKey();
        }

        ////////////////////////operators and simple calculator///////////////////////////

        private static void Calculator()
        {
            int number1;
            int number2;
            int add, sub, mul, rem;
            float div;
            Console.Write("please enter number1 ");
            number1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("please enter number2 ");
            number2 = Convert.ToInt32(Console.ReadLine());
            add = number1 + number2;
            sub = number1 - number2;
            mul = number1 * number2;
            rem = number1 % number2;
            div = (float)number1 / number2;
            Console.WriteLine("Addition\t{0}", add);
            Console.WriteLine("Subtraction\t{0}", sub);
            Console.WriteLine("Multiplication\t{0}", mul);
            Console.WriteLine("Remainder\t{0}", rem);
            Console.WriteLine("Division\t{0}", div);
            Console.ReadKey();
        }

    }

}
