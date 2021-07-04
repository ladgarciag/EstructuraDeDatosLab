using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    class ListaSimplementeEnlazadaCircular
    {
        private Nodo primero;
        private Nodo ultimo;

        public ListaSimplementeEnlazadaCircular()
        {
            primero = null;
            ultimo = null;
        }
        public Nodo Primero
        {
            get { return primero; }
            set { primero = value; }
        }

        public Nodo Ultimo
        {
            get { return ultimo; }
            set { ultimo = value; }
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
            Nodo p;
            if (Vacio())
            {
                primero = new Nodo(info, null);
                primero.Enlace = primero;
                ultimo = primero;
            }
            else
            {
                p = new Nodo(info, primero);
                ultimo.Enlace = p;
                ultimo = p;
            }
        }

        public void Eliminar(int dato)
        {
            Nodo eliminar, p, q, r;
            p = primero;
            eliminar = null;
            if (Vacio())
                MessageBox.Show("***Error, esta lista está vacía***");
            else
            {
                while(p != primero)
                {
                    if (p.Info == dato)
                    {
                        eliminar = p;
                    }
                    p = p.Enlace;

                }
                if (eliminar == null)
                {
                    MessageBox.Show("***Error, el elemento no está en la lista***");
                }
                else if (eliminar == primero)
                {
                    if (eliminar.Enlace == primero)
                    {
                        primero = null;
                        ultimo = null;
                    }
                    else
                    {
                        primero = primero.Enlace;
                        ultimo.Enlace = primero;
                    }
                    eliminar.Enlace = null;
                    eliminar = null;
                }
                else
                {
                    p = primero;
                    r = null;
                    do
                    {
                        if (p.Enlace == eliminar)
                            r = p;
                        p = p.Enlace;
                    } while (p != primero);
                    r.Enlace = eliminar.Enlace;
                    if (eliminar.Enlace == primero)
                        ultimo = r;
                    eliminar.Enlace = null;
                    eliminar = null;
                }
            }
        }
    }
}

