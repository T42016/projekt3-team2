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
        static MemoryGame game = new MemoryGame(4, 4);

        static void Main(string[] args)
        {
                Menu();
        }

        public static void Win()
        {
            Console.Clear();
            Console.WriteLine("You Win!");
            Thread.Sleep(2000);
            Console.Clear();

            Menu();
        }

        public static void Menu()
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
                        Console.WriteLine("Input Height Of Playing Field! (Max 10, Min 2)");
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

            if (height < 11 && height > 1 && width < 11 && width > 1)
            {
                if (width * height % 2 == 0)
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
            else
            {
                Console.Clear();
                Console.WriteLine("!ERROR! Width Or Height Had A Value Above 10 Or Under 2 !ERROR!");
                Thread.Sleep(2000);
                Menu();
            }
            
        }

        static void Setup()
        {
            while (true)
            {
                Console.Clear();
                game.DrawBoard();
                Console.WriteLine("Draws: " + game.Draws);
                if (game.HasMismatch)
                    Console.WriteLine("Press any key");

                var key = Console.ReadKey();

                if (game.HasMismatch)
                {
                    game.CloseMismatch();
                    continue;
                }

                if (key.Key == ConsoleKey.LeftArrow && game.PosX > 0)
                    game.PosX--;
                if (key.Key == ConsoleKey.RightArrow && game.PosX < game.SizeX - 1)
                    game.PosX++;
                if (key.Key == ConsoleKey.UpArrow && game.PosY > 0)
                    game.PosY--;
                if (key.Key == ConsoleKey.DownArrow && game.PosY < game.SizeY - 1)
                    game.PosY++;
                if (key.Key == ConsoleKey.R)
                    game.ResetBoard();
                if (key.Key == ConsoleKey.Spacebar)
                    game.ClickCoordinate(game.PosX, game.PosY);

                if (game.Points == game.Maxpoints)
                {
                    Win();
                }
            }
        }
    }
}
