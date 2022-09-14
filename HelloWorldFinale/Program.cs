using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorldFinale
{
    internal class Program
    {
        static void Main(string[] args)
        {
                Console.WriteLine("Please put in your name: ");
                string name = Console.ReadLine();

                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("- - - - - - - - - - - - - - - -");
                Console.WriteLine($"Hello '{name}', have a good day!");
                Console.WriteLine("- - - - - - - - - - - - - - - -");
                Console.Beep();
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("Program by Serena Burnett");
                Console.WriteLine(" ");
                Console.WriteLine(" ");
                Console.WriteLine("the final version of this i promise lol");
            Console.ReadKey(true);

            }
        }
    }
