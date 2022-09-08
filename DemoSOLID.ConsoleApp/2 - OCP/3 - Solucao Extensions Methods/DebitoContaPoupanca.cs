namespace DemoSOLID.ConsoleApp.OCP.SolucaoExtensionsMethods
{
    public static class DebitoContaPoupanca
    {
        public static string DebitarContaPoupanca(this DebitoConta debitoConta)
        {
            // * Valida aniversário da conta *
            // * Debita conta poupança *
            return debitoConta.FormatarTransacao();
        }
    }
}
