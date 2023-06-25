namespace Beginner_15
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double S, D, L, R, P = 3.14;
            Console.Write("Enter a number: ");
            R = Convert.ToDouble(Console.ReadLine());
            L = 2 * P * R;
            S = P * Math.Pow(R, 2);
            Console.WriteLine("L: = " + L);
            Console.WriteLine("S: = " + S);
            //double D, S, L, P = 3.14;
            //Console.Write("S: ");
            //S = Convert.ToDouble(Console.ReadLine());
            //D = Math.Sqrt(3.14 / S);
            //Console.WriteLine("D: " +D);
            //L = 2 * P * D;
            //Console.WriteLine("L: " +L);

        }
    }
}