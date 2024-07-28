using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_10
{
    internal class Arboles10
    {
        private Nodo vraiz;

        public Nodo raiz
        {
            get { return vraiz; }
            set { vraiz = value; }
        }

        public Arboles10()
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

        private void Descendente(Nodo a, ListBox lst)
        {
            if (a != null)
            {
                Descendente(a.der, lst);
                lst.Items.Add(a.info);
                Descendente(a.izq, lst);
            }
        }

        public void Descendente(ListBox lst)
        {
            lst.Items.Clear();
            Descendente(raiz, lst);
        }

        private void enOrden(Nodo r, ListBox lst)
        {
            if (r != null)
            {
                enOrden(r.izq, lst);
                lst.Items.Add(r.info);
                enOrden(r.der, lst);
            }
        }
        public void enOrden(ListBox lst)
        {
            lst.Items.Clear();
            enOrden(raiz, lst);
        }
    }
}
