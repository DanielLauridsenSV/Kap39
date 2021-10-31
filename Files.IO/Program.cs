using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;
using System.Collections;

namespace Files.IO
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int userinput =0;
            Console.WriteLine("write your name");
            string username = Console.ReadLine();
            if (File.Exists($"{username}.txt"))
            {
                userinput = int.Parse(File.ReadAllText($"{username}.txt"));
            }

            bool continueplay = true;
            
            while (continueplay)
            {
                Console.WriteLine($" current score is :{userinput}");
                ConsoleKey consoleKey = Console.ReadKey().Key;
                if (consoleKey == ConsoleKey.Escape)
                {
                    continueplay = false;
                    break;
                }

                userinput ++;

                Console.Clear();

            }
            string score = ($"{userinput}\n");
            File.WriteAllText($"{username}.txt",score);
        }

    }
}
