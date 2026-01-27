using System;

namespace Mision_Rango_B_El_Triaje
{
    class Program
    {
        static void Main(string[] args)
        {
            int vida = 40;

            if (vida == 100)
            {
                Console.WriteLine("Estado: Perfecto.");
            }
            else if (vida >= 50)
            {
                Console.WriteLine("Estado: Herido, pero puedo luchar.");
            }
            else if (vida > 0)
            {
                Console.WriteLine("Estado: ¡PELIGRO CRÍTICO! Huye.");
            }
            else
            {
                Console.WriteLine("Estado: Muerto.");
            }
        }
    }
}