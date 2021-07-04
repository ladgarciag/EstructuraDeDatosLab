using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    class ListaDoblementeEnlazada
    {
        private NodoDoble primero;
        private NodoDoble ultimo;
        private int m7;

        public ListaDoblementeEnlazada()
        {
            primero = null;
            ultimo = null;
        }

        public NodoDoble Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public NodoDoble Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
        }

        public int Multiplo7
        {
            get { return m7; }
            set { m7 = value; }
        }

        public bool Vacio()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void Insertar(int informacion)
        {
            NodoDoble p;

            if (informacion % 7 == 0)
                m7++;


            if (Vacio())
            {
                primero = new NodoDoble(informacion, null, null);
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble(informacion, ultimo, null);
                ultimo.EnlaceDerecho = p;
                ultimo = p;
            }
        }
    }

}
