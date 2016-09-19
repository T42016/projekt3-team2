using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using MemoryLogic;

namespace MemoryTest
{
    class Program
    {
        private static int posX = 0;
        private static int posY = 0;
        static MemoryGame game = new MemoryGame(4, 4);
        private static char[] symbols = {'*', '!', 'ü', '?', 'ö', 'ä', 'å', '&', '@', '£', '#', '$', '¤', '§', '=', '½', 'w', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '^', '~', '-', ';', ':', '[', '(', '{' };

        static void Main(string[] args)
        {
                Menu();
        }

        static void Win()
        {
            Console.Clear();
            Console.WriteLine("You Win!");
            Thread.Sleep(2000);
            Console.Clear();

            Menu();
        }

        static void Menu()
        {
            int height = 0;
            int width = 0;

            Console.Clear();
            Console.WriteLine("--Memory Game!--");
            Console.WriteLine("1.Play Game");
            Console.WriteLine("2.Exit Game");

            var command = Console.ReadLine();

            switch (command)
            {

                case "1":
                    Console.Clear();
                    try
                    {
                        Console.WriteLine("Input Width Of Playing Field! (Max 10, Min 2,)");
                        width = int.Parse(Console.ReadLine());
                        Console.WriteLine("Input Hight Of Playing Field! (Max 10, Min 2)");
                        height = int.Parse(Console.ReadLine());
                    }
                    catch (Exception e)
                    {
                        Console.Clear();
                        Console.WriteLine("!ERROR! Please Input A Number !ERROR!");
                        Thread.Sleep(2000);
                    }
                    break;
                case "2":
                    Environment.Exit(0);
                    break;
                default:
                    Menu();
                    break;
            }

            if (width * height % 2 == 0 && width * height <= 100 && width * height >= 4)
            {
                game.ResetBoard();
                game = new MemoryGame(width, height);
                Console.Clear();
                Setup();
            }
            else
            {
                Console.Clear();
                Console.WriteLine("!ERROR! The Playing Field Needs A Even Number Of Positions !ERROR!");
                Thread.Sleep(2000);
                Menu();
            }
        }

        static void Setup()
        {
            while (true)
            {
                Console.Clear();
                DrawBoard();
                Console.WriteLine("Draws: " + game.Draws);
                if (game.HasMismatch)
                    Console.WriteLine("Press any key");

                var key = Console.ReadKey();

                if (game.HasMismatch)
                {
                    game.CloseMismatch();
                    continue;
                }

                if (key.Key == ConsoleKey.LeftArrow && posX > 0)
                    posX--;
                if (key.Key == ConsoleKey.RightArrow && posX < game.SizeX - 1)
                    posX++;
                if (key.Key == ConsoleKey.UpArrow && posY > 0)
                    posY--;
                if (key.Key == ConsoleKey.DownArrow && posY < game.SizeY - 1)
                    posY++;
                if (key.Key == ConsoleKey.R)
                    game.ResetBoard();
                if (key.Key == ConsoleKey.Spacebar)
                    game.ClickCoordinate(posX, posY);

                if (game.Points == game.Maxpoints)
                {
                    Win();
                }
            }
        }

        static void DrawBoard()
        {
            for (int y = 0; y < game.SizeY; y++)
            {
                for (int x = 0; x < game.SizeX; x++)
                {
                    if (x == posX && y == posY)
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;

                    var info = game.GetCoordinate(x, y);
                    if (info.IsOpen)
                    {
                        Console.ForegroundColor = info.IsFound ? ConsoleColor.Green : ConsoleColor.Cyan;
                        Console.Write(symbols[info.Value] + " ");
                    }
                    else
                    {
                        Console.ForegroundColor = ConsoleColor.Gray;
                        Console.Write(". ");
                    }
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.BackgroundColor = ConsoleColor.Black;
        }
    }
}
