using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ListasCircularesTencionDeProcesos
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random prob = new Random();
        Estructura lstC = new Estructura();
        Proceso proceso;
        public int atendido, vacio, incompleto, sumaCiclos = 0;


        private void btnEmpezar_Click(object sender, EventArgs e)
        {
            for(int i = 1; i <= 300; i++)
            {
                int r = prob.Next(1, 101);
                if(r <= 35)
                {
                    proceso = new Proceso();
                    lstC.encolar(proceso);
                }
                lstC.cambio(proceso);

                if(lstC.ver(proceso) != null)
                {
                    lstC.ver(proceso)._ciclos--;

                    if(lstC.ver(proceso)._ciclos == 0)
                    {
                        lstC.desencolar(proceso);
                        atendido++;
                    }
                }
                else
                {
                    if(proceso == null)
                        vacio++;

                }

                if(i == 300 && lstC.ver(proceso)._ciclos > 0)
                {
                    incompleto++;

                    sumaCiclos += lstC.ver(proceso)._ciclos;
                }
            }

            lblResultado.Text = "Ciclos atendidos: " + atendido + " | "
                + " Vacio hasta el ciclo: " + vacio + " | "
                + " Ciclos incompletos: " + incompleto + " | "
                + "Suma de ciclos incompletos: " + sumaCiclos;
        }
    }
}
