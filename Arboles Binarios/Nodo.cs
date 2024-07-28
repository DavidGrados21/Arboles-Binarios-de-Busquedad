using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios
{
    internal class Nodo
    {
        public int vinfo;
        public Nodo vizq;
        public Nodo vder;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }

        public Nodo izq
        {
            get { return vizq; }
            set { vizq = value; }
        }

        public Nodo der
        {
            get { return vder; }
            set { vder = value; }
        }

        public Nodo(int vinfo)
        {
            info = vinfo;
            izq = null;
            der = null;
        }
    }
}
