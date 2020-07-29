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
            Board boar = new Board(8, 8);

            boar.putPiece(new Tower(boar, Color.Black), new Position(0, 0));
            boar.putPiece(new Tower(boar, Color.Black), new Position(1, 3));
            boar.putPiece(new King(boar, Color.Black) , new Position(2, 4));

            Screen.printBoard(boar);



        }
    }
}
