using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualBird : VirtualPet
    {
        private bool isChirping;

        public bool IsChirping
        {
            get { return this.isChirping; }
            set { this.isChirping = value; }
        }

        public VirtualBird()
        {

        }
        public VirtualBird(string name, bool isHungry, bool isThirsty, bool isBored, bool isTired, bool isSick)
        {
            this.Name = name;
            this.IsHungry = isHungry;
            this.IsThirsty = isThirsty;
            this.IsBored = isBored;
            this.IsTired = isTired;
            this.IsSick = isSick;
        }
        

        public string GiveTreat()
        {
            string message = string.Empty;
            if (isChirping)
            {
                message = "You gave your bird a treat.";
            }
            else
            {
                message = "The bird already had a treat.";
            }
            isChirping = false;
            return message;
        }

    }
}
