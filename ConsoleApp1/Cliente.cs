using System;

namespace GrifoUsuarios
{
    public class Cliente : Usuario
    {
        public double LitrosCargados { get; set; }

        public Cliente(string nombre, double saldo, double litrosCargados)
            : base(nombre, saldo)
        {
            LitrosCargados = litrosCargados;
        }

        public override void MostrarInformacion()
        {
            base.MostrarInformacion();
            Console.WriteLine($"   Tipo: Cliente | Litros Cargados: {LitrosCargados} L");
        }
    }
}