using System.Reflection;
using System.Security.Cryptography.X509Certificates;

namespace Funksiya
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Printer();
        }
        public static void Printer()
        {
            
            string Name = "Something";
            string Color = "Red";
            int Year = 2018;
            Console.WriteLine("{0}" + "\n" + "{1}" + "\n" + "{2}", Name, Color, Year);
            
        }
   
    }
}