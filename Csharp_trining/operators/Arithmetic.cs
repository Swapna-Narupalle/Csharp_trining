using System;
using System.Runtime.InteropServices;


class Arithmetic_operator
{
    static void Main()
    {
        //Arithmetic operators: +, -, *, /, %
        int x = 2;// "+"
        int y = 4;
        int sum = (x + y);
        Console.WriteLine($"sum of {x} and {y} is {sum}");


        int x1 = 2;// "-"
        int y1 = 4;
        int diff = (x1 - y1);
        Console.WriteLine($"difference between {x1} and {y1} is {diff}");


        int x2 = 2;// "*"
        int y2 = 4;
        int mul = (x2*y2);
        Console.WriteLine($"product of {x2} and {y2} is {mul}");



        int x3 = 4;// "/" :integer division
        int y3 = 2;
        int div = (x3/y3);
        Console.WriteLine($"integer division of {x3} and {y3} is {div}");


        double num1 = 7;
        double num2 = 4;
        double floatdiv = (num1 / num2);
        Console.WriteLine($"float division of {num1} and {num2} is {floatdiv}");


        int x4 = 2;// "%"
        int y4 = 4;
        int modulodiv = (x4%y4);
        Console.WriteLine($"modulo division of {x4} and {y4} is {modulodiv}");


        //area of rectangle
        int length = 5;
        int width = 6;
        int area = (length * width);
        string areaofrectangle = string.Format("The area of rectangle is: {0}", area);
        Console.WriteLine(areaofrectangle);


        //simple intrest
        int principal = 20000;
        int time = 2;
        int rate = 3;
        int Simpleintrest = (principal * time * rate) / 100;
        Console.WriteLine($"simple intrest is: {Simpleintrest}");


        //average of five numbers
        int num_1 = 10, num_2 = 20, num_3 = 30, num_4 = 20, num_5 = 10;
        double average = (num_1 + num_2 + num_3 + num_4 + num_5) / 5;
        Console.WriteLine($"avarage of five numbers is: {average}");


    }
}
