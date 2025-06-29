using System;


class Task
{
    static void Main()
    {
        //3.prepare the string array
        string[] empNames = {"John", "Robert", "Chandra", "Peter"};


        //4.get third employee from the array
        Console.WriteLine($"Third employee: { empNames[2]}");


        //5.Check weather Second and Third employee Equals or not from the Array
        if (empNames[1] == empNames[2])
        {
            Console.WriteLine("second and third employees are equal");
        }
        else
        {
            Console.WriteLine("second and third employees are not equal");
        }


        //6.Check the employee whose name starts with “J” from the Array
        foreach(string empName in empNames)
        {
            if (empName.StartsWith("J"))
            {
                Console.WriteLine($"{empName} name starts with 'J' from the array");
            }
        }



    }
}
