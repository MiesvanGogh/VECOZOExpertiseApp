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
        public Manager()
        {
            InitializeComponent();

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
            if(GBMedewerker.Visible == false)
            {
                GBMedewerker.Visible = true;
            }
            else
            {
                GBMedewerker.Visible = false;
            }
        }

        private void LbNaam_Click(object sender, EventArgs e)
        {

        }
    }
}
