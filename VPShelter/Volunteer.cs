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

        public string FeedAll(List<VirtualPet> Food)
        {
            foreach (VirtualPet pet in Food)
            {
                if (pet.IsHungry)
                {
                    pet.Feed();
                }
            }
            return "All the pets have been fed.";
        }

        public string WaterAll(List<VirtualPet> Water)
        {
            foreach (VirtualPet pet in Water)
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

        public override void Menu(VirtualPetShelter shelter)
        {
            string choice = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Volunteer Menu");
                shelter.ShelterStatus();
                Console.WriteLine("1.Feed all");
                Console.WriteLine("2.water all");
                Console.WriteLine("3.Clock Out");
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        Console.WriteLine(FeedAll(shelter.Pets));
                        Console.WriteLine("Please press enter to continue.");
                        Console.ReadLine();
                        break;
                    case "2":
                        Console.WriteLine(WaterAll(shelter.Pets));
                        Console.WriteLine("Please press enter to continue.");
                        Console.ReadLine();
                        break;
                    case "3":
                        ClockOut();
                        Console.WriteLine("Have a good day.");
                        Console.WriteLine("Please press enter to continue.");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
                shelter.TickAll();
            } while (choice.ToLower() != "x");
        }
    }
}
