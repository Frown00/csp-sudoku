using System;
using System.Collections.Generic;
using System.Text;

namespace CSP.common
{
    public class Cell
    {
        public int Id { get; set; }
        public string Value { get; set; }

        public Cell(int id, string val)
        {
            Id = id;
            Value = val;
        }

        public override string ToString()
        {
            return Value;
        }
    }
}
