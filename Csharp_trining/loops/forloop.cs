using System;

using System.Data.SqlTypes;

class forloop

{

    static void Main()

    {

        for (int i = 0; i < 10; i++)

        {

            Console.WriteLine("Value of i: " + i);

        }


        for (int currentValue = 0; currentValue < 5; currentValue = currentValue + 1)

        {

            //Console.WriteLine($"Current Value is:  {currentValue}");

            Console.WriteLine("Current Value is:" + currentValue);

        }


        int[] currencyList = { 10, 20, 30, 40, 50 };

        int totalAmount = 0;

        for (int currency = 0; currency < currencyList.Length; currency = currency + 1)

        {

            Console.WriteLine("currency value:" + currencyList[currency]);

            totalAmount = totalAmount + currencyList[currency];

        }

        Console.WriteLine("Total Currency is: " + totalAmount);

    }

}
