using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlockBuster;

namespace BlockBusterConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            var b = BlockBusterBasicFunctions.GetAllMovies();
            var oh = new OutputHelper();

            args = Environment.GetCommandLineArgs();

            if (args[1].ToLower() == "console")
            {
                oh.WriteToConsole(b);
            }else if(args[1].ToLower() == "csv")
            {
                oh.WriteToCSV(b);
            }
            else
            {
                Console.WriteLine($"Desired output is not available.");
                Environment.Exit(99);
            }
        }

    }
}
