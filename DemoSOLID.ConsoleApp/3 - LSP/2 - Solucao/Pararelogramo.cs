namespace DemoSOLID.ConsoleApp.LSP.Solucao
{
    public abstract class Pararelogramo
    {
        protected Pararelogramo(int altura, int largura)
        {
            Altura = altura;
            Largura = largura;
        }

        public double Altura { get; }
        public double Largura { get; }
        public double Area => Altura * Largura;
    }
}
