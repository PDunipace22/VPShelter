using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    class Program
    {
        static void Main(string[] args)
        {
            VirtualPetShelter shelter = new VirtualPetShelter();
            InitializeMe(shelter);
            string choice = string.Empty;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome to Peter's Virtual Pet Shelter. What employee type are you?");
                Console.WriteLine("1.Manager");
                Console.WriteLine("2.Volunteer");
                Console.WriteLine("3.Tick");
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        int managerIndex = PickManager(shelter.People);
                        if (managerIndex > -1)
                        {
                            shelter.People[managerIndex].Menu(shelter);
                        }
                        break;
                    case "2":
                        int volunteerIndex = PickVolunteer(shelter.People);
                        if (volunteerIndex > -1)
                        {
                            shelter.People[volunteerIndex].Menu(shelter);
                        }
                        break;
                    default:
                        break;
                }
                shelter.TickAll();
            } while (choice.ToLower() != "x");
        }



        static int PickManager(List<Employee> people)
        {
            string choice = string.Empty;
            int foo = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome Manager, who are you?");
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].GetType() == typeof(Manager))
                    {
                        Console.WriteLine(i + "." + people[i].Name);
                    }

                }
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                for (int i = 0; i < people.Count; i++)
                {
                    if (i.ToString() == choice && people[i].GetType() == typeof(Manager))
                    {
                        foo = i;
                    }
                }
            } while (choice.ToLower() != "x" && foo == -1);
            return foo;
        }

        static int PickVolunteer(List<Employee> people)
        {
            string choice = string.Empty;
            int foo = -1;

            do
            {
                Console.Clear();
                Console.WriteLine("Welcome Volunteer, who are you?");
                for (int i = 0; i < people.Count; i++)
                {
                    if (people[i].GetType() == typeof(Volunteer))
                    {
                        Console.WriteLine(i + "." + people[i].Name);
                    }

                }
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                for (int i = 0; i < people.Count; i++)
                {
                    if (i.ToString() == choice && people[i].GetType() == typeof(Volunteer))
                    {
                        foo = i;
                    }
                }
            } while (choice.ToLower() != "x" && foo == -1);
            return foo;
        }

      

        static void InitializeMe(VirtualPetShelter shelterName)
        {
            shelterName.People.Add(new Manager("Bob", "B.D.", "Boss", "five hundred dollars"));
            shelterName.People.Add(new Manager("Joe", ".J.K.", "Day", "Minimum wage"));
            shelterName.People.Add(new Manager("Frank", "F.J.", "Evenings", "twenty dollars an hour"));
            shelterName.People.Add(new Manager("John", "J.D.", "Nights", "thirdy dollars and hour"));
            shelterName.People.Add(new Volunteer("Steven", "S.K.", "Cat"));
            shelterName.People.Add(new Volunteer("Jason", "J.N.", "Dog"));
            shelterName.People.Add(new Volunteer("Mark", "M.V.", "Bird"));

            shelterName.Pets.Add(new VirtualBird("Sam", false, false, false, false, false));
            shelterName.Pets.Add(new VirtualCat("Cameo", false, false, false, false, false));
            shelterName.Pets.Add(new VirtualDog("Fido", false, false, false, false, false));
        }
    }
}   

