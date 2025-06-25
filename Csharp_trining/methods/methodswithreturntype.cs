using System;




class Methods_returntype
{
    static void Main()
    {
        //string movieDetails = Method1();
        //Console.WriteLine(movieDetails);
        string Movietalk = Method2();
        Console.WriteLine(Movietalk);
        
    }

    static string Method1()
    {
        string movieName = "Aravinda sametha";
        string actorName = "NTR";
        return ($"{actorName} acted in {movieName}");
    }

    static string Method2()
    {
        string movieName1 = "Aravinda sametha";
        string movieDetails = Method1();
        Console.WriteLine(movieDetails);
        string Moviereview = "bestMovie";
        string aboutMovie;
        switch (Moviereview)
        {
            case "bestMovie":
                aboutMovie = $"{movieName1} is a blockermovie";
                break;
            case "worstMovie":
                aboutMovie = $"{movieName1} is a flop movie";
                break;
            default:
                aboutMovie = "pls enter either bestMovie or worstMovie";
                break;
        }
        return aboutMovie;
        


                
    }
          
           

        
    
 }

