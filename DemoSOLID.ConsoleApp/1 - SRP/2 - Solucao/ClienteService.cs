namespace DemoSOLID.ConsoleApp.SRP.Solucao
{
    public class ClienteService
    {
        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            var repo = new ClienteRepository();
            repo.AdicionarCliente(cliente);

            EmailService.Enviar("bruno@empresa.net", cliente.Email, "Bem vindo.", "Parabéns, você está cadastrado!");

            return "Cliente cadastrado com sucesso";
        }
    }
}
