namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int k, n;
            Console.Write("Enter K: ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter N: ");
            n = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write(k + " ");
            } 

            /* 2 int a, b, n;
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++) { Console.WriteLine(i); }
            n = b - a + 1;
            Console.WriteLine("Answer is " + n); */

            /* 3 int a, b, n;
            Console.Write("Enter A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter B: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = b - 1; i > a; i--) { Console.WriteLine(i); }
            n = b - a - 1;
            Console.WriteLine("Answer is " + n);*/


            /* 15 double a, n;
            Console.Write("A: ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("N: ");
            n = Convert.ToDouble(Console.ReadLine());
            double summ = 1;
            for (double i = 1; i <= n; i++)
            {
                summ *= a;
            }
            Console.WriteLine("summ = " + summ); */

            /* 16 int a, n, num;
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("N: ");
            n = Convert.ToInt32(Console.ReadLine());
            num = 1;
            for (int i = 1; i <= n; i++)
            {
                num *= a;
                Console.WriteLine(num);
            }*/

            /* 17  int a , b ;
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            int num = 1;
            for (int i = 2; i <= b; ++i)
            {
                c *= a;
                num += c;
            }
            Console.WriteLine("Num = " + num);*/

            /* 38 double a = 0, b;
            b = int.Parse(Console.ReadLine());
            for (int i = 1; i <= b; i++)
            {
                a += Math.Pow(i, b - i + 1);
                Console.WriteLine(a);
            } */

            /* 39  int a, b;
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = 1; j <= i; j++)
                {
                    Console.Write($" {i} ");
                }

            }*/

            /* 40  int a, b;
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                for (int j = a; j <= i; j++)
                {
                    Console.Write($" {i} ");
                }

            }*/
        }
    }
}