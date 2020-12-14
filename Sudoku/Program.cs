using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sudoku
{
    class Program
    {
        static void Main(string[] args)
        {
            var p = new Puzzle();
            p.SetItem(1, 1, 1);
            p.SetItem(1, 4, 2);
            p.SetItem(1, 5, 5);
            p.SetItem(1, 7, 5);

            p.SetItem(2, 1, 7);
            p.SetItem(2, 4, 1);
            p.SetItem(2, 5, 3);
            p.SetItem(2, 7, 5);

            p.SetItem(3, 1, 9);
            p.SetItem(3, 4, 6);
            p.SetItem(3, 5, 1);
            p.SetItem(3, 7, 8);

            p.Draw();

            Console.ReadLine();
        }
    }
}
