using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classsworkything43
{
    internal class Table
    {
        private int line;
        private char tur;
        public Table(int line, char tur)
        {
            this.line = line;
            this.tur = tur;
        }
        public int GetLine()
        {
            return this.line;
        }
        public int GetTur()
        {
            return this.tur;
        }

    }
}
