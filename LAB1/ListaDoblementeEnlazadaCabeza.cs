using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    class ListaDoblementeEnlazadaCabeza
    {
        NodoDoble primero;
        NodoDoble ultimo;
        NodoCabeza cabeza;

        public ListaDoblementeEnlazadaCabeza()
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
                ultimo = primero;
            }
            else
            {
                p = new NodoDoble(info, ultimo, null);
                ultimo.EnlaceDerecho = p;
                ultimo = p;
            }
            cabeza.Elem++;
        }

        public void Eliminar(int dato)
        {
            NodoDoble eliminar, p, q, r;
            p = primero;
            eliminar = null;


            if (Vacio())
                MessageBox.Show("***Error, la lista está vacía***");
            else
            {
                while (p != null)
                {
                    if (p.Informacion == dato)
                        eliminar = p;
                    p = p.EnlaceDerecho;

                }
                if (eliminar == null)
                {
                    MessageBox.Show("***Error, el elemento no está en la lista***");
                }
                else if (eliminar == primero)
                {
                    if (eliminar.EnlaceDerecho == null)
                    {
                        primero = null;
                        ultimo = null;
                        cabeza = null;
                    }
                    else
                    {
                        primero = primero.EnlaceDerecho;
                        primero.EnlaceIzquierdo = null;
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
                    if (q == null)
                    {
                        r.EnlaceDerecho = null;
                    }
                    else
                    {
                        r.EnlaceDerecho = q;
                        q.EnlaceIzquierdo = r;
                    }
                    eliminar.EnlaceDerecho = null;
                    eliminar.EnlaceIzquierdo = null;
                    eliminar = null;
                    cabeza.Elem--;
                }
            }
        }
    }
}
