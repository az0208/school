using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worktorasah54
{
    internal class Manager:Worker
    {
        private int managementyears;
        private string managementclass;
        public Manager(string name, int ID, int years, int pay, int managementyears, string managementclass): base(name, ID, years, pay)
        {
            this.managementyears = managementyears;
            this.managementclass = managementclass;
        }
        public override string ToString()
        {
            return base.ToString() + " " + managementyears + " " + managementclass;
        }
    }
}
