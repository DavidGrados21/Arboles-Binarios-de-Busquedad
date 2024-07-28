using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios.EJERCICIO_09
{
    internal class NodoLS
    {
        private int vinfo;
        private NodoLS vsgte;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public NodoLS sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public NodoLS()
        {
            info = 0;
            sgte = null;
        }

        public NodoLS(int vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public NodoLS(int vinfo, NodoLS vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }

    }
}
