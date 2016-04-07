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
    public enum EShipState { wandering, refueling};
    public partial class Form1 : Form
    {
        const int SHIP_SIZE = 40;
        int numShips;
        List<PetrolBot> botList;
        List<Ship> shipList;
        Graphics mainCavas;


        public Form1()
        {
            InitializeComponent();
            mainCavas = CreateGraphics();
            timer1.Enabled = true;
            shipList = new List<Ship>();
            numShips = 4;            

            for (int i = 0; i < numShips; i++ )
            {
                shipList.Add(new Ship(mainCavas, SHIP_SIZE));
            }                
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < shipList.Count; i++)
            {
                shipList[i].ShipCycle();
            }
        }
    }
}
