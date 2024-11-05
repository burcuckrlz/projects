// Decisiones.cs
using System;

class Decisiones
{
    static void Main()
    {
        Console.Write("Ingrese un número: ");
        try
        {
            double numero = Convert.ToDouble(Console.ReadLine());
            if (numero > 0)
            {
                Console.WriteLine("El número ingresado es positivo.");
            }
            else if (numero < 0)
            {
                Console.WriteLine("El número ingresado es negativo.");
            }
            else
            {
                Console.WriteLine("El número ingresado es cero.");
            }
        }
        catch
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}
