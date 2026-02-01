using System;

namespace Mision_Bucle_Voluntad
{
    class Program
    {
        static void Main(string[] args)
        {
            int energia = 5;

            while (energia > 0)
            {
                Console.WriteLine($"Realizando golpe... Energia restante: {energia}");
                energia--;
            }
            Console.WriteLine("Entrenamiento completado. Zenzero está agotado.");
        }
    }
}