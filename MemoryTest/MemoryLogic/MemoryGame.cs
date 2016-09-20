﻿using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MemoryLogic
{
    public class MemoryGame
    {
        public int SizeX { get; }
        public int SizeY { get; }
        public int Draws { get; private set; }
        public bool HasMismatch => lastOpened.Count == 2;
        public int Maxpoints;
        public int Points;
        public int PosX = 0;
        public int PosY = 0;

        private static char[] symbols = { '*', '!', 'ü', '?', 'ö', 'ä', 'å', '&', '@', '£', '#', '$', '¤', '§', '=', '½', 'w', 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z', '^', '~', '-', ';', ':', '[', '(', '{' };


        public MemoryGame(int sizeX, int sizeY)
        {
            SizeX = sizeX;
            SizeY = sizeY;
            _board = new PositionInfo[sizeX, sizeY];
            ResetBoard();
            Maxpoints = sizeX*sizeY/2;
        }

        private PositionInfo[,] _board;
        private List<PositionInfo> lastOpened = new List<PositionInfo>();

        public void ResetBoard()
        {
            Random rnd = new Random();
            List<int> values = new List<int>();
            Draws = 0;
            Points = 0;

            for (int i = 0; i < SizeX*SizeY; i++)
                values.Add(i/2);

            for (int x = 0; x < SizeX; x++)
                for (int y = 0; y < SizeY; y++)
                {
                    int index = rnd.Next(values.Count);
                    _board[x, y] = new PositionInfo()
                    {
                        X = x,
                        Y = y,
                        Value = values[index]
                    };
                    values.RemoveAt(index);
                }
        }

        public PositionInfo GetCoordinate(int x, int y)
        {
            if (x < 0 || x >= SizeX || y < 0 || y > SizeY)
                throw new IndexOutOfRangeException();

            return _board[x, y];
        }

        public void CloseMismatch()
        {
            if (lastOpened.Count == 0)
                return;

            lastOpened.ForEach(c => c.IsOpen = false);
            lastOpened.Clear();
        }

        public void ClickCoordinate(int x, int y)
        {
            var coord = GetCoordinate(x, y);
            if (coord.IsOpen || lastOpened.Count == 2)
                return;

            coord.IsOpen = true;
            if (lastOpened.Count == 1 && lastOpened.First().Value == coord.Value)
            {
                coord.IsFound = true;
                lastOpened.First().IsFound = true;
                lastOpened.Clear();
                Draws++;
                Points++;
            }
            else
            {
                lastOpened.Add(coord);
                if(lastOpened.Count == 2)
                    Draws++;
            }
        }

        public void DrawBoard()
        {
            for (int y = 0; y < SizeY; y++)
            {
                for (int x = 0; x < SizeX; x++)
                {
                    if (x == PosX && y == PosY)
                        Console.BackgroundColor = ConsoleColor.DarkCyan;
                    else
                        Console.BackgroundColor = ConsoleColor.Black;

                    var info = GetCoordinate(x, y);
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
