using System;

namespace Mision_Rango_C_Cuenta_Regresiva
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 10; i >= 0; i--)
            {
                Console.WriteLine($"Detonación en... {i}");
            }
            Console.WriteLine("¡BOOM!");
        }
    }
}