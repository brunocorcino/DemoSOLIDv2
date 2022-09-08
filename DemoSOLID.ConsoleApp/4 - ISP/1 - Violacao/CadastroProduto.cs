namespace DemoSOLID.ConsoleApp.ISP.Violacao
{
    public class CadastroProduto : ICadastro
    {
        public void ValidarDados()
        {
            // * Valida o valor do produto *
        }

        public void SalvarBanco()
        {
            // * Salva na tabela Produtos *
        }

        public void EnviarEmail()
        {
            // Produto não tem e-mail
            // Obrigado a implementar por herdar de interface genérica.
            throw new NotImplementedException("Esse médoto não serve para nada");
        }
    }
}
