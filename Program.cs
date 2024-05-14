using Sistest.Exercises;
using System;


namespace Sistest 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1
            Exercise1 ex1 = new Exercise1();
            Console.WriteLine("Exercise 1:");
            Console.WriteLine(ex1.Solution(268));
            Console.WriteLine(ex1.Solution(670));
            Console.WriteLine(ex1.Solution(0));
            Console.WriteLine(ex1.Solution(-999));

            //Ejercicio 2
            Exercise2 ex2 = new Exercise2();
            Console.WriteLine("Exercise 2:");
            //int[] array = { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 };
            //int[] array2 = { 0, 0 };
            //int[] array3 = { 1, 1, 0, 1, 1, 1 };
            //int[] array4 = { 1, 1, 1, 1, 1 }; 
            //Console.WriteLine(ex2.Solution(array));
            //Console.WriteLine(ex2.Solution(array2));
            //Console.WriteLine(ex2.Solution(array3));
            //Console.WriteLine(ex2.Solution(array4));

            int[] array1 = { 1, 1, 0, 1, 1, 1 }; // Esperado: 3
            Console.WriteLine(ex2.Solution(array1)); // Debe devolver 3
            int[] array2 = { 1, 1, 1, 1, 1 }; // Esperado: 0
            Console.WriteLine(ex2.Solution(array2)); // Debe devolver 0
            int[] array3 = { 0, 0, 1, 1, 1 }; // Esperado: 2
            Console.WriteLine(ex2.Solution(array3)); // Debe devolver 2
            int[] array4 = { 0, 0, 0, 0 }; // Esperado: -1
            Console.WriteLine(ex2.Solution(array4)); // Debe devolver -1
            int[] array5 = { 0, 1, 1, 0, 1, 0 }; // Esperado: 1
            Console.WriteLine(ex2.Solution(array5)); // Debe devolver 1





            // Ejercicio 3
            //Exercise3 ex3 = new Exercise3();
            //Console.WriteLine("\nExercise 3:");
            //ex3.ExecuteSQL();
        }
    }
}
