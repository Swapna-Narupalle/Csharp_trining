using System;


class sizesof_DT
{
    static void Main()
    {

        //sizes of data types
        Console.WriteLine($"Size of byte is: {sizeof(byte)} bytes");
        Console.WriteLine($"Size of short is: {sizeof(short)} bytes");
        Console.WriteLine($"Size of int is: {sizeof(int)} bytes");
        Console.WriteLine($"Size of long is: {sizeof(long)} bytes");
        Console.WriteLine($"Size of float is: {sizeof(float)} bytes");
        Console.WriteLine($"Size of double is: {sizeof(double)} bytes");
        Console.WriteLine($"Size of decimal is: {sizeof(decimal)} bytes");
        Console.WriteLine($"Size of Character: {sizeof(char)}");
        Console.WriteLine($"Size of Bool: {sizeof(bool)}");

        

        //bool
        bool isStudent = true;
        Console.WriteLine($"{isStudent}");


        //char
        char grade = 'A';
        Console.WriteLine(grade);


        //string
        string Name = "Swapna";
        Console.WriteLine("Name is: " + Name);
    }



}
