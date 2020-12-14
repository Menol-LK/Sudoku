using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    public class Puzzle
    {
        int[,] array;

        public int this[int row, int column]
        {
            get
            {
                return array[row-1, column-1];
            }
        }

        public Puzzle()
        {
            array = new int[9,9];
        }

        public void SetItem(int row, int column, int value)
        {
            array[row - 1, column - 1] = value;
        }


        public void Draw()
        {
            drawOpeningLine();
            for (int row = 0; row < array.GetLength(0); row++)
            {
                Console.Write("│");

                for (int column = 0; column < array.GetLength(1); column++)
                {
                    Console.Write(" ");
                    Console.Write(array[row, column]);
                    Console.Write(" ");
                    if((column+1) % 3 == 0)
                    {
                        Console.Write("│");
                    }
                }

                Console.WriteLine();
                if (row < 8 && (row + 1) % 3 == 0)
                {
                    drawMiddleLine();
                }
            }
            drawClosingLine();
        }


        private void drawOpeningLine()
        {
            Console.WriteLine("┌─────────┬─────────┬─────────┐");
        }

        private void drawMiddleLine()
        {
            Console.WriteLine("├─────────┼─────────┼─────────┤");

            //Console.Write("|");
            //for (int column = 0; column < array.GetLength(1); column++)
            //{
            //    Console.Write("-");
            //}
            //// Console.WriteLine();
            //Console.WriteLine("|");
        }

        private void drawClosingLine()
        {
            Console.WriteLine("└─────────┴─────────┴─────────┘");
        }
    }
}
