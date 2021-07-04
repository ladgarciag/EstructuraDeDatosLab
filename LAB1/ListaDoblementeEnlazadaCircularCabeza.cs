using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    class ListaDoblementeEnlazadaCircularCabeza
    {
        NodoDoble primero;
        NodoDoble ultimo;
        NodoCabeza cabeza;

        public ListaDoblementeEnlazadaCircularCabeza()
        {
            primero = null;
            ultimo = null;
            cabeza = null;
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

        public NodoCabeza Cabeza
        {
            get { return cabeza; }
            set { cabeza = value; }
        }

        public bool Vacio()
        {
            if (primero == null)
                return true;
            else
                return false;
        }

        public void Insertar(int info)
        {
            NodoDoble p;
            if (Vacio())
            {
                cabeza = new NodoCabeza();
                primero = new NodoDoble(info, null, null);
                cabeza.Lista = primero;
                primero.EnlaceDerecho = primero;
                primero.EnlaceIzquierdo = primero;
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble(info, ultimo, primero);
                ultimo.EnlaceDerecho = p;
                ultimo = p;
                primero.EnlaceIzquierdo = ultimo;
            }
            cabeza.Elem++;
        }

        public void Eliminar(int dato)
        {
            NodoDoble eliminar, p, q, r;
            p = primero;
            eliminar = null;
            if (Vacio())
                MessageBox.Show("Error, la lista está vacía");
            else
            {
                while (p != primero)
                {
                    if (p.Informacion == dato)
                        eliminar = p;
                    p = p.EnlaceDerecho;
                } 

                if (eliminar == null)
                {
                    MessageBox.Show("Error, el elemento no está en la lista");
                }
                else if (eliminar == primero)
                {
                    if (eliminar.EnlaceDerecho == primero)
                    {
                        primero = null;
                        ultimo = null;
                        cabeza = null;
                    }
                    else
                    {
                        primero = primero.EnlaceDerecho;
                        primero.EnlaceIzquierdo = ultimo;
                        ultimo.EnlaceDerecho = primero;
                        cabeza.Elem--;
                    }
                    eliminar.EnlaceDerecho = null;
                    eliminar.EnlaceIzquierdo = null;
                    eliminar = null;
                }
                else
                {
                    q = eliminar.EnlaceDerecho;
                    r = eliminar.EnlaceIzquierdo;
                    r.EnlaceDerecho = q;
                    q.EnlaceIzquierdo = r;
                    if (q == primero)
                        ultimo = r;
                    eliminar.EnlaceDerecho = null;
                    eliminar.EnlaceIzquierdo = null;
                    eliminar = null;
                    cabeza.Elem     --;
                }
            }
        }

    }
}
