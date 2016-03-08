using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Game_Character
{
   
    public partial class Form1 : Form
    {

        List<Character> characterList = new List<Character>();

        public Form1()
        {
            InitializeComponent();            

            characterList.Add(new King("Dennis", BattleBox));
            characterList.Add(new Queen("Dee", BattleBox));
            characterList.Add(new Knight("Mac", BattleBox));
            characterList.Add(new Knight("Charlie", BattleBox));
            characterList.Add(new Troll("Frank", BattleBox));

            for (int i = 0; i < characterList.Count; i++ )
                checkedListBox1.Items.Add(characterList[i].getName());
        }

        private void btnAddCharacter_Click(object sender, EventArgs e)
        {
            //characterList.Add()
        }

        private void btnBattle_Click(object sender, EventArgs e)
        {
            List<Character> checkedList = new List<Character>();

            for (int i = 0; i < checkedListBox1.CheckedItems.Count; i++)
            {
                for (int j = 0; j < characterList.Count; j++)
                {
                    if (characterList[j].getName() == (String) checkedListBox1.CheckedItems[i])
                    {
                        checkedList.Add(characterList[j]);
                    }
                }
            }

            for (int i = 0; i < checkedList.Count; i++)
            {
                BattleBox.Items.Add("----------------------------------------------------------------------------------------------");
                checkedList[i].StateName();
                checkedList[i].Declaim();
                checkedList[i].Battle();
                BattleBox.Items.Add("----------------------------------------------------------------------------------------------");
            }
        }

        private void btn_changeWeapon(object sender, EventArgs e)
        {

        }


    }
}
