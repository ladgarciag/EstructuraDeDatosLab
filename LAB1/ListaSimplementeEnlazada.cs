using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LAB1
{
    class ListaSimplementeEnlazada 
    { 

    private Nodo primero;

    public Nodo Primero
    {
        get { return primero; }
        set { primero = value; }
    }

    public ListaSimplementeEnlazada()
    {
        primero = null;
    }

    public bool Vacia()
    {
            if (primero == null)
                return true;
            else
                return false;
    }

    public void InsertarOrd(int info)
    {
        Nodo p, r, q;

        if (Vacia())
            primero = new Nodo(info, null);
        else if (info < primero.Info)
        {
            p = new Nodo(info, primero);
            primero = p;
        }
        else
        {
            r = primero;
            q = primero.Enlace;
            while (q != null && info > q.Info)
            {
                r = q;
                q = q.Enlace;
            }
            if (q != null)
            {
                p = new Nodo(info, q);
                r.Enlace = p;
            }
            else
            {
                p = new Nodo(info, null);
                r.Enlace = p;
            }
        }
    }
}
}