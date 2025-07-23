using System;


class numeric_Datatypes
{
    static void Main()
    {
        //1. Non floating data types

        //byte (Range: 0 to 255)
        byte experience = 5;
        Console.WriteLine($"Swapna has {experience} years of experience in the IT industry.");


        //short(Range: -32, 768 to 32, 767)
        short marks = 911;
        Console.WriteLine($"Sreeja scored {marks} in her intermediate exams.");


        //ushort (Range: 0 to 65,535)
        ushort myBalance = 50000;
        Console.WriteLine($"My bank balance is {myBalance}.");


        //int(Range: -2, 147, 483, 648 to 2, 147, 483, 647)
        int mcetRank = 100000;
        Console.WriteLine($"Sindhu secured rank {mcetRank} in the MCET examination.");


        //uint (Range: 0 to 4,294,967,295)
        uint distance = 300000u;
        Console.WriteLine($"The distance is {distance} meters.");


        //long (Range: –9,223,372,036,854,775,808 to 9,223,372,036,854,775,807)
        long population = 20000000000000L;
        Console.WriteLine($"The world population is approximately {population}.");


        //ulong (Range: 0 to 18,446,744,073,709,551,615)
        ulong bankbalance = 500000000000000UL;
        Console.WriteLine($"Ambani's bank balance is {bankbalance}.");



        //2. floating data types

        // float: 7 - digit precision, suffix 'f' required
        float height = 5.9f;
        Console.WriteLine($"Rushi's height is {height} feet.");

        // double: 15-16 digit precision, default for floating-point literals
        double pi = 3.14159265358979;
        Console.WriteLine($"The value of Pi is approximately {pi}.");

        // decimal: 28-29 significant digits, used for financial/calculation accuracy, suffix 'm' or 'M' required
        decimal productPrice = 99999.99m;
        Console.WriteLine($"The price of the luxury product is ₹{productPrice}.");
    }
}
