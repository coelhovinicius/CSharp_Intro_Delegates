/* DELEGATES*/

/* >>> PROGRAMA PRINCIPAL <<< */
using System;
using Aula221_Intro_Delegates.Services;

namespace Aula221_Intro_Delegates
{
    class Program
    {
        // Expecifica que e uma referencia para uma funcao que recebe dois numeros "double" e retorna um numero "double"
        delegate double BinaryNumericOperation(double n1, double n2); // Declaracao do Delegate

        static void Main(string[] args)
        {
            double a = 10;
            double b = 12;

            BinaryNumericOperation op1 = CalculationService.Sum;
            // BinaryNumericOperation op1 = new BinaryNumericOperation(CalculationService.Sum); // Sintaxe alternativa

            double result1 = op1(a, b);
            Console.WriteLine(result1);

            BinaryNumericOperation op2 = CalculationService.Max;

            double result2 = op2(a, b);
            //double result2 = op2.Invoke(a, b); // Sintaxe alternativa - invoca a funcao atribuida a op2
            Console.WriteLine(result2);

            /*double result1 = CalculationService.Sum(a, b);
            Console.WriteLine(result1);

            double result2 = CalculationService.Max(a, b);
            Console.WriteLine(result2);

            double result3 = CalculationService.Square(a);
            Console.WriteLine(result3);*/
        }
    }
}
