namespace DemoSOLID.ConsoleApp.DIP.Solucao.Interfaces
{
    public interface IEmailService
    {
        void Enviar(string de, string para, string assunto, string mensagem);
    }
}
