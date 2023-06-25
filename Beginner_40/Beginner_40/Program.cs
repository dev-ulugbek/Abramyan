namespace Beginner_40
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a1, a2, b1, b2, c1, c2, d, x, y;
            Console.Write("A1: ");
            a1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("B1: ");
            b1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("C1: ");
            c1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("A2: ");
            a2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("B2: ");
            b2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("C2: ");
            c2 = Convert.ToDouble(Console.ReadLine());

            d = a1 * b2 - a2 * b1;
            x = (c1 * b2 - c2* b1) / d;
            y = (a1 * c2 - a2* c1) / d;

            Console.WriteLine("X: " + x);
            Console.WriteLine("Y: " + y);
        }
    }
}