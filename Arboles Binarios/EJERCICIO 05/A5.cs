using Arboles_Binarios.EJERCICIO_06;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_05
{
    public partial class A5 : Form
    {
        Arbol5 arbol = new Arbol5();
        public A5()
        {
            InitializeComponent();
        }

        private void btnSegundo_Click(object sender, EventArgs e)
        {
            int f = arbol.Diferencia();
            MessageBox.Show("La diferencia es " + f, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
    }
}
