using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComputerBuilder
{
    class MachineSpecPrinter
    {
        private IMachine_Maker machineMaker;
        private ListBox displayBox;

        public MachineSpecPrinter(IMachine_Maker machineMaker, ListBox displayBox)
        {
            this.machineMaker = machineMaker;
            this.displayBox = displayBox;
        }

        public void printSpec()
        {
            Processor currCPU = machineMaker.makeCPU();
            Memory currMemory = machineMaker.makeMemory();
            GraphicsCard currGraphics = machineMaker.makeGraphicsCard();

            double totalPrice = currCPU.Price + currMemory.Price + currGraphics.Price;
        }
    }
}
