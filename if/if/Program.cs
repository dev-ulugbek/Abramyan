using static System.Console;
namespace If_else;
internal class Program
{
    static void Main(string[] args)
    {
        /* 1  int a;
        Console.Write("Enter a number:  ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 0) 
        {
            a++;
            Console.WriteLine("Answer is = " + a); 
        }
        else { Console.WriteLine("Answer is = "+ a); } */

        // if 1
        Console.Write("Enter N: ");
        int n = int.Parse(Console.ReadLine()!);
        if (n > 0)
            n++;
        Console.WriteLine(n);



        /* 2  int a;
        Console.Write("Enter a number:  ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 0)
        {
            a++;
            Console.WriteLine("Answer is = " + a);
        }
        else 
        {
            a -= 2;
            Console.WriteLine("Answer is = " + a); 
        }*/

        /* 3  int a;
        Console.Write("Enter a number:  ");
        a = Convert.ToInt32(Console.ReadLine());
        if (a > 0)
        {
            a++;
            Console.WriteLine("Answer is = " + a);
        }
        else if (a < 0)
        {
            a -= 2;
            Console.WriteLine("Answer is = " + a);
        }
        else
        {
            a = 10;
            Console.WriteLine("Answer is = " + a);
        } */


        /* 14 int a, b, c;
        Console.Write(«A: «);
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write(«B: «);
        b = Convert.ToInt16(Console.ReadLine());
        Console.Write(«C: «);
        c = Convert.ToInt16(Console.ReadLine());
        if (a c && c > a) { Console.WriteLine(a + » min » + b + » max «); }
        else if (b > a && a > c) { Console.WriteLine(c + » min » +b + » max «); }
        else if (a > b && b > c) { Console.WriteLine(c + » min » +a + » max «); }
        else if (b < a && a < c) { Console.WriteLine(b + " min " + c + " max ");}
        else if (b < c && c < a) { Console.WriteLine(b + " min " + a + " max ");} */


        /* 15 int a, b, c;
        Console.Write("A: ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("B: ");
        b = Convert.ToInt16(Console.ReadLine());
        Console.Write("C: ");
        c = Convert.ToInt16(Console.ReadLine());
        if (b <= c && b <= a) { Console.WriteLine(a + c); }
        else if (a <= c && a <= b) { Console.WriteLine(b + c); }
        else { Console.WriteLine(b + a); }*/

        /* 16 int a, b, c;
        Console.Write("A: ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("B: ");
        b = Convert.ToInt16(Console.ReadLine());
        Console.Write("C: ");
        c = Convert.ToInt16(Console.ReadLine());
        if ((a <= b) && (b <= c))
        {
            a = a * 2;
            b = b * 2;
            c = c * 2;

            Console.WriteLine("A: " + a + " " + "B: " + b + " " + "C: " + c);
        }
        else
        {
            a = a * (-1);
            b = b * (-1);
            c = c * (-1);
            Console.WriteLine("A: " + a + " " + "B: " + b + " " + "C: " + c);
        } */

        /* 17  int a, b, c;
        Console.Write("A: ");
        a = Convert.ToInt16(Console.ReadLine());
        Console.Write("B: ");
        b = Convert.ToInt16(Console.ReadLine());
        Console.Write("C: ");
        c = Convert.ToInt16(Console.ReadLine());
        if ((a <= b) && (b <= c) || (a>=b)&&(b>=c))
        {
            a = a * 2;
            b = b * 2;
            c = c * 2;

            Console.WriteLine("A: " + a + " " + "B: " + b + " " + "C: " + c);
        }
        else
        {
            a = a * (-1);
            b = b * (-1);
            c = c * (-1);
            Console.WriteLine("A: " + a + " " + "B: " + b + " " + "C: " + c);
        } */

        /* 28  int year, days;
        Console.Write("Year: ");
        year = Convert.ToInt32(Console.ReadLine());
        days = (year % 400 == 0) ? 366 : 365;
        Console.Write("Days: " +days);*/

        /* 29  int num;
        Console.Write("Enter a number:  ");
        num = Convert.ToInt32(Console.ReadLine());
        if (num == 0) { Console.WriteLine("Zero number"); }
        else 
        {
            if (num > 0) { Console.WriteLine("positive number"); }
            else { Console.WriteLine("negative number"); }
            if (num % 2 == 0) { Console.WriteLine("even number"); }
            else { Console.WriteLine("odd number"); }
        } */

        /* 30 int num;
        Console.Write("Enter a number: ");
        num  = Convert.ToInt32(Console.ReadLine());
        if (num % 2 == 0) { Console.WriteLine("Even number"); }
        else if (num < 0) { Console.WriteLine("Invalid number"); }
        else { Console.WriteLine("Odd number"); }
        if (num > 0 && num < 10) { Console.WriteLine("single digit number"); }
        else if (num > 9 && num < 100) { Console.WriteLine("two-digit number"); }
        else if (num > 100 & num < 1000) { Console.WriteLine("three-digit number"); } */
        
    }
}
