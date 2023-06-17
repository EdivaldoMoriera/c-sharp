 using System.Globalization;

namespace Course
{
   
    class Program
    {
        static void Main(string[] args)
        {
           double saldo = 45.000;
             Console.WriteLine(saldo.ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}