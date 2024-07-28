using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_09
{
    public partial class A9 : Form
    {
        Arboles9 arbol = new Arboles9();
        ListaSimple lista = new ListaSimple();
        public A9()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtValor.Text);
                txtValor.Clear();
                txtValor.Focus();
                lista.insertarAlInicio(x);
                lstLista.Items.Clear();
                lista.mostrar(lstLista);
            }
            catch
            {
                MessageBox.Show("Hubo un error, por favor introduzca el valor nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtValor.Focus();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lista.conversion(arbol);
            arbol.preOrden(lstArbol);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lstArbol_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lstLista_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtValor_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
