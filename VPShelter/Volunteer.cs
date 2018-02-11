using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{

    public class Volunteer : Employee
    {
        private string petLikes;      

        public string PetLikes
        {
            get { return this.petLikes; }
            set { this.petLikes = value; }
        }

        public Volunteer()
        {
        }

        public Volunteer(string name, string initials, string petLikes)
        {
            Name = name;
            Initials = initials;
            PetLikes = petLikes;
        }

        public string FeedAll(List<VirtualPet> Foo)
        {
            foreach (VirtualPet pet in Foo)
            {
                if (pet.IsHungry)
                {
                    pet.Feed();
                }
            }
            return "All the pets have been fed.";
        }

        public string WaterAll(List<VirtualPet> Foo)
        {
            foreach (VirtualPet pet in Foo)
            {
                if (pet.IsThirsty)
                {
                    pet.GiveDrink();
                }
            }
            return "All the pets have been given water.";
        }

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
