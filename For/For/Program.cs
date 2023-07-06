namespace For
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /* 1
            Console.Write("Enter K: ");
            int k = int.Parse(Console.ReadLine()!);
            Console.Write("Enter N: ");
            int n = int.Parse(Console.ReadLine()!);
            for (int i = 0; i < n; i++)
            {
                //Вывести N раз число K.
                Console.Write(k);
            }
            */


            /* 2
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = a; i <= b; i++)
            {
                // Вывести в порядке возрастания все  целые числа, расположенные
                // между A и B(включая сами числа A и B),
               
                Console.WriteLine(i);
            }
            // а также количество N этих чисел.
            int n = b - a + 1;
            Console.WriteLine("Answer is " + n);
            */


            /* 3
            Console.Write("Enter A: ");
            int a = int.Parse(Console.ReadLine());
            Console.Write("Enter B: ");
            int b = int.Parse(Console.ReadLine());
            for (int i = b - 1; i > a; i--)
            {
                // Вывести в порядке убывания все целые числа,
                // расположенные между A и B(не включая числа A и B)
                Console.WriteLine(i);
            }
            //  а также количество N этих чисел.
            int n = b - a - 1;
            Console.WriteLine("Answer is " + n);
            */

            /* 4
           Console.Write("Price = ");
           double price = double.Parse(Console.ReadLine());
           for (int i = 1; i <= 10; ++i)
               Console.WriteLine($"{i} kg = {price * i}");
            */

            /* 5
            Console.Write("Price = ");
            double price = double.Parse(Console.ReadLine());
            for (double i = 0; i <= 1.1; i+=0.1)
            {
                Console.WriteLine($"{i} kg = {price * i}");
            }
            */


            /*6
            Console.Write("Price = ");
            double price = double.Parse(Console.ReadLine());
            for (double i = 1.2; i <= 2; i+=0.2 )
            {
                Console.WriteLine($"{i} kg = {price * i}");
            }
            */


            /* 7
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine()!);
            int summa = 0;
            for (int i = a; i <= b; i++)
            {
                summa += i;
                Console.WriteLine($"Result = {summa}");
            }
            */


            /* 8
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine()!);
            int summa = 1;
            for (int i = a; i <= b; i++)
            {
                summa *= i;
                Console.WriteLine($"Result = {summa}");
            }
            */


            /* 9
            Console.Write("A: ");
            int a = int.Parse(Console.ReadLine()!);
            Console.Write("B: ");
            int b = int.Parse(Console.ReadLine()!);
            int summa = 0;
            for (int i = a; i <= b; i++)
            {
                summa += i*i;
                Console.WriteLine($"Result = {summa}");
            }
            */


            /* 10
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine()!);
            double summa = 0;
            for (double i = 1; i <= n; i++)
            {
                summa += 1 / i;
                Console.WriteLine($"Result = {summa}");
            }
            */


            /* 11
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine()!);
            int summa = 0;
            for (int i = n; i <= n * 2; i++)
            {
                summa += i * i;
                Console.WriteLine($"Result = {summa}");
            }
            */


            /* 12
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine()!);
            double result = 1;
            for (double i = 1.1; i <=n; i++)
            {
                result *=(1 + 0.1 * i);
            }
            Console.WriteLine($"Result = {result}");
            */


            /* 13
            Console.Write("N: ");
            double n = Convert.ToInt32(Console.ReadLine());
            double result = 0;
            for (int i = 1; i <= n; i++)
            {
                result += Math.Pow(-1, i + 1) * (1.0 + i / 10);
                Console.WriteLine("Result = " + result);
            }
            */


            /*
            Console.Write("N: ");
            int n = int.Parse(Console.ReadLine());
            int summa = 0;
            int result = 1;
            for(int i = 0; i < (2 * n - 1); i+=2)
            {
                result += i;
                Console.WriteLine($"Result = {result}");
            }
            */


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

            /* 16
             int a, n, num;
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

            /*int a , b ;
            Console.Write("A: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("B: ");
            b = Convert.ToInt32(Console.ReadLine());
            int c = 1;
            int result = 1;
            for (int i = 2; i <= b; ++i)
            {
                c *= a;
                result += c;
            }
            Console.WriteLine("Result = " + result);
            */

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

            //40   

            /*int a, b;
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