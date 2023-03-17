using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using u1tarea2.Guia_de_ejercicios;

namespace u1tarea2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Guia de ejercicios U1-Tarea2 = POO 2023 = Jose luis contreras");
            Console.WriteLine("-------------------------------------------------------------\n");

            char seguir = 's';
            while (seguir == 's')
            {

            Console.WriteLine("Guia de EJercicios");
            Console.WriteLine("------------------");
            Console.WriteLine("1. Ejercicio 1\n2. Ejercicio 2\n3. Ejercicio 3");
            Console.WriteLine("1. Ejercicio 4\n5. Ejercicio 5\n6. Ejercicio 6");
            Console.WriteLine("7. Ejercicio 7\n8. Ejercicio 8\n9. Ejercicio 9");
            Console.WriteLine("10. Ejercicio 10\n11. Ejercicio 11\n");

                Console.WriteLine("Ingrese el ejercicio que quiera vizualizar: ");
                int num = int.Parse(Console.ReadLine());
                Console.Clear();
                switch (num)
                {
                    case 1:
                        Ejercicio01 ejercicio01 = new Ejercicio01();
                        break;
                    case 2:
                        Ejercicio02 ejercicio02 = new Ejercicio02();
                        break;
                    case 3:
                        Ejercicio03 ejercicio03 = new Ejercicio03();
                        break;
                    case 4:
                        Ejercicio04 ejercicio04 = new Ejercicio04();
                        break;
                    case 5:
                        Ejercicio05 ejercicio05 = new Ejercicio05();
                        break;
                    case 6:
                        Ejercicio06 ejercicio06 = new Ejercicio06();
                        break;
                    case 7:
                        Ejercicio07 ejercicio07 = new Ejercicio07();
                        break;
                    case 8:
                        Ejercicio08 ejercicio08 = new Ejercicio08();
                        break;
                    case 9:
                        Ejercicio09 ejercicio09 = new Ejercicio09();
                        break;
                    case 10:
                        Ejercicio10 ejercicio10 = new Ejercicio10();
                        break;
                    case 11:
                        Ejercicio11 ejercicio11 = new Ejercicio11();
                        break;
                    default:
                        Console.WriteLine("Ejecicio no encontrado");
                        break;
                }
                Console.WriteLine("\n---------------------------------------");
                Console.WriteLine("¿Desea vizualizar otro ejercicio? (s/n)");
                seguir = char.Parse(Console.ReadLine());
                Console.Clear();
            }
        }
    }
}
