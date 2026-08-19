using System;

namespace GrifoUsuarios
{
    class Program
    {
        static double LeerDouble(string mensaje)
        {
            double valor;
            Console.Write(mensaje);

            while (!double.TryParse(Console.ReadLine(), out valor))
            {
                Console.WriteLine("⚠ Valor inválido. Debes ingresar solo números (ejemplo: 150.5).");
                Console.Write(mensaje);
            }

            return valor;
        }

        static string LeerNombre(string mensaje)
        {
            string texto;
            Console.Write(mensaje);
            texto = Console.ReadLine();

            while (string.IsNullOrWhiteSpace(texto) || double.TryParse(texto, out _))
            {
                Console.WriteLine("⚠ Nombre inválido. No puede estar vacío ni ser solo números.");
                Console.Write(mensaje);
                texto = Console.ReadLine();
            }

            return texto;
        }

        static void Main(string[] args)
        {
            Grifo grifo = new Grifo();
            bool salir = false;

            while (!salir)
            {
                Console.WriteLine("\n===== MENÚ GRIFO =====");
                Console.WriteLine("1. Mostrar información de usuarios");
                Console.WriteLine("2. Agregar cliente");
                Console.WriteLine("3. Agregar empleado");
                Console.WriteLine("4. Salir");
                Console.Write("Elige una opción: ");

                string opcion = Console.ReadLine();

                switch (opcion)
                {
                    case "1":
                        Console.WriteLine("\n--- Lista de Usuarios ---");
                        grifo.MostrarUsuarios();
                        break;

                    case "2":
                        string nombreCliente = LeerNombre("Nombre del cliente: ");
                        double saldoCliente = LeerDouble("Saldo: ");
                        double litros = LeerDouble("Litros cargados: ");

                        grifo.AgregarUsuario(new Cliente(nombreCliente, saldoCliente, litros));
                        Console.WriteLine("Cliente agregado correctamente.");
                        break;

                    case "3":
                        string nombreEmpleado = LeerNombre("Nombre del empleado: ");
                        double saldoEmpleado = LeerDouble("Saldo: ");
                        double sueldo = LeerDouble("Sueldo: ");

                        grifo.AgregarUsuario(new Empleado(nombreEmpleado, saldoEmpleado, sueldo));
                        Console.WriteLine("Empleado agregado correctamente.");
                        break;

                    case "4":
                        salir = true;
                        Console.WriteLine("Saliendo del programa...");
                        break;

                    default:
                        Console.WriteLine("Opción no válida, intenta de nuevo.");
                        break;
                }
            }

            Console.WriteLine("Presiona una tecla para cerrar...");
            Console.ReadKey();
        }
    }
}