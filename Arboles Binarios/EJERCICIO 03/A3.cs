using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_03
{
    public partial class A3 : Form
    {
        Arbol3 arbol = new Arbol3();
        public A3()
        {
            InitializeComponent();
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtDato.Text);
                txtDato.Clear();
                txtDato.Focus();
                arbol.insertar(x);
                lstDatos.Items.Clear();
                arbol.preOrden(lstDatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error, por favor introduzca el valor nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDato.Clear();
                txtDato.Focus();
            }
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            int x = int.Parse(Interaction.InputBox("Ingrese numero a buscar su camino: "));
            lstDatos.Items.Clear();
            lstDatos.Items.Add("Para llegar a su destino");
            lstDatos.Items.Add("Tenemos que recorrer el sgte camino");
            arbol.buscar(x, lstDatos);
        }
    }
}
