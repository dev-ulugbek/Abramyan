namespace Begnner_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            int P = 4 * a;
            Console.WriteLine("Answer is = " + P);
        }
    }
}