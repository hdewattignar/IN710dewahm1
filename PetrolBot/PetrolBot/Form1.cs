using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PetrolBot
{    
    public partial class Form1 : Form
    {
        const int SHIP_SIZE = 40;
        int numShips;
        List<PetrolBot> botList;
        List<Ship> shipList;

        Graphics mainCanvas;
        Bitmap offScreenBitmap;
        Graphics offScreenGraphics;


        public Form1()
        {
            InitializeComponent();

            mainCanvas = this.CreateGraphics();
            offScreenBitmap = new Bitmap(this.Width, this.Height);
            offScreenGraphics = Graphics.FromImage(offScreenBitmap);

            timer1.Enabled = true;
            shipList = new List<Ship>();
            botList = new List<PetrolBot>();
            numShips = 4;            

            for (int i = 0; i < numShips; i++ )
            {
                shipList.Add(new Ship(offScreenGraphics, SHIP_SIZE));
                botList.Add(new PetrolBot(offScreenGraphics,shipList[i], new Point(50 * (i + 1), 500)));
            }            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SolidBrush mainBrush = new SolidBrush(Color.Black);

            mainCanvas.FillRectangle(mainBrush, 200, 200, 200, 200);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            mainCanvas.DrawImage(offScreenBitmap,0,0);

            for(int i = 0; i < shipList.Count; i++)
            {
                shipList[i].ShipCycle();
                botList[i].drawBot();
            }
        }
    }
}
