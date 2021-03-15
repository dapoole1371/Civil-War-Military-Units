using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Weapon
    {
        protected string Name { get; set; }        
        protected string Weight { get; set; }
        protected WeaponType WeaponType { get; set; }
        protected UnitType UnitType { get; set; }

        public Weapon SetType(ref Weapon weapon, UnitType unitType)
        {
            if (unitType == UnitType.Infantry)
            {
                Musket musket = new Musket();
                weapon = musket;
                return weapon;
            }
            if (unitType == UnitType.Cavalier)
            {
                Sword sword = new Sword();
                weapon = sword;
                return weapon;
            }
            if (unitType == UnitType.Artilleryman)
            {
                Howitzer cannon = new Howitzer();
                weapon = cannon;
                return weapon;
            }
            else
                return weapon;
        }
        
        public virtual string WeaponDetails(ref Weapon weapon)
        {
            return $"The {Name} was the most common {WeaponType} in use during the American Civil War.\nThe {WeaponType} weighed {Weight}.";
        }

        public virtual string Operate(ref Weapon weapon)
        {
            return "No weapon selected.";
        }
    }
}
