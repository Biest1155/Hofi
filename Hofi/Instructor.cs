using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hofi
{
    class Instructor
    {
       public Instructor(string memberNumber, string name, string mail, string hireDate)
        {
            MemberNumber = memberNumber;
            Name = name;
            Mail = mail;
            HireDate = hireDate;

        }
        public Instructor(string memberNumber) : this(memberNumber, "", "", "")
        {

        }
      
   
        public string MemberNumber { get; set; }
        public string Name { get; set; }
        public string Mail { get; set; }
        public string HireDate { get; set; }

    }
}
