using System;


class Methodswith_parameters
{
    static void Main()
    {
        Method1("Swapna", 2);
        Method2(50000);
        Method2("50k");
    }

    static void Method1(string employeeName, byte experience)
    {
        Console.WriteLine($"{employeeName} has {experience} years of experience in it industry");
    }

    static void Method2(dynamic empsalary)
    {
        Console.WriteLine($"salary is: {empsalary}");
    }
}
