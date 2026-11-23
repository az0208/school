using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worktorasah54
{
    internal class Worker
    {
        private string name;
        private int ID;
        private int years;
        private int pay;
        public Worker(string name, int ID, int years, int pay)
        {
            this.name = name;
            this.ID = ID;
            this.years = years;
            this.pay = pay;
        }
        public override string ToString()
        {
            return name  + " " + ID + " " + years + " " + pay;
        }
    }
}
