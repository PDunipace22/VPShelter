using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{

    public class Volunteer : Employee
    {
        public string Likes { get; set; }

        public string FeedAll(List<VirtualPet> Foo)
        {
            foreach(VirtualPet pet in Foo)
            {
                if(pet.IsHungry)
                {
                    pet.Feed();
                }
            }
            return "All the animals are fed.";
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
            return "All the animals have been given water.";
        }
    }
}
