using System;


class Comparisonoperators
{
    static void Main()
    {
        //comparison operators: ==, !=, <, <=, >, >=

        bool x = true;
        bool y = false;

        bool IsEqual = 5 == 5;
        bool IsNotEqual = 4 != 5;
        bool IsGreaterOrEqual = 6 >= 7;
        bool IsLessOrEqual = 7 <= 7;
        bool IsGreater = 8 > 8;
        bool IsLess = 9 < 9;

        Console.WriteLine("***************Comparison Operators**************");
        Console.WriteLine($"IsEqual is {IsEqual}, IsNotEqual is {IsNotEqual}, IsGreaterOrEqual is {IsGreaterOrEqual}, IsLessOrEqual is {IsLessOrEqual}, IsGreater is {IsGreater}, IsLesser is {IsLess}");

        int a = 5, b = 3;
        Console.WriteLine($"a={a} and b={b}");
        Console.WriteLine($"a==b: {a == b}");
        Console.WriteLine($"a!=b: {a != b}");
        Console.WriteLine($"a>b: {a > b}");
        Console.WriteLine($"a>=b: {a >= b}");
        Console.WriteLine($"a<b: {a < b}");
        Console.WriteLine($"a<=b: {a <= b}");


        //check whether a number is even or odd
        Console.WriteLine("enter a number....");
        int number = Convert.ToInt32(Console.ReadLine());
        if (number % 2 == 0)
        {
            Console.WriteLine($"{number} is a even number...");
        }
        else
        {
            Console.WriteLine($"{number} is a odd number...");
        }


        //check whether a person is eligible to vote or not
        Console.WriteLine("enter the age of a person...");
        int age = Convert.ToInt32(Console.ReadLine());
        if(age>=18)
        {
            Console.WriteLine($"Person is eligible to vote");
        }
        else
        {
            Console.WriteLine($"Person is not eligible to vote");
        }


        //check if a number is positive, negative, or zero
        Console.WriteLine("enter the number...");
        int num = Convert.ToInt32(Console.ReadLine());
        if(num>0)
        {
            Console.WriteLine("number is positive");
        }
        else if(num<0)
        {
            Console.WriteLine("number is positive");
        }
        else
        {
            Console.WriteLine("number is zero");
        }
    }
}
