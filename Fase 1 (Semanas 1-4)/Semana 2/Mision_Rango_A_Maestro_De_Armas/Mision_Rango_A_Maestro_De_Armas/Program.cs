using System;

namespace Mision_Rango_A_Maestro_De_Armas
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 2;

            switch (opcion)
            {
                case 1:
                    Console.WriteLine("Has equipado la Espada del Destino. Ataque +10");
                    break;
                case 2:
                    Console.WriteLine("Has equipado el Bastón de Hielo. Magia +15");
                    break;
                case 3:
                    Console.WriteLine("Has equipado el Arco Fantasma. Agilidad +20");
                    break;
                default:
                    Console.WriteLine("Opción inválida. Lucharás con las manos vacías.");
                    break;
            }
        }
    }
}