using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    /// <summary>
    /// Programa principal para la prueba técnica PGD - Ejercicio 1: Sucesión de Fibonacci
    /// Implementa la generación de la sucesión de Fibonacci hasta un número ingresado por el usuario
    /// utilizando la fórmula recursiva solicitada.
    /// </summary>
    internal class Program
    {
        /// <summary>
        /// Punto de entrada principal de la aplicación
        /// </summary>
        /// <param name="args">Argumentos de línea de comandos</param>
        static void Main(string[] args)
        {
            try
            {
                Console.Title = "Prueba Técnica PGD - Fibonacci";
                
                // Solicitar número al usuario
                int numeroLimite = SolicitarNumeroAlUsuario();

                // Generar y mostrar la sucesión de Fibonacci
                Console.WriteLine();
                Console.WriteLine($"Sucesión de Fibonacci hasta {numeroLimite}:");
                Console.WriteLine("----------------------------------------");
                
                GenerarYMostrarFibonacci(numeroLimite);

                Console.WriteLine();
                Console.WriteLine("Proceso completado. Presione cualquier tecla para salir...");
                Console.ReadKey();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                Console.WriteLine("Presione cualquier tecla para salir...");
                Console.ReadKey();
            }
        }

        /// <summary>
        /// Solicita al usuario que ingrese un número válido para generar la sucesión de Fibonacci
        /// </summary>
        /// <returns>Número válido ingresado por el usuario</returns>
        private static int SolicitarNumeroAlUsuario()
        {
            int numero = 0;
            bool entradaValida = false;

            do
            {
                Console.Write("Ingrese un número para generar Fibonacci: ");
                string entrada = Console.ReadLine();

                // Validar entrada
                if (string.IsNullOrWhiteSpace(entrada))
                {
                    Console.WriteLine("Error: Ingrese un valor válido.");
                    continue;
                }

                if (!int.TryParse(entrada.Trim(), out numero))
                {
                    Console.WriteLine("Error: Debe ser un número entero.");
                    continue;
                }

                if (numero < 0)
                {
                    Console.WriteLine("Error: El número debe ser >= 0.");
                    continue;
                }

                entradaValida = true;

            } while (!entradaValida);

            return numero;
        }

        /// <summary>
        /// Genera y muestra la sucesión de Fibonacci hasta el número especificado
        /// utilizando la fórmula recursiva
        /// </summary>
        /// <param name="limite">Número límite hasta el cual generar la sucesión</param>
        private static void GenerarYMostrarFibonacci(int limite)
        {
            var fibonacci = new List<long>();
            int posicion = 0;
            long valorFibonacci;

            // Generar sucesión hasta alcanzar el límite
            do
            {
                valorFibonacci = CalcularFibonacciRecursivo(posicion);
                
                if (valorFibonacci <= limite)
                {
                    fibonacci.Add(valorFibonacci);
                    posicion++;
                }
                else
                {
                    break;
                }

            } while (valorFibonacci <= limite);

            // Mostrar resultados
            if (fibonacci.Count > 0)
            {
                Console.WriteLine($"Números encontrados: {fibonacci.Count}");
                Console.WriteLine();
                
                // Mostrar la sucesión completa
                Console.WriteLine(string.Join(", ", fibonacci));
            }
            else
            {
                Console.WriteLine("No se encontraron números de Fibonacci <= al límite.");
            }
        }

        /// <summary>
        /// Calcula el n-ésimo número de Fibonacci utilizando la fórmula recursiva
        /// F(n) = F(n-1) + F(n-2), donde F(0) = 0 y F(1) = 1
        /// </summary>
        /// <param name="n">Posición en la sucesión de Fibonacci</param>
        /// <returns>Valor de Fibonacci en la posición n</returns>
        private static long CalcularFibonacciRecursivo(int n)
        {
            // Casos base de la recursión
            if (n == 0) return 0;
            if (n == 1) return 1;

            // Fórmula recursiva: F(n) = F(n-1) + F(n-2)
            return CalcularFibonacciRecursivo(n - 1) + CalcularFibonacciRecursivo(n - 2);
        }
    }
}
