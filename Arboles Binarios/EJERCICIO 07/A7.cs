using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_07
{
    public partial class A7 : Form
    {
        Arboles7 arbol = new Arboles7 ();
        ListaSimple7 lista = new ListaSimple7 ();
        public A7()
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

        private void btnHojas_Click(object sender, EventArgs e)
        {
            arbol.MostrarHojas(lista);
            lstDatos.Items.Clear();
            lstDatos.Items.Add("Las hojas de este árbol binario de búsqueda son: ");
            lista.mostrar(lstDatos);
        }
    }
}
