using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Promedio
{
    class Utilidades
    {
        public static Stack ParseAtoS(Object[] pArray)
        {
            Stack _S = new Stack();
            for (int i = 0; i < pArray.Length; i++)
            {
                _S.Push(pArray[i]);
            }
            return _S;
        }

        public static ListViewItem makeListViewItem( Estudiante pEstudiante, int pCantidad)
        {
            ListViewItem item = new ListViewItem( (pCantidad+1).ToString());
            item.SubItems.Add( pEstudiante.nombre);
            item.SubItems.Add( pEstudiante.GetDefinitiva().ToString());
            item.SubItems.Add( pEstudiante.GetEstado().ToString());

            return item;
        }

        public static Estudiante GetEstudiante( Queue pLista, int pCodEstudiante)
        {
            Estudiante rVictima = new Estudiante();

            for(int i=0; i<pCodEstudiante; i++)
            {
                rVictima = (Estudiante) pLista.Dequeue();
                pLista.Enqueue( rVictima);
            }
            for(int i=0; i< pLista.Count - pCodEstudiante; i++)
            {
                pLista.Enqueue( pLista.Dequeue());
            }
            return rVictima;
        }

        public static void cambiarEstudiante( Queue pLista1, int pCodEstudiante, Estudiante pNuevo, ListView pLista2)
        {
            for (int i = 0; i < pCodEstudiante-1; i++)
            {
                pLista1.Enqueue(pLista1.Dequeue());
                
            }
            pLista1.Dequeue();
            pLista1.Enqueue(pNuevo);
            for (int i = 0; i < pLista1.Count - pCodEstudiante; i++)
            {
                pLista1.Enqueue(pLista1.Dequeue());
                
            }

            pLista2.Items[pCodEstudiante - 1].SubItems[1].Text = pNuevo.nombre;
            pLista2.Items[pCodEstudiante - 1].SubItems[2].Text = pNuevo.GetDefinitiva().ToString();
            pLista2.Items[pCodEstudiante - 1].SubItems[3].Text = pNuevo.GetEstado();
        }
    }
}
