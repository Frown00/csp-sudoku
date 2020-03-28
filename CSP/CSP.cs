using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using CSP;
using CSP.common;
using System.Threading;

namespace program
{
    public class CSP
    {
        enum Problem {
            SUDOKU,
            JOLKA
        }
        public CSP()
        {
            run(problem: Problem.SUDOKU, visualize: true);
        }

        private void run(Problem problem = Problem.SUDOKU, bool visualize = false, int board = 1)
        {
            board -= 1;
            if(problem == Problem.SUDOKU)
            {
                List<SudokuBoard> sudokuBoards = Loader.ReadSudokuBoards();
                if(board < sudokuBoards.Count && board >= 0)
                {
                    SudokuBoard chosen = sudokuBoards[board];
                    SudokuGame sudoku = new SudokuGame(chosen);
                    if (visualize)
                    {
                        var sudokuView = new Sudoku(sudoku.Fields);
                        sudokuView.Show();
                        sudokuView.Refresh();
                        //for (int i = 0; i < 10; i++)
                        //{
                        //    sudokuView.ChangeCellVal(0, i.ToString());
                        //    sudokuView.Refresh();
                        //}
                    }
                }
                ///
            }
            
            
        }
    }
}
