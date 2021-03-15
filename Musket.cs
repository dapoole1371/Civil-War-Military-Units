using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Musket : Weapon
    {
        public Musket()
        {
            Name = "Springfield M1861 rifled musket";
            Weight = "9lb";
            WeaponType = WeaponType.Musket;
            UnitType = UnitType.Infantry;
        }

        public override string WeaponDetails(ref Weapon weapon)
        {
            return $"The {Name} was the most widely used musket during the American Civil War.\nIt was the main weapon for the infantry.\nThe {Name} weighed {Weight}.\n";
        }
        public override string Operate(ref Weapon weapon)
        {
            return $"To operate the {Name}, a soldier had to tear open a powder cartridge,\n pour the powder down the barrel,\npush the paper wrapper into the barrel with a musket ball,\n then ram it all down with a ramrod.\nAfter replacing the ramrod, a percussion cap was placed under the hammer,\nthe trigger was pulled causing the rifle to fire.";
        }
    }
}
