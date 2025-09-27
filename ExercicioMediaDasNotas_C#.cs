using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        // Lê as 4 notas
        Console.Write("Digite a primeira nota: ");
        double nota1 = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        Console.Write("Digite a segunda nota: ");
        double nota2 = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        Console.Write("Digite a terceira nota: ");
        double nota3 = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        Console.Write("Digite a quarta nota: ");
        double nota4 = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        // Calcula a média
        double media = (nota1 + nota2 + nota3 + nota4) / 4;

        // Exibe a média formatada com 2 casas decimais
        Console.WriteLine("\nA média das notas é: " + media.ToString("F2", new CultureInfo("pt-BR")));
    }
}
