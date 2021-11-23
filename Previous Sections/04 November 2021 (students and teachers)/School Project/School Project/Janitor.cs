using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace School_Project
{
    class Janitor : Employee
    {
        // Fields
        private int id;
        

        public Janitor(ref int employees, ref int janitors)
        {
            employees++;
            janitors++;
            this.id = employees;
        }

    }
}
