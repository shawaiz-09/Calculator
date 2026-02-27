using System;

namespace Calculator
{
    class Calc
    {
        static int? num1 = 0;
        static int? num2 = 0;
        static int? result = 0;
        void intro()
        {
            Console.WriteLine("This is simple Calculator");
            Console.WriteLine("1 - Addition");
            Console.WriteLine("2 - Subtraction");
            Console.WriteLine("3 - Multiplication");
            Console.WriteLine("4 - Division");
        }

        void taking_input()
        {
            Console.Write("Enter the choice : ");
            int? choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case 1:

                    Console.Write("Enter the num1 : ");
                    Calc.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the num2 : ");
                    Calc.num2 = Convert.ToInt32(Console.ReadLine());
                    Calc.result = num1 + num2;
                    Console.WriteLine("The result is " + Calc.result);
                    break;
                case 2:

                    Console.Write("Enter the num1 : ");
                    Calc.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the num2 : ");
                    Calc.num2 = Convert.ToInt32(Console.ReadLine());
                    Calc.result = num1 - num2;
                    Console.WriteLine("The result is " + Calc.result);
                    break;
                case 3:

                    Console.Write("Enter the num1 : ");
                    Calc.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the num2 : ");
                    Calc.num2 = Convert.ToInt32(Console.ReadLine());
                    Calc.result = num1 * num2;
                    Console.WriteLine("The result is " + Calc.result);
                    break;

                case 4:

                    Console.Write("Enter the num1 : ");
                    Calc.num1 = Convert.ToInt32(Console.ReadLine());
                    Console.Write("Enter the num2 : ");
                    Calc.num2 = Convert.ToInt32(Console.ReadLine());
                    if(num2==0)
                    {
                        Console.WriteLine("Can't divided by zero");
                    }
                    else
                    {
                        Calc.result = num1 / num2;
                        Console.WriteLine("The result is : " + Calc.result);
                    }
                    break;
                    
                    


            }

        }
        static void Main()
        {
            Calc c1 = new Calc();
            c1.intro();
            c1.taking_input();
        }
    }
}

// Shawaiz Hassan