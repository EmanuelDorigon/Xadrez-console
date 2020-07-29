using System;
using System.Collections.Generic;
using board;

namespace Xadrez_console
{
    class Screen
    {
        public static void printBoard(Board bor)
        {

            for (int i = 0; i < bor.Lines; i++)
            {
                for (int j = 0; j < bor.Columns; j++) 
                {
                    if (bor.piece(i, j) == null)
                    {
                        Console.Write("- ");
                    }
                    else
                    {
                        Console.Write(bor.piece(i, j) + " ");
                    }
                }
                Console.WriteLine();


            }
        }
    }
}
