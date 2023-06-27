namespace Integer_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int L;
            Console.Write("Enter a number in sm: ");
            L = Convert.ToInt32(Console.ReadLine());
            int x = L / 100;
            Console.Write($"Answer is {x}m");

            /* 2 double M;
            Console.Write("Enter a number:  ");
            M = Convert.ToDouble(Console.ReadLine());
            double a = M / 1000;
            Console.WriteLine(a+"t");*/

            /* 3 double a, b;
            Console.Write("Inter a number: ");
            a = Convert.ToDouble(Console.ReadLine());
            b = a / 1024;
            Console.WriteLine(b + " kilobayt"); */

            /* 14 int a, b;
            Console.Write("Inter a number:  ");
            a = Convert.ToInt32(Console.ReadLine());
            b = (a % 10) * 100 + (a / 100) * 10 + (a % 100 / 10);
            Console.WriteLine("Result = " + b); */

            /* 15 int a, b,c, d, f;
            Console.Write("Inter a number ");
            a = Convert.ToInt32(Console.ReadLine());
            b = (a / 100);
            c = (a / 10) % 10;
            d = a % 10;
            f = c * 100 + b * 10 + d;
            Console.WriteLine("Result = " + f); */

            /* 16 int a, b;
            Console.Write("Inter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            b = (a / 100) * 100 + (a % 10) * 10 + (a % 100 / 10);
            Console.Write("Result = " + b); */

            /* 28  int k, n, m;
            Console.Write("Input:  ");
            k = Convert.ToInt32(Console.ReadLine());
            Console.Write("Input:  ");
            n = Convert.ToInt32(Console.ReadLine());
            m = ((k + n - 2) % 7) + 1;
            if (m == 1)
            {
                Console.WriteLine("Today is: " + m + "-" + "Monday");
            }
            else if (m == 2)
            {
                Console.WriteLine("Today is: " + m + "-" + "Tuesday");
            }
            else if (m == 3)
            {
                Console.WriteLine("Today is: " + m + "-" + "Wensday");
            }
            else if (m == 4)
            {
                Console.WriteLine("Today is: " + m + "-" + "Thursday");
            }
            else if (m == 5)
            {
                Console.WriteLine("Today is: " + m + "-" + "Friday");
            }
            else if (m == 6)
            {
                Console.WriteLine("Today is: " + m + "-" + "Saturday");
            }
            else if (m == 7)
            {
                Console.WriteLine("Today is: " + m + "-" + "Sunday");
            }
            else
            {
                Console.WriteLine("Today is: " + m + "-" + "Error day");
            }*/

            /* 29 double a, b, c, d, s;
            Console.Write("Enter A:  ");
            a = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter B:  ");
            b = Convert.ToDouble(Console.ReadLine());
            Console.Write("Enter C:  ");
            c = Convert.ToDouble(Console.ReadLine());
            d = ( a / c ) * ( b / c );
            s = a * b - d *(c * c);
            Console.WriteLine("Kolichestvo = " + d);
            Console.WriteLine("Ploshad = " + s); */

            /* 30 int a, b;
            Console.Write("Enter a number: ");
            a = Convert.ToInt16(Console.ReadLine());
            b = (a / 100) + 1;
            Console.WriteLine("Answer: " + b); */

        }
    }
}