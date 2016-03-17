using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnimalWorld
{
    public partial class Form1 : Form
    {        
        Manager manager;
        List<PictureBox> pictureBoxes;
        Continent continent;
        Random rGen;

        public Form1()
        {
            InitializeComponent();
            rGen = new Random();
            
            pictureBoxes = new List<PictureBox>();
            pictureBoxes.Add(pictureBox1);
            pictureBoxes.Add(pictureBox2);
            pictureBoxes.Add(pictureBox3);
            pictureBoxes.Add(pictureBox4);

            pictureBoxes[0].

            manager = new Manager(pictureBoxes, lb_Display);           

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lb_Display.Items.Clear();
            continent = new NorthAmerica(rGen, 4);
            manager.runSimulation(continent);
        }

        private void btn_Australia_Click(object sender, EventArgs e)
        {
            lb_Display.Items.Clear();
            continent = new Australia(rGen, 3);
            manager.runSimulation(continent);
        }
    }
}
