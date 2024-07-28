using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_02
{
    public partial class A2 : Form
    {
        Arbol2 arbol = new Arbol2();
        public A2()
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
        private void btnMenor_Click(object sender, EventArgs e)
        {
            MessageBox.Show("El dato menor es " + arbol.EncontrarMenor(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
