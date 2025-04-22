using System.Drawing;

namespace ContaCorrente
{
    public class ContaCorrente
    {
        public int id;
        public double saldoDisponivel;
        public double limiteDebito;

        public double Saque(int valor)
        {
            double resultado = limiteDebito -= valor;
            return resultado;
        }
        public double Deposito(int valor)
        {
            double resultado = limiteDebito += valor;
            return resultado;
        }
        public double Consulta()
        {
            return saldoDisponivel;
        }
        public double Extrato()
        {
            return 10;
        }
        public void TransferirPara(ContaCorrente conta, int valor)
        {
            conta.saldoDisponivel = + valor;
        }

        public double Movimentacoes()
        {
            return 10;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 08 - Conta Corrente ");
        }
    }
}
