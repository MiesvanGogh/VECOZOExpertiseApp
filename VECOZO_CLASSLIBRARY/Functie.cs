using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace VECOZO_CLASSLIBRARY
{
    public class Functie
    {
        public int ID;
        public string Naam;

        public Functie(int ID, string Naam)
        {
            this.ID = ID;
            this.Naam = Naam;
        }

        public Functie()
        {

        }

        public List<Functie> Functielist()
        {
            List<Functie> lijst = new List<Functie>();
            string connect = "Data Source = mssqlstud.fhict.local; Initial Catalog = dbi485146_vecozo; Persist Security Info=True;User ID = dbi485146_vecozo; Password=Welkom123";
            DataTable dt = new();
            SqlDataAdapter da = new("SELECT * from Functie", connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"].ToString());
                lijst.Add(new Functie(ID, dr["Functie"].ToString()));
            }

            return lijst;
        }
        public List<Functie> GetLijstID()
        {
            List<Functie> lijstID = new List<Functie>();
            DataTable dt = new();
            string connect = "Data Source = mssqlstud.fhict.local; Initial Catalog = dbi485146_vecozo; Persist Security Info=True;User ID = dbi485146_vecozo; Password=Welkom123";
            string Sql = "SELECT ID, Functie " +
                "FROM Functie f " +
                 "WHERE f.ID = " + ID.ToString();
            SqlDataAdapter da = new(Sql, connect);
            da.Fill(dt);
            foreach (DataRow dr in dt.Rows)
            {
                int ID = Convert.ToInt32(dr["ID"].ToString());
                lijstID.Add(new Functie(ID, dr["Functie"].ToString()));
            }
            return lijstID;
        }

        public int GetID()
        {
            return ID;
        }

        public override string? ToString()
        {
            return $"{Naam}";
        }
    }
}
