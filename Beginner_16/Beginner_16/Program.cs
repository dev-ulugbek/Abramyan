namespace Beginner_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int x1, x2;
            Console.Write("X1:  ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("X2:  ");
            x2 = Convert.ToInt32(Console.ReadLine());
            int x3 = Math.Abs(x2- x1);
            Console.WriteLine("Answer is: =  "+ x3);
        }
    }
}