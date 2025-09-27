using System;
using System.Globalization;

class Program
{
    static void Main()
    {
        CultureInfo culture = CultureInfo.InvariantCulture;

        // Dados da Alemanha
        Console.Write("Digite o preço da viagem para Alemanha: ");
        double precoAlemanha = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        Console.Write("Digite a quantidade de pessoas que irão para Alemanha: ");
        int pessoasAlemanha = int.Parse(Console.ReadLine());

        // Dados de Portugal
        Console.Write("Digite o preço da viagem para Portugal: ");
        double precoPortugal = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        Console.Write("Digite a quantidade de pessoas que irão para Portugal: ");
        int pessoasPortugal = int.Parse(Console.ReadLine());

        // Dados da Itália
        Console.Write("Digite o preço da viagem para Itália: ");
        double precoItalia = double.Parse(Console.ReadLine().Replace(",", "."), culture);

        Console.Write("Digite a quantidade de pessoas que irão para Itália: ");
        int pessoasItalia = int.Parse(Console.ReadLine());

        // Calcula o valor total por destino
        double totalAlemanha = precoAlemanha * pessoasAlemanha;
        double totalPortugal = precoPortugal * pessoasPortugal;
        double totalItalia = precoItalia * pessoasItalia;

        // Calcula o valor total geral
        double totalGeral = totalAlemanha + totalPortugal + totalItalia;

        // Exibe os resultados
        Console.WriteLine("\n--- Valores Totais ---");
        Console.WriteLine("Total Alemanha: R$ " + totalAlemanha.ToString("F2", new CultureInfo("pt-BR")));
        Console.WriteLine("Total Portugal: R$ " + totalPortugal.ToString("F2", new CultureInfo("pt-BR")));
        Console.WriteLine("Total Itália: R$ " + totalItalia.ToString("F2", new CultureInfo("pt-BR")));
        Console.WriteLine("Valor total da viagem (todos os destinos): R$ " + totalGeral.ToString("F2", new CultureInfo("pt-BR")));
    }
}
