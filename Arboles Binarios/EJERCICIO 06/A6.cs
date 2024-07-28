using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_06
{
    public partial class A6 : Form
    {
        Arbol6 arbol = new Arbol6();
        public A6()
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
            int s = arbol.buscarsegundoMin();
            MessageBox.Show("El segundo menor es " + s , "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
