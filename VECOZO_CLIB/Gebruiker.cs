using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace VECOZO_CLIB
{
    public class Gebruiker
    {
        public string Naam;
        public List<string> Persoonlijkheden;
        public List<string> Vaardigheden;
        public int Beoordeling;
        public string Functie;
        public Boolean IsManager;

        public Gebruiker(string naam, List<string> persoonlijkheden, List<string> vaardigheden, int beoordeling, string functie, bool isManager)
        {
            Naam = naam;
            Persoonlijkheden = persoonlijkheden;
            Vaardigheden = vaardigheden;
            Beoordeling = beoordeling;
            Functie = functie;
            IsManager = isManager;
        }

        //Medewerker classes
        public void PersoonlijkhedenAanpassen()
        {
        }
        public void RolAanpassen()
        {
        }
        public void VaardigehedenAanpassen()
        {
        }

        
        //Manager classes
        public void MedewerkerInzien()
        {
            if (IsManager = true)
            {

            }
        }
        public void MedewerkerVerwijderen()
        {
            if (IsManager = true)
            {

            }
        }
        public void MedewerkerFilteren()
        {
            if (IsManager = true)
            {

            }
        }
        public void RolToevoegen()
        {
            if (IsManager = true)
            {

            }
        }
        public void RolVerwijderen()
        {
            if (IsManager = true)
            {

            }
        }

        public override string? ToString()
        {
            return Naam;
        }
    }
}
