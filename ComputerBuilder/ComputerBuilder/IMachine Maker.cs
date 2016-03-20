using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComputerBuilder
{
    interface IMachine_Maker
    {
        public abstract Processor makeCPU();
        public abstract GraphicsCard makeGraphicsCard();
        public abstract Memory makeMemory();

    }
}
