﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Arboles_Binarios.EJERCICIO_01
{
    internal class Arbol1
    {
        private Nodo vraiz;

        public Nodo raiz
        {
            get { return vraiz; }
            set { vraiz = value; }
        }

        public Arbol1()
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

        private int EncontrarMayor(Nodo r)
        {
            int M = 0;
            while (r.der != null)
            {
                M = r.der.info;
                r.der = r.der.der;
            }
            return M;
        }
        public int EncontrarMayor()
        {
            return EncontrarMayor(raiz);
        }
    }
}
