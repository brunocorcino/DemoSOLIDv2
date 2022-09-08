namespace DemoSOLID.ConsoleApp.OCP.SolucaoExtensionsMethods
{
    public class CaixaEletronico
    {
        public string Debitar()
        {
            var debitoConta = new DebitoConta
            {
                NumeroConta = "12345",
                Valor = 150
            };

            var opcaoDigitada = 1;

            return opcaoDigitada switch
            {
                1 => debitoConta.DebitarContaCorrente(),
                2 => debitoConta.DebitarContaInvestimento(),
                3 => debitoConta.DebitarContaPoupanca(),
                _ => null,
            };
        }
    }
}
