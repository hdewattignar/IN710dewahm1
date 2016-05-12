using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShowAssignments
{
    public class Manager
    {
        SqlConnection bitdevConnection;

        public Manager()
        {
            connectToDB();
        }

        public void connectToDB()
        {
            bitdevConnection = new SqlConnection();

            bitdevConnection.ConnectionString =     "Data Source = bitdev.ict.op.ac.nz;" +
                                                        "Initial Catalog = IN700001_201601_DEWAHM1;" +
                                                        "User ID = dewahm1;" +
                                                        "Password = xxxxxx;" +
                                                        "MultipleActiveResultSets=true;";

            bitdevConnection.Open();
        }

        public String showPapers()
        {
            String query = "SELECT tblPaper.name, tblTutor.firstName, tblTutor.lastName, tblTutor.email" +
                                "FROM tblPaper" +
                                "JOIN tblTutor" +
                                "ON tblPaper.tutorID = tblTutor.tutorID;";

            SqlCommand command= new SqlCommand();
            command.Connection = bitdevConnection;
            command.CommandText = query;

            SqlDataReader reader;
            reader = command.ExecuteReader();

        }

        public String showAssignments()
        {

        }

        public String showMarks()
        {

        }

    }
}
