using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        static string Input(string question)
        {
            Console.WriteLine(question);
            return Console.ReadLine().ToLower();
        }



        static void Main(string[] args)
        {
            string flavour = Input("What is your favourite pizza?");

            switch (flavour)
            {
                case "cheese and tomato":
                case "margherita":
                    Console.WriteLine("Suitable for vegetarians");
                    break;

                case "pepperoni":
                case "meat feast":
                    Console.WriteLine("Not suitable for vegetarians");
                    break;

                case "":
                    Console.WriteLine("You didn't even type anything");
                    break;
                default:
                    Console.WriteLine("Unknown pizza. May contain meat!");
                    break;
            }
            Console.ReadLine();
        }
    }
}
