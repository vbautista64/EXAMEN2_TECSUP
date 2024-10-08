using EXAMEN2_TECSUP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN2_TECSUP.Clases
{
    public class Gerente :  EmpleadoBase , ISueldoBonificable , IDescuentoImpuesto
    {
        public override decimal SueldoBase { get; set ; }

        public Gerente(string nombre, int id) 
        { 
            Nombre = nombre;
            IdEmpleado= id; 
            Puesto= "Gerente";
            SueldoBase = 8000;
        }

        public override decimal CalcularSueldo()
        {
            return SueldoBase+Calcularbonificacion()- DescontarSueldo();
        }

        public override void MostrarDetalle()
        {
            base.MostrarDetalle();
            Console.WriteLine($"Sueldo Total: {CalcularSueldo()}");

        }

        public decimal Calcularbonificacion()
        {
            decimal bono = 1000M;
            return bono;
        }

        public decimal DescontarSueldo()
        {
            decimal descuento = SueldoBase * Contantes.descuentoGerentes;
            return descuento;
        }
    }
}
