using DemoSOLID.ConsoleApp.ISP.Solucao.Interfaces;

namespace DemoSOLID.ConsoleApp.ISP.Solucao
{
    public class CadastroCliente : ICadastroCliente
    {
        public void ValidarDados()
        {
            // * Validar CPF, Email, etc *
        }

        public void SalvarBanco()
        {
            // * Salva na tabela Clientes *
        }

        public void EnviarEmail()
        {
            // * Envia e-mail para o cliente *
        }
    }
}
