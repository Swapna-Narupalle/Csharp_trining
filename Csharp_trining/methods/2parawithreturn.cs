using System;
using System.ComponentModel.Design;


class Methodwithreturntype_parameters
{
    static void Main()
    {
        string foodDetails = getfoodDetails(195.50);
        Console.WriteLine(foodDetails);

        string[] foodNames = new string[] {"gobi", "chickenBiryani", "eggrice"};
        double[] foodprices = new double[] {80.65, 200.60, 90.56};
        Console.WriteLine("pls select your order");
        string orderName = Console.ReadLine();
        string orderDetails = getorderDetails(foodNames, foodprices, orderName);
        Console.WriteLine(orderDetails);
    }

    static string getfoodDetails(double bill)
    {
        return $"the total food bill is: {bill:F2}";
    }

    static string getorderDetails(string[] foodNames, double[] foodprices, string orderName)
    {
        for(int i= 0; i < foodNames.Length; i++ )
        {
            if (foodNames[i].Equals(orderName, StringComparison.OrdinalIgnoreCase))
            {
                return $"you ordered {foodNames[i]} and the bill is {foodprices[i]}";
            }
            
        }
        return "your order is not in the menu";
    }
}
