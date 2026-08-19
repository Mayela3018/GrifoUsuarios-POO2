using System;

namespace GrifoUsuarios
{
    public class Empleado : Usuario
    {
        public double Sueldo { get; set; }

        public Empleado(string nombre, double saldo, double sueldo)
            : base(nombre, saldo)
        {
            Sueldo = sueldo;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"   Tipo: Empleado | Sueldo: S/ {Sueldo}");
        }
    }
}