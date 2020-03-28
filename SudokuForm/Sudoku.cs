using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using CSP.common;
using CSP.SudokuForm;

namespace program
{
    public partial class Sudoku : Form
    {
        private DataGridView myNewGrid;  // Declare a grid for this form
        private List<SudokuRow> sudokuRows; // Declare this here so that you can use it later to manipulate the cell contents
        private List<Cell> cells;
        int columns = 9;
        int rows = 9;
        int rowHeight = 50;
        public Sudoku(List<Cell> cells)
        {
            this.cells = new List<Cell>(cells);
            BuildBoard();
        }

        private void BuildBoard()
        {
            Text = "Sudoku";
            Width = (columns + 2) * rowHeight;
            Height = (rows + 2) * rowHeight;
            myNewGrid = new DataGridView();
            myNewGrid.RowTemplate.Height = rowHeight;
            ((ISupportInitialize)(myNewGrid)).BeginInit();
            SuspendLayout();
            myNewGrid.Parent = this;  // You have to set the parent manually so that the grid is displayed on the form
            myNewGrid.Location = new Point(10, 10);  // You will need to calculate this postion based on your other controls.  
            myNewGrid.Size = new Size(10 * 50, 9 * 50);  // You said you need the grid to be 12x12.  You can change the size here.
            myNewGrid.ColumnHeadersVisible = false; // You could turn this back on if you wanted, but this hides the headers that would say, "Cell1, Cell2...."
            myNewGrid.RowHeadersVisible = false;
            myNewGrid.RowsDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            myNewGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            //myNewGrid.CellClick += MyNewGrid_CellClick;  // Set up an event handler for CellClick.  You handle this in the MyNewGrid_CellClick method, below
            ((ISupportInitialize)(myNewGrid)).EndInit();
            ResumeLayout(false);
            myNewGrid.Visible = true;
            LoadGridData();
        }

        private void LoadGridData()
        {
            
            sudokuRows = new List<SudokuRow>();
            int skipVal = 0;
            for (var i = 0; i < rows; i++)
            {
                List<Cell> rowCells = cells.Skip(skipVal).Take(columns).ToList();
                sudokuRows.Add(new SudokuRow(rowCells));
                skipVal += columns;
            }
            myNewGrid.DataSource = sudokuRows;
        }

        public void ChangeCellVal(int id, string val)
        {
            //
            cells[id].Value = val;
            LoadGridData();
        }
    }
}
