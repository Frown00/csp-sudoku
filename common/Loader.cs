using System;
using System.Collections.Generic;
using System.Text;
using CsvHelper;
using System.IO;
using System.Globalization;
using System.Linq;

namespace CSP.common
{
    class Loader
    {

        public static List<SudokuBoard> ReadSudokuBoards()
        {
            string filePath = Path.GetDirectoryName(AppDomain.CurrentDomain.BaseDirectory);
            filePath = Directory.GetParent(filePath).FullName;
            filePath = Directory.GetParent(Directory.GetParent(filePath).FullName).FullName;
            filePath += @"\data\Sudoku.csv";
            using (var reader = new StreamReader(filePath))
            using (var csv = new CsvReader(reader, CultureInfo.InvariantCulture))
            {
                csv.Configuration.Delimiter = ";";
                csv.Configuration.PrepareHeaderForMatch = (string header, int index) => header.ToLower();
                var records = csv.GetRecords<SudokuBoard>().ToList();
                return records;
            }
        }
    }
}
