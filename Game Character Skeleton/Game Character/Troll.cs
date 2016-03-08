using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Troll : Character, IWeapon
    {
        public Troll(String name)
            : base(name)
        {
            weapon = new WeaponKnife();
        }

        public override string Declaim()
        {
            return "Trolls dont have time to chat";
        }
    }
}
