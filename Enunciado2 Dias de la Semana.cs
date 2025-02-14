using System;

namespace Enunciado1
{
    class Program
    {
        static void Main(string[] args)


        { 
            // Separador de operaciones
            Console.WriteLine("Enunciado 2 Dias de la Semana");

            // Explicación del uso de switch
            Console.WriteLine("\n¿Por qué elegí usar 'switch'?");
            Console.WriteLine("Usé 'switch' porque estamos trabajando con valores exactos y discretos (del 1 al 7).");
            Console.WriteLine("El 'switch' es ideal para este tipo de situaciones porque permite manejar cada valor de forma clara.");
            Console.WriteLine("En vez de tener que escribir múltiples condiciones 'if-else', el 'switch' es más limpio y fácil de leer.");

            Console.WriteLine("===========================================================================");

            //Pedir Numero del 1 al 7 al Usuario
            Console.WriteLine("Ingrese un numero del 1 al 7:");
            if (int.TryParse(Console.ReadLine(), out int numero))
            {
                //Determinar el dia de la Semana usando switch
                switch (numero)
                {
                    case 1:
                        Console.WriteLine("El dia es Lunes.");
                        break;

                    case 2:
                        Console.WriteLine("El dia es Martes.");
                        break;

                    case 3:
                        Console.WriteLine("El dia es Miercoles.");
                        break;

                    case 4:
                        Console.WriteLine("El dia es Jueves.");
                        break;

                    case 5:
                        Console.WriteLine("El dia es Viernes.");
                        break;

                    case 6:
                        Console.WriteLine("El dia es Sabado.");
                        break;

                    case 7:
                        Console.WriteLine("El dia es Domingo.");
                        break;
                    default:
                        Console.WriteLine("El Numero Ingresado es Invalido. Debe ingresar un numero entre el 1 y 7");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Por favor, ingrese un número válido.");
            }


            
        }


    }

}


  

   

 
