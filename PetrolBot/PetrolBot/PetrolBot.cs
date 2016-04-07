﻿using System;
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
        Bitmap offScreenBitmap;
        Graphics offScreenGraphics;

        Color botColour;
        Point botCurrentLocation;
        Ship botShip;
        Point botStartingLocation;
        Point shipLocation;

        public PetrolBot(Graphics botCanvas, Ship botShip, Point botStartingLocation)
        {            
            this.botCanvas = botCanvas;


            this.botShip = botShip;
            this.botStartingLocation = botStartingLocation;
            botColour = Color.Red;
            botCurrentLocation = botStartingLocation;

            Ship.OutOfFuelEventHandler outOfFuelHandler = new Ship.OutOfFuelEventHandler(OutOfFuelEventHandler);
            botShip.OutOfFuelEvent += outOfFuelHandler;

            Ship.FullOfFuelEventHandler fullOfFuelHandler = new Ship.FullOfFuelEventHandler(OutOfFuelEventHandler);
            botShip.FullOfFuelEvent += fullOfFuelHandler;
        }

        public void drawBot()
        {
            SolidBrush botBrush = new SolidBrush(botColour);

            botCanvas.FillEllipse(botBrush, new Rectangle(botCurrentLocation, new Size(20,20)));
        }

        public void FullOfFuelEventHandler(object ship, ShipEventArgs shipArgs)
        {
            botCurrentLocation = botStartingLocation;
        }

        public void OutOfFuelEventHandler(object ship, ShipEventArgs shipArgs)
        {
            botCurrentLocation = botShip.ShipLocation;

            if(botShip.Petrol < 100)
            {
                botShip.Petrol += 5;
            }
            
        }
    }
}
