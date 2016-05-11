using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AssignmentsDataBaseADO
{
    public class Manager
    {
        bool connectionOpen = false;
        SqlConnection bitdevConnection;
        public Manager()
        {
            
        }

        public void openConnection()
        {
            bitdevConnection = new SqlConnection();

            bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                "Initial Catalog = World;" +
                                                "User ID = dewahm1;" +
                                                "Password = xxxxxxx;";

            bitdevConnection.Open();            

            connectionOpen = true;
        }

        public void createTables()
        {
            if(connectionOpen == true)
            {
                //create tables if the connection has been opened
            }
        }

        public void populateDataBase()
        {
            if (connectionOpen == true)
            {
                //populate tables if the connection has been opened
            }
        }
    }
}
