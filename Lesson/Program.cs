using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson
{
    class Program
    {
        // gets input and returns it
        static string Input(string question)
        {
            Print(question, ConsoleColor.DarkRed);
            return Console.ReadLine().ToLower();
        }

        // outputs a string in nice colour
        static void Print(string statement, ConsoleColor newColour)
        {
            ConsoleColor oldColour = Console.ForegroundColor;
            Console.ForegroundColor = newColour;
            Console.WriteLine(statement);
            Console.ForegroundColor = oldColour;
        }

        // actual code
        static void Main(string[] args)
        {
            string flavour = Input("What is your favourite pizza?");

            switch (flavour)
            {
                case "cheese and tomato":
                case "margherita":
                    Print("Suitable for vegetarians", ConsoleColor.Blue);
                    break;

                case "pepperoni":
                case "meat feast":
                    Print("Not suitable for vegetarians", ConsoleColor.Blue);
                    break;

                case "":
                    Print("You didn't even type anything", ConsoleColor.Blue);
                    break;
                default:
                    Print("Unknown pizza. May contain meat!", ConsoleColor.Blue);
                    break;
            }

            string musicGenre = Input("What genre of music is your favourite?".ToLower());

            switch (musicGenre)
            {
                default:
                    Print($"No way, {musicGenre} is my favourite music genre too", ConsoleColor.Blue);
                        break;
            }

            
            Console.ReadLine();
        }
    }
}
