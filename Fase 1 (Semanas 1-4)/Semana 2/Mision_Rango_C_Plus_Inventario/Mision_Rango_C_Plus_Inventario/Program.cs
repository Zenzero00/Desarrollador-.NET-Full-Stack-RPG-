using System;

namespace Mision_Rango_C_Plus_Inventario
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] inventario = { "Poción" , "Espada" , "Mapa" , "Grimorio"};

            foreach (string item in inventario)
            {
                Console.WriteLine($"Verificando equipo... Tienes: {item}");
            }
        }
    }
}