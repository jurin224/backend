namespace Caixa
{
    public class ContaCorrente
    {
        public string titular { get; set; }
        public decimal saldo { get; set; }

        public ContaCorrente(string titular)
        {
            this.titular = titular;
        }
        public void VerSaldo()
        {
            Console.WriteLine($"Seu Saldo é de {saldo}");
        }

        public void Depositar(decimal valor)
        {
            saldo += valor;
            Console.WriteLine($"Voce depositou R${valor}");

        }

        public void Retirar(decimal valor)
        {
            if (valor <= 0 || valor > saldo)
            {
                Console.WriteLine("Você não possui esse valor");
            }
            else
            {
                saldo -= valor;
                Console.WriteLine($"Seu saldo é {saldo}");
            }

            

        }

    }
}