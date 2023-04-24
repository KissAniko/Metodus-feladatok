using System;

namespace Fizetendő
{
    class Program
    {
        /*Készítsen egy metódust Fizetendo néven, ami a következő paraméterekkel bír
            - fogyasztás 100km-en(legkisebb helyfoglalású lebegőpontos típus)
            - megtett út km-ben(legnagyobb helyfoglalású egész típus)
            - egy liter üzemanyag ára(egész típus)

        Visszatérési érték: Az adott fogyasztás mellett mekkora költséget jelent az út megtétele.*/
        static void Main(string[] args)
      
        {

            Console.WriteLine($"Fizetendő: {Fizetendo(7, 100, 480)} Ft.");
        }
      
            static double  Fizetendo(float fogyasztas, decimal ut, int uzemanyagAr)
        {
            Console.Write($"A megtett út (km): ");
            ut = Convert.ToDecimal(Console.ReadLine());

            decimal fizetendo = Convert.ToDecimal(fogyasztas) * ut * uzemanyagAr / 100;

            return Convert.ToDouble(fizetendo);                      
        }
    }
}
