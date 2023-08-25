using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Metadata.W3cXsd2001;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace Guessing_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nextround = 1;
            int score = 0;
            int rounds = 0;
            Console.WriteLine("");
            Console.WriteLine("");
            Console.WriteLine("KIOYDIOLABS (C) 2023");
            Console.WriteLine("");
            Console.WriteLine("Welcome to the 'Guessing Game'");
            Console.WriteLine("");
            while (nextround == 1)
            {
                rounds = rounds + 1;
                Random random = new Random();
                int rand = random.Next(0, 7);
                Console.WriteLine("Enter a number between 0 and 6 :");
                Console.WriteLine("");
                string userinput = Console.ReadLine();
                int userinputint = int.Parse(userinput);
                if (userinputint == rand)
                {
                    Console.WriteLine("You are correct!");
                    Console.WriteLine("");
                    score = score + 1;
                    /*Console.WriteLine("Score : " + score);
                    Console.WriteLine("Round : " + rounds);*/
                    Console.WriteLine("----------------");
                    Console.WriteLine("|   Score : " + score + "  |");
                    Console.WriteLine("----------------");
                    Console.WriteLine("|   Score : " + rounds + "  |");
                    Console.WriteLine("----------------");

                }
                else if (userinputint > 6)
                {
                    Console.WriteLine("Invalid Number");
                }
                else if (userinputint < 0)
                {
                    Console.WriteLine("Invalid Number");
                }
                else
                {
                    Console.WriteLine("You are wrong! Try again!");
                    Console.WriteLine("----------------");
                    Console.WriteLine("|   Score : " + score + "  |");
                    Console.WriteLine("----------------");
                    Console.WriteLine("|   Score : " + rounds + "  |");
                    Console.WriteLine("----------------");
                }
                Console.WriteLine("Do you want to try again? [y/n] : ");
                string goon = Console.ReadLine();
                if (goon == "y")
                {
                    continue;
                }
                else
                {
                    Console.WriteLine("Goodbye! :)");
                    Console.WriteLine("");
                    Console.WriteLine("Final score is : " + score + ".");
                    Console.WriteLine("");
                    Console.WriteLine("You played " + rounds + " rounds.");
                    Console.WriteLine("");
                    Console.WriteLine("Press enter to exit...");
                    Console.WriteLine("");
                    Console.ReadLine();
                    break;
                }
                {
                    
                }
                {

                }
            }
        }
    }
}
