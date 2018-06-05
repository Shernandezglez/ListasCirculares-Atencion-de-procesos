using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasCircularesTencionDeProcesos
{
    class Proceso
    {
        public int _ciclos;
        private Proceso _siguiente;
        Random rnd = new Random();

        public Proceso()
        {
            _ciclos = rnd.Next(4, 15);
        }

        public override string ToString()
        {
            return "Ciclos: " + _ciclos;
        }

        public Proceso Siguiente
        {
            get { return _siguiente; }
            set { _siguiente = value; }
        }
    }
}
