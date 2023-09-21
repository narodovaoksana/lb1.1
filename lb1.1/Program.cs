using System;

class Program
{
    static void Main()
    {
        while (true)
        {
            Console.WriteLine("Choose the task number (5 - 17, or 0 to exit).");
            int taskNumber;
            if (int.TryParse(Console.ReadLine(), out taskNumber))
            {
                switch (taskNumber)
                {
                    case 5:
                        Task5();
                        break;
                    case 6:
                        Task6();
                        break;
                    case 7:
                        Task7();
                        break;
                    case 8:
                        Task8();
                        break;
                    case 9:
                        Task9();
                        break;
                    case 10:
                        Task10();
                        break;
                    case 11:
                        Task11();
                        break;
                    case 12:
                        Task12();
                        break;
                    case 13:
                        Task13();
                        break;
                    case 14:
                        Task14();
                        break;
                    case 15:
                        Task15();
                        break;
                    case 16:
                        Task16();
                        break;
                    case 17:
                        Task17();
                        break;
                    case 0:
                        Console.WriteLine("The program is exiting..");
                        return;
                    default:
                        Console.WriteLine("Incorrect task number. Please try again.");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Incorrect input format. Please enter an integer.");
            }
        }
    }

    static void Task5()
    {
        Console.WriteLine("Task 5");
        sbyte a = -100;
        Console.WriteLine("a: " + a);

        byte b = 128;
        Console.WriteLine("b: " + b);

        short c = -3540;
        Console.WriteLine("c: " + c);

        int d = 64876;
        Console.WriteLine("d: " + d);

        long e = 2147483648;
        Console.WriteLine("e: " + e);

        int f = -1141583228;
        Console.WriteLine("f: " + f);

        long g = -1223372036854775808;
        Console.WriteLine("g: " + g);
    }

    static void Task6()
    {
        Console.WriteLine("Task 6");
        double value1 = 3.141592653589793238;
        Console.WriteLine("Value 1: " + value1);

        float value2 = 1.60217657f;
        Console.WriteLine("Value 2: " + value2);

        decimal value3 = 7.8184261974584555216535342341m;
        Console.WriteLine("Value 3: " + value3);
    }

    static void Task7()
    {
        Console.WriteLine("Task 7");
        string universityName = "Software University";
        char letterB = 'B';
        char letterY = 'y';
        char letterE = 'e';
        string loveProgramming = "I love programming";

        Console.WriteLine("Values of variables.:");
        Console.WriteLine("universityName: " + universityName);
        Console.WriteLine("letterB: " + letterB);
        Console.WriteLine("letterY: " + letterY);
        Console.WriteLine("letterE: " + letterE);
        Console.WriteLine("loveProgramming: " + loveProgramming);
    }
    static void Task8()
    {
        Console.WriteLine("Task 8");
        Console.WriteLine("Enter three numbers:");

        double a = double.Parse(Console.ReadLine());
        double b = double.Parse(Console.ReadLine());
        double c = double.Parse(Console.ReadLine());

        double average = (a + b + c) / 3.0;
        Console.WriteLine("Average: " + average);
    }
    static void Task9()
    {
        Console.WriteLine("Task9");
        Console.WriteLine("Enter the value for side a:");
        int a = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value for side b:");
        int b = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value for height h:");
        int h = int.Parse(Console.ReadLine());

        float area = ((a + b) / 2.0f) * h;
        Console.WriteLine("Area: " + area);
    }
    static void Task10()
    {
        Console.WriteLine("Taskk 10");
        Console.WriteLine("Enter a number:");

        int n = int.Parse(Console.ReadLine());

        int lastDigit = n % 10;

        Console.WriteLine("Last Digit: " + lastDigit);
    }
    static void Task11()
    {
        Console.WriteLine("Task11");
        Console.WriteLine("Enter a number:");
        int number = int.Parse(Console.ReadLine());

        Console.WriteLine("Enter the value of n:");
        int n = int.Parse(Console.ReadLine());

        int nDigit = FindNthDigit(number, n);

        if (nDigit != -1)
        {
            Console.WriteLine($"The {n}-th digit from the right is: {nDigit}");
        }
        else
        {
            Console.WriteLine("No such digit exists.");
        }
    }

    static int FindNthDigit(int num, int n)
    {
        int count = 0;

        while (num > 0)
        {
            int digit = num % 10;
            count++;

            if (count == n)
            {
                return digit;
            }

            num /= 10;
        }

        return -1;
    }
    static void Task12()
    {
        Console.WriteLine("Task 12");
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        bool result = (n > 20) && (n % 2 == 1);

        Console.WriteLine("Is the number greater than 20 and odd:" + result);

    }
    static void Task13()
    {
        Console.WriteLine("Task 13");
        Console.WriteLine("Enter a number:");
        int n = int.Parse(Console.ReadLine());

        bool result = (n % 9 == 0) || (n % 11 == 0) || (n % 13 == 0);

        Console.WriteLine(result);
    }
    static void Task14()
    {
        Console.WriteLine("Task 14");
        Console.WriteLine("Enter three numbers:");

        int max = int.MinValue;

        for (int i = 0; i < 3; i++)
        {
            Console.Write($"Enter number {i + 1}: ");
            int number = int.Parse(Console.ReadLine());

            if (number > max)
            {
                max = number;
            }
        }

        Console.WriteLine("The largest number is: " + max);
    }

    static void Task15()
    {
        Console.WriteLine("Task 15");
        Console.Write("Enter the first number: ");
        double a = double.Parse(Console.ReadLine());
        Console.Write("Enter the second number: ");
        double b = double.Parse(Console.ReadLine());
        Console.Write("Enter the third number: ");
        double c = double.Parse(Console.ReadLine());
        double product = a * b * c;
        if (product > 0)
        {
            Console.WriteLine("The product is positive.");
        }
        else if (product < 0)
        {
            Console.WriteLine("The product is negative.");
        }
        else
        {
            Console.WriteLine("The product is zero.");
        }
    }
    static void Task16()
    {
        Console.WriteLine("Task 16");
        Console.Write("Enter the  number: ");
        double a = double.Parse(Console.ReadLine());
        if (a <= 0)
        {
            Console.WriteLine("not valid");
        }
        else if (a == 1)
        {
            Console.WriteLine("Monday");
        }
        else if (a == 2)
        {
            Console.WriteLine("Tuesday");
        }
        else if (a == 3)
        {
            Console.WriteLine("Wednesday");
        }
        else if (a == 4)
        {
            Console.WriteLine("Thurday");
        }
        else if (a == 5)
        {
            Console.WriteLine("Friday");

        }
        else if (a == 6)
        {
            Console.WriteLine("Saturday");
        }
        else if (a == 7)
        {
            Console.WriteLine("Sunday");
        }

        else
        {
            Console.WriteLine("not valid");
        }

    }
    static void Task17()
    {
        Console.WriteLine("Task 17");
        Console.WriteLine("Enter a number to calculate its factorial:");
        int n = int.Parse(Console.ReadLine());

        if (n < 0)
        {
            Console.WriteLine("Invalid input. Factorial is not defined for negative numbers.");
        }

        long factorial = 1;

        for (int i = 2; i <= n; i++)
        {
            factorial *= i;
        }
        Console.WriteLine("Factorial of " + n + " is: " + factorial);
    }

}










