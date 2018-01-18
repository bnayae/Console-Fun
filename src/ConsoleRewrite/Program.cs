using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

// see: https://stackoverflow.com/questions/888533/how-can-i-update-the-current-line-in-a-c-sharp-windows-console-app

namespace ConsoleRewrite
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(@"
  _                                         _          _   
 | |                                       | |        | |  
 | |__  _ __   __ _ _   _  __ _    ___  ___| |__   ___| |_ 
 | '_ \| '_ \ / _` | | | |/ _` |  / _ \/ __| '_ \ / _ \ __|
 | |_) | | | | (_| | |_| | (_| | |  __/\__ \ | | |  __/ |_ 
 |_.__/|_| |_|\__,_|\__, |\__,_|  \___||___/_| |_|\___|\__|
                     __/ |                                 
                    |___/                                  
");
            while (true)
            {
                Spin();
                Console.SetCursorPosition(20, 7);
                Console.WriteLine(@"  _/ |                                 
                     |__/                                  
");
                Spin();
                Console.SetCursorPosition(20, 7);
                Console.WriteLine(@" __/ |                                 
                    |___/                                  
");

            }

        }

        private static void Spin()
        {
           Console.SetCursorPosition(0, 9);
           for (int i = 0; i < 10; i++)
            {
                switch (i % 4)
                {
                    case 0: Console.Write("/"); break;
                    case 1: Console.Write("-"); break;
                    case 2: Console.Write("\\"); break;
                    case 3: Console.Write("|"); break;
                }
                Thread.Sleep(100);
                Console.SetCursorPosition(Console.CursorLeft - 1, Console.CursorTop);
            }
        }
    }
}
