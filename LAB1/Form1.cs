using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LAB1
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }

        ListaSimplementeEnlazada lse = new ListaSimplementeEnlazada();
        ListaDoblementeEnlazada  lde = new ListaDoblementeEnlazada();
        ListaSimplementeEnlazadaCircular lsec = new ListaSimplementeEnlazadaCircular();
        ListaDoblementeEnlazadaCircular ldec = new ListaDoblementeEnlazadaCircular();
        ListaDoblementeEnlazadaCircularCabeza ldecCabeza = new ListaDoblementeEnlazadaCircularCabeza();

        void MostrarLSE()
        {
            Nodo p;
            lview.Clear();
            p = lse.Primero;
            while (p != null)
            {
                if (!lse.Vacia())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.Enlace;
                }
            }
        }

        void MostrarLDE()
        {
            NodoDoble p;
            lview.Clear();
            p = lde.Primero;
            while (p != null)
            {
                if (!lde.Vacio())
                {
                    lview.Items.Add(p.Informacion.ToString());
                    p = p.EnlaceDerecho;
                }
            }

        }

        void MostrarLSEC()
        {
            Nodo p;
            lview.Clear();
            p = lsec.Primero;
            do
            {
                if (!lsec.Vacio())
                {
                    lview.Items.Add(p.Info.ToString());
                    p = p.Enlace;
                }
            } while (p != lsec.Primero);
        }
        void MostrarLDEC()
        {
            NodoDoble p;
            lview.Clear();
            p = ldec.Primero;
            do
            {
                if (!ldec.Vacio())
                {
                    lview.Items.Add(p.Informacion.ToString());
                    p = p.EnlaceDerecho;
                }
            } while (p != ldec.Primero);
        }

        void MostrarLDECabeza()
        {
            NodoDoble p;
            lview.Clear();
            p = ldecCabeza.Primero;
            while (p != null)
            {
                if (!ldecCabeza.Vacio())
                {
                    lview.Items.Add(p.Informacion.ToString());
                    p = p.EnlaceDerecho;
                }
            }
        }
        

        private void listListaElementos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void LSEIntOrd_Click(object sender, EventArgs e)
        {

            if (txtInLSE.Text != "")
            {
                lse.InsertarOrd(Int32.Parse(txtInLSE.Text));
                MostrarLSE();
                txtInLSE.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }
        private void txtIn_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtInLSE.Text != "")
                {

                    lse.InsertarOrd(Int32.Parse(txtInLSE.Text));
                    MostrarLSE();
                    txtInLSE.Clear();
                }
                else
                {
                    MessageBox.Show("***Error, introduza un valor***");
                }
            }

        }

        

        private void LDEInt_Click(object sender, EventArgs e)
        {
            if (txtlnlde.Text != "")
            {
                lde.Insertar(Int32.Parse(txtlnlde.Text));
                MostrarLDE();
                txtBoxm7.Clear();
                if (lde.Multiplo7 > 0)
                    txtBoxm7.Items.Add(lde.Multiplo7.ToString());
                txtlnlde.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }
        private void txtInLDE_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtlnlde.Text != "")
                {
                    lde.Insertar(Int32.Parse(txtlnlde.Text));
                    MostrarLDE();
                    txtBoxm7.Clear();
                    if (lde.Multiplo7 > 0)
                        txtBoxm7.Items.Add(lde.Multiplo7.ToString());
                    txtlnlde.Clear();
                }
                else
                {
                    MessageBox.Show("***Error, introduza un valor***");
                }
            }
        }

        private void LSECInt_Click(object sender, EventArgs e)
        {
            if (txtlnlsec.Text != "")
            {
                lsec.Insertar(Int32.Parse(txtlnlsec.Text));
                MostrarLSEC();
                txtlnlsec.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }

        private void txtInLSEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtlnlsec.Text != "")
                {
                    lsec.Insertar(Int32.Parse(txtlnlsec.Text));
                    MostrarLSEC();
                    txtlnlsec.Clear();
                }
                else
                {
                    MessageBox.Show("***Error, introduza un valor***");
                }
            }
        }

        private void LSECEli_Click(object sender, EventArgs e)
        {

            if (txtlnlsec.Text != "")
            {
                lsec.Eliminar(Int32.Parse(txtlnlsec.Text));
                MostrarLDEC();
                txtlnlsec.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }



        private void LDECInt_Click(object sender, EventArgs e)
        {
            if (txtlnldec.Text != "")
            {
                ldec.Insertar(Int32.Parse(txtlnldec.Text));
                MostrarLDEC();
                txtlnldec.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }

        private void txtInLDEC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar == (int)Keys.Enter)
            {
                if (txtlnldec.Text != "")
                {
                    ldec.Insertar(Int32.Parse(txtlnldec.Text));
                    MostrarLDEC();
                    txtlnldec.Clear();
                }
                else
                {
                    MessageBox.Show("***Error, introduza un valor***");
                }
            }
        }

        private void LDECEli_Click(object sender, EventArgs e)
        {
            if (txtlnldec.Text != "")
            {
                ldec.Eliminar(Int32.Parse(txtlnldec.Text));
                MostrarLDEC();
                txtlnldec.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }

        private void LDECabezaInt_Click(object sender, EventArgs e)
        {
            if (txtlnldecCabeza.Text != "")
            {
                ldecCabeza.Insertar(Int32.Parse(txtlnldecCabeza.Text));
                MostrarLDECabeza();
                txtboxele.Clear();
                if (ldecCabeza.Cabeza.Elem > 0)
                    txtboxele.Items.Add(ldecCabeza.Cabeza.Elem.ToString());
                else
                    txtboxele.Items.Add(0.ToString());
                txtlnldecCabeza.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }

        private void LDECabezaEli_Click(object sender, EventArgs e)
        {
            if (txtlnldecCabeza.Text != "")
            {
                ldecCabeza.Eliminar(Int32.Parse(txtlnldecCabeza.Text));
                MostrarLDECabeza();
                txtboxele.Clear();
                if (ldecCabeza.Cabeza != null)
                    txtboxele.Items.Add(ldecCabeza.Cabeza.Elem.ToString());
                else
                    txtboxele.Items.Add(0.ToString());
                txtlnldecCabeza.Clear();
            }
            else
            {
                MessageBox.Show("***Error, introduza un valor***");
            }
        }
    }
}
