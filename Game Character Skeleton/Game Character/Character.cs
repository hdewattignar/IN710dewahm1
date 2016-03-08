using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Game_Character
{
    abstract class Character
    {

        protected String name;
        protected IWeapon weapon;

        public Character(String name)
        {
            this.name = name;
        }

        public String StateName()
        {
            return "My name is " + name;
        }

        public String Battle()
        {
            return weapon.UseWeapon();
        }

        abstract public  String Declaim();   


    }
}
