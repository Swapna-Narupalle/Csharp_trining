using System;

class Methodwith_returntypeparameters
{
    static void Main()
    {
        string aboutMovie = Method1("RRR", 10000000000);
        Console.WriteLine(aboutMovie);
    }

    static dynamic Method1(string movie, ulong collection)
    {
        return ($"{movie} collected {collection} profit in worldwide");
    }
}
