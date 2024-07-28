using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_09
{
    internal class ListaSimple
    {
        public NodoLS inicio;

        public ListaSimple()
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
            NodoLS nuevo = new NodoLS(valor);

            nuevo.sgte = inicio;
            inicio = nuevo;
        }
        public void mostrar( ListBox lst)
        {
            NodoLS actual = inicio;
            while (actual != null)
            {
                lst.Items.Add(actual.info);
                actual = actual.sgte;
            }
        }
        public void conversion(Arboles9 a)
        {
            NodoLS actual = inicio;

            while (actual != null)
            {
                a.insertar(actual.info);
                actual = actual.sgte;
            }
        }
    }
}
