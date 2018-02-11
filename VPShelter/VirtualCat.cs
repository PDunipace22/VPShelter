using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualCat : VirtualPet
    {
        private bool isMeowing;

        public bool IsMeowing
        {
            get { return this.isMeowing; }
            set { this.isMeowing = value; }
        }

        public VirtualCat()
        {

        }
        public VirtualCat(string name, bool isHungry, bool isThirsty, bool isBored, bool isTired, bool isSick)
        {
            this.Name = name;
            this.IsHungry = isHungry;
            this.IsThirsty = isThirsty;
            this.IsBored = isBored;
            this.IsTired = isTired;
            this.IsSick = isSick;
        }
       

        public string GiveTreats()
        {
            string message = string.Empty;
            if (isMeowing)
            {
                message = "You gave the cat a treat.";
            }
            else
            {
                message = "The cat already had a treat.";
            }
            isMeowing = false;
            return message;
        }
    }
}
