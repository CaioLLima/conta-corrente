namespace ContaCorrente
{
    public class ContaCorrente
    {
        public int id;
        public double saldoDisponivel;
        public double limiteDebito;
        public Movimentacao[] movimentacoes;
        public int contador = 0;

        public void Sacar(int valor)
        {
            if (valor < saldoDisponivel + limiteDebito)
            {
                saldoDisponivel -= valor;

                Movimentacao novaMovimentacao = new Movimentacao();

                novaMovimentacao.valor = valor;

                novaMovimentacao.tipo = "Débito";

                movimentacoes[contador] = novaMovimentacao;
                contador++;

            }
        }
        public void Depositar(int valor)
        {
            saldoDisponivel += valor;

            Movimentacao novaMovimentacao = new Movimentacao();

            novaMovimentacao.valor = valor;

            novaMovimentacao.tipo = "Crédito";

            movimentacoes[contador] = novaMovimentacao;
            contador++;

        }
        public void Consultar()
        {
            Console.WriteLine($"O saldo atual da sua conta é de : {saldoDisponivel}");
        }
        public void TransferirPara(ContaCorrente conta, int valor)
        {
            conta.Depositar(valor);
            this.Sacar(valor);
        }

        public void ExibirExtrato()
        {
            Console.WriteLine($"O extrato da conta #{id}");

            for (int i = 0; i < movimentacoes.Length; i++)
            {
                Movimentacao movimentacaoAtual = movimentacoes[i];

                if(movimentacaoAtual!= null)
                {
                    Console.WriteLine(movimentacaoAtual.LerMovimentacao());
                }
            }
        }
        
    }
}
