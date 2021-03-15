using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Cavalier : Personnel
    {
        public Cavalier()
        {
            WeaponType = WeaponType.Sword;
            UnitType = UnitType.Cavalier;
        }

        public override string DisplayInfo(ref Personnel person)
        {
            return "The Cavalier was a very important unit on a Civil War battlefield, providing\nscouting reports of enemy positions, screening the army's movements\nand disrupting supply lines.\n";
        }
    }
}
