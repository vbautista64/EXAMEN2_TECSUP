using EXAMEN2_TECSUP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN2_TECSUP.Clases
{
    public class ConsultorExterno : EmpleadoBase
    {
        public override decimal SueldoBase { get ; set; }

        public ConsultorExterno(string nombre, int id)
        {
            Nombre = nombre;
            IdEmpleado = id;
            Puesto = "Consultor Externo";
            SueldoBase = 5000;
        }

        public override void MostrarDetalle()
        {
            base.MostrarDetalle();
            Console.WriteLine($"Sueldo Total: {CalcularSueldo()}");

        }

        public override decimal CalcularSueldo()
        {
            
            return SueldoBase;
        }
    }
}
