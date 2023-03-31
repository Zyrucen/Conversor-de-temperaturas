using System;
using System.Data;

namespace Conversor_de_temperaturas

/* Ejercicio: Conversor de grados Celsius a Fahrenheit

Crea un programa que pida al usuario una temperatura en 
grados Celsius y la convierta a grados Fahrenheit utilizando la fórmula:
°F = (°C * 9 / 5) + 32
ºC = (32 °F − 32) × 5 / 9 = 0 °C


Añadimos la funcionalidad de poder pasar tambien de ºF a ºC con una selecion al 
principio del programa. 

 */
{
    internal class Program

    {
        static void Main(string[] args)
        {

            //Declaramos alguna variable necesaria para el programa. 
            int selecion;
            float Temp;
            string respuesta;

            // Mostramos por consola una explicacion de lo que hace el programa. 

            Console.WriteLine("Programa conversor de temperatura");

            do
            {
                Console.WriteLine("Por favor, elige que temperatura quieres transformar\n" +
                "De Fahrenheit a Celsius - Opcion 1\n" +
                "De Celsius a Fahrenheit - Opcion 2");
                selecion = Int32.Parse(Console.ReadLine());
                //Creamos un selector de opciones para hacer las conversiones
                switch (selecion)
                {
                    case 1:
                        Console.WriteLine("Escribe los grados ºF que quieres convertir a grados ºC");
                        Temp = float.Parse(Console.ReadLine());
                        Console.WriteLine("{0} ºC ", ((Temp - 32) * 5 / 9));
                        break;
                    case 2:
                        Console.WriteLine("Escribe los grados ºC que quieres convertir a grados ºF");
                        Temp = float.Parse(Console.ReadLine());
                        Console.WriteLine("{0} ºF ", (Temp * 9 / 5 + 32));
                        break;
                    default: Console.WriteLine("Por favor, escribe una opcion correcta (1, 2)");
                        break;
                }
                Console.WriteLine("¿Quieres hacer otra conversion?");
                respuesta = Console.ReadLine();
                respuesta = respuesta.ToLower();
            }while (respuesta == "si");

        }
    }
}
