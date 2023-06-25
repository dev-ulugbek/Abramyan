namespace Beginner_38
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, x;
            Console.Write("A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToDouble(Console.ReadLine());
            x = -b / a;
            Console.WriteLine("X: = " + x);
        }
    }
}