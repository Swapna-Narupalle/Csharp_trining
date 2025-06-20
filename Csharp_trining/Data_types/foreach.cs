using System;


class Foreachloops
{
    class Student { public string Name; public int Age; }

    static void Main()
    {
        //int
        int[] Ranks = { 20000, 1000, 2000, 3000, 5000 };
        foreach (int Rank in Ranks)
        {
            Console.WriteLine($"Ranks of student is: {Rank}");
        }



        //string
        string[] fruits = { "Apple", "Banana", "Panasa" };
        foreach (string fruit in fruits)
        {
            Console.WriteLine($"The name of fruit is: {fruit}");
        }




        string[] countryNames = { "India", "Amerika", "Srilanka" };
        foreach (string countryName in countryNames)
        {
            if (countryName.StartsWith("I"))
            {
                Console.WriteLine($"The name of the country is: {countryName}");
            }
        }



        string[] stateNames = { "Andhra Pradesh", "Arunachal Pradesh", "Kerala", "banglore" };
        foreach (string stateName in stateNames)
        {
            if (stateName.Contains("Pradesh"))
            {
                Console.WriteLine($"The Name of the state is: {stateName}");
            }
        }


        string[] subjects = { "Maths", "Pysics", "Chemistry" };
        foreach (string subject in subjects)
        {
            if (subject.Contains("Maths"))
            {
                Console.WriteLine($"My favourite subject is: {subject}");
            }

        }



        //bool
        bool[] answers = { true, false, true };
        foreach (bool answer in answers)
        {
            Console.WriteLine($"Answer is: {answer}");
        }



        //char
        char[] Grades = { 'A', 'C', 'B' };
        foreach (char Grade in Grades)
        {
            Console.WriteLine($"The Grade of student is: {Grade}");
        }
    


      //object
      object[] students = {
            new Student { Name = "Swapna", Age = 21 },
            new Student { Name = "Mouni", Age = 22 }
        };

        foreach (var obj in students)
        {
            if (obj is Student s)
            {
                Console.WriteLine($"Student Name: {s.Name}, Age: {s.Age}");
            }
        }
    }
}
