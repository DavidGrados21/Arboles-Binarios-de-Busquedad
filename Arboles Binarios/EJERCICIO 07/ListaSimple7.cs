using Arboles_Binarios.EJERCICIO_09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_07
{
    internal class ListaSimple7
    {
        public NodoLS7 inicio;

        public ListaSimple7()
        {
            inicio = null;
        }

        public bool vacia()
        {
            if (inicio == null)
                return true;
            else
                return false;
        }
        public void insertarAlInicio(int valor)
        {
            NodoLS7 nuevo = new NodoLS7(valor);

            nuevo.sgte = inicio;
            inicio = nuevo;
        }
        public void mostrar(ListBox lst)
        {
            NodoLS7 actual = inicio;
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }
    }
}
