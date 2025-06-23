using System;


class Conditionalstatements_if
{
    static void Main()
    {
        //conditional statements

        //even or odd
        int num = 5;
        if (num % 2 == 0)
        {
            Console.WriteLine($"{num} is even number");
        }
        else
        {
            Console.WriteLine($"{num} is odd number");
        }



        

        int[] numbers = { 6, 10, 11, 5, 6 };
        foreach (int number in numbers)
        {
            if (number == 10)
            {
                Console.WriteLine($"{number} is eqyal to 10");
            }
            else if(number > 10)
            {
                Console.WriteLine($"{number} is greater than 10");
            }
            else
            {
                Console.WriteLine($"{number} is less than 10");
            }
        }



        int[] Students_marks = { 100, 80, 90, 50, 20 };
        foreach(int Student_marks in Students_marks)
        {
            if (Student_marks >= 90)
            {
                Console.WriteLine($" student got S-Grade");
            }
            else if (Student_marks >= 80)
            {
                Console.WriteLine($"student got A-Grade");
            }
            else if (Student_marks >= 70)
            {
                Console.WriteLine($"student got B-Grade");
            }
            else if (Student_marks >= 60)
            {
                Console.WriteLine($"student got C-Grade");
            }
            else if (Student_marks >= 50)
            {
                Console.WriteLine($"student got D-Grade");
            }
            else if (Student_marks >= 40)
            {
                Console.WriteLine($"student got E-Grade");
            }
            else
            {
                Console.WriteLine($"student is Fail");
            }
        }



    }
}
