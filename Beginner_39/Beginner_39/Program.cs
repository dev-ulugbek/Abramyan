namespace Beginner_39
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c, d, x1, x2;
            Console.Write("A:  ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B:  ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("C:  ");
            c = Convert.ToDouble(Console.ReadLine());
            d = Math.Pow(b, 2) - 4 * a * c;
            if (d > 0)
            {
                x1 = (-b + Math.Sqrt(d)) / 2 * a;
                x2 = (-b - Math.Sqrt(d)) / 2 * a;

                Console.WriteLine("D: = " + d);
                Console.WriteLine("X1: = " + x1);
                Console.WriteLine("X2: = " + x2);
            }
            else
                Console.WriteLine("Error:  D lowwer than the 0 ");


        }
    }
}