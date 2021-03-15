using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Artilleryman : Personnel
    {
        public Artilleryman()
        {
            WeaponType = WeaponType.Howitzer;
            UnitType = UnitType.Artilleryman;
        }

        public override string DisplayInfo(ref Personnel person)
        {
            return "The Artilleryman was important on the Civil War battlefield, sometimes deciding who won or lost.\nArtillery provided exceptional fortification reduction when used\nagainst enemy positions, and also proved devastating to attacking\nforces when loaded with grapeshot.\n";
        }
    }
}
