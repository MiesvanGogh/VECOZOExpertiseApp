using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VECOZO_CLASSLIBRARY;

namespace VecozoExpertiseApp
{

    public partial class Medewerker : Form
    {
        DBSQL GetDataBase = new DBSQL();
        public Medewerker()
        {
            InitializeComponent();
            Functie f = new();
            List<Functie> lijst = f.Functielist();
            foreach (Functie functie in lijst)
            {
                BoxFunctie.Items.Add(functie);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
        }
        private void Ster_Enter(object sender, EventArgs e)
        {
            PictureBox Ster = (PictureBox)sender;
        }
        private void Ster_Leave(object sender, EventArgs e)
        {

        }
        private void Ster_Click(object sender, EventArgs e)
        {

        }

        private void BtnOpslaan_Click(object sender, EventArgs e)
        {

            Functie fr = new();
            object obj = BoxFunctie.SelectedItem;  //Bewaart welk object geselecteerd is
            Functie geselect = (Functie)obj; //Je maakt het object een groep
            List<Functie> lijst = geselect.GetLijstID();
            foreach (Functie geb in lijst)
            {
                MessageBox.Show(geb.GetID().ToString());
            }
            
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Manager Man = new Manager();
            this.Hide();
            Man.ShowDialog();
            this.Show();
        }
        private void BoxRol_SelectedIndexChanged(object sender, EventArgs e)
        {
        }
        private void Medewerker_Load(object sender, EventArgs e)
        {

        }
    }
}

