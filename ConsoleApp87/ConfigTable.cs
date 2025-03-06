using Microsoft.Data.SqlClient;

public class Conf
{

    public Conf(string SqlConnectionString, string a1, string a1 = null, string a3 = null)
    {
        var storageAccount = new SqlConnection(SqlConnectionString);
        storageAccount.Open();
        string sqlQueryString = $"SELECT * FROM {a1} WHERE region = '{a2}' AND timeSeries_bodyType = '{a3}' AND active = 1;";
        SqlCommand sqlQuery = new SqlCommand(sqlQueryString, storageAccount);
        SqlDataReader reader = sqlQuery.ExecuteReader();

    }

}
