using Arboles_Binarios.EJERCICIO_09;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arboles_Binarios.EJERCICIO_07
{
    internal class NodoLS7
    {
        private int vinfo;
        private NodoLS7 vsgte;

        public int info
        {
            get { return vinfo; }
            set { vinfo = value; }
        }
        public NodoLS7 sgte
        {
            get { return vsgte; }
            set { vsgte = value; }
        }

        public NodoLS7()
        {
            info = 0;
            sgte = null;
        }

        public NodoLS7(int vinfo)
        {
            info = vinfo;
            sgte = null;
        }

        public NodoLS7(int vinfo, NodoLS7 vsgte)
        {
            info = vinfo;
            sgte = vsgte;
        }
    }
}
