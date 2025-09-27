using System;

class Program
{
    static void Main()
    {
        // Entrada do primeiro número
        Console.Write("Digite o primeiro número: ");
        double numero1 = double.Parse(Console.ReadLine());

        // Entrada do segundo número
        Console.Write("Digite o segundo número: ");
        double numero2 = double.Parse(Console.ReadLine());

        // Operações
        double soma = numero1 + numero2;
        double subtracao = numero1 - numero2;
        double multiplicacao = numero1 * numero2;

        // Saída dos resultados
        Console.WriteLine("\n--- Resultados ---");
        Console.WriteLine("Soma: " + soma);
        Console.WriteLine("Subtração: " + subtracao);
        Console.WriteLine("Multiplicação: " + multiplicacao);
    }
}
