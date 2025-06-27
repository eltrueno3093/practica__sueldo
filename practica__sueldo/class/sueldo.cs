using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica__sueldo
{
    public  class sueldo:Calculo_nomina
    {
        #region Constructor
        public sueldo(double precio) {
            Sueldo = 0;
            hora_precio = precio;
        }
        #endregion;
        #region Atributos
        private double hora_precio;
        private double sueldoempl;
        #endregion;
        #region Propiedades
        public double Hora_precio
        {
            get { return hora_precio; }
            set { hora_precio = value; }
        }

        public double Sueldo
        {
            get { return sueldoempl; }
            set { sueldoempl = value; }
        }
        #endregion;
        #region Metodos

        public double sueldoNomina(int horas)
        {
            return Sueldo = Hora_precio * horas;
        }
        #endregion;
    }
}
