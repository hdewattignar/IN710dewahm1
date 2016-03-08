using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class King : Character
    {
        public King(String name)
            : base(name)
        {
            weapon = new WeaponSword();
        }

        public override string Declaim()
        {
            return "I am the most mighty of Kings";
        }
    }
}
