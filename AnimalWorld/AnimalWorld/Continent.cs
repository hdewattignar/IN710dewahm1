using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public abstract class Continent
    {
        public const int ANIMAL_SIM_COUNT = 4;

        protected ListBox displaybox;
        protected Random rGen;
        protected int nAnimalTypes;
        protected Graphics canvas;
        protected IAnimalFactory animalFactory;
    }
}
