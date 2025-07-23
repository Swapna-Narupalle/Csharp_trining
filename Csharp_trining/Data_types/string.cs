using System;
using System.Linq;


class Stringdatatype
{
    static void Main()
    {
        string studentName = "Swapna";
        Console.WriteLine(studentName);//Swapna

        string employee = "\"Swapna\""; 
        Console.WriteLine(employee);//Swapna


        //string interpolation
        string EmpoyeeName = "Madhu";
        int experiance = 3;
        string employeeDetails = $"{EmpoyeeName} has {experiance} years of experiance in the IT industry";
        Console.WriteLine(employeeDetails);


        string names = "Swapna\nMouni\nMadhu";
        Console.WriteLine(names);


        //string concatination
        string Name = "Swapna";
        string sirName = "Narupalle";
        string fullname = Name + ' ' + sirName;
        Console.WriteLine(fullname);//Swapna Narupalle


        string message = "Sandya is a First Class Student";
        int result = message.Length;
        Console.WriteLine(result);
        string updatedmessage1 = message.ToLower();
        Console.WriteLine(updatedmessage1);
        string updatedmessage2 = message.ToUpper();
        Console.WriteLine(updatedmessage2);


        string collegeName = "          KSRMCE          ";
        string updatedcName = collegeName.Trim();
        Console.WriteLine(updatedcName);


        string collegeName1 = "********SRIT*********";
        string updatedcName1 = collegeName1.Trim('*');
        Console.WriteLine(updatedcName1);


        string collegeName2 = "********Savitha*********";
        string updatedcName2 = collegeName2.TrimEnd('*');
        Console.WriteLine(updatedcName2);


        string collegeName3 = "********CBIT*********";
        string updatedcName3 = collegeName3.TrimStart('*');
        Console.WriteLine(updatedcName3);


        string collegeName4 = "KORM";
        string padleft_cName = collegeName4.PadLeft(10);
        Console.WriteLine(padleft_cName);


        string collegeName5 = "KORM";
        string padleft_cName1 = collegeName5.PadLeft(10, '*');
        Console.WriteLine(padleft_cName1);


        string collegeName6 = "KORM";
        string padright_cName = collegeName6.PadRight(10, '*');
        Console.WriteLine(padright_cName);


        string Mailid = "swapnan@gmain.com";
        //bool isequals = Mailid.Equals("swapna@gmail");
        bool isequals = Mailid.Contains("swapna@gmail");
        Console.WriteLine(isequals);
       

        Console.WriteLine("Please enter your email id");
        string eMailid = Console.ReadLine();
        bool isemailid_equals = eMailid.Equals("swapnan@gmain.com");
        Console.WriteLine(isemailid_equals);



        string sentence = "Python is a interprited programming language";
        string substring = sentence.Substring(12, 11);
        Console.WriteLine(substring);


        string original_sentence = "Swapna is a software engineer";
        string replaced_sentence = original_sentence.Replace("Swapna", "Rushi");
        Console.WriteLine(replaced_sentence);


        string employeeName = "Sindhu";
        int employeeexperiance = 3;
        string information = string.Format("{0} is a software engineer with {1} years of experiance", employeeName, employeeexperiance);
        Console.WriteLine(information);

        
        //palindrome
        string name = "Swapna";
        string reverseName = new string(name.Reverse().ToArray());

        if (name.Equals(reverseName, StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine($"{name} is a palindrome.");
        }
        else
        {
            Console.WriteLine($"{name} is not a palindrome.");
        }


        //words count
        Console.WriteLine("Count no of words in sentence");
        Console.WriteLine("Enter a sentence :");
        string CountWords = Console.ReadLine();
        string[] splittedWords = CountWords.Split(' ');
        int wordCount = splittedWords.Length;
        Console.WriteLine("Number of words in the sentence:" + wordCount);



        //Concat
        string nameFull = "Divya" + " " + "Bandike";
        Console.WriteLine(nameFull);


        //With Concat Method
        string a = "  Divya";
        string b = "Bandike";
        string c = "  Venkata";
        string fullName = string.Concat(b, c, a);
        Console.WriteLine(fullName);


        //Alternate Method

        string Name1 = string.Concat("Kavya", " ", "Bandike");
        Console.WriteLine(Name1);



















    }
}
