namespace DemoSOLID.ConsoleApp.OCP.SolucaoExtensionsMethods
{
    public static class DebitoContaCorrente
    {
        public static string DebitarContaCorrente(this DebitoConta debitoConta)
        {
            // * Debita da Conta Corrente *
            return debitoConta.FormatarTransacao();
        }
    }
}
