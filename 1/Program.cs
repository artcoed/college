using System;

public class Program
{
    public static void Main(string[] args)
    {
        /*var a = float.Parse(Console.ReadLine());
        var b = float.Parse(Console.ReadLine());
        Console.WriteLine(a + b);*/

        /*var strA = Console.ReadLine();
        var strB = Console.ReadLine();
        Console.WriteLine(strA + strB);*/

        var str = Console.ReadLine();
        var separator = 0;

        for (var i = 0; i < str.Length; i++)
        {
            if (str[i] == '.')
            {
                separator = i;
            }
        }
        
        for (var i = 0; i < separator; i++)
        {
            Console.Write(str[i]);
        }

        Console.WriteLine("");

        for (var i = separator + 1; i < str.Length; i++)
        {
            Console.Write(str[i]);
        }
    }
}