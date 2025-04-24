using System.Drawing;

namespace ContaCorrente
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Atividade 08 - Conta Corrente ");

            ContaCorrente conta1 = new ContaCorrente();

            conta1.saldoDisponivel = 1000;
            conta1.id = 12;
            conta1.limiteDebito = 0;
            conta1.movimentacoes = new Movimentacao[10];

            conta1.Sacar(300);
            conta1.Depositar(200);
            conta1.Sacar(100);
            conta1.Depositar(500);
            conta1.Sacar(600);
            conta1.Depositar(1200);
            conta1.Consultar();


            ContaCorrente conta2 = new ContaCorrente();

            conta2.saldoDisponivel = 1000;
            conta2.id = 13;
            conta2.limiteDebito = 0;
            conta2.movimentacoes = new Movimentacao[10];

            conta1.TransferirPara(conta2, 300);

            conta1.ExibirExtrato();

            Console.WriteLine("");
            conta2.ExibirExtrato();
            Console.ReadLine();
        }
    }
}
