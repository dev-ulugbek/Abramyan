namespace Boolean
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 0)
            {
                Console.WriteLine(true); 
            }
            else 
            {
                Console.WriteLine(false);
            } 

            /* 2 int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 == 0) { Console.WriteLine(true); }
            else { Console.WriteLine(false); } */

            /* 3  int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a % 2 != 0) { Console.WriteLine(true); }
            else { Console.WriteLine(false); }  */

            /* 15 int a, b, c;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            b = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            c = Convert.ToInt32(Console.ReadLine());
            if (a > 0 && b > 0 && c < 0 || a > 0 && b < 0 && c > 0 ||
                a < 0 && b > 0 && c > 0) { Console.WriteLine(true); }
            else { Console.WriteLine(false); } */

            /* 16  int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 9 && a < 100 && a % 2 == 0) { Console.WriteLine(true); }
            else { Console.WriteLine(false); } */

            /* 17  int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());
            if (a > 99 && a < 1000 && a % 2 != 0) { Console.WriteLine(true); }
            else { Console.WriteLine(false); } */

            /* 38  int x1, x2, y1, y2;
            Console.Write("Enter a number for X1: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for Y1: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for X2: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number for Y2: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2)) { Console.WriteLine(true); }
            else { Console.WriteLine(false); }*/


            /* 39  int x1, x2, y1, y2;
            Console.Write("Enter a number for : ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(x1 - x2) == Math.Abs(y1 - y2) || (x1 == x2) || (y1 == y2)) { Console.WriteLine(true); }
            else { Console.WriteLine(false); } */

            /* 40  int x1, x2, y1, y2;
            Console.Write("Enter a number: ");
            x1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter a number: ");
            y2 = Convert.ToInt32(Console.ReadLine());
            if (Math.Abs(x1 - x2) == 1 && Math.Abs(y1 - y2) == 2 || Math.Abs(x1 - x2) == 2 && Math.Abs(y1 - y2) == 1) 
            { Console.WriteLine(true); }
            else { Console.WriteLine(false); } */
        }
    }
}