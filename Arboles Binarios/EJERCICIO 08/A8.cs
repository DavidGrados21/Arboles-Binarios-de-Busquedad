using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_08
{
    public partial class A8 : Form
    {
        Arboles8 arbol = new Arboles8();
        Arboles8 arbolDuplicado = new Arboles8();
        public A8()
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
                arbol.insertar(x);
                lstArbolP.Items.Clear();
                arbol.preOrden(lstArbolP);
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
            arbol.Duplicado(lstArbolD, arbolDuplicado);
            arbolDuplicado.preOrden(lstArbolD);
        }
    }
}
