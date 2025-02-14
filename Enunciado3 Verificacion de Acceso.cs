using System;

namespace Enunciado3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Separador de operaciones
            Console.WriteLine("Enunciado 3 Verificacion de Acceso");

            // Explicación del uso de if-else
            Console.WriteLine("\n¿Por qué elegí usar 'if-else'?");
            Console.WriteLine("En este caso, usamos 'if-else' porque tenemos varias condiciones de verificación: ");
            Console.WriteLine("1. Verificar si el usuario y la contraseña son correctos.");
            Console.WriteLine("2. Verificar si solo el usuario es correcto pero la contraseña no.");
            Console.WriteLine("3. Verificar si el usuario no existe.");
            Console.WriteLine("La estructura 'if-else' es ideal para comparar múltiples condiciones que no siguen un patrón claro y único.");
            Console.WriteLine("Cada condición necesita ser evaluada de forma independiente y no hay un valor discreto como en el caso de un 'switch'.");

            Console.WriteLine("===========================================================================");

            //Datos de Acceso Corectos
            string usuarioCorrecto = "Jesús";
            string contraseñaCorrecta = "exodo14:14";

            //Solicitar Usuario y Contraseña
            Console.WriteLine("Ingrese su Usuario: ");
            string usuarioIngresado = Console.ReadLine();

            Console.WriteLine("Ingrese su Contraseña: ");
            string contraseñaIngresada = Console.ReadLine();

            //Verificacion
            if (usuarioIngresado == usuarioCorrecto && contraseñaIngresada == contraseñaCorrecta)
            {
                Console.WriteLine("Acceso Concedido. ");
            }
            else if (usuarioIngresado == usuarioCorrecto && usuarioIngresado != contraseñaCorrecta)
            {
                Console.WriteLine("Contraseña Incorrecta. ");
            }
            else
            {
                Console.WriteLine("Usuario no registrado.");
            }
        }
    }
}
