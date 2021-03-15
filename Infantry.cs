using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Infantry : Personnel
    {
        public Infantry()
        {
            UnitType = UnitType.Infantry;
            WeaponType = WeaponType.Musket;
        }

        public override string DisplayInfo(ref Personnel person)
        {
            string unitInfo = $"The most common unit of the Civil War was the Infantryman.\n";
            return unitInfo;
        }
    }
}
