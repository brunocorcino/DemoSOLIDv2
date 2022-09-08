namespace DemoSOLID.ConsoleApp.ISP.Solucao.Interfaces
{
    public interface ICadastroCliente : ICadastro
    {
        void ValidarDados();
        void EnviarEmail();
    }
}
