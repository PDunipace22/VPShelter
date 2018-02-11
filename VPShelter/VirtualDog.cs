using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VPShelter
{
    public class VirtualDog : VirtualPet
    {
        private bool isBarking;

        public bool IsBarking
        {
            get { return this.isBarking; }
            set { this.isBarking = value; }
        }
        #region constructors
        public VirtualDog()
        {
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

        public string GiveTreat()
        {
            string message = string.Empty;
            if (isBarking)
            {
                message = "You gave the dog a treat.";
            }
            else
            {
                message = "The dog already had a treat.";
            }
            isBarking = false;
            return message;
        }
    }
}
