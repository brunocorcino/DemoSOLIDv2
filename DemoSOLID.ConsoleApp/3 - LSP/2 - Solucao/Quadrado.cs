namespace DemoSOLID.ConsoleApp.LSP.Solucao
{
    public class Quadrado : Pararelogramo
    {
        public Quadrado(int altura, int largura) : base(altura, largura)
        {
            if (largura != altura)
                throw new ArgumentException("Os dois lados do quadrado precisam ser iguais");
        }
    }
}
