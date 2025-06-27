using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace practica__sueldo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void datosbox_Click(object sender, EventArgs e)
        {
            Calculo_nomina Empleado = new empleado(nombrebox.Text,apellidobox.Text,puestobox.Text);
            Calculo_nomina Horas = new calculo_hora(int.Parse(iniciobox.Text), int.Parse(finbox.Text));
            Calculo_nomina sueldo = new sueldo(double.Parse(preciobox.Text));
            empleado empelado1 = new empleado(nombrebox.Text, apellidobox.Text, puestobox.Text);
            calculo_hora  hora1 = new calculo_hora(int.Parse(iniciobox.Text), int.Parse(finbox.Text));
            sueldo sueldo1 = new sueldo(double.Parse(preciobox.Text));
            listBox1.Items.Add("DATOS DE Empleado" + empelado1.informacionEmpleado());
            listBox1.Items.Add("Horas trabajadas" + Convert.ToString(hora1.calculoHora()));
            listBox1.Items.Add("Sueldo" + Convert.ToString(sueldo1.sueldoNomina(hora1.calculoHora())));

           

        }
    }
}
