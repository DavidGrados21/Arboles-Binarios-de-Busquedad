using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_08
{
    internal class Arboles8
    {
        private Nodo vraiz;

        public Nodo raiz
        {
            get { return vraiz; }
            set { vraiz = value; }
        }

        public Arboles8()
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
        private void Duplicado(Nodo A, ListBox lst, Arboles8 T)
        {
            if (A != null)
            {
                T.insertar(A.info);
                Duplicado(A.izq, lst, T);
                Duplicado(A.der, lst, T);
            }
        }

        public void Duplicado(ListBox lst, Arboles8 a)
        {
            lst.Items.Clear();
            Duplicado(raiz, lst, a);
        }
    }
}
