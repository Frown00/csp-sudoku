using System;
using System.Collections.Generic;
using System.Text;
using CSP.common;

namespace CSP
{
    class SudokuGame
    {
        int id;
        double difficulty;
        public List<Cell> Fields { get; set; }
        public SudokuGame(SudokuBoard board)
        {
            id = board.Id;
            difficulty = board.Difficulty;
            Fields = new List<Cell>();
            AssignNumbers(board.Puzzle);
        }

        private void AssignNumbers(string puzzle)
        {
            for(int i = 0; i < puzzle.Length; i++)
            {
                string val = puzzle[i].ToString();
                if (val == ".")
                {
                    Fields.Add(new Cell(i, ""));
                } else
                {
                    Fields.Add(new Cell(i, val));
                }
            }
        }
    }
}
