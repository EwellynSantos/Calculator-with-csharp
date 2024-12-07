using System;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {  
            Calcular();
        }

        static void Calcular()
        {
            Console.Clear();

            Console.WriteLine("**************** Calculadora ******************");

            Console.WriteLine("Insira a operação (+, -, *, /): ");
            var operacao = Console.ReadLine();

            Console.WriteLine("Primeiro valor: ");
            float valor1 = float.Parse(Console.ReadLine() ?? "0");

            Console.WriteLine("Segundo valor: ");
            float valor2 = float.Parse(Console.ReadLine() ?? "0");

            switch(operacao)
            {
                case "+":
                    Console.WriteLine($"Resultado: {valor1 + valor2}");
                    break;
                case "-":
                    Console.WriteLine($"Resultado: {valor1 - valor2}");
                    break;
                case "*":
                    Console.WriteLine($"Resultado: {valor1 * valor2}");
                    break;
                case "/":
                    if (valor1 == 0 || valor2 == 0){
                        Console.WriteLine("Erro: Divisão por zero!");
                    } else {
                        Console.WriteLine($"Resultado: {valor1 / valor2}");
                    }
                    break;
                default:
                    Console.WriteLine("Operação inválida!");
                    break;
            }
        }
    }    
}