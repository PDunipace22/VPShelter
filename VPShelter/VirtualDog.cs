﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualDog : VirtualPet
    {
        private string petType;
        private string petDiet;

        public string PetType
        {
            get { return this.petType; }
            set { this.petType = value; }
        }
        public string PetDiet
        {
            get { return this.petDiet; }
            set { this.petDiet = value; }
        }
    
        #region constructors
        public VirtualDog()
        { 
        }
        public VirtualDog(string name, string description, string petType, string petDiet)
        {
            Name = name;
            Description = description;
            PetType = petType;
            PetDiet = petDiet;
        }
        public VirtualDog(string name, bool isHungry, bool isThirsty, bool isBored, bool isTired, bool isSick)
        {
            this.Name = name;
            this.IsHungry = isHungry;
            this.IsThirsty = isThirsty;
            this.IsBored = isBored;
            this.IsTired = isTired;
            this.IsSick = isSick;
        }
        #endregion
    }
}
