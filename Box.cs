using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace P10CarteLotoV1
{
    internal class Box
    {
        private int? value;
        private int column;
        private int line;

        public int? Value {
            get => this.value;
            private set {
                if (value < 1 || value > 90)
                {
                    throw new ArgumentException($"Unallowed box value. Expected a value between 1 (inclusive) and 90 (inclusive). Got : {value}");
                }

                this.value = value;
            }
        }

        public bool HasValue { get => (this.value != null); }

        public int Column
        {
            get => this.column;
            private set
            {
                if (value < 1 || value > 9)
                {
                    throw new ArgumentException($"Unallowed box column. Expected a value between 1 (inclusive) and 9 (inclusive). Got : {value}");
                }

                this.column = value;
            }
        }

        public int Line {
            get => this.line;
            private set
            {
                if (value < 1 || value > 3)
                {
                    throw new ArgumentException($"Unallowed box line. Expected a value between 1 (inclusive) and 3 (inclusive). Got : {value}");
                }

                this.line = value;
            }
        }

        public bool IsTicked { get; set; }

        public Box(int? value, int column, int line)
        {
            this.Value = value;
            this.Column = column;
            this.Line = line;
            this.IsTicked = false;
        }
    }
}
