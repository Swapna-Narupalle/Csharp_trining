using System;

class Task1_methods
{
    static void Main()
    {
       string stuDetails = GetstudentMarks("Swapna", 99);
       Console.WriteLine(stuDetails);

        Checknumbertype();

        GateExamfeeDetails();

        string fooddetails = GetfoodOrderdetails();
        Console.WriteLine(fooddetails);
    }

    //16.Prepare the Method with params with return types.
    static string GetstudentMarks(string stuName, int marks)
    {
        return $"{stuName} secured {marks} marks";
    }


    //17.Prepare the Methods with conditions (if elseif else)
    static void Checknumbertype()
    {
        Console.WriteLine("enter a number:");
        int num = int.Parse(Console.ReadLine());
        if (num > 0)
        {
            Console.WriteLine($"{num} is positive number");
        }
        else if (num < 0)
        {
            Console.WriteLine($"{num} is negative number");
        }
        else
        {
            Console.WriteLine($"{num} is zero");
        }

    }


    //18.Prepare the methods with Conditions (switch case)
    static void GateExamfeeDetails()
    {
        Console.WriteLine("enter the gender(Male or Female)");
        string gender = Console.ReadLine().Trim().ToLower();
        int? examfee = null;
        switch (gender)
        {
            case "male":
                examfee = 1800;
                break;
            case "female":
                examfee = 900;
                break;
            default:
                Console.WriteLine("invalid input, pls enter either Male or Female");
                break;
        }
        if (examfee.HasValue)
        {
            Console.WriteLine($"for {gender} gate exam fee is: {examfee}");
        }
    }


    //19.Prepare the Methods with if else if else and Switch case conditions.
    static string GetfoodOrderdetails()
    {
        Console.WriteLine("select your food item: Gobi, chicken biryani, chilly chicken");
        string selectedorder = Console.ReadLine();
        double price;
        string orderDetails;
        switch (selectedorder.ToLower())
        {
            case "gobi":
                price = 89.67;
                break;
            case "chicken biryani":
                price = 256.78;
                break;
            case "chilly chicken":
                price = 120.56;
                break;
            default:
                return $"invalid food item is selected";
                break;
        }
        if (price < 100)
        {
            orderDetails = "This is a budget-friendly item";
        }
        else if(price>=100 && price <= 200)
        {
            orderDetails = "This is a mid-range item";
        }
        else
        {
            orderDetails = "this is a premium item";
        }
        return $"you ordered: {selectedorder}\n price: {price} \n orderDetails: {orderDetails}";
    }
}
