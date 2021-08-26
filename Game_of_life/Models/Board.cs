using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_life.Models
{
    class Board
    {
        public int Size { get; set; }
        public Cell[,] theGrid { get; set; }

        public Board(int s)
        {
            Size = s;

            theGrid = new Cell[Size, Size];

            for(int i = 0; i < Size; i++)
            {
                for(int j = 0; j < Size; j++)
                {
                    theGrid[i, j] = new Cell(i, j);
                }
            }
        }
    }
}
