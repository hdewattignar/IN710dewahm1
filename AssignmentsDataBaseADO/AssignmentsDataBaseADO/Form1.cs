using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AssignmentsDataBaseADO
{
    public partial class Form1 : Form
    {
        Manager manager;

        public Form1()
        {
            InitializeComponent();

            manager = new Manager();
        }

        private void btn_connect_Click(object sender, EventArgs e)
        {
            manager.openConnection();
        }

        private void btn_createTables_Click(object sender, EventArgs e)
        {
            manager.createTables();
        }

        private void btn_populateTables_Click(object sender, EventArgs e)
        {
            manager.populateDataBase();
        }
    }
}
