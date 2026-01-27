using System;

namespace Mision_Rango_C_El_Guardian
{
    class Program
    {
        static void Main(string[] args)
        {
            int nivelJugador = 3;
            int nivelRequerido = 10;

            if (nivelJugador >= nivelRequerido)
            {
                Console.WriteLine("Bienvenido, pasad.");
            }
            else
            {
                Console.WriteLine($"Alto ahí. Necesitas nivel {nivelRequerido} para entrar.");
            }
        }
    }
}