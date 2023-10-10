using System;

namespace Ex2
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
        public double Rendimentos(double periodo, double saque)
        {
            double saldo = 0;
            for(int i = 0; i < periodo; i++)
            {
                if(i == 4)
                {
                    saldo = saldo - saque;
                    valorInicial = saldo;
                    
                    
                }
                saldo = valorInicial * Math.Pow(1 + (taxaJuros / 100), i);
            }
            if(periodo%10 > 0)
            {
                saldo += (valorInicial * Math.Pow(1 + (taxaJuros / 100), periodo%10 )) - valorInicial;
            }
            return saldo;
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

                double saldo = tabMes.Rendimentos(periodo, saque);

                Console.WriteLine($"seu saldo total é {saldo.ToString("c")}");
            }
        }
    }
}
