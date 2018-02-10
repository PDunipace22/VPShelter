﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public abstract class Employee
    {
        private string name;
        private string initials;
        private string employeeType;
        private bool present = false;

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
        }

        public void ClockIn()
        {
            present = true;
        }

        public void ClockOut()
        {
            present = false;
        }
    }
}
