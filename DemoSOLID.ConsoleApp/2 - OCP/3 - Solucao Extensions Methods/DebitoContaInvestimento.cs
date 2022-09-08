namespace DemoSOLID.ConsoleApp.OCP.SolucaoExtensionsMethods
{
    public static class DebitoContaInvestimento
    {
        public static string DebitarContaInvestimento(this DebitoConta debitoConta)
        {
            // * Isentar taxas *
            // * Debita conta investimento *
            return debitoConta.FormatarTransacao();
        }
    }
}
