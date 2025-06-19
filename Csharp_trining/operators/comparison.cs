using System;


class Comparisonoperators
{
    static void Main()
    {
        //comparison operators: ==, !=, <, <=, >, >=
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
