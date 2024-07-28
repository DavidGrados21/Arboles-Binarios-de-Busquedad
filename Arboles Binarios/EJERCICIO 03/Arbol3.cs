using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_03
{
    internal class Arbol3
    {
        private Nodo vraiz;

        public Nodo raiz
        {
            get { return vraiz; }
            set { vraiz = value; }
        }

        public Arbol3()
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
        public void buscar(int x, Nodo r, ListBox lst)
        {
            if (r != null)
            {
                if (x == r.info)
                {
                    lst.Items.Add("Ha llegado a su destino");
                    lst.Items.Add(r.info);
                }
                else
                {
                    lst.Items.Add(r.info);
                    if (x < r.info)
                    {
                        buscar(x, r.izq, lst);
                    }
                    else
                    {
                        buscar(x, r.der, lst);
                    }
                }
            }
        }

        public void buscar(int x, ListBox lst)
        {
            buscar(x, raiz, lst);
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
