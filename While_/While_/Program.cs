namespace While_
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            while(a > 0)
            {
                a -= b;
            }
            Console.WriteLine("Answer = " + a + b);
        }
    }
}