using System;

namespace Parte3
{
    class Program
    {
        static void Main(string[] args)
        {
            //Valores Numericos 
            int Valor1 = 12;
            int Valor2 = 8;

            //Comparaciones Logicas
            bool esMayor = Valor1 > Valor2;
            Console.WriteLine($"¿El Primer Valor es Mayor que el Segundo Valor?  {esMayor}");

            bool esMenor = Valor1 < Valor2;
            Console.WriteLine($"¿El Primer Valor es Menor que el Segundo Valor?  {esMenor}");

            bool esIgual = Valor1 == Valor2;
            Console.WriteLine($"¿Los dos Valores son Iguales?  {esIgual}");


            //Uso de AND (&&) y OR (||) en Expresiones Logicas
            bool andExpresion = (Valor1 > 0) && (Valor2 > 0);
            Console.WriteLine($"¿Ambos Valores son Mayores que 0?  {andExpresion}");

            bool orExpresion = (Valor1 < 0) || (Valor2 < 0);
            Console.WriteLine($"¿Al menos uno de los Valores es Mayor que 0?  {orExpresion}");
        }
    }
}
