using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using Console = Colorful.Console;
using System.Configuration;

namespace Lab18_ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello world");
            Debug.WriteLine("Write something to the output window... blablablabla");
            Console.WriteLine("Program has finished. Press enter to quit.", Color.Aquamarine);
            string greeting = Properties.Settings.Default.GreetingMessage;
            string angryMessage = Properties.Settings.Default.AngryMessage;
            Console.WriteLine(greeting);
            string tiredMessage = ConfigurationManager.AppSettings["tiredMessage"];
            Console.WriteLine(tiredMessage);
            Console.ReadKey();

        }

    }
}
