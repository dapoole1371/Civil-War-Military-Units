using System;
using System.Collections.Generic;
using System.Text;

namespace Ex_7A_Military_Unit
{
    class Personnel
    {
        public UnitType UnitType { get; set; }
        protected WeaponType WeaponType { get; set; }
    
        public virtual string DisplayInfo(ref Personnel person)
        {
            return "No unit selected.";
        }

        public Personnel SetType(ref Personnel person, int input)
        {
            switch(input)
            {
                case 1:
                    Infantry infantry = new Infantry();
                    person = infantry;
                    return person;
                case 2:
                    Cavalier cav = new Cavalier();
                    person = cav;
                    return person;
                case 3:
                    Artilleryman arty = new Artilleryman();
                    person = arty;
                    return person;
                default:
                    return person;
            }
        }
    }
}
