using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesTencionDeProcesos
{
    class Estructura
    {
        Proceso inicio, ultimo = null;
        

        public void encolar(Proceso nuevo)
        {
            if(inicio == null)
            {
                inicio = nuevo;
                inicio.Siguiente = inicio;
                ultimo = nuevo;
            }
            else
            {
                ultimo.Siguiente = nuevo;
                nuevo.Siguiente = inicio;
                ultimo = nuevo;
            }
        }
    }
}
