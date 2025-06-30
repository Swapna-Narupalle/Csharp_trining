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
        ///<summary>
        ///for loop: Used to iterate with a counter and index-based access.
        ///foreach loop:Used to iterate over a collection without using an index.
        ///</summary>
        //get employee names by using for loop
        for (int i=0; i<empNames.Length; i++)
        {
            Console.WriteLine($"employee Name is: {empNames[i]}");
        }
        //get employee names by using foreach loop
        foreach(string empName in empNames)
        {
            Console.WriteLine($"employee is: {empName}");
        }


        //11.Explain me what is the importance of the Looping system. ? Explain with Example
        ///<summary>
        ///Loops: loop iterates until the condition is false
        ///while loop:it iterates the block until the condition is true
        ///do-while loop: Executes the block of code at least once, and repeats until the condition is true.
        ///</summary>
        //example of while loop
        string Name = "Swapna";
        while (Name.EndsWith("a"))
        {
            Console.WriteLine($"{Name} ends with 'a' letter");
            Name = Name.Substring(0, Name.Length - 1);
        }
        //example by using do-while loop
        string employee_Name;
        do
        {
            Console.WriteLine("enter the employee Name(min 6 letters)");
            employee_Name = Console.ReadLine();
        } while (employee_Name.Length < 6);
        Console.WriteLine($"employee name is {employee_Name}");


        //12.What are the floating data types ? EXample
        ///<summary>
        ///floting data types are used to store the decimal values
        ///Example:decimal, float, double
        ///</summary>
        decimal price = 23.22m;
        float temperature = 34.99f;
        double distance = 78.998;
        Console.WriteLine($"decimal price is: {price}");
        Console.WriteLine($"float temperature is: {temperature}");
        Console.WriteLine($"double distance is: {distance}");


        //13.What are the Logical operators importance of that ? Explain with example
        ///<summary>
        ///logical operators:&&, ||, !
        ///logical operators: By using logical operators we can find whether the given codition is true or false. These are used in conditional statements
        ///like if, else if, else
        ///</summary>
        Console.WriteLine("enter age:");
        int age = Convert.ToInt32(Console.ReadLine());
        bool hasVoterid = false;
        if(age>=18 && !hasVoterid)
        {
            Console.WriteLine("eligible to vote");
        }
        else if(age>=18 || !hasVoterid)
        {
            Console.WriteLine("Partially eligible to vote");
        }
        else
        {
            Console.WriteLine("Not eligible to vote");
        }


        //14.What is the nullable types ? Example
        ///<summary>
        ///nullable data types:A nullable type allows a value type (like int, bool, double, etc.) to also hold a null value.
        ///</summary>
        int? age1 = null;
        if(age1 == null)
        {
            Console.WriteLine("age is not provided");
        }
        else
        {
            Console.WriteLine($"age is: {age1}");
        }


        //15.What is implicit conversation type ? Example
        ///<summary>
        ///implicit conversion: to convert value of small data type into large data type
        ///</summary>
        byte experience = 18;
        int updatedexp = experience;
        Console.WriteLine(updatedexp);
        Console.WriteLine(updatedexp.GetType());
    }
}
