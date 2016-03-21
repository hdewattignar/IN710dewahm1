using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MixAndMatch
{
    public partial class Form1 : Form
    {
        CharacterMaker maker;
        Character character;
        public Form1()
        {
            InitializeComponent();

            //populate combo box
            cb_Head.DataSource = Enum.GetValues(typeof(CharacterTypes));
            cb_Body.DataSource = Enum.GetValues(typeof(CharacterTypes));
            cb_Feet.DataSource = Enum.GetValues(typeof(CharacterTypes));

            
            pb_Head.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_Body.SizeMode = PictureBoxSizeMode.AutoSize;
            pb_Feet.SizeMode = PictureBoxSizeMode.AutoSize;
            
        }

        private void btn_MakeMonster_Click(object sender, EventArgs e)
        {
            maker = new CharacterMaker();
            character = maker.createCharacter((int)cb_Head.SelectedValue, (int)cb_Body.SelectedValue, (int)cb_Feet.SelectedValue);

            pb_Head.BackgroundImage = character.Head.Image;
            pb_Body.BackgroundImage = character.Body.Image;
            pb_Feet.BackgroundImage = character.Feet.Image;
        }
    }
}
