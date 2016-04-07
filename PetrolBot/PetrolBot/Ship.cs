using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PetrolBot
{
    public class Ship
    {
        int petrol;        
        Color shipColour;
        Point shipLocation;       
        int shipSize;
        EShipState shipState;
        Point shipVelocity;
        Graphics shipCanvas;
        Random rgen;

        public delegate void OutOfFuelEventHandler(object ship, ShipEventArgs shipArgs);
        public event OutOfFuelEventHandler OutOfFuelEvent;

        public delegate void FullOfFuelEventHandler(object ship, ShipEventArgs shipArgs);
        public event FullOfFuelEventHandler FullOfFuelEvent; 

        public Point ShipLocation
        {
            get { return shipLocation; }
            set { shipLocation = value; }
        }

        public int Petrol
        {
            get { return petrol; }
            set { petrol = value; }
        }

        public Ship(Graphics shipCanvas, int shipSize)
        {
            this.shipCanvas = shipCanvas;
            rgen = new Random();
            petrol = 100;
            shipColour = Color.Red;
            shipLocation = new Point(rgen.Next(600), rgen.Next(600));
            this.shipSize = shipSize;
            shipState = EShipState.wandering;
            shipVelocity = new Point(5, 5);

        }

        public void drawShip()
        {
            double petrolRatio = petrol / 100.0;
            double redValue = 255 * petrolRatio;
            shipColour = Color.FromArgb((int)redValue, 0, 0);
            SolidBrush shipBrush = new SolidBrush(shipColour);

            shipCanvas.FillRectangle(shipBrush, shipLocation.X, shipLocation.Y, shipSize, shipSize);
        }

        public void moveShip()
        {
            if(shipLocation.X < 0)
            {
                shipVelocity.X = 5;
            }
            if (shipLocation.Y < 0)
            {
                shipVelocity.Y = 5;
            }
            if (shipLocation.X > 550)
            {
                shipVelocity.X = -5;
            }
            if (shipLocation.Y > 550)
            {
                shipVelocity.Y = -5;
            }

            shipLocation.X += shipVelocity.X;
            shipLocation.Y += shipVelocity.Y;
            usePetrol();
        }

        public void OnFullOfFuelEvent()
        {
            ShipEventArgs shipArgs = new ShipEventArgs(shipState);

            if (FullOfFuelEvent != null)
                FullOfFuelEvent(this, shipArgs);
        }

        public void OnOutOfFuelEvent()
        {
            ShipEventArgs shipArgs = new ShipEventArgs(shipState);

            if (OutOfFuelEvent != null)
                OutOfFuelEvent(this, shipArgs);
        }

        public void refuel()
        {
            petrol += 5;
        }

        public void ShipCycle()
        {
            if (petrol == 100)
            {
                shipState = EShipState.wandering;
                OnFullOfFuelEvent();
            }
                
            if (petrol == 0)
                shipState = EShipState.refueling;

            if(shipState == EShipState.wandering)
            {
                drawShip();
                moveShip();
            }
            else
            {                
                drawShip();
                OnOutOfFuelEvent();
            }
                
        }

        public void usePetrol()
        {
            petrol -= 1;
        }






    }
}
