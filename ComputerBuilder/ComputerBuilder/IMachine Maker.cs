using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    interface IMachine_Maker
    {
        public abstract void makeCPU();
        public abstract void makeGraphicsCard();
        public abstract void makeMemory();

    }
}
