using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class NodoDoble
    {
        private int informacion;
        private NodoDoble enlaceIzquierdo;
        private NodoDoble enlaceDerecho;


        public int Informacion
        {
            get { return informacion; }
            set { informacion = value; }
        }
        public NodoDoble EnlaceIzquierdo
        {
            get { return enlaceIzquierdo; }
            set { enlaceIzquierdo = value; }
        }
        public NodoDoble EnlaceDerecho
        {
            get { return enlaceDerecho; }
            set { enlaceDerecho = value; }
        }
        public NodoDoble(int _informacion, NodoDoble _enlaceIzquierdo, NodoDoble _enlaceDerecho)
        {
            informacion = _informacion;
            enlaceDerecho = _enlaceDerecho;
            enlaceIzquierdo = _enlaceIzquierdo;
        }
    }
}