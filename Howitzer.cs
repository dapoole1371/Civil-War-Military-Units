using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Howitzer : Weapon
    {
        public Howitzer()
        {
            Name = "M1841 Howitzer";
            Weight = "1300lb";
            WeaponType = WeaponType.Howitzer;
            UnitType = UnitType.Artilleryman;
        }

        public override string WeaponDetails(ref Weapon weapon)
        {
            return $"The {Name} was one of the most common pieces of field artillery during the Civil War.\nThe {Name} weighed approximately {Weight} and fired a 18lb projectile\nover 1000 yards.\n";
        }

        public override string Operate(ref Weapon weapon)
        {
            return $"To operate the {Name}, artillery crews had to level the cannon,\naim the cannon by adjusting the direction and elevation,\ninsert powder bags into the barrel,\nram the bags into the barrel with a ramrod,\nram a cannonball into the barrel with a ramrod,\nprime the cannon with a fuze inserted in the top rear of the barrel,\npull a lanyard to set the fuze off.\nOnce fired, the barrel had to be cleaned with a wet swab\nto prevent sparks from igniting the next charge early.\n";
        }
    }
}
