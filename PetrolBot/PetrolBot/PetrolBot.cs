using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class PetrolBot
    {
        Graphics botCanvas;
        Color botColour;
        Point botCurrentLocation;
        Ship botShip;
        Point botStartingLocation;
        Point shipLocation;

        public PetrolBot(Point shipLocation, Graphics botCanvas, Ship botShip, Point botStartingLocation)
        {
            this.shipLocation = shipLocation;
            this.botCanvas = botCanvas;
            this.botShip = botShip;
            this.botStartingLocation = botStartingLocation;
        }

        public void drawBot()
        {

        }

        public void FullOfFuelEventHandler()
        {

        }

        public void OutOfFuelEventHandler()
        {

        }
    }
}
