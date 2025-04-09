// Ejercicio: “Sistema de Notas Finales”

// Descripción del reto:

// Un profesor necesita ayuda para calcular la nota final de sus estudiantes y saber si aprueban o reprueban. El sistema debe registrar los datos de 5 estudiantes. Cada uno tiene 3 notas parciales y la nota final es el promedio de estas.

// Además, se debe clasificar su desempeño así:
//  • Aprobado: si la nota final es mayor o igual a 70
//  • Requiere recuperación: si la nota está entre 60 y 69
//  • Reprobado: si la nota es menor a 60

// ⸻

// Requisitos del reto:
//  1. Entrada de datos:
//  • Por cada estudiante, solicitar:
//  • Nombre completo
//  • Nota 1
//  • Nota 2
//  • Nota 3
//  • Validar que las notas estén entre 0 y 100.
//  2. Procesamiento:
//  • Calcular el promedio de las 3 notas.
//  • Determinar su estatus final (Aprobado, Recuperación, Reprobado).


using System.Drawing;
using System.Net.Cache;

string[] estudiantes = new string[5];
int[] notaFinal = new int[5];

   
    for(int i = 0; i < estudiantes.Length; i++){
        
        Console.ForegroundColor = ConsoleColor.Magenta;
        Console.Write($"{i + 1}. Inserte el nombre completo del estudiante: \n");
        Console.ForegroundColor = ConsoleColor.White;
        estudiantes[i] = Console.ReadLine() ?? "";

        int[] nota = new int[3];
        int sumaNotas = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n-------------------------------------------");
            Console.WriteLine("     Ingrese las notas del estudiante        ");
            Console.WriteLine("-------------------------------------------\n");

        for(int j = 0; j < nota.Length; j++){

            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write($"{j + 1}. Inserte la nota: ");
            Console.ForegroundColor = ConsoleColor.White;
            nota[j] = Convert.ToInt32(Console.ReadLine());

                if(nota[j] < 0 ||  nota[j] > 100){

                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("La nota debe estar entre 0 y 100");
                    j--;
                    continue;

                }

            sumaNotas += nota[j];
        }

        notaFinal[i] = sumaNotas / 3;
    

    }

    Console.ForegroundColor = ConsoleColor.DarkCyan;
    Console.WriteLine("\t RESUMEN FINAL DE ESTUDIANTES\n");

    for(int i = 0; i < estudiantes.Length; i++){

        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine($"\n {i + 1 }. El estudiante {estudiantes[i]}, tiene un promedio de: {notaFinal[i]}");

        if(notaFinal[i] >= 70){

                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Estado: Aprobado");
            }else if(notaFinal[i]  >= 60 && notaFinal[i] <= 69){

                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Estado: Requiere recuperacion");
            }else{
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Estado: Reprobado");
            }

    }

    Console.ResetColor();







