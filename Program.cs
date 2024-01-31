
namespace POO
{
    class Program
    {
        static void Main()
        {
            ContaCorrente minhaConta = new ContaCorrente("João", "123456", 789, "Agência Central", 1000.00);

            minhaConta.ExibirInformacoes(); // Exibir informações iniciais

            minhaConta.Depositar(500.00);   // Realizar um depósito

            minhaConta.Sacar(200.00);       // Realizar um saque

            minhaConta.ExibirInformacoes(); // Exibir informações após operações

            Console.ReadLine();
        }
    }
}
