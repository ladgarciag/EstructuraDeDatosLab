using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    class ListaDoblementeEnlazadaCircular
    { 
    private NodoDoble primero;
    private NodoDoble ultimo;


    public ListaDoblementeEnlazadaCircular()
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
            primero = new NodoDoble(info, null, null);
            primero.EnlaceDerecho = primero;
            primero.EnlaceIzquierdo = primero;
            ultimo = primero;
        }
        else
        {
            p = new NodoDoble(info, ultimo, primero);
            ultimo.EnlaceDerecho = p;
            primero.EnlaceIzquierdo = ultimo;
            ultimo = p;
            }
    }

    public void Eliminar(int dato)
    {
        NodoDoble eliminar, p, q, r;
        p = primero;
        eliminar = null;

        if (Vacio())
            MessageBox.Show("***Error, esta lista está vacía***");
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
                MessageBox.Show("***Error, el elemento no está en la lista***");
            }

            else if (eliminar == primero)
            {
                if (eliminar.EnlaceDerecho == primero)
                {
                    primero = null;
                    ultimo = null;
                }
                else
                {
                    primero = primero.EnlaceDerecho;
                    primero.EnlaceIzquierdo = ultimo;
                    ultimo.EnlaceDerecho = primero;
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
                    {
                        ultimo = r; 
                    }  

                eliminar.EnlaceDerecho = null;
                eliminar.EnlaceIzquierdo = null;
                eliminar = null;

            }
        }
    }
}
}
