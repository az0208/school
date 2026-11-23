using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worktorasah54
{
    internal class Company
    {
        private string companyname;
        private int numworkers;
        private Worker[] workers;
        private int worknum;
        public Company(string companyname, int numworkers)
        {
            this.companyname = companyname;
            this.numworkers = numworkers;
            this.worknum = 0;
            Worker[] workers = new Worker[numworkers];
        }
        public void AddWorker(Worker worker)
        {
            if (numworkers > worknum)
            {
                this.workers[worknum] = worker;
                this.worknum++;
            }
        }
    }
}
