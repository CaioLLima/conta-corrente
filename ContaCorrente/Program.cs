using System.Drawing;

namespace ContaCorrente
{
    

    public class ContaCorrente
    {
        public int id;
        public double saldoDisponivel;
        public double limiteDebito;
        public Movimentacao[] movimentacoes;

        public double Sacar(int valor)
        {
            double resultado = saldoDisponivel -= valor;
            return resultado;
        }
        public double Depositar(int valor)
        {
            double resultado = saldoDisponivel += valor;
            return resultado;
        }
        public void Consultar()
        {
            Console.WriteLine($"O saldo atual da sua conta é de : {saldoDisponivel}");
        }
        public void TransferirPara(ContaCorrente conta, int valor)
        {
            saldoDisponivel -= valor;
            conta.saldoDisponivel += valor;
        }

       /* public void Movimentacao1()
        {
            movimentacoes = new Movimentacao[10];

            for(int i =0; i < contadorMov; i++)
            { 
                    Console.WriteLine($"{i+1} movimentação é {movimentacoes[i]}");  
            }
        }*/

        public void Extrato()
        {
            for (int i = 0; i < movimentacoes.Length; i++)
            {
                Console.WriteLine($"{i + 1} movimentação é {movimentacoes[i]}");
            }
        }
        
    }

    public class Movimentacao
    {
        public double credito;
        public double debito;

        public string Credito()
        {
            return "tste";
        }
    }
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

            conta1.TransferirPara(conta2, 300);

            Console.WriteLine("Teste de transferencia");
            conta1.Consultar();
            conta2.Consultar();

            conta1.Extrato();
            Console.ReadLine();
        }
    }
}
