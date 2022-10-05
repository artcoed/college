using System;

namespace gfgf
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var a = int.Parse(Console.ReadLine());
            var b = int.Parse(Console.ReadLine());
            var c = int.Parse(Console.ReadLine());

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
                var x1 = (-b - Math.Sqrt(discriminant))/ 2 * a;
                var x2 = (-b + Math.Sqrt(discriminant)) / 2 * a;
                Console.WriteLine($"x1 = {x1}, x2 = {x2}");
            }
            

            Console.Read();
        }
    }
}
