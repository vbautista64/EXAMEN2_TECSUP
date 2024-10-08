using EXAMEN2_TECSUP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace EXAMEN2_TECSUP.Clases
{
    public class Desarrollador : EmpleadoBase, ISueldoBonificable
    {

        public override decimal SueldoBase { get; set; }

        public Desarrollador(string nombre, int id)
        {
            Nombre = nombre;
            IdEmpleado = id;
            Puesto = "Desarrollador";
            SueldoBase = 3000;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase + Calcularbonificacion();
        }

        public override void MostrarDetalle()
        {
            base.MostrarDetalle();
            Console.WriteLine($"Sueldo Total: {CalcularSueldo()}");

        }

        public decimal Calcularbonificacion()
        {
            decimal bono = 0;
            return bono;
        }

    }
}
