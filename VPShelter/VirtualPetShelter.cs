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

        public void TickAll()
        {
            foreach (VirtualPet pet in this.pets)
            {
                pet.Tick();
            }
        }

        public void ShelterStatus()
        {
            Console.WriteLine("This is the status of your pets:");
            Console.WriteLine("{0,-15} {1,-8} {2,-8} {3,-8} {4,-8} {5,-8}", "Name", "Hungry", "Thirsty", "Bored", "Sleeping", "Sick");
            Console.WriteLine("{0,-15} {1,-8} {2,-8} {3,-8} {4,-8} {5,-8}", "----------", "--------", "--------", "--------", "--------", "--------");
            foreach (VirtualPet pet in this.pets)
            {
                Console.WriteLine("{0,-15} {1,-8} {2,-8} {3,-8} {4,-8} {5,-8}", pet.Name, pet.IsHungry, pet.IsThirsty, pet.IsBored, pet.IsTired, pet.IsSick);
            }
            Console.WriteLine(string.Empty);
        }
    }
}
