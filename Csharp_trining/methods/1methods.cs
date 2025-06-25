using System;

  class Methods
  {
    static void Main()
    {
        Method1();
        Method3();
    }

    static void Method1()
    {
        Console.WriteLine("method1");
        Method2();
    }
    static void Method2()
    {
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
    }

    static void Method3()
    {
        string message = "Sandya is a First Class Student";
        int result = message.Length;
        Console.WriteLine(result);
        string updatedmessage1 = message.ToLower();
        Console.WriteLine(updatedmessage1);
        string updatedmessage2 = message.ToUpper();
        Console.WriteLine(updatedmessage2);
    }
  }

