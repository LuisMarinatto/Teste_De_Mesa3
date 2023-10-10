using System;
namespace Ex1
{
    class valorPresente
    {
        private double valorInicial;
        private double taxaJuros;

        public valorPresente(double valorInicial, double taxaJuros)
        {
            this.valorInicial = valorInicial;
            this.taxaJuros = taxaJuros;
        }
        public double getValorInicial(double periodo)
        {
            double saldo = valorInicial * Math.Pow(1 + taxaJuros / 100, periodo);

            return saldo;
        }
    }
    class Program
    {

        static void Main(string[] args)
        {
            Console.WriteLine("insira o valor inicial");
            double valorInicial = double.Parse(Console.ReadLine());

            Console.WriteLine("insira a taxa de juros");
            double taxaJuros = double.Parse(Console.ReadLine());

            Console.WriteLine("insira a quantidade de meses"); //pode usar de exemplo o 8,3 e afins...
            double periodo = double.Parse(Console.ReadLine());

            valorPresente tabMes = new valorPresente(valorInicial, taxaJuros);

            double saldo = tabMes.getValorInicial(periodo);

            Console.WriteLine($"seu saldo total é {saldo.ToString("c")}");
        }

    }
}