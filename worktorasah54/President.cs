using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worktorasah54
{
    internal class President:Manager
    {
        private int presidentyears;
        public President(string name, int ID, int years, int pay, int managementyears, string managementclass, int presidentyears) : base(name, ID, years, pay, managementyears, managementclass)
        {
            this.presidentyears = presidentyears;
        }
        public override string ToString()
        {
            return base.ToString() + " " + presidentyears.ToString();
        }
    }
}
