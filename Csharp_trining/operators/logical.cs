using System;


class Logicaloperators
{
    static void Main()
    {
        //Logical operators

        int a = 10, b = 70;
        if (a >= 10 && b <= 100)
        {
            Console.WriteLine("condition is True!!!");
        }
        else
        {
            Console.WriteLine("condition is False!!!");
        }



        //whether the person is allowed to cast vote or not
        int age = 18;
        bool hasvoterID = false;
        if(age>=18 && hasvoterID)
        {
            Console.WriteLine("entry allowed");
        }
        else if(age >= 18 && !hasvoterID)
        {
            Console.WriteLine("entry denied: Id required");
        }
        else
        {
            Console.WriteLine("entry denied and not elligible to vote");
        }



        //OR operator
        int age1 = 17;
        bool hasid = true;
        if(age1>=18 || hasid)
        {
            Console.WriteLine("entry allowed");
        }
        else
        {
            Console.WriteLine("not allowed");
        }


        //Not operator
        bool isweekend = false;
        if (!isweekend)
        {
            Console.WriteLine("relax");
        }
        else
        {
            Console.WriteLine("go to work");
        }
    }
}
