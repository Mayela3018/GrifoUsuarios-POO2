using System;
using System.Collections.Generic;

namespace GrifoUsuarios
{
    public class Grifo
    {
        private List<Usuario> usuarios = new List<Usuario>();

        public void AgregarUsuario(Usuario usuario)
        {
            usuarios.Add(usuario);
        }

        public void MostrarUsuarios()
        {
            if (usuarios.Count == 0)
            {
                Console.WriteLine("No hay usuarios registrados.");
                return;
            }

            int contador = 1;
            foreach (Usuario u in usuarios)
            {
                Console.WriteLine($"--- Usuario #{contador} ---");
                u.MostrarInformacion(); 
                contador++;
            }
        }
    }
}