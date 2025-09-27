using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        // Entrada do preço do litro da gasolina
        Console.Write("Digite o preço do litro da gasolina: ");
        double precoLitro = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        // Entrada da quantidade de litros vendidos
        Console.Write("Digite a quantidade de litros vendidos: ");
        double litrosVendidos = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        // Calcula o valor total
        double total = precoLitro * litrosVendidos;

        // Exibe o resultado formatado com 2 casas decimais
        Console.WriteLine("\nO cliente deverá pagar: R$ " + total.ToString("F2", new CultureInfo("pt-BR")));
    }
}
