namespace Beginner_17
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, c;
            Console.Write("A:  ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B:  ");
            b= Convert.ToInt32(Console.ReadLine());
            Console.Write("C:  ");
            c = Convert.ToInt32(Console.ReadLine());
            int AC = Math.Abs(a - c);
            int BC = Math.Abs(b - c);
            int sum = AC + BC;
            Console.WriteLine("Summa = " + sum);
        }
    }
}