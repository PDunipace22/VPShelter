using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualPet
    {
        //Fields
        private bool isHungry;
        private bool isThirsty;
        private bool isBored;
        private bool isTired;
        private bool isSick;
        private string name;
        private string description;


        #region Properties
        public virtual bool IsHungry
        {
            get { return this.isHungry; }
            set { this.isHungry = value; }
        }
        public virtual bool IsThirsty
        {
            get { return this.isThirsty; }
            set { this.isThirsty = value; }
        }
        public virtual bool IsBored
        {
            get { return this.isBored; }
            set { this.isBored = value; }
        }
        public virtual bool IsTired
        {
            get { return this.isTired; }
            set { this.isTired = value; }
        }
        public virtual bool IsSick
        {
            get { return this.isSick; }
            set { this.isSick = value; }
        }
        public virtual string Name
        {
            get { return this.name; }
            set { this.name = value; }
        }
        public virtual string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }
        #endregion 

        //Constructors
        public VirtualPet()
        {
            
        }
        public VirtualPet(string name, string description)
        {
            this.name = name;
            this.description = description;
        }
        public VirtualPet(string name,string description, bool isHungry, bool isThirsty, bool isBored, bool isTired, bool isSick)
        {
            this.name = name;
            this.description = description;
            this.isHungry = isHungry;
            this.isThirsty = isThirsty;
            this.isBored = isBored;
            this.isTired = isTired;
            this.isSick = isSick;
        }
        
        //Methods
        public string Feed()
        {
            string message = string.Empty;
            if (isHungry)
            {
                message = "You just fed " + this.name;
            }
            else
            {
                message =  this.name + " is not hungry right now.";
            }
            Tick();
            isHungry = false;
            return message;
        }

        public string GiveDrink()
        {
            string message = string.Empty;
            if (isThirsty)
            {
                message = "You just gave " + this.name + " pet a drink.";
            }
            else
            {
                message = "Sam is not thirsty right now.";
            }
            Tick();
            isThirsty = false;
            return message;
        }

        public string Play()
        {
            string message = string.Empty;
            if (isBored)
            {
                message = "You just finished talking to Sam.";
            }
            else
            {
                message = "Sam is already talking to himself.";
            }
            Tick();
            isBored = false;
            return message;
        }
        public string Sleep()
        {
            string message = string.Empty;
            if (isTired)
            {
                message = "Sam just took a nap.";
            }
            else
            {
                message = "Sam already took a nap.";
            }
            Tick();
            isTired = false;
            return message;
        }
        public string Health()
        {
            string message = string.Empty;
            if (isSick)
            {
                message = "Sam just went to the vet.";
            }
            else
            {
                message = "Sam already went to the vet.";
            }
            Tick();
            isSick = false;
            return message;
        }
        public void Tick()
        {
            Random careOptions = new Random();
            isHungry = (careOptions.Next(1, 5) == 3 || isHungry);
            isBored = (careOptions.Next(1, 7) == 1 || isBored);
            isTired = (careOptions.Next(1, 8) == 7 || isTired);
            isSick = (careOptions.Next(1, 20) == 10 || isSick);
            isThirsty = (careOptions.Next(1, 5) == 3 || isThirsty);
        }
    }
}
