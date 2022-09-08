namespace DemoSOLID.ConsoleApp.OCP.Violacao
{
    public class DebitoConta
    {
        // Caso surja um novo tipo de conta, terá de modificar o comportamento da classe.
        public void Debitar(decimal valor, string conta, TipoConta tipoConta)
        {
            if (tipoConta == TipoConta.Corrente)
            {
                // * Debita da conta corrente *
            }

            if (tipoConta == TipoConta.Poupanca)
            {
                // * Valida aniversário da conta *
                // * Debita da conta poupança *
            }
        }
    }
}
