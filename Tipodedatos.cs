using System;

namespace TiposdeDatos
{
    class Program
    {
        static void Main(string[] args)
        {
            // Número Entero (int)
            int numentero = 12;
            Console.WriteLine($"El Número Entero en (int) es: {numentero}");

            // Número Decimal (float)
            float decimalfloat = 3.1415927f;
            Console.WriteLine($"El Número Decimal en (float) es: {decimalfloat}");

            // Número Decimal (double)
            double decimaldouble = 3.141592653589793;
            Console.WriteLine($"El Número Decimal en (double) es: {decimaldouble}");

            // Valor Máximo para byte
            byte bytemax = 255;
            Console.WriteLine($"El Valor Máximo en Byte es: {bytemax}");

            // Texto
            string texto = "Hola, Dios te Bendiga";
            Console.WriteLine($"El Texto dice: {texto}");
        }
    }
}
