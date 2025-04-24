namespace ContaCorrente
{
    public class Movimentacao
    {
        public string descricao;
        public string tipo;
        public double valor;
  
        public string LerMovimentacao()
        {
            return $"{tipo} - {valor.ToString("C2")}";
        }
    }
}
