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
    public partial class Manager : Form
    {
        DBSQL connection = new();

        public Manager()
        {
            InitializeComponent();
            LaadNamen();
            
        }

        public void LaadNamen()
        {
            lbNaam1.Text = connection.GetNaam(1);
            lbNaam2.Text = connection.GetNaam(2);
            lbNaam3.Text = connection.GetNaam(3);
            lbNaam4.Text = connection.GetNaam(4);
            lbNaam5.Text = connection.GetNaam(5);
            lbNaam6.Text = connection.GetNaam(6);
            lbNaam7.Text = connection.GetNaam(7);
            lbNaam8.Text = connection.GetNaam(8);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Manager_Load(object sender, EventArgs e)
        {
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void LbNaam_Click(object sender, EventArgs e)
        {

        }
        
        private void OnPicureboxClick(object sender, EventArgs e)
        {
            int index;
            GBMedewerker.Show();

            if(sender == Persoon1)
            {
                index = 1;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            }
            if(sender == Persoon2)
            {
                index = 2;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            }
            if(sender == Persoon3)
            {
                index = 3;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            } 
            if (sender == Persoon4)
            {
                index = 4;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            }
            if (sender == Persoon5)
            {
                index = 5;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            }
            if (sender == Persoon6)
            {
                index = 6;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            }
            if (sender == Persoon7)
            {
                index = 7;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            }
            if (sender == Persoon8)
            {
                index = 8;
                LBVaardigheid.Text = connection.GetVaardigheid(index);
                LbFunctie.Text = connection.GetFunctie(index);
                LbPers.Text = connection.GetPersoonlijkheden(index);
            }


        }
    }
}
