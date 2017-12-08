using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hofi
{
    class Controller
    {
        DatabaseConnectionPoint DatabaseCon = new DatabaseConnectionPoint();
        
        public void spinningOrFitnessController(string watchType, string memberNumber, string date)
        {
            Console.Clear();
            DatabaseConnectionPoint DatabaseCon = new DatabaseConnectionPoint();
            Watch watch = new Watch(watchType, date);

            Instructor instructor = new Instructor(memberNumber);
            

            DatabaseCon.RegisterWatch(watch, instructor);

        }

        internal void AddInstructorSQL(string memberNumber, string name, string mail, string hireDate)
        {
            Instructor instructor = new Instructor(memberNumber, name, mail, hireDate);

            DatabaseCon.AddInstructorSQL(instructor);
        }
    }

}
