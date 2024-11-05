// CalcularLetraDNI.cs
using System;

class CalcularLetraDNI
{
    static void Main()
    {
        char[] letras = {'T', 'R', 'W', 'A', 'G', 'M', 'Y', 'F', 'P', 'D', 'X', 'B', 'N', 'J', 'Z', 'S', 'Q', 'V', 'H', 'L', 'C', 'K', 'E'};
        
        Console.Write("Ingrese su número de DNI (solo la parte numérica): ");
        try
        {
            int dni = Convert.ToInt32(Console.ReadLine());
            if (dni < 0 || dni > 99999999)
            {
                Console.WriteLine("Número de DNI inválido.");
            }
            else
            {
                char letra = letras[dni % 23];
                Console.WriteLine("La letra de su DNI es: " + letra);
            }
        }
        catch
        {
            Console.WriteLine("Por favor, ingrese un número válido.");
        }
    }
}
