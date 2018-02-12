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
        public Manager(string name, string intitials, string shift, string pay)
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

        public override void Menu(VirtualPetShelter shelter)
        {
            string choice = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Manager Menu");
                shelter.ShelterStatus();
                Console.WriteLine("1.Adoptions");
                Console.WriteLine("2.Play with pet");
                Console.WriteLine("3.Clock Out");
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        PickPetForAdoption(shelter.Pets);
                        break;
                    case "2":
                        PickPetForPlay(shelter.Pets);
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

        static void PickPetForAdoption(List<VirtualPet> critters)
        {
            string choice = string.Empty;
            int foo = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Please pick a pet to adopt.");
                for (int i = 0; i < critters.Count; i++)
                {
                    Console.WriteLine(i + "." + critters[i].Name);
                }
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                for (int i = 0; i < critters.Count; i++)
                {
                    if (i.ToString() == choice)
                    {
                        foo = i;
                    }
                }
            } while (choice.ToLower() != "x" && foo == -1);
            critters.RemoveAt(foo);
            Console.WriteLine("Congrats on successfully adopting a virtual pet.");
            Console.WriteLine("Please press enter to continue.");
            Console.ReadLine();
        }

        static void PickPetForPlay(List<VirtualPet> critters)
        {
            string choice = string.Empty;
            int foo = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Please pick a pet to play with.");
                for (int i = 0; i < critters.Count; i++)
                {
                    Console.WriteLine(i + "." + critters[i].Name);
                }
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                for (int i = 0; i < critters.Count; i++)
                {
                    if (i.ToString() == choice)
                    {
                        foo = i;
                    }
                }
            } while (choice.ToLower() != "x" && foo == -1);
            critters[foo].Play();
            Console.WriteLine("Thank you for playing with " + critters[foo].Name);
            Console.WriteLine("Please press enter to continue.");
            Console.ReadLine();
        }
    }
}
