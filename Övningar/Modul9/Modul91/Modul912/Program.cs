using System;



public class Program
{
    public static void Main()
    {
        AskAndRespond(AskAndRespond_ToUpper);
        AskAndRespond(AskAndRespond_Tripple);
        AskAndRespond(AskAndRespond_AddStars);
    }

    static string AskAndRespond_ToUpper(string input)
    {
        return input.ToUpper();

    }
    static string AskAndRespond_Tripple(string input)
    {
        return input + input + input;

    }
    static string AskAndRespond_AddStars(string input)
    {
        string x = "";
        foreach (char n in input)
        {
            x += n + "*";
        }
        return x.Trim('*');
    }
    public static void AskAndRespond(Func<string, string> converter)
    {
        Console.Write("Enter a string to convert:");
        var con1 = Console.ReadLine();
        var resCon1 = converter(con1);
        Console.WriteLine(resCon1);
    }
}

