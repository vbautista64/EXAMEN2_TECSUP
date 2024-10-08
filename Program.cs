// See https://aka.ms/new-console-template for more information


using EXAMEN2_TECSUP.Clases;
using EXAMEN2_TECSUP.Interface;
using System;
using System.Globalization;
using System.Net.Http.Headers;
using System.Reflection.Metadata;

//List<EmpleadoBase> empleados = new List<EmpleadoBase>();


////primera parte
//empleados.Add(new Gerente("Felix Montero", 555584));
//empleados.Add(new Gerente("Victor Bautista", 425444));
//empleados.Add(new Gerente("Rosa Diaz", 000255));
//empleados.Add(new Gerente("Cindy Caldas", 55555));

//empleados.Add(new Desarrollador("Manuel Morales", 987454));
//empleados.Add(new Desarrollador("Victor Bautista", 255444));
//empleados.Add(new Desarrollador("Bruno Gordero", 666666));
//empleados.Add(new Desarrollador("Santi Duende", 555545));
//empleados.Add(new Desarrollador("Jhon Anguila", 798974));
//empleados.Add(new Desarrollador("Leslie kalifa", 798748));

////segunda parte
//empleados.Add(new GerenteRRHH("jose Montero", 555584));
//empleados.Add(new GerenteRRHH("Manuel Bautista", 425444));
//empleados.Add(new GerenteRRHH("Julia Diaz", 000255));
//empleados.Add(new GerenteRRHH("Joselo Caldas", 55555));

//empleados.Add(new ConsultorExterno("Karla Morales", 987454));
//empleados.Add(new ConsultorExterno("Cesar Bautista", 255444));
//empleados.Add(new ConsultorExterno("brian Gordero", 666666));
//empleados.Add(new ConsultorExterno("Santiago Duende", 555545));
//empleados.Add(new ConsultorExterno("Jhony Anguilar", 798974));
//empleados.Add(new ConsultorExterno("Mia Kalifa", 798748));


//foreach (EmpleadoBase empleado in empleados)
//{
//    empleado.MostrarDetalle();    

//    if(empleado is ISueldoBonificable bonificable)
//    {
//        Console.WriteLine($"Bono :{bonificable.Calcularbonificacion()}");
//    }

//    if (empleado is IDescuentoImpuesto descuento)
//    {
//        Console.WriteLine($"Descuento :{descuento.DescontarSueldo()}");
//    }

//    Console.WriteLine($"Sueldo Total:{empleado.CalcularSueldo()}");

//    Console.WriteLine("===============================");
//}

List<EmpleadoBase> empleados = new List<EmpleadoBase>();

Inicio();

void Inicio()
{
    int tipo = 1;
    do
    {

        Console.WriteLine("Ingrese una opción \n" +
            "1: Ingresar Empleado\n" +
            "2: Mostrar Listado de Empleado\n" +
            "3: Salir");

        tipo = Convert.ToInt32(Console.ReadLine());

        switch (tipo)
        {
            case 1:
                IngresarEmpleados();
                break;
            case 2:
                MostrarListaEmpleados();
                break;
            case 3:
                Environment.Exit(0);
                break;
            default:
                break;
        }


    } while (tipo != 3);
}




void IngresarEmpleados()
{
    string nombre;
    int tipotrab = 1;
    Int32 idEmpleado = 0;

    try
    {
        Console.WriteLine("Ingrese nombre del Trabajador:");
        nombre = Console.ReadLine().ToString();

        Console.WriteLine("Ingrese Id del Trabajador:");
        idEmpleado = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese una opción para el Puesto de Trabajo: \n" +
            "1: Gerente\n" +
            "2: Gerente RRHH\n" +
            "3: Desarrollador\n" +
            "4: Consultor Externo\n" +
            "5: Regresar");
        tipotrab = Convert.ToInt32(Console.ReadLine());

        switch (tipotrab)
        {
            case 1:
                empleados.Add(new Gerente(nombre, idEmpleado));
                break;
            case 2:
                empleados.Add(new GerenteRRHH(nombre, idEmpleado));
                break;
            case 3:
                empleados.Add(new Desarrollador(nombre, idEmpleado));
                break;
            case 4:
                empleados.Add(new ConsultorExterno(nombre, idEmpleado));
                break;
            case 5:
                Inicio();
                break;
            default:
                Inicio();
                break;
        }

        Inicio();
    }
    catch (Exception ex)
    {

        Console.WriteLine(ex.Message);
        Inicio();
    }

   

}

void MostrarListaEmpleados()
{

    foreach (EmpleadoBase empleado in empleados)
    {
        empleado.MostrarDetalle();

        if (empleado is ISueldoBonificable bonificable)
        {
            Console.WriteLine($"Bono :{bonificable.Calcularbonificacion()}");
        }

        if (empleado is IDescuentoImpuesto descuento)
        {
            Console.WriteLine($"Descuento :{descuento.DescontarSueldo()}");
        }

        Console.WriteLine($"Sueldo Total:{empleado.CalcularSueldo()}");

        Console.WriteLine("===============================");
    }

    Console.WriteLine($"Total de Empleados:{empleados.Count}");
    Console.WriteLine($"Suma de Sueldos:{empleados.Sum(x=>x.CalcularSueldo())}");
}

Console.ReadLine();