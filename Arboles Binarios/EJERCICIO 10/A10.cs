using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_10
{
    public partial class A10 : Form
    {
        Arboles10 arbol = new Arboles10();
        public A10()
        {
            InitializeComponent();
        }
        private void button2_Click(object sender, EventArgs e)
        {
            arbol.Descendente(lstDatos);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                int x = int.Parse(txtValor.Text);
                txtValor.Clear();
                txtValor.Focus();
                arbol.insertar(x);
                arbol.enOrden(lstDatos);
            }
            catch
            {
                MessageBox.Show("Hubo un error, por favor introduzca el valor nuevamente", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtValor.Clear();
                txtValor.Focus();
            }
        }
    }
}
