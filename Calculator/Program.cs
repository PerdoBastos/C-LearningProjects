using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora!");
            Console.Write("Insere o primeiro numero: ");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("Insere o operador: ");
            string op = Console.ReadLine();
            Calculator(op, num1);
        }

        static void Calculator(string op, int num1)
        {
            switch (op)
            {
                case "+":
                    Console.Write("Inerse o segundo numero para somar: ");
                    int sum = Convert.ToInt32(Console.ReadLine());
                    int result1 = num1 + sum;
                    Console.WriteLine("Resultado: " + result1);
                    Console.ReadLine();
                    break;

                case "-":
                    Console.Write("Insere o segundo numero para subtrair: ");
                    int sub = Convert.ToInt32(Console.ReadLine());
                    int result2 = num1 - sub;
                    Console.WriteLine("Resultado: " + result2);
                    Console.ReadLine();
                    break;

                case "*":
                    Console.Write("Insere o segundo numero para multiplicar: ");
                    int mul = Convert.ToInt32(Console.ReadLine());
                    int result3 = num1 * mul;
                    Console.WriteLine("Resultado: " + result3);
                    Console.ReadLine();
                    break;

                case "/":
                    Console.Write("Insere o segundo numero para dividir: ");
                    int div = Convert.ToInt32(Console.ReadLine());
                    int result4 = num1 / div;
                    Console.WriteLine("Resultado: " + result4);
                    Console.ReadLine();
                    break;

                default:
                    Console.Write("Operador incorreto");
                    Console.ReadLine();
                    break;
            }
        }

    }
}