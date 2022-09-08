namespace DemoSOLID.ConsoleApp.DIP.Violacao
{
    public class Cliente
    {
        public int ClienteId { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public DateTime DataCadastro { get; set; }

        public bool Validar() => ValidarEmail() && ValidarCpf();

        public bool ValidarEmail() => Email.Contains("@");

        public bool ValidarCpf() => Cpf.Length == 11;
    }
}
