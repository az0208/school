using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace classsworkything43
{
    public class School
    {
        private int classnum;
        private Kita[] Classes = new Kita[100];
        
        public School(int n)
        {
            this.Classes = new Kita[n];
            this.classnum = 0;
        }

        public Kita ShowClass(int n)
        {
            return Classes[n];
        }
        public void NewClass(Kita k)
        {
            this.Classes[this.classnum] = k;
            this.classnum++;
        }
        public int TableNum()
        {
            int sum = 0;
            for (int i = 0; i < classnum; i++)
            {
                sum = sum + Classes[i].Getcount();
            }
            return sum;
        }
        public int CheckSpace()
        {
            for (int i = 0; i < classnum; i++)
            {
                if (Classes[i].Getcount() <= 21)
                {
                    return i;
                }
            }
            return -1;
        }
    }
}
