using EXAMEN2_TECSUP.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EXAMEN2_TECSUP.Clases
{
    public abstract class EmpleadoBase : IEmpleado
    {
        public string Nombre { get; set; }
        public int IdEmpleado { get; set; }
        public string Puesto { get; set; }

        public abstract decimal SueldoBase { get; set; }

        public abstract decimal CalcularSueldo();

        public virtual void MostrarDetalle()
        {
            Console.WriteLine($"Nombre: {Nombre}");
            Console.WriteLine($"ID: {IdEmpleado}");
            Console.WriteLine($"Puesto: {Puesto}");
            Console.WriteLine($"Sueldo Base: {SueldoBase}");
        }

        //public void CalcularSueldo()
        //{
        //    throw new NotImplementedException();
        //}

        //public void MostrarDetalle()
        //{
        //    throw new NotImplementedException();
        //}
    }
}
