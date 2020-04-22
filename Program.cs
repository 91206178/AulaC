using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, resultado = 0;
            string op;

            Console.WriteLine("Numero 1:");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Operacao: [x,/,-,+]");
            op = Console.ReadLine();

            Console.WriteLine("Numero 2");
            num2 = int.Parse(Console.ReadLine()); 

            switch (op)
            {

                case "x": 
                    resultado = (num1 * num2);
                    break;

                case "/":
                    resultado = (num1 / num2);
                    break;

                case "-":
                    resultado = (num1 - num2);
                    break;

                case "+":
                    resultado = (num1 + num2);
                    break;
                default:

                    Console.WriteLine("Operação Invalida!");
                    break; 

            }
            Console.WriteLine(num1 + " " + op + " " + num2 + " =" + resultado); 

            Console.ReadKey(); 

        }
    }
}
