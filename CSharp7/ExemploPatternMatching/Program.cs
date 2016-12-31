using System;

namespace ExemploPatternMatching
{
    class Program
    {
        public static void ExibirInformacoesCotacao(Cotacao cotacao)
        {
            double valorCotacao = 0;
            if (cotacao is CotacaoDolar dolar)
                valorCotacao = dolar.ValorComercial;
            else if (cotacao is CotacaoEuro euro)
                valorCotacao = euro.ValorCotacao;

            Console.WriteLine(new String('-', 40));
            Console.WriteLine($"Data: {cotacao.DataCotacao:dd/MM/yyyy}");
            Console.WriteLine($"Sigla: {cotacao.SiglaMoeda}");
            Console.WriteLine($"Moeda: {cotacao.NomeMoeda}");
            Console.WriteLine($"Valor: {valorCotacao:0.0000}");
        }

        static void Main(string[] args)
        {
            CotacaoDolar dolar = new CotacaoDolar();
            dolar.DataCotacao = new DateTime(2016, 12, 09);
            dolar.ValorComercial = 3.3729;
            dolar.ValorTurismo = 3.5600;
            ExibirInformacoesCotacao(dolar);

            CotacaoEuro euro = new CotacaoEuro();
            euro.DataCotacao = new DateTime(2016, 12, 09);
            euro.ValorCotacao = 3.5710;
            ExibirInformacoesCotacao(euro);

            Console.ReadKey();
        }
    }
}