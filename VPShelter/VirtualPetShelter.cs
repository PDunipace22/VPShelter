using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPetShelter
    {
        private List<Employee> people = new List<Employee>(0);
        private List<VirtualPet> pets = new List<VirtualPet>(0);

        public List<Employee> People
        {
            get { return this.people; }
            set { this.people = value; }
        }
        public List<VirtualPet> Pets
        {
            get { return this.pets; }
            set { this.pets = value; }
        }
    }
}
