using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica__sueldo
{
    public class empleado:Calculo_nomina
    {
        #region Constructor
        public empleado(string nombre, string apellido, string puesto) { 
            Nombre = nombre;
            Apellido = apellido;
            Puesto = puesto;
        
        }
        #endregion;
        #region Atributos
        private string nombre;
        private string apellido;
        private string puesto;
        #endregion;
        #region Propiedades

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }

        public string Puesto
        {
            get { return puesto; }
            set { puesto = value; }
        }
        #endregion;
        #region Metodos

        public string informacionEmpleado()
        {
            return $"Nombre: {Nombre}\n Apellido: {Apellido}\n Puesto: {Puesto}";
        }
        #endregion;
    }
}
