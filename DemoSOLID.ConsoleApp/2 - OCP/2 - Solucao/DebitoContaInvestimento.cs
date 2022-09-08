namespace DemoSOLID.ConsoleApp.OCP.Solucao
{
    public class DebitoContaInvestimento : DebitoConta
    {
        public override string Debitar(decimal valor, string conta)
        {
            // * Isentar taxas *
            // * Debita conta investimento *
            return FormatarTransacao();
        }
    }
}
