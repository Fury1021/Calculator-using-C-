using System;

namespace calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            start();
        }
        public static void Exit()
        {
            System.Environment.Exit(0);
        }
        public static void start()
        {
            Console.WriteLine();
            Console.WriteLine("==========Calculator Menu==========");
            Console.WriteLine();

            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
            Console.WriteLine("5 - Remainder");
            Console.WriteLine("6 - Exit");

            Console.WriteLine();
            int number;
            Console.Write("Enter Number for operation: ");
            number = Convert.ToInt32(Console.ReadLine());

            switch (number)
            {
                case 1:
                    sum1();
                    break;
                case 2:
                    diff1();
                    break;
                case 3:
                    product1();
                    break;
                case 4:
                    quotient1();
                    break;
                case 5:
                    Rem1();
                    break;
                case 6:
                    Exit();
                    break;
            }
        }
        public static void sum1()
        {
            Console.WriteLine();
            Console.WriteLine();

            int num1, num2, sum;
            Console.WriteLine("==========Addition==========");
            Console.WriteLine();

            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //solution
            sum = num1 + num2;

            Console.WriteLine();
            Console.WriteLine("The sum of {0} and {1} is {2}", num1, num2, sum);
            Console.WriteLine();
            string question;
            Console.Write("Go back to Menu? Y/ N?: ");
            question = (Console.ReadLine());

            if (question == "Y")
            {
                start();
            }
            else
            {
                Exit();
            }
        }
        public static void diff1()
        {
            Console.WriteLine();
            Console.WriteLine();

            int num1, num2, diff;
            Console.WriteLine("==========Subraction==========");
            Console.WriteLine();

            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //solution
            diff = num1 - num2;

            Console.WriteLine();
            Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, diff);
            Console.WriteLine();
            string question;
            Console.Write("Go back to Menu? Y/ N?: ");
            question = (Console.ReadLine());

            if (question == "Y")
            {
                start();
            }
            else
            {
                Exit();
            }
        }
        public static void product1()
        {
            Console.WriteLine();
            Console.WriteLine();

            int num1, num2, product;
            Console.WriteLine("==========Product==========");
            Console.WriteLine();

            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //solution
            product = num1 * num2;

            Console.WriteLine();
            Console.WriteLine("The product of {0} and {1} is {2}", num1, num2, product);
            Console.WriteLine();
            string question;
            Console.Write("Go back to Menu? Y/ N?: ");
            question = (Console.ReadLine());

            if (question == "Y")
            {
                start();
            }
            else
            {
                Exit();
            }
        }
        public static void quotient1()
        {
            Console.WriteLine();
            Console.WriteLine();

            int num1, num2, quotient;
            Console.WriteLine("==========Division==========");
            Console.WriteLine();

            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //solution
            quotient = num1 / num2;

            Console.WriteLine();
            Console.WriteLine("The quotient of {0} and {1} is {2}", num1, num2, quotient);
            Console.WriteLine();
            string question;
            Console.Write("Go back to Menu? Y/ N?: ");
            question = (Console.ReadLine());

            if (question == "Y")
            {
                start();
            }
            else
            {
                Exit();
            }
        }
        public static void Rem1()
        {
            Console.WriteLine();
            Console.WriteLine();

            int num1, num2, remain;
            Console.WriteLine("==========Remainder==========");
            Console.WriteLine();

            Console.Write("Enter Number 1: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter Number 2: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            //solution
            remain = num1 % num2;

            Console.WriteLine();
            Console.WriteLine("The difference of {0} and {1} is {2}", num1, num2, remain);
            Console.WriteLine();
            string question;
            Console.Write("Go back to Menu? Y/ N?: ");
            question = (Console.ReadLine());

            if (question == "Y")
            {
                start();
            }
            else
            {
                Exit();
            }
        }
    }
}
