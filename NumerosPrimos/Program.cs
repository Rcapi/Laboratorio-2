using System;
using System.Net.WebSockets;

using System;

namespace Lab01
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Ingrese el valor de la cantidad de pares de numeros primos gemelos que hay que mostrar:");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] paresGemelos = new int[n * 2]; 

            int contador = 0;
            int i = 3;

            while (contador < n)
            {
                if (EsPrimo(i) && EsPrimo(i + 2)) // Recordatorio. funcion para ver si el numero es primo, ademas de ser primo este y su "gemelo" tienen que serlos para mostrarlo. un gemelo es cuando la diferencia de dos numeros primos es 2. 
                {
                    paresGemelos[contador * 2] = i;
                    paresGemelos[contador * 2 + 1] = i + 2;
                    contador++;
                }

                i++;
            }

            Console.WriteLine($"Los primeros {n} pares de numeros primos gemelos son:");
            for (int j = 0; j < n * 2; j += 2)
            {
                Console.WriteLine($"({paresGemelos[j]}, {paresGemelos[j + 1]})");
            }
        }

        static bool EsPrimo(int numero)
        {
            if (numero <= 1) return false;
            if (numero == 2) return true;
            if (numero % 2 == 0) return false;

            int limite = (int)Math.Sqrt(numero);

            for (int i = 2; i <= limite; i ++)
            {
                if (numero % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}