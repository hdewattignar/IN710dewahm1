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
        bool tablesCreated = false;        
        String status;
        SqlConnection bitdevConnection;
        public Manager()
        {
            status = "Not Connected";
        }

        public String Setup()
        {
            openConnection();

            createTables();

            if(tablesCreated)
                populateDataBase();

            return status;
        }        

        public void openConnection()
        {
            try
            {
                bitdevConnection = new SqlConnection();

                bitdevConnection.ConnectionString = "Data Source = bitdev.ict.op.ac.nz;" +
                                                    "Initial Catalog = IN700001_201601_DEWAHM1;" +
                                                    "User ID = dewahm1;" +
                                                    "Password = xxxxxx;" +
                                                    "MultipleActiveResultSets=true;";

                bitdevConnection.Open();

                connectionOpen = true;

                status = "Connection successful. ";
            }
            catch(Exception e)
            {
                status = "Error connecting. " + e.Message;
            }
            
        }

        public void createTables()
        {
            if(connectionOpen == true)
            {
                String dropTablesIfExist = "IF OBJECT_ID(tblPaper) IS NOT NULL DROP TABLE tblPaper;" +
                                            "IF OBJECT_ID(tblTutor) IS NOT NULL DROP TABLE tblPaper;" +
                                            "IF OBJECT_ID(tblAssignment) IS NOT NULL DROP TABLE tblPaper;";                

                String createTableTutor = "CREATE TABLE tblTutor(" +
                                            "tutorID int NOT NULL," +
                                            "firstName varchar(20) NOT NULL," +
                                            "lastName varchar(20) NOT NULL," +
                                            "email varchar(50) NOT NULL," +
                                            "PRIMARY KEY(tutorID));";

                String createTablePaper = "CREATE TABLE tblPaper(" +
                                             "paperID int NOT NULL," +
                                             "tutorID int NOT NULL," +
                                             "name varchar(255) NOT NULL," +
                                             "FOREIGN KEY (tutorID) REFFERENCES tblTutor(tutorID))" +
                                             "PRIMARY KEY(paperID));";                       

                String createTableAssignment = "CREATE TABLE tblAssignment(" +
                                            "assignmentID int NOT," +
                                            "paperID int NOT NULL," +
                                            "title varchar(20) NOT NULL," +
                                            "mark int NOT NULL," +
                                            "dueDate date," +
                                            "FOREIGN KEY (paperID) REFFERENCES tblPaper(paperID));" +
                                            "PRIMARY KEY(assignmentID));";                

                try
                {
                    SqlCommand cmdDropTablesIfExist = new SqlCommand(dropTablesIfExist, bitdevConnection);
                    cmdDropTablesIfExist.BeginExecuteNonQuery();
                    SqlCommand cmdCreateTableTutor = new SqlCommand(createTableTutor, bitdevConnection);
                    cmdCreateTableTutor.BeginExecuteNonQuery();
                    SqlCommand cmdCreateAssignment = new SqlCommand(createTableAssignment, bitdevConnection);
                    cmdCreateAssignment.BeginExecuteNonQuery();
                    SqlCommand cmdCreateTablePaper = new SqlCommand(createTablePaper, bitdevConnection);
                    cmdCreateTablePaper.BeginExecuteNonQuery();       

                    status += "Tables created. ";
                    tablesCreated = true;
                }
                catch(Exception  e)
                {
                    status += "Error creating tables. " + e.Message;
                }
            }
        }

        public void populateDataBase()
        {
            if (connectionOpen == true)
            {
                String insertTutors =   "INSERT into tblTutor" +
                                            "VALUES( '1', 'Patricia', 'Haden', 'phaden@op.ac.nz');" +
                                        "INSERT into tblTutor" +
                                            "VALUES( '2', 'David', 'Rozado', 'david.rosado@op.ac.nz');" +
                                        "INSERT into tblTutor" +
                                            "VALUES( '3', 'Tom', 'Clark', 'tom.clark@op.ac.nz');";

                String insertPapers = "INSERT into tblPapers" +
                                            "VALUES('1' ,'1', 'Object Oriented System Design');" +
                                        "INSERT into tblPapers" +
                                            "VALUES('2' ,'1', 'Design and Development for Mobile Devices');" +
                                        "INSERT into tblPapers" +
                                            "VALUES('3' ,'2', 'Web 3');" +
                                        "INSERT into tblPapers" +
                                            "VALUES('4' ,'3', 'Project');";

                String insertAssignments = "INSERT into tblAssignments" +
                                                "VALUES('1' ,'1', 'Greay Scott Diffusion','76','2016-5-2');" +
                                            "INSERT into tblAssignments" +
                                                "VALUES('2' ,'3', 'CV','85','2016-3-31');" +
                                            "INSERT into tblAssignments" +
                                                "VALUES('3' ,'3', 'Online Store','93','2016-5-2');" +
                                            "INSERT into tblAssignments" +
                                                "VALUES('4' ,'1', 'Mobile Assignment','0','2016-5-22');" +
                                            "INSERT into tblAssignments" +
                                                "VALUES('5' ,'4', 'Project Assignment','0','2016-5-19');";
                try
                {
                    SqlCommand cmdInsertTutors = new SqlCommand(insertTutors, bitdevConnection);
                    SqlCommand cmdInsertPapers = new SqlCommand(insertPapers, bitdevConnection);
                    SqlCommand cmdInsertAssignments = new SqlCommand(insertAssignments, bitdevConnection);

                    cmdInsertTutors.BeginExecuteNonQuery();
                    cmdInsertPapers.BeginExecuteNonQuery();
                    cmdInsertAssignments.BeginExecuteNonQuery();

                    status += "Tables populated. ";
                }
                catch(Exception e)
                {
                    status += "Error populating tables. " + e.Message;
                }
                
            }
        }
    }
}
