namespace Beginner_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number ");
            a = Convert.ToInt32(Console.ReadLine());
            int S = a * a;
            Console.WriteLine("Answer is = " + S);
        }
    }
}