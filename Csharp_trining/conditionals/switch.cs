using System;


class Conditionalstatements_switch
{
    static void Main()
    {
        //switch case

        //day of the week
        //int day = 3;
        Console.WriteLine("Enter day number");
        int day = int.Parse(Console.ReadLine());

        switch (day)
        {
            case 1:
                Console.WriteLine("Monday");
                break;
            case 2:
                Console.WriteLine("Tuesday");
                break;
            case 3:
                Console.WriteLine("Wednesday");
                break;
            case 4:
                Console.WriteLine("Thursday");
                break;
            case 5:
                Console.WriteLine("Friday");
                break;
            case 6:
                Console.WriteLine("Saturday");
                break;
            case 7:
                Console.WriteLine("Sunday");
                break;
            default:
                Console.WriteLine("Invalid day");
                break;
        }


        //vowel or consonent
        //char ch = 'e';
        Console.WriteLine("Enter a letter..");
        char ch = Console.ReadKey().KeyChar;
        Console.WriteLine("");
        switch (ch)
        {
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }


        //month name from number 
        //int month = 4;
        Console.WriteLine("Enter Month number");
        string input = Console.ReadLine();
        if (int.TryParse(input, out int month))
        {
            switch (month)
            {
                case 1:
                    Console.WriteLine("January");
                    break;
                case 2:
                    Console.WriteLine("February");
                    break;
                case 3:
                    Console.WriteLine("March");
                    break;
                case 4:
                    Console.WriteLine("April");
                    break;
                case 5:
                    Console.WriteLine("May");
                    break;
                case 6:
                    Console.WriteLine("June");
                    break;
                default:
                    Console.WriteLine("Invalid month");
                    break;
            }
        }
        else
        {
            Console.WriteLine("Please enter a valid number");
        }
        



        //Grade based on marks
        int marks = 86;

        switch (marks / 10)
        {
            case 10:
            case 9:
                Console.WriteLine("S Grade");
                break;
            case 8:
                Console.WriteLine("A Grade");
                break;
            case 7:
                Console.WriteLine("B Grade");
                break;
            case 6:
                Console.WriteLine("C Grade");
                break;
            case 5:
                Console.WriteLine("D Grade");
                break;
            default:
                Console.WriteLine("Fail");
                break;
        }






        Console.WriteLine("enter a role of employee");
        string role = Console.ReadLine();
        string package;
        switch (role)
        {
            case "fresher":
                Console.WriteLine("enter the location");
                string location = Console.ReadLine();
                if (location == "India")
                {
                    package = "3 LPA";
                }
                else if (location == "Amerika")
                {
                    package = "5 LPA";
                }
                else
                {
                    package = "location is not available pls enter either India or Amerika";
                }
                break;
            case "Software_Engineer":
                package = "10LPA";
                break;
            default:
                package = "No package";
                break;
        }
        Console.WriteLine($"package is: {package}");



    }
}
