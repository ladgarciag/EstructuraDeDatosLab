using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class Nodo
    {
        private int info;
        private Nodo enlace;

        public int Info
        {
            get { return info; }
            set { info = value; }
        }
        public Nodo Enlace
        {
            get { return enlace; }
            set { enlace = value; }
        }
        public Nodo(int _info, Nodo _enlace)
        {
            info = _info;
            enlace = _enlace;
        }


    }
}
