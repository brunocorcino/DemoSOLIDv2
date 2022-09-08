namespace DemoSOLID.ConsoleApp.OCP.Solucao
{
    public class DebitoContaPoupanca : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // * Valida aniversário da conta *
            // * Debita conta poupança *
            return FormatarTransacao();
        }
    }
}
