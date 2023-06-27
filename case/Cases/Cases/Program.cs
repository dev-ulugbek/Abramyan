using System.ComponentModel;
using System.Net.NetworkInformation;
using System.Xml.Linq;

namespace Cases
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("Input a number 1 to 7 :  ");
            a = Convert.ToInt32(Console.ReadLine());
            switch(a)
            {
                case 1: Console.WriteLine("Monday");break;
                case 2: Console.WriteLine("Tuesday"); break;
                case 3: Console.WriteLine("Wednesday"); break;
                case 4: Console.WriteLine("Thursday"); break;
                case 5: Console.WriteLine("Friday"); break;
                case 6: Console.WriteLine("Saturday"); break;
                case 7: Console.WriteLine("Sunday"); break;
                    default: Console.WriteLine("incorrectly chosen number"); break;
            }

            /* 2  int a;
            Console.Write("Input a number 1 to 5 :  ");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1: Console.WriteLine("Bad"); break;
                case 2: Console.WriteLine("unsatisfactory"); break;
                case 3: Console.WriteLine("satisfactorily"); break;
                case 4: Console.WriteLine("Ok"); break;
                case 5: Console.WriteLine("Good"); break;
                    default: Console.WriteLine("incorrectly chosen number"); break;
            }*/

            /*  3 int a;
            Console.Write("Input a number 1 to 12 :  ");
            a = Convert.ToInt32(Console.ReadLine());
            switch (a)
            {
                case 1:
                    case 2:  
                        case 12: Console.WriteLine("Winter"); break;
                case 3:
                    case 4: 
                        case 5: Console.WriteLine("Spring"); break;
                case 6:
                    case 7: 
                        case 8: Console.WriteLine("Summer"); break;
                case 9:
                    case 10: 
                        case 11: Console.WriteLine("Fal"); break;
                    default: Console.WriteLine("incorrectly chosen number"); break;
            }*/

            /* 9  int d, m;
            Console.Write("Day: ");
            d = Convert.ToInt32(Console.ReadLine());
            Console.Write("Month: ");
            m = Convert.ToInt32(Console.ReadLine());
            switch (m)
            {
                case 1:
                    case 3:
                        case 5:
                            case 7:
                                case 8:
                                    case 10:
                                        case 12:
                    if (d == 31) d = 0; break;

                case 4:
                    case 6:
                        case 9:
                            case 11:
                    if (d == 30) d = 0; break;

                case 2:
                    if (d == 28) d = 0;break;
            }

            if (d == 0)
                if (m == 12) m = 1;
                else m++;

            d++;

            Console.WriteLine("Day: " + d +"  " + "Month: " + m); */

            /* 10  Console.Write("Direction:");
            String c = Console.ReadLine();
            Console.Write("Operation:");
            int n = int.Parse(Console.ReadLine());

            switch (c)
            {
                case "North":

                    switch (n)
                    {
                        case 1: c = "West"; break;
                        case 0: c = "North"; break;
                        case -1: c = "East"; break;
                    } break;
                    

                case "East":
                    switch (n)
                    {
                        case 1: c = "North"; break;
                        case 0: c = "East"; break;
                        case -1: c = "South"; break;
                    } break;
                    
                case "South":
                    switch (n)
                    {
                        case 1: c = "East"; break;
                        case 0: c = "South"; break;
                        case -1: c = "West"; break;
                    } break;
                default:
                    switch (n)
                    {
                        case 1: c = "South"; break;
                        case 0:c = "West"; break;
                        case -1: c = "North"; break;
                    } break;
            }
            Console.Write("Result: " + c); */

            /* 11 Console.Write("Enter the current moving direction of the robot\r\n: ");
            string c = Convert.ToString(Console.ReadLine());
            Console.Write("Enter first command: ");
            int n1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter second command: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            switch (c)
            {
                case "North":
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = "East";
                            break;
                        case 1:
                            c = "West";
                            break;
                        case -2:
                        case 2:
                            c = "Sourth";
                            break;
                    }
                    break;
                case "East":
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = "Sourth";
                            break;
                        case 1:
                            c = "North";
                            break;
                        case -2:
                        case 2:
                            c = "West";
                            break;
                    }
                    break;
                case "Sourth":
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = "West";
                            break;
                        case 1:
                            c = "East";
                            break;
                        case -2:
                        case 2:
                            c = "North";
                            break;
                    }
                    break;
                case "West":
                    switch (n1 + n2)
                    {
                        case -1:
                        case 3:
                            c = "Norh";
                            break;
                        case 1:
                            c = "South";
                            break;
                        case -2:
                        case 2:
                            c = "East";
                            break;
                    }
                    break;

            }
            Console.WriteLine(c); */

            /* 18  int num;
            Console.Write("Enter a number:  ");
            num = Convert.ToInt32(Console.ReadLine());
            switch(num / 100)
            {
                case 1: Console.Write("one hundred"); break;
                    case 2: Console.Write("two hundred"); break;
                    case 3: Console.Write("three hundred"); break;
                    case 4: Console.Write("four hundred"); break;
                    case 5: Console.Write("five hundred"); break;
                    case 6: Console.Write("six hundred"); break;
                    case 7: Console.Write("seven hundred"); break;
                    case 8: Console.Write("eight hundred"); break;
                    case 9: Console.Write("nine hundred"); break;
            }
            if ((num % 100) / 10 == 1)
            {
                switch (num % 100)
                {
                    case 10: Console.Write("ten"); break;
                        case 11: Console.Write(" eleven"); break;
                        case 12: Console.Write(" twelve"); break;
                        case 13: Console.Write(" thirdteen"); break;
                        case 14: Console.Write(" fourteen"); break;
                        case 15: Console.Write(" fifeteen"); break;
                        case 16: Console.Write(" sixteen"); break;
                        case 17: Console.Write(" seventeen"); break;
                        case 18: Console.Write(" eightteen"); break;
                        case 19: Console.Write(" nineteen"); break;

                }

            }
            else 
            {
                switch((num % 100)/10)
                {
                    case 2: Console.Write(" twenty"); break;
                        case 3: Console.Write(" thirty"); break;
                        case 4: Console.Write(" fourty"); break;
                        case 5: Console.Write(" fifety"); break;
                        case 6: Console.Write(" sixty"); break;
                        case 7: Console.Write(" seventy"); break;
                        case 8: Console.Write(" eighty"); break;
                        case 9: Console.Write(" ninety"); break;
                }
                switch (num % 10)
                {
                    case 1: Console.Write(" one"); break;
                        case 2: Console.Write(" two");break;
                        case 3: Console.Write(" three");break;
                        case 4: Console.Write(" four");break;
                        case 5: Console.Write(" five"); break;
                        case 6: Console.Write(" six"); break;
                        case 7: Console.Write(" seven"); break;
                        case 8: Console.Write(" eight"); break;
                        case 9: Console.Write(" nine"); break;
                }
            }*/

            /* 19 int a;
            Console.Write("Enter a number: ");
            a = Convert.ToInt32(Console.ReadLine());

            switch ((a) % 10)
            {
                case 0:
                case 1: Console.Write("White"); break;
                case 2:
                case 3: Console.Write("Black"); break;
                case 4:
                case 5: Console.Write("Greeen");break;
                case 6:
                case 7: Console.Write("Red"); break;
                case 8:
                case 9: Console.Write("Yellow"); break;
            }

            switch ((a + 1) % 5)
            {
                case 0:
                case 1:
                case 2:
                case 3:
                case 4:
                case 5:
                case 9:
                case 10:
                case 11: Console.Write(" Ouch"); break;
                case 6:
                case 7:
                case 8: Console.Write(" Wow"); break;
            }

            switch ((a + 8) % 12)
            {
                case 0: Console.Write(" Mouse"); break;
                case 1: Console.Write(" Cow"); break;
                case 2: Console.Write(" Tiger"); break;
                case 3: Console.Write(" Rabbit"); break;
                case 4: Console.Write(" Dragon"); break;
                case 5: Console.Write(" Snake"); break;
                case 6: Console.Write(" Hourse"); break;
                case 7: Console.Write(" Sheep"); break;
                case 8: Console.Write(" Monkey"); break;
                case 9: Console.Write(" Chiken"); break;
                case 10: Console.Write(" Dog"); break;
                case 11: Console.Write(" Pig"); break;
            }*/

            /*20  Console.Write("Day: ");
            int d = int.Parse(Console.ReadLine());
            Console.Write("Month: ");
            int m = int.Parse(Console.ReadLine());
                switch (m)
                {
                    case 1:
                        if (m == 1 && d >= 20)
                        {
                            Console.WriteLine("Aquarius ");
                            break;
                        }
                        if (m == 1 && d >= 19)
                        {
                            Console.WriteLine("Fish ");
                            break;
                        }
                        if (m == 2 && d >= 21)
                        {
                            Console.WriteLine("Aries");
                            break;
                        }
                        if (m == 3 && d >= 20)
                        {
                            Console.WriteLine("Taurus");
                            break;
                        }
                        if (m == 4 && d >= 21)
                        {
                            Console.WriteLine("Twins");
                            break;
                        }
                        if (m == 5 && d >= 22)
                        {
                            Console.WriteLine("Cancer");
                            break;
                        }
                        if (m == 6 && d <= 21)
                        {
                            Console.WriteLine("Twins");
                            break;
                        }
                        else
                            break;
                    default:
                        Console.WriteLine("Error !");
                        break;
                }*/
            
        }
    }
}