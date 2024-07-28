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

namespace Arboles_Binarios.EJERCICIO_04
{
    public partial class A4 : Form
    {
        Arbol4 arbol = new Arbol4(); 
        public A4()
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
            int x = int.Parse(Interaction.InputBox("Ingrese numero a buscar: "));
            Nodo p = arbol.buscar(x, lstDatos);
            if (p != null)
            {
                MessageBox.Show("El valor se encuentra en el arbol");
            }
            else
            {
                MessageBox.Show("El valor no se encuentra en el arbol");
            }
        }
    }
}
