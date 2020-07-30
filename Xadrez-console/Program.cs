using System;
using board;
using Xadrez_console.board;
using xadrez;

namespace Xadrez_console
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Board boar = new Board(8, 8);

                boar.putPiece(new Tower(boar, Color.Black), new Position(0, 0));
                boar.putPiece(new Tower(boar, Color.Black), new Position(1, 9));
                boar.putPiece(new King(boar, Color.Black), new Position(0, 2));

                Screen.printBoard(boar);

            }
            catch (BoardException e)
            {
                Console.WriteLine(e.Message);
            }            
        }
    }
}
