using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    class Queen : Character
    {
        public Queen(String name)
            : base(name)
        {
            weapon = new WeaponBow();
        }

        public override string Declaim()
        {
            return "I am a powerful Queen!";
        }
       
    }
}
