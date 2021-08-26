using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_of_life.Models
{
    class Cell
    {
        public int RowNumber { get; set; }
        public int ColumnNumber { get; set; }
        public bool IsAlive { get; set; }

        public Cell(int x, int y)
        {
            RowNumber = x;
            ColumnNumber = y;
            IsAlive = false;
        }
    }
}
