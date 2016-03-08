using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Knight : Character
    {
        public Knight(String name)
            : base(name)
        {
            weapon = new WeaponKnife();
        }

        public override string Declaim()
        {
            return "I am a chivalruos Knight!";
        }        
        
    }
}
