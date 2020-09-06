using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2daEvaluacion3erBim
{
    class Program
    {
        static void Main(string[] args)
        {
            int op;
            do
            {
                op = menu();
                switch (op)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        Ejercicio2();
                        break;
                    case 3:
                        Ejercicio3();
                        break;
                    case 4:
                        Ejercicio4();
                        break;
                }
            } while (op != 5);


        }

        private static void Ejercicio4()
        {
            Console.WriteLine("Introduzca la cantidad de notas que introducira: ");
            int N = int.Parse(Console.ReadLine());
            int nota, Aprobados=0, reprobados=0, apro=0;
            Console.WriteLine("Solo notas de entre 0 y 100 por favor");
            for(int i = 1; i <= N; i++)
            {
                Console.WriteLine("Ingrese la nota del estudiante " + i + "o");
                do
                {
                    nota = int.Parse(Console.ReadLine());
                } while (!(nota > 0 && nota < 101));
                if (nota > 60)
                {
                    Aprobados++;
                    if (nota > 79 && nota < 101)
                        apro++;
                }
                else
                {
                    reprobados++;
                    //Aqui podremos realizar nuevas capturas
                }
            }
            int porcentaje = (reprobados * 100) / N;
            Console.WriteLine("------------------------- RESULTADO -----------------------------");
            Console.WriteLine("Aprobaron " + Aprobados + " estudiante(s)");
            Console.WriteLine("El porcentaje de reprobados es de " + porcentaje + "%  de los estudiantes");
            Console.WriteLine("Aprobaron " + apro + " estudiantes con una nota de entre 80 y 100");
            Console.WriteLine("-----------------------------------------------------------------");
        }

        private static void Ejercicio3()
        {
            Console.WriteLine("ingrese la cantidad N a leer numeros");
            int N = int.Parse(Console.ReadLine());
            int max = 0, min = int.MaxValue, numero;
            for (int i = 1; i <= N; i++)
            {
                Console.WriteLine("Ingrese el " + i + "o numero:");
                numero = int.Parse(Console.ReadLine());
                if (numero >= max)
                    max = numero;
                if (numero <= min)
                    min = numero;
            }
            int resultado = max - min;
            Console.WriteLine("El resultado " + resultado);
        }

        private static void Ejercicio2()
        {
            Console.WriteLine("Ingrese la cantidad N a generar");
            int N = int.Parse(Console.ReadLine());
            int a = -1, b = 1, c, cp=0;
            for(int i = 0; i < N; i++)
            {
                c = a + b;
                Console.WriteLine(c);
                if (c % 2 != 0)
                    cp++;
                a = b;
                b = c;
            }
            Console.WriteLine(" ----------  resultado ----------");
            decimal porcentaje = (cp * 100) / N;
            Console.WriteLine("Existe un " + porcentaje + "% de numeros impares");
            Console.WriteLine(" --------------------------------");
        }

        private static void Ejercicio1()
        {
            Console.WriteLine("Ingrese la cantidad de numeros que generara");
            int N = int.Parse(Console.ReadLine());
            int num = 4;
            for(int i = 1; i <= N; i++)
            {
                if (i % 2 == 0)
                {
                    num = num * 2;
                    Console.WriteLine(num);
                    num = num + 2;
                }
                else
                {
                    Console.WriteLine(num);
                }
            }
        }

        private static int menu()
        {
            int op;
            do
            {
                Console.WriteLine(" ----- MENU PRINCIPAL -----");
                Console.WriteLine("1. Generar e imprimir la siguiente secuencia: 4,8,10,20,22,44");
                Console.WriteLine("2. Generar los N primero FIBONACCIS, e imprimir el porcentaje de los terminos impares");
                Console.WriteLine("3. Leer N numeros e imprimir el resultado de la diferencia del mayor y el menor de los numeros");
                Console.WriteLine("4. Leer las notas de N estudiantes e imprimir: a) Cuantos aprobaron la materia b) Porcentaje de los estudiantes que no aprobaron c) Cuantos aprobaron con nota entre 80 y 100");
                Console.WriteLine("5. SALIR");
                Console.WriteLine("INTRODUCIR UNA OPCION [1-5]");
                op = int.Parse(Console.ReadLine());
            } while (op < 1 || op > 5);
            return op;
        }
    }
}
