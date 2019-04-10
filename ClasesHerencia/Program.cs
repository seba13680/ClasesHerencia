using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesHerencia
{

    class Persona
    {
        public int Id;
        public string Nombre;
        public string Apellido;
        public DateTime FechaNacimiento;
        public bool EsPersonaFisica;
        public int CuitCuil;

        public virtual int ObtenerTotal()
        {
           
            return 0;
        }

    }

    class Empleado: Persona
    {
        public DateTime FechaIngreso;
        public int NumeroLegajo;
        public int Sueldo;

        public override int ObtenerTotal()
        {
            return Sueldo;
        }



    }

    class Proveedor: Persona
    {
        public string NombreComercial;
        public DateTime FechaUltimaCompra;
        public int TotalCompras;

        public override int ObtenerTotal()
        {
            return TotalCompras;
        }

    }

    class Cliente: Persona
    {
        public int TotalVentas;
        public bool EsClientePreferencial;
        public decimal LimiteDeCuentaCorriente;

        public override int ObtenerTotal()
        {
            return TotalVentas;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {

            Cliente cliente = new Cliente();
            cliente.Id = 1234;
            cliente.Nombre = "Juan";
            cliente.Apellido = "Perez";
            cliente.TotalVentas = 13234;
            cliente.LimiteDeCuentaCorriente = 70000;
            Console.WriteLine("El cliente con ID = [{0}], {1} {2}, tiene un total de ventas de : {3} pesos ", cliente.Id, cliente.Nombre, cliente.Apellido, cliente.ObtenerTotal());

            Proveedor proveedor = new Proveedor();
            proveedor.Id = 8643;
            proveedor.NombreComercial = "Proveedor S.R.L";
            proveedor.CuitCuil = 345677893;
            proveedor.TotalCompras = 300456;
            Console.WriteLine("El proveedor con ID = [{0}], {1}, CUIT : {2}, tiene un total de compras de : {3} pesos ", proveedor.Id, proveedor.NombreComercial,proveedor.CuitCuil,proveedor.ObtenerTotal());

            Empleado empleado = new Empleado();
            empleado.Id = 6434;
            empleado.Nombre = "José";
            empleado.Apellido = "Lopez";
            empleado.NumeroLegajo = 669911;
            empleado.Sueldo = 25000;
            Console.WriteLine("El empleado con ID = [{0}], {1}{2}, Número de legajo : {3} Tiene un sueldo de : {4} pesos ", empleado.Id, empleado.Nombre, empleado.Apellido, empleado.NumeroLegajo, empleado.ObtenerTotal());




        }
    }
}
