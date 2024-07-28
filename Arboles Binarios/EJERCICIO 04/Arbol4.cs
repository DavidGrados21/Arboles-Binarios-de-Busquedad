using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_04
{
    internal class Arbol4
    {
        private Nodo vraiz;

        public Nodo raiz
        {
            get { return vraiz; }
            set { vraiz = value; }
        }

        public Arbol4()
        {
            raiz = null;
        }
        private Nodo insertar(Nodo r, int dato)
        {
            if (r == null)
            {
                r = new Nodo(dato);
            }
            else
            {
                if (dato < r.info)
                {
                    r.izq = insertar(r.izq, dato);
                }
                else
                {
                    if (dato > r.info)
                    {
                        r.der = insertar(r.der, dato);
                    }
                }
            }
            return r;
        }

        public void insertar(int dato)
        {
            raiz = insertar(raiz, dato);
        }
        public Nodo buscar(int x, Nodo r, ListBox lst, int C)
        {
            C++;
            if (r != null)
            {
                if (x == r.info)
                {
                    lst.Items.Clear();
                    lst.Items.Add("Se recorrieron " + C + "elementos");
                    lst.Items.Add("Para llegar a dicho valor");
                    return r;
                }
                else
                {
                    if (x < r.info)
                    {
                        return buscar(x, r.izq, lst, C);
                    }
                    else
                    {
                        return buscar(x, r.der, lst, C);
                    }
                }
            }
            else
                return null;
        }

        public Nodo buscar(int x, ListBox lst)
        {
            int c = 0;
            return buscar(x, raiz,lst, c);
        }

        private void preOrden(Nodo r, ListBox lst)
        {
            if (r != null)
            {
                lst.Items.Add(r.info);
                preOrden(r.izq, lst);
                preOrden(r.der, lst);
            }
        }

        public void preOrden(ListBox lst)
        {
            lst.Items.Clear();
            preOrden(raiz, lst);
        }
    }
}
