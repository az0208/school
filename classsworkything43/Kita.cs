using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace classsworkything43
{
    public class Kita
    {
        private int count;
        private Table[] t = new Table[35];
        public Kita()
        {
            this.count = 0;
            this.t = new Table[35];
        }
        public int Getcount()
        {
            return count;
        }
        public int HowMany()
        {
            return this.count;
        }
        public bool IsOk(int n)
        {
            if (n <= count * 2)
            {
                return true;
            }
            return false;
        }
    }
}
