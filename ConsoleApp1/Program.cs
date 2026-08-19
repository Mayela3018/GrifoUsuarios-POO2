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
                Console.WriteLine("Valor inválido. Debes ingresar solo números (ejemplo: 150.5).");
                Console.Write(mensaje);
            }

            return valor;
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
                        Console.Write("Nombre del cliente: ");
                        string nombreCliente = Console.ReadLine();
                        double saldoCliente = LeerDouble("Saldo: ");
                        double litros = LeerDouble("Litros cargados: ");

                        grifo.AgregarUsuario(new Cliente(nombreCliente, saldoCliente, litros));
                        Console.WriteLine("Cliente agregado correctamente.");
                        break;

                    case "3":
                        Console.Write("Nombre del empleado: ");
                        string nombreEmpleado = Console.ReadLine();
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