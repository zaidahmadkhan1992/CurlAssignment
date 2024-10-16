using System.Data.SqlClient;

namespace Demo.HelperFunctions
{
    public  class UtilityFunctions : IUtilityFunctions
    {
        public  void writeToMySQL()
        {
           // string constr = ConfigurationManager.["sqlString"].ConnectionString;
            using (SqlConnection sqlCon = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=master;Integrated Security=True"))
            {
                try
                {
                    sqlCon.Open();
                    SqlCommand sqlCmd = new SqlCommand("LOAD DATA INFILE 'adp-sample-data.csv' INTO TABLE sdcdbftest.importexport;", sqlCon);
                    sqlCmd.ExecuteNonQuery();
                }
                catch (SqlException)
                {
                    throw;
                }
            }
        }
    }
}