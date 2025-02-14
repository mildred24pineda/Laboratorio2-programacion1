# Laboratorio2-programacion1

### Operadores Lógicos y Tipos de Datos en C#

1️⃣**¿Para qué crees que se usan los operadores lógicos en programación?**
Los operadores lógicos en programación se usan para evaluar condiciones y tomar decisiones en el código. Permiten combinar expresiones booleanas y controlar el flujo del programa en estructuras como `if`, `while` y `for`.  

✔️**Ejemplo de operadores lógicos en C#:** 
- `&&` (AND) → Devuelve `true` si ambas condiciones son verdaderas.  
- `||` (OR) → Devuelve `true` si al menos una condición es verdadera.  
- `!` (NOT) → Invierte el valor de una condición booleana.
  

2️⃣**¿Por qué es importante declarar correctamente el tipo de dato de una variable?**
Declarar correctamente el tipo de dato en una variable es fundamental porque:  
   1. **Optimiza el uso de memoria**: Cada tipo de dato ocupa un espacio específico en memoria, por lo que elegir el adecuado evita desperdicio de recursos.  
   2. **Evita errores de tipo**: Si no se usa el tipo correcto, pueden ocurrir errores en cálculos o conversiones inesperadas.  
   3. **Mejora la claridad del código**: Facilita la lectura y mantenimiento del programa.  



✔️**Uso de Operadores Lógicos en C#**
```csharp
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

