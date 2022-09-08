namespace DemoSOLID.ConsoleApp.OCP.Solucao
{
    public class DebitoContaCorrente : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // * Debita da Conta Corrente *
            return FormatarTransacao();
        }
    }
}
