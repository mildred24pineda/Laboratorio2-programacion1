using System;


namespace Enunciado1
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enunciado 2 Clasificacion de Edad");

            // Explicación del uso de if-else
            Console.WriteLine("\n¿Por qué elegí usar 'if-else'?");
            Console.WriteLine("Decidí usar la estructura 'if-else' porque estamos trabajando con rangos de edades.");
            Console.WriteLine("Por ejemplo, si la edad está entre 12 y 17 años, o si es mayor de 60. ");
            Console.WriteLine("El 'switch' no sería adecuado aquí porque solo funciona bien con valores exactos.");
            Console.WriteLine("En cambio, 'if-else' nos permite manejar estas comparaciones de manera más flexible y clara.");

            Console.WriteLine("=========================================================");

            //Pedir la Edad
            Console.WriteLine("Ingrese su edad");
            int edad = int.Parse(Console.ReadLine());

            //Clasificacion de edad Usando (if-else)
            if (edad < 12)
            {
                Console.WriteLine("Categoria: Niño");
            }
            else if (edad >= 12 && edad <= 17)
            {
                Console.WriteLine("Categoria: Adolescente");
            }
            else if (edad >= 18 && edad <= 59)
            {
                Console.WriteLine("Categoria: Adulto");
            }
            else if (edad >= 60 )
            {
                Console.WriteLine("Categoria: Adulto Mayor");
            }

        }
    }
}
