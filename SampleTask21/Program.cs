using System;
using System.Linq;
namespace SampleTask21
{
    class Program
    {
        static void Main(string[] args)
        {
            if (!args.Any())
            {
                Console.WriteLine("Just startup");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine($"Now the time is {DateTime.Now.ToString("dd/MM/yy HH:mm:ss")}");
                Console.WriteLine($"Hello all words {string.Join(',', args)}");
            }
               
        }
    }
}
