using System;

namespace Ex3
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
        public void Rendimentos(double periodo, double saque)
        {
            double saldo = 0, saldoLiq = 0;

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"| {"Valor Presente".PadLeft(14)} | {"Taxa de Juros",13} | {"Mes",3} | {"Saque de Rendimento".PadLeft(19)} | {"Saldo Liquido Restante".PadLeft(23)} | {"Rendimento Restante".PadLeft(20)} |");
            for (int i = 0; i < periodo; i++)
            {
                if (i == 4)
                {
                    saldo = saldo - saque;
                    valorInicial = saldo;
                    saldoLiq = valorInicial * Math.Pow(1 + (taxaJuros / 100), i+1) - valorInicial;

                }

                saldoLiq = valorInicial * Math.Pow(1 + (taxaJuros / 100), i + 1) - valorInicial;
                saldo = valorInicial * Math.Pow(1 + (taxaJuros / 100), i);
                Console.WriteLine($"| {valorInicial.ToString("c").PadLeft(14)} | {taxaJuros,13} | {i + 1,3} | {saque.ToString("c").PadLeft(19)} | {saldoLiq.ToString("c").PadLeft(23)} | {saldo.ToString("c").PadLeft(20)} |".PadLeft(14));
            }
            if (periodo % 10 > 0)
            {
                saldoLiq = valorInicial * Math.Pow(1 + (taxaJuros / 100), periodo%10) - valorInicial;
                saldo += (valorInicial * Math.Pow(1 + (taxaJuros / 100), periodo % 10)) - valorInicial;
            }

        }

        class program
        {
            static void Main(String[] args)
            {
                Console.WriteLine("insira o valor inicial");
                double valorInicial = double.Parse(Console.ReadLine());

                Console.WriteLine("insira a taxa de juros");
                double taxaJuros = double.Parse(Console.ReadLine());

                Console.WriteLine("insira a quantidade de meses"); //pode usar de exemplo o 8,3 e afins...
                double periodo = double.Parse(Console.ReadLine());

                valorPresente tabMes = new valorPresente(valorInicial, taxaJuros);

                Console.WriteLine("quanto você deseja sacar?");
                double saque = double.Parse(Console.ReadLine());

                

                tabMes.Rendimentos(periodo, saque);
            }
        }
    }
}