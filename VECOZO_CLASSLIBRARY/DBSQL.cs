using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VECOZO_CLASSLIBRARY
{
    public class DBSQL
    {
        string connect = "Data Source = mssqlstud.fhict.local; Initial Catalog = dbi485146_vecozo; Persist Security Info=True;User ID = dbi485146_vecozo; Password=Welkom123";
        SqlConnection con = new SqlConnection();

        public SqlDataReader loadSQL(string query)
        {
            SqlConnection databaseConnection = new SqlConnection(connect);
            SqlCommand cmd = new SqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            SqlDataReader reader;
            databaseConnection.Open();
            reader = cmd.ExecuteReader();

            return (reader);
        }

        public static DataTable GetValues(string Naam, string Wachtwoord)
        {
            string query = string.Format("SELECT * FROM Gebruiker WHERE Naam = '" + Naam + "' AND Wachtwoord = '" + Wachtwoord + "'");
            SqlConnection databaseConnection = new SqlConnection("Server=mssqlstud.fhict.local;Database=dbi485146;User Id=dbi485146;Password=Welkom01;");
            SqlCommand cmd = new SqlCommand(query, databaseConnection);
            cmd.CommandTimeout = 60;
            databaseConnection.Open();

            DataTable dt = new DataTable(); //this is creating a virtual table
            dt.Load(cmd.ExecuteReader());

            return dt;
        }

    }
}
