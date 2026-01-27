using System;

namespace Mision_Rango_D_Logica_Booleana
{
    class Program
    {
        static void Main(string[] args)
        {
            bool tieneMana = true;
            bool conoceHechizo = true;

            bool puedeAtacar = tieneMana && conoceHechizo;

            Console.WriteLine($"¿Zenzero puede atacar?: {puedeAtacar}");
        }
    }
}