using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinalP2
{
    public partial class inicio : Form
    {
        public inicio()
        {
            InitializeComponent(); // Si estás usando Windows Forms Designer
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void buttonInciaSistema_Click(object sender, EventArgs e)
        {
            login inicio = new login();
            inicio.Show();
            this.Hide();

        }

        private void inicio_Load(object sender, EventArgs e)
        {

        }
    }
}
