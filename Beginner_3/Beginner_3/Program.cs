namespace Beginner_3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            b = Convert.ToInt32(Console.ReadLine());
            int S = a * b;
            int P = 2 * (a + b);
            Console.WriteLine("Ploshad = " + S);
            Console.WriteLine("Perimetr = " + P);
        }
    }
}