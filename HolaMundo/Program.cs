using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace HolaMundo
{
    internal class Program
    {

        static void Main(string[] args)
        {
            int opcion;
            do
            {
                Console.WriteLine("MENU:");
                Console.WriteLine("1. Determinar si un número ingresado por el usuario es positivo, negativo o cero");
                Console.WriteLine("2. Imprimir un mensaje según el día de la semana");
                Console.WriteLine("3. Calcular la suma de los primeros 100 números naturales");
                Console.WriteLine("4. Imprimir números desde 1 hasta el número ingresado");
                Console.WriteLine("5. Calcular el área de un círculo");
                Console.WriteLine("6. Mostrar elementos de un arreglo unidimensional");
                Console.WriteLine("7. Mostrar nombres de personas almacenados en una lista");
                Console.WriteLine("8. Salir");
                Console.WriteLine("INGRESE LA OPCION REQUERIDA:");

                opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        DeterminarNumero();
                        break;
                    case 2:
                        ImprimirDiaSemana();
                        break;
                    case 3:
                        Console.WriteLine("LA SUMA DE LOS PRIMEROS 100 NUMEROS NATURALES ES: " + SumaPrimeros100Numeros());
                        break;
                    case 4:
                        ImprimirNumerosHastaN();
                        break;
                    case 5:
                        Console.WriteLine("INGRESE EL RADIO DEL CIRCULO:");
                        double radio = double.Parse(Console.ReadLine());
                        Console.WriteLine("EL AREA DEL CIRCULO ES: " + CalcularAreaCirculo(radio));
                        break;
                    case 6:
                        MostrarArreglo();
                        break;
                    case 7:
                        MostrarNombres();
                        break;
                    case 8:
                        Console.WriteLine("SALIENDO");
                        break;
                    default:
                        Console.WriteLine("INGRESE UNA OPCION VALIDA.");
                        break;
                }
            } while (opcion != 8);
        }

        static void DeterminarNumero()
        {
            Console.WriteLine("INGRESE UN NUMERO:");
            int numero = int.Parse(Console.ReadLine());
            if (numero > 0)
                Console.WriteLine("EL NUMERO ES POSITIVO.");
            else if (numero < 0)
                Console.WriteLine("EL NUMERO ES NEGATIVO.");
            else
                Console.WriteLine("EL NUMERO ES CERO.");
        }

        static void ImprimirDiaSemana()
        {
            Console.WriteLine("INGRESE UN NUMERO DEL 1 AL 7 REPRESENTANDO EL DIA DE LA SEMANA:");
            int numeroDia = int.Parse(Console.ReadLine());
            switch (numeroDia)
            {
                case 1:
                    Console.WriteLine("LUNES");
                    break;
                case 2:
                    Console.WriteLine("MARTES");
                    break;
                case 3:
                    Console.WriteLine("MIERCOLES");
                    break;
                case 4:
                    Console.WriteLine("JUEVES");
                    break;
                case 5:
                    Console.WriteLine("VIERNES");
                    break;
                case 6:
                    Console.WriteLine("SABADO");
                    break;
                case 7:
                    Console.WriteLine("DOMINGO");
                    break;
                default:
                    Console.WriteLine("DIA NO VALIDO.");
                    break;
            }
        }

        static int SumaPrimeros100Numeros()
        {
            int suma = 0;
            for (int i = 1; i <= 100; i++)
            {
                suma += i;
            }
            return suma;
        }

        static void ImprimirNumerosHastaN()
        {
            Console.WriteLine("INGRESE UN NUMERO:");
            int numero = int.Parse(Console.ReadLine());
            for (int i = 1; i <= numero; i++)
            {
                Console.WriteLine(i);
            }
        }

        static double CalcularAreaCirculo(double radio)
        {
            return Math.PI * radio * radio;
        }

        static void MostrarArreglo()
        {
            int[] arreglo = { 1, 2, 3, 4, 5 };
            Console.WriteLine("ELEMENTOS DEL ARREGLO:");
            foreach (var elemento in arreglo)
            {
                Console.WriteLine(elemento);
            }
        }

        static void MostrarNombres()
        {
            List<string> nombres = new List<string>() { "JUAN", "MARIA", "CARLOS", "ANA" };
            Console.WriteLine("NOMBRES ALMACENADOS:");
            foreach (var nombre in nombres)
            {
                Console.WriteLine(nombre);
            }
        }

    }


    

}

