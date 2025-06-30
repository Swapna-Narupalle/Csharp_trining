using System;


class Task
{
    static void Main()
    {
        //3.prepare the string array
        string[] empNames = {"John", "Robert", "Chandra", "Peter"};
        Console.WriteLine(empNames);


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

        //7.Convert Employees List into single String
        string employees = string.Join(", ", empNames);
        Console.WriteLine($"empNames is: {employees}");


        //8.Replace the “Robert” with “Peter” in String
        string updatedemployees = employees.Replace("Robert", "Peter");
        Console.WriteLine($"updated employees is: {updatedemployees}");


        //9.Get the Employee whose name length is more that 4 charcters from the array
        foreach(string empName in empNames)
        {
            if (empName.Length > 4)
            {
                Console.WriteLine($"employeeName with more than 4 characters is: {empName}");
            }
        }


        //10.Diff b/w for and foreach ? Explain with example

    }
}
