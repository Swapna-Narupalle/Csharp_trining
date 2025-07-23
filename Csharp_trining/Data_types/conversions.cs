using System;


class Conversiontypes
{
    static void Main()
    {
        //implicit conversion: to convert small datatype into large datatype
        byte age = 15;
        int updatedage = age;
        Console.WriteLine($"value: {updatedage}");
        Console.WriteLine($"Type: {updatedage.GetType()}");

        int number = 200000;
        long updatednumber = number;
        Console.WriteLine($"value is: {updatednumber}");
        Console.WriteLine($"Type is: {updatednumber.GetType()}");


        int rank = 10000;
        double updatedRank = rank;
        Console.WriteLine($"value is: {updatedRank}");
        Console.WriteLine($"Type is: {updatedRank.GetType()}");



        //explicit conversions: To convert Large Datatype into Small Datatype
        int num = 20000;
        ulong updatednum = (ulong)num;
        Console.WriteLine($"value is: {updatednum}");
        Console.WriteLine($"Type is: {updatednum.GetType()}");


        int marks = 1000;
        byte updatedMarks = (byte)marks;
        Console.WriteLine($"value: {updatedMarks}");
        Console.WriteLine($"type: {updatedMarks.GetType()}");


        double percentage = 9.999;
        int updatedPercentage = (int)percentage;
        Console.WriteLine($"value: {updatedPercentage}");
        Console.WriteLine($"type: {updatedPercentage.GetType()}");


        int value = 90102441;
        string updatedvalue = value.ToString();
        Console.WriteLine($"value: {updatedvalue}");
        Console.WriteLine($"type: {updatedvalue.GetType()}");



        string value1 = "90102441";
        int updatedvalue1 = int.Parse(value1);
        Console.WriteLine($"value: {updatedvalue1}");
        Console.WriteLine($"type: {updatedvalue1.GetType()}");



        string value2 = "90102441";
        int updatedvalue2 = Convert.ToInt32(value2);
        Console.WriteLine($"value: {updatedvalue2}");
        Console.WriteLine($"type: {updatedvalue2.GetType()}");


        //value type numeric types
        string nullableString = null;
        Console.WriteLine($"string: {nullableString}");
        int output = Convert.ToInt32(nullableString);
        Console.WriteLine($"value: {output}");//0
        Console.WriteLine($"type: {output.GetType()}");
        //int a = null; we cannot assign null into ineger. but we can Define null into string after we convert string type into int.

        DateTime datetime = DateTime.Now;
        Console.WriteLine(datetime.ToString());


        //get age of the person
        DateTime birthdate = new DateTime(2003, 12, 11);
        DateTime today = DateTime.Now;
        int age1 = today.Year - birthdate.Year;
        Console.WriteLine(age1);


        //Age calculator
        Console.Write("Enter your birth year: ");
        int birthYear = int.Parse(Console.ReadLine());

        int currentYear = DateTime.Now.Year;
        int currentAge = currentYear - birthYear;

        Console.WriteLine($"You are {currentAge} years old.");












    }
}
