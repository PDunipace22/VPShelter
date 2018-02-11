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
                Console.WriteLine("Welcome to Big Al's Virtual Pet Shelter. What employee type are you?");
                Console.WriteLine("1.Manager");
                Console.WriteLine("2.Volunteer");
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                switch(choice)
                {
                    case "1":
                        PickManager(shelter.People);
                        break;
                    case "2":
                        break;
                }
            } while (choice.ToLower() != "x");
        }

        

        static void PickManager(List<Employee> people)
        {
            string choice = string.Empty;
           
            do
            {
                Console.Clear();
                Console.WriteLine("Welcome Manager, who are you?");
                for(int i = 0; i<people.Count;i++)
                {
                    Console.WriteLine(i + "." + people[i].Name);
                }
                Console.WriteLine("x.Exit");
                choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":

                        break;
                    case "2":
                        break;
                }
            } while (choice.ToLower() != "x");
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
