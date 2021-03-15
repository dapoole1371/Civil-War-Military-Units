using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Sword : Weapon
    {
        private string Length { get; set; }

        public Sword()
        {
            Name = "M1860 Light Cavalry Saber";
            Weight = "2lb 4oz";
            Length = "41 inches";
            UnitType = UnitType.Cavalier;
        }

        public override string WeaponDetails(ref Weapon weapon)
        {
            string details = $"The {Name} was the most common weapon used by the Cavalry during the American Civil War.\n The {Name} weighed {Weight} and was {Length} long.\n";

            return details;
        }

        public override string Operate(ref Weapon weapon)
        {
            return $"To operate the {Name}, you simply got close enough to the enemy, and swung the sword!\n";
        }
    }
}
