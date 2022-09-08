using DemoSOLID.ConsoleApp.DIP.Solucao.Interfaces;

namespace DemoSOLID.ConsoleApp.DIP.Solucao
{
    public class ClienteService : IClienteService
    {
        private readonly IClienteRepository _clienteRepository;
        private readonly IEmailService _emailServices;

        public ClienteService(IClienteRepository clienteRepository, IEmailService emailServices)
        {
            _clienteRepository = clienteRepository;
            _emailServices = emailServices;
        }

        public string AdicionarCliente(Cliente cliente)
        {
            if (!cliente.Validar())
                return "Dados inválidos";

            _clienteRepository.AdicionarCliente(cliente);

            _emailServices.Enviar("bruno@empresa.net", cliente.Email, "Bem vindo.", "Parabéns, você está cadastrado!");

            return "Cliente cadastrado com sucesso";
        }
    }
}
