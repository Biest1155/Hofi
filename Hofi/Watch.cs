using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hofi
{
    class Watch
    {
        public Watch(string type, string date, int salary)
        {
            Type = type;
            Date = date;
            Salary = salary;
        }
        public Watch(string type, string date) : this(type, date, 0)
        {

        }



        public string Type { get; set; }
        public string Date { get; set; }
        public int Salary { get; set; }


    }
}
