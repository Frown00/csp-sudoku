using System;
using System.Collections.Generic;
using System.Text;
using CSP.common;

namespace CSP.SudokuForm
{
        public class SudokuRow
        {
            public Cell Cell1 { get; set; }
            public Cell Cell2 { get; set; }
            public Cell Cell3 { get; set; }
            public Cell Cell4 { get; set; }
            public Cell Cell5 { get; set; }
            public Cell Cell6 { get; set; }
            public Cell Cell7 { get; set; }
            public Cell Cell8 { get; set; }
            public Cell Cell9 { get; set; }

            public SudokuRow(List<Cell> cells)
            {
                Cell1 = new Cell(cells[0].Id, cells[0].Value);
                Cell2 = new Cell(cells[1].Id, cells[1].Value);
                Cell3 = new Cell(cells[2].Id, cells[2].Value);
                Cell4 = new Cell(cells[3].Id, cells[3].Value);
                Cell5 = new Cell(cells[4].Id, cells[4].Value);
                Cell6 = new Cell(cells[5].Id, cells[5].Value);
                Cell7 = new Cell(cells[6].Id, cells[6].Value);
                Cell8 = new Cell(cells[7].Id, cells[7].Value);
                Cell9 = new Cell(cells[8].Id, cells[8].Value);
            }
    }
}
