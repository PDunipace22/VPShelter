using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class Manager : Employee
    {
        //fields
        private string pay;
        private string shift;

        public string Pay
        {
            get { return this.pay; }
            set { this.pay = value; }
        }
        public string Shift
        {
            get { return this.shift; }
            set { this.shift = value; }
        }

        //Constructor
        public Manager()
        {

        }
        public Manager(string name,string intitials, string shift, string pay)
        {
            Name = name;
            Initials = intitials;
            Shift = shift;
            Pay = pay;
        }
        //Methods
        public override void ClockIn()
        {
            Present = true;
        }

        public override void ClockOut()
        {
            Present = false;
        }

        
    }
}
