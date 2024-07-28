using Arboles_Binarios.EJERCICIO_10;
using Arboles_Binarios.EJERCICIO_09;
using Arboles_Binarios.EJERCICIO_08;
using Arboles_Binarios.EJERCICIO_07;
using Arboles_Binarios.EJERCICIO_06;
using Arboles_Binarios.EJERCICIO_05;
using Arboles_Binarios.EJERCICIO_04;
using Arboles_Binarios.EJERCICIO_03;
using Arboles_Binarios.EJERCICIO_02;
using Arboles_Binarios.EJERCICIO_01;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios
{
    public partial class PantallaPrincipal : Form
    {
        public PantallaPrincipal()
        {
            InitializeComponent();
        }

        private void btnGrupo_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Los integrantes son\n" +
    "\n- ARNOLD EMILIO CHOMBA SUAREZ" +
    "\n- DEYBY MAURICIO GRADOS SHUPINGAHUA" +
    "\n- KATHERINE LISBETH LLACCOLLA GAMBOA" +
    "\n- LAURA THALIA GARCIA LUJAN", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Form ventana = new A10();
            this.Visible = false;
            ventana.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Form ventana = new A9();
            this.Visible = false;
            ventana.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Form ventana = new A8();
            this.Visible = false;
            ventana.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form ventana = new A7();
            this.Visible = false;
            ventana.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form ventana = new A6();
            this.Visible = false;
            ventana.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Form ventana = new A5();
            this.Visible = false;
            ventana.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form ventana = new A4();
            this.Visible = false;
            ventana.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Form ventana = new A3();
            this.Visible = false;
            ventana.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form ventana = new A2();
            this.Visible = false;
            ventana.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form ventana = new A1();
            this.Visible = false;
            ventana.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
