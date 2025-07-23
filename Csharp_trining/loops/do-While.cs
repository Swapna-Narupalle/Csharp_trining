using System;
class do_while_loop
{
    static void Main()
    {
        int num = 0;
        do
        {
            Console.WriteLine($"Your Number is: {num}");
            num = num + 1;
        } while (num < 3);



        int indianCurrency = 0;
        Console.WriteLine($"My Indian Currency Before While Loop: {indianCurrency}");
        do
        {
            indianCurrency = indianCurrency + 1;
            Console.WriteLine($"Your Currency is: {indianCurrency}");
        } while (indianCurrency < 5);



        //To Add all the currency values
        int[] currencyNoteBox = { 10, 20, 50, 50, 100, 200 };

        int countingStage = 0;
        int totalAmount = 0;

        do
        {
            Console.WriteLine($"Counting Stage is :{countingStage}" +
                $"Currency Note is:{currencyNoteBox[countingStage]}" +
                $"Before Total Amount is: {totalAmount}");
            totalAmount = totalAmount + currencyNoteBox[countingStage];
            countingStage = countingStage + 1;
            Console.WriteLine($"Counting Stage is {countingStage} : After Counting Total Amount is :{totalAmount}");

        } while (countingStage < currencyNoteBox.Length);


    }
}