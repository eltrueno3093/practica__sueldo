using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica__sueldo
{
    public class calculo_hora:Calculo_nomina
    {
        #region Constructor
        public calculo_hora(int ihoras,int fhoras) {
            horas_trabajadas = 0;
            Inicio_horas = ihoras;
            fin_horas = fhoras;
        
        }
        #endregion;
        #region Atributos
        private int incio_horas;
        private int fin_horas;
        private int horas_trabajadas;
        #endregion;
        #region Propiedades
        public int Inicio_horas
        {
            get { return incio_horas; }
            set { incio_horas = value; }
        }

        public int Fin_horas
        {
            get { return fin_horas; }
            set { fin_horas = value; }
        }

        public int Horas_trabajadas
        {
            get { return horas_trabajadas; }
            set { horas_trabajadas  = value; }
        }

        #endregion;
        #region Metodos

        public int calculoHora()
        {
            
            for (int i = Inicio_horas; i <= Fin_horas; i++)
            {
                Horas_trabajadas ++;
            }

                return Horas_trabajadas;
        }
        #endregion;
    }
}
