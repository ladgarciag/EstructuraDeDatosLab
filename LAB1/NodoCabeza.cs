using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class NodoCabeza
    {
        private int elem;
        private NodoDoble lista;

        public NodoCabeza()
        {
            elem = 0;
            lista = null;
        }

        public int Elem
        {
            get { return elem; }
            set { elem = value; }
        }

        public NodoDoble Lista
        {
            get { return lista; }
            set { lista = value; }
        }
    }
}