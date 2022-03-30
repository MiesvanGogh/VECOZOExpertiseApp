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

        public string GetNaam(int ID)
        {
            string FunctieNamen = "";
            DataTable dt = new();
            SqlDataAdapter da = new($"SELECT CONCAT(Voornaam, ' ', Achternaam) AS Naam FROM Gebruiker WHERE ID = {ID}", connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FunctieNamen = dr["Naam"].ToString();
            }

            return FunctieNamen;
        }

        public string GetVaardigheid (int ID)
        {
            string VaardigheidNamen = "";
            DataTable dt = new();
            SqlDataAdapter da = new($"SELECT STRING_AGG(V.Vaardigheid, ', ') AS Vaardigheid FROM Gebruiker AS G JOIN Gebruiker_Vaardigheid AS GV ON GV.Gebruiker_id = G.ID JOIN Vaardigheid AS V ON GV.Vaardigheid_id = V.ID WHERE G.ID = {ID}", connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                VaardigheidNamen = dr["Vaardigheid"].ToString();
            }
            return VaardigheidNamen;
        }

        public string GetFunctie(int ID)
        {
            string FunctieNamen = "";
            DataTable dt = new();
            SqlDataAdapter da = new($"SELECT F.Functie FROM Gebruiker AS G INNER JOIN Functie AS F ON F.ID = G.FunctieID WHERE G.ID = {ID}", connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                FunctieNamen = dr["Functie"].ToString();
            }

            return FunctieNamen;
        }

        public string GetPersoonlijkheden(int ID)
        {
            string PersoonlijkheidNamen = "";
            DataTable dt = new();
            SqlDataAdapter da = new($"SELECT STRING_AGG(P.Persoonlijkheid, ', ') AS Persoonlijkheid FROM Gebruiker AS G JOIN Gebruiker_Persoonlijkheid AS GP ON GP.Gebruiker_id = G.ID JOIN Persoonlijkheid AS P ON GP.Persoonlijkheid_id = P.ID WHERE G.ID = {ID}", connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                PersoonlijkheidNamen = dr["Persoonlijkheid"].ToString();
            }

            return PersoonlijkheidNamen;
        }

    }
}
