using System;

public class Program
{
    static void ChangeValue(int x)
    {
        x = 200;

        Console.WriteLine(x);
    }

    public static void Main()
    {
        int i = 100;

        Console.WriteLine(i);

        ChangeValue(i);

        Console.WriteLine(i);
    }
}