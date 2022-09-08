using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoSOLID.ConsoleApp.LSP.Solucao
{
    public static class CalculoArea
    {
        private static void ObterArea(Pararelogramo pararelogramo)
        {
            Console.Clear();
            var nomeForma = ObterNomeFormaGeometrica(pararelogramo);
            Console.WriteLine($"Cálculo da área do {nomeForma}");
            Console.WriteLine();
            Console.WriteLine(pararelogramo.Altura + " * " + pararelogramo.Largura);
            Console.WriteLine();
            Console.WriteLine(pararelogramo.Area);
        }

        private static string ObterNomeFormaGeometrica(Pararelogramo pararelogramo)
        {
            if (pararelogramo is Retangulo)
                return "Retângulo";

            if (pararelogramo is Quadrado)
                return "Quadrado";

            return "";
        }

        public static void CalcularAreaQuadrado()
        {
            var quadrado = new Quadrado(10, 10);

            ObterArea(quadrado);
        }

        public static void CalcularAreaRetangulo()
        {
            var quadrado = new Retangulo(10, 5);

            ObterArea(quadrado);
        }
    }
}
