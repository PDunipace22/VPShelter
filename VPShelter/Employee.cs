using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        //fields
        private string name;
        private string initials;
        private string employeeType;
        private bool present = false;

        //Properties
        public string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public string Initials
        {
            get { return this.initials; }
            set { this.initials = value; }
        }
        public string EmployeeType
        {
            get { return this.employeeType; }
            set { this.employeeType = value; }
            //{
            //    if (value == "v" || value == "m")
            //    {
            //        this.employeeType = value;
            //    }
            //}
        }
        public bool Present
        {
            get { return this.present; }
            set { this.present = value; }
        }

        //method
        public abstract void ClockIn();

        public abstract void ClockOut();

        public abstract void Menu(VirtualPetShelter shelter);
    }
}
