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

        public Proceso ver(Proceso actual)
        {
            return actual;
        }

        public Proceso cambio(Proceso actual)
        {
            if(actual == null)
            {
                return null;
            }
            else
            {
                actual = actual.Siguiente;
                return actual;
            }
        }

        public void desencolar(Proceso actual)
        {
            if (inicio != null)
            {
                while(inicio._ciclos == 0)
                {
                    inicio = inicio.Siguiente;
                }

            }   
            else if(ultimo._ciclos == 0)
            {
                while(actual.Siguiente.Siguiente != null)
                {
                    ultimo = actual.Siguiente;
                }
                ultimo.Siguiente = inicio;
            }
            else
                actual.Siguiente = actual.Siguiente.Siguiente;
        }

        public int sumaCiclos()
        {
            int cont = 0;
            Proceso temp = inicio;

            while(temp != null)
            {
                temp = temp.Siguiente;
                if(temp.Siguiente == inicio)
                {
                    break;
                }

            }
            

            return cont;
        }
    }
}
