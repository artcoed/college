using System;

public class Program
{
    public static void Main(string[] args)
    {
        var canReload = true;
        while (canReload)
        {
            Reload();
            Console.WriteLine("Хотите продолжить?");
            if (Console.ReadLine().ToLower() != "да")
                canReload = false;
        }
    }

    public static void Reload()
    {
        Console.Write("Введите число a: ");
        var a = float.Parse(Console.ReadLine());
        Console.Write("Введите операцию: ");
        var operation = Console.ReadLine();
        Console.Write("Введите число b: ");
        var b = float.Parse(Console.ReadLine());

        switch (operation)
        {
            case "+":
                Console.WriteLine(a + b);
                break;
            case "-":
                Console.WriteLine(a - b);
                break;
            case "*":
                Console.WriteLine(a * b);
                break;
            case "/":
                Console.WriteLine(a / b);
                break;
            case "%":
                Console.WriteLine(a % b);
                break;
            case "^":
                Console.WriteLine(Math.Pow(a, b));
                break;
            case "$":
                Console.WriteLine(Math.Pow(a, 1 / b));
                break;
            case "D":
                Console.Write("Введите число c: ");
                var c = float.Parse(Console.ReadLine());
                var discriminant = Math.Pow(b, 2) - 4 * a * c;
                if (discriminant < 0)
                {
                    Console.WriteLine("Корней нет");
                }
                else if (discriminant == 0)
                {
                    var x = (-b) / 2 * a;
                    Console.WriteLine("x = " + x);
                }
                else
                {
                    var x1 = (-b - Math.Sqrt(discriminant)) / 2 * a;
                    var x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                    Console.WriteLine($"x1 = {x1}, x2 = {x2}");
                }

                break;
            default:
                Console.WriteLine("Операция указана неверно");
                break;
        }
    }
}