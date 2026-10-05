// ==========================================
// PROGRAMA COMPLETO DE LÓGICA BÁSICA EN C#
// ==========================================

using System;
using System.Collections.Generic;
using System.Linq;

namespace LogicaBasicaCSharp
{
    class Program
    {
        static void Main(string[] args)Get-Content -Path "Logica#1\Program.cs" -Head 15
        {
            Console.WriteLine("¡Probando el flujo completo de Git y GitHub!");
            Console.WriteLine("==========================================");
            Console.WriteLine("   LÓGICA DE PROGRAMACIÓN EN C# - BÁSICO");
            Console.WriteLine("==========================================");
            Console.WriteLine();

            // ==========================================
            // 1. VARIABLES Y TIPOS DE DATOS
            // ==========================================
            Console.WriteLine("=== 1. VARIABLES Y TIPOS DE DATOS ===");

            int edad = 25;
            double altura = 1.75;
            string nombre = "Juan";
            bool esEstudiante = true;
            char letra = 'A';

            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Altura: {altura}"); //IMPRIMIR VALORES REALES DE ESTE MISMO CON $ COMO CON UN MENSAJE
            Console.WriteLine($"Es estudiante: {esEstudiante}, Letra: {letra}");
            Console.WriteLine();

            // ==========================================
            // 2. OPERADORES
            // ==========================================

            Console.WriteLine("=== 2. OPERADORES ===");

            int a = 10, b = 3;
            Console.WriteLine($"Suma: {a + b}");
            Console.WriteLine($"Resta: {a - b}");
            Console.WriteLine($"Multiplicación: {a * b}");
            Console.WriteLine($"División: {(double)a / b:F2}");
            Console.WriteLine($"Módulo: {a % b}");
            Console.WriteLine($"Potencia: {Math.Pow(a, b)}");
            Console.WriteLine($"¿Es mayor? {a > b}");
            Console.WriteLine($"AND lógico: {(a > 5 && b < 5)}");
            Console.WriteLine();

            // ==========================================
            // 3. CONDICIONALES (if, else if, else, switch)
            // ==========================================
            Console.WriteLine("=== 3. CONDICIONALES ===");

            int nota = 85;
            if (nota >= 90)
                Console.WriteLine("Excelente");
            else if (nota >= 70)
                Console.WriteLine("Aprobado");
            else if (nota >= 60)
                Console.WriteLine("Suficiente");
            else
                Console.WriteLine("Reprobado");

            // Switch
            int dia = 3;
            switch (dia)
            {
                case 1: Console.WriteLine("Lunes"); break;
                case 2: Console.WriteLine("Martes"); break;
                case 3: Console.WriteLine("Miércoles"); break;
                default: Console.WriteLine("Otro día"); break;
            }
            Console.WriteLine();

            // ==========================================
            // 4. BUCLES (for, foreach, while, do while)
            // ==========================================
            Console.WriteLine("=== 4. BUCLES ===");

            // For
            Console.Write("For: ");
            for (int i = 0; i < 5; i++)
                Console.Write($"{i} ");
            Console.WriteLine();

            // Foreach
            string[] frutas = { "manzana", "banana", "naranja" };
            Console.Write("Foreach: ");
            foreach (string fruta in frutas)
                Console.Write($"{fruta} ");
            Console.WriteLine();

            // While
            Console.Write("While: ");
            int contador = 0;
            while (contador < 5)
            {
                Console.Write($"{contador} "); 
                contador++;
            }
            Console.WriteLine();

            // Do While
            Console.Write("Do While: ");
            int num = 0;
            do
            {
                Console.Write($"{num} ");
                num++;
            } while (num < 5);
            Console.WriteLine();
            Console.WriteLine();

            // ==========================================
            // 5. FUNCIONES Y MÉTODOS
            // ==========================================
            Console.WriteLine("=== 5. FUNCIONES ===");

            // Llamar funciones
            Saludar();
            Console.WriteLine($"Suma: {Sumar(5, 3)}");
            Console.WriteLine($"Factorial de 5: {Factorial(5)}");
            Console.WriteLine($"Potencia: {Potencia(2, 5)}");
            Console.WriteLine($"Combinación C(5,2): {Combinacion(5, 2)}");

            // Función con parámetros opcionales
            MostrarDatos("Juan", 25, "Madrid");
            MostrarDatos("Maria", 30);
            MostrarDatos("Pedro");
            Console.WriteLine();

            // ==========================================
            // 6. ARREGLOS Y LISTAS
            // ==========================================
            Console.WriteLine("=== 6. ARREGLOS Y LISTAS ===");

            // Arreglos
            int[] numeros = { 1, 2, 3, 4, 5 };
            Console.Write("Arreglo: ");
            foreach (int n in numeros)
                Console.Write($"{n} ");
            Console.WriteLine();

            // Listas
            List<string> colores = new List<string> { "rojo", "verde", "azul" };
            colores.Add("amarillo");
            Console.Write("Lista: ");
            foreach (string color in colores)
                Console.Write($"{color} ");
            Console.WriteLine();
            Console.WriteLine();

            // ==========================================
            // 7. DICCIONARIOS
            // ==========================================
            Console.WriteLine("=== 7. DICCIONARIOS ===");

            Dictionary<string, int> edades = new Dictionary<string, int>
            {
                { "Juan", 25 },
                { "Maria", 30 },
                { "Pedro", 22 }
            };

            foreach (var kvp in edades)
                Console.WriteLine($"{kvp.Key}: {kvp.Value} años");
            Console.WriteLine();

            // ==========================================
            // 8. MANEJO DE STRINGS
            // ==========================================
            Console.WriteLine("=== 8. MANEJO DE STRINGS ===");

            string texto = "Hola Mundo";
            Console.WriteLine($"Original: {texto}");
            Console.WriteLine($"Mayúsculas: {texto.ToUpper()}");
            Console.WriteLine($"Minúsculas: {texto.ToLower()}");
            Console.WriteLine($"Longitud: {texto.Length}");
            Console.WriteLine($"Contiene 'Mundo': {texto.Contains("Mundo")}");
            Console.WriteLine($"Reemplazar: {texto.Replace("Mundo", "C#")}");
            Console.WriteLine($"Substring: {texto.Substring(0, 4)}");
            Console.WriteLine();

            // ==========================================
            // 9. MANEJO DE EXCEPCIONES
            // ==========================================
            Console.WriteLine("=== 9. MANEJO DE EXCEPCIONES ===");

            try
            {
                Console.Write("Ingresa un número para dividir 10: ");
                int divisor = int.Parse(Console.ReadLine());
                int resultado = 10 / divisor;
                Console.WriteLine($"10 / {divisor} = {resultado}");
            }
            catch (FormatException)
            {
                Console.WriteLine("Error: Debes ingresar un número válido");
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Error: No se puede dividir entre cero");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
            }
            finally
            {
                Console.WriteLine("Bloque finally ejecutado");
            }
            Console.WriteLine();

            // ==========================================
            // 10. EJERCICIOS PRÁCTICOS
            // ==========================================
            Console.WriteLine("=== 10. EJERCICIOS PRÁCTICOS ===");

            // Números pares
            Console.Write("Números pares del 0 al 20: ");
            for (int i = 0; i <= 20; i += 2)
                Console.Write($"{i} ");
            Console.WriteLine();

            // Primos
            Console.Write("Números primos del 1 al 20: ");
            for (int i = 1; i <= 20; i++)
                if (EsPrimo(i))
                    Console.Write($"{i} ");
            Console.WriteLine();

            // Palíndromo
            Console.WriteLine($"¿'anita lava la tina' es palíndromo? {EsPalindromo("anita lava la tina")}");

            // Suma de dígitos
            Console.WriteLine($"Suma de dígitos de 1234: {SumaDigitos(1234)}");
            Console.WriteLine();

            Console.WriteLine("==========================================");
            Console.WriteLine("   FIN DEL PROGRAMA");
            Console.WriteLine("==========================================");
            Console.ReadKey();
        }

        // ==========================================
        // FUNCIONES Y MÉTODOS AUXILIARES
        // ==========================================

        // Función simple
        static void Saludar()
        {
            Console.WriteLine("¡Hola desde una función!");
        }

        // Función con parámetros y retorno
        static int Sumar(int a, int b)
        {
            return a + b;
        }

        // Función recursiva: Factorial
        static int Factorial(int n)
        {
            if (n == 0)
                return 1;
            return n * Factorial(n - 1);
        }

        // Función recursiva con 2 llamadas: Potencia
        static int Potencia(int baseNum, int exponente)
        {
            if (exponente == 0)
                return 1;
            else
                return Potencia(baseNum, exponente - 1) * Potencia(baseNum, exponente - 1) / baseNum;
        }

        // Función recursiva con 2 llamadas: Combinaciones
        static int Combinacion(int n, int k)
        {
            if (k == 0 || k == n)
                return 1;
            if (k > n)
                return 0;
            return Combinacion(n - 1, k - 1) + Combinacion(n - 1, k);
        }

        // Función con parámetros opcionales
        static void MostrarDatos(string nombre, int edad = 0, string ciudad = "Desconocida")
        {
            Console.WriteLine($"Nombre: {nombre}, Edad: {edad}, Ciudad: {ciudad}");
        }

        // Función: Números primos
        static bool EsPrimo(int n)
        {
            if (n < 2) return false;
            for (int i = 2; i <= Math.Sqrt(n); i++)
                if (n % i == 0)
                    return false;
            return true;
        }

        // Función: Palíndromo
        static bool EsPalindromo(string texto)
        {
            texto = texto.ToLower().Replace(" ", "");
            char[] arr = texto.ToCharArray();
            Array.Reverse(arr);
            return texto == new string(arr);
        }

        // Función recursiva: Suma de dígitos
        static int SumaDigitos(int n)
        {
            n = Math.Abs(n);
            if (n == 0)
                return 0;
            return n % 10 + SumaDigitos(n / 10);
            
        }
    }
}