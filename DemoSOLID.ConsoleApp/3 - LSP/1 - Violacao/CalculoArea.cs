namespace DemoSOLID.ConsoleApp.LSP.Violacao
{
    public static class CalculoArea
    {
        private static void ObterAreaRetangulo(Retangulo ret)
        {
            Console.Clear();
            Console.WriteLine("Cálculo da área do Retangulo");
            Console.WriteLine();
            Console.WriteLine(ret.Altura + " * " + ret.Largura);
            Console.WriteLine();
            Console.WriteLine(ret.Area);
        }

        public static void Calcular()
        {
            var quad = new Quadrado
            {
                Altura = 10,
                Largura = 5
            };

            ObterAreaRetangulo(quad);
        }
    }
}
