using System;

class Whileloop
{
    static void Main()
    {
        //print 1-10 numbers
        int num = 0;
        while (num < 10)
        {
            num = num + 1;
            Console.WriteLine(num);
        }

        //print even numbers from 0-20
        int number = 0;
        while (number < 20)
        {
            number = number + 2;
            if(number%2==0)
            {
                Console.WriteLine(number);
            }
        }

        //print sum of first 10 natural numbers
        int num1 = 0;
        int sum = 0;
        while (num1 < 10)
        {
            sum = sum + num1;
            num1 = num1 + 1;
            //Console.WriteLine(sum);
        }
       Console.WriteLine(sum);
    }
}
