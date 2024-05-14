using Sistest.Exercises;
using System;


namespace Sistest 
{
    class Program
    {
        static void Main(string[] args)
        {
            // Exercise 1
            Exercise1 ex1 = new Exercise1();
            Console.WriteLine("Exercise 1:");
            Console.WriteLine(ex1.Solution(268)); //must return 5268
            







            Console.WriteLine(ex1.Solution(670));  // Must return 6750
            Console.WriteLine(ex1.Solution(0));  // Must return 50
            Console.WriteLine(ex1.Solution(-999));  // Must return - 5999

            Console.WriteLine(ex1.Solution(-100000));  // Must return - 1000005
            Console.WriteLine(ex1.Solution(11111));  // Must return 511111
            Console.WriteLine(ex1.Solution(-11111));  // Must return - 111115
            Console.WriteLine(ex1.Solution(22222));  // Must return 522222
            Console.WriteLine(ex1.Solution(-22222));  // Must return - 222225


            //Exercise 2
            Exercise2 ex2 = new Exercise2();
            Console.WriteLine("Exercise 2:");
            int[] arrayExample = { 0, 1, 1, 1, 0, 1, 1, 1, 0, 1 };
            int[] arrayExample1 = { 0, 0 };

            Console.WriteLine(ex2.Solution(arrayExample));  //Must return 1
            Console.WriteLine(ex2.Solution(arrayExample1)); //Must return -1

            int[] array1 = { 1 };
            Console.WriteLine(ex2.Solution(array1));  // Must return 0

            int[] array2 = { 0 };
            Console.WriteLine(ex2.Solution(array2));  // Must return -1

            int[] array3 = { 0, 0 };
            Console.WriteLine(ex2.Solution(array3));  // Must return -1

            int[] array4 = { 1, 0 };
            Console.WriteLine(ex2.Solution(array4));  // Must return 0

            int[] array5 = { 0, 1 };
            Console.WriteLine(ex2.Solution(array5));  // Must return 1

            int[] array6 = { 1, 1 };
            Console.WriteLine(ex2.Solution(array6));  // Must return 0

            int[] array7 = { 1, 0, 1 };
            Console.WriteLine(ex2.Solution(array7));  // Must return 0

            int[] array8 = { 0, 1, 1 };
            Console.WriteLine(ex2.Solution(array8));  // Must return 1

            int[] array9 = { 0, 1, 1, 0, 1, 0 };
            Console.WriteLine(ex2.Solution(array9));  // Must return 1

            int[] array10 = { 1, 1, 0, 1 };
            Console.WriteLine(ex2.Solution(array10));  // Must return 0

            int[] array11 = { 1, 0, 1, 1 };
            Console.WriteLine(ex2.Solution(array11));  // Must return 2

            int[] array12 = { 0, 1, 1, 1 };
            Console.WriteLine(ex2.Solution(array12));  // Must return 1

            int[] array13 = { 1, 0, 1, 1, 0 };
            Console.WriteLine(ex2.Solution(array13));  // Must return 2

            int[] array14 = { 0, 1, 1, 1, 0 };
            Console.WriteLine(ex2.Solution(array14));  // Must return 1

            int[] array15 = { 1, 1, 0, 1, 1 };
            Console.WriteLine(ex2.Solution(array15));  // Must return 0

            int[] array16 = { 1, 1, 0, 0, 1, 1 };
            Console.WriteLine(ex2.Solution(array16));  // Must return 0

            int[] array17 = { 0, 0, 1, 1, 1, 0, 0 };
            Console.WriteLine(ex2.Solution(array17));  // Must return 2

            int[] array18 = { 0, 1, 1, 1, 0, 1, 1 };
            Console.WriteLine(ex2.Solution(array18));  // Must return 1

            int[] array19 = { 0, 1, 1, 1, 0, 1, 1, 1 };
            Console.WriteLine(ex2.Solution(array19));  // Must return 1

            int[] array20 = { 1, 1, 0, 1, 1, 0 };
            Console.WriteLine(ex2.Solution(array20));  // Must return 0

            int[] array21 = { 1, 1, 0, 1, 1, 0, 1 };
            Console.WriteLine(ex2.Solution(array21));  // Must return 0

            int[] array22 = { 1, 0, 1, 0, 1, 1, 1 };
            Console.WriteLine(ex2.Solution(array22));  // Must return 4

            int[] array23 = { 1, 0, 1, 1, 1, 1, 0 };
            Console.WriteLine(ex2.Solution(array23));  // Must return 2

            int[] array24 = { 1, 1, 1, 0, 1, 1, 1 };
            Console.WriteLine(ex2.Solution(array24));  // Must return 0

            int[] array25 = { 1, 1, 0, 1, 0, 1, 1, 0 };
            Console.WriteLine(ex2.Solution(array25));  // Must return 0

            int[] array26 = { 1, 0, 1, 0, 1, 0, 1 };
            Console.WriteLine(ex2.Solution(array26));  // Must return 0

            int[] array27 = { 1, 0, 0, 1, 1, 0, 1 };
            Console.WriteLine(ex2.Solution(array27));  // Must return 3

            int[] array28 = { 1, 1, 1, 0, 0, 0, 0 };
            Console.WriteLine(ex2.Solution(array28));  // Must return 0

            int[] array29 = { 1, 0, 1, 1, 1, 1, 0 };
            Console.WriteLine(ex2.Solution(array29));  // Must return 2

            int[] array30 = { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            Console.WriteLine(ex2.Solution(array30));  // Must return -1


            //Exercise 3
            Exercise3 ex3 = new Exercise3();
            Console.WriteLine("Exercise 3:");
            ex3.ExecuteSQL(); //Must return 
        }
    }
}
