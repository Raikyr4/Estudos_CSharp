
namespace POO
{
    class ContaCorrente
    {
        // Membros da classe
        public string Titular;
        public string Conta;
        public int NumeroAgencia;
        public string NomeAgencia;
        public double Saldo;

        // Construtor
        public ContaCorrente(string titular, string conta, int numeroAgencia, string nomeAgencia, double saldoInicial)
        {
            Titular = titular;
            Conta = conta;
            NumeroAgencia = numeroAgencia;
            NomeAgencia = nomeAgencia;
            Saldo = saldoInicial;
        }

        // Método para realizar um depósito
        public void Depositar(double valor)
        {
            Saldo += valor;
            //para usar a interpolação de strings devemos usar a sintaxe a baico
            //:C formata o valor como uma moeda. 
            // devemos sempre colocar entre {} o nome da variavel que será interpolada
            Console.WriteLine($"Depósito de {valor:C} realizado. Novo saldo: {Saldo:C}");
        }

        // Método para realizar varios depósitos de uma vez
        // para esse metodo podemos passar uma quantidade ideterminada de valores 
        // usamos a sintaxe params para que isso seja possível
        public void VariosDepositos(params double[] valores)
        {
            for (int i = 0; i < valores.Length; i++)
            {
                Saldo += valores[i];

                Console.WriteLine($"Depósito de {valores[i]:C} realizado. Novo saldo: {Saldo:C}");
            }
        }

        // Método para realizar um saque
        public void Sacar(double valor)
        {
            if (valor > Saldo)
            {
                Console.WriteLine("Saldo insuficiente para realizar o saque.");
            }
            else
            {
                Saldo -= valor;
                Console.WriteLine($"Saque de {valor:C} realizado. Novo saldo: {Saldo:C}");
            }
        }

        // Método para exibir informações da conta
        public void ExibirInformacoes()
        {
            Console.WriteLine($"Titular: {Titular}");
            Console.WriteLine($"Número da Conta: {Conta}");
            Console.WriteLine($"Número da Agência: {NumeroAgencia}");
            Console.WriteLine($"Nome da Agência: {NomeAgencia}");
            Console.WriteLine($"Saldo: {Saldo:C}");
        }
    }
}
