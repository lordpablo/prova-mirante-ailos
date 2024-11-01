namespace Questao1
{
    class ContaBancaria
    {
        public ContaBancaria(int conta, string titular, double saldo = 0)
        {
            this.Conta = conta;
            this.Titular = titular;
            this.Saldo = saldo;
        }
        public int Conta { get; set; }
        public string Titular { get; set; }
        public double Saldo { get; set; }

        public void Deposito(double valor)
        {
            this.Saldo += valor;
        }
        public void Saque(double valor)
        {
            this.Saldo -= (valor + 3.5);
        }

        public string InfoConta()
        {
            return $"Conta: {this.Conta}, Titular: {this.Titular}, Saldo: R$ {string.Format("{0:0.00}", this.Saldo)}";
        }
    }
}
