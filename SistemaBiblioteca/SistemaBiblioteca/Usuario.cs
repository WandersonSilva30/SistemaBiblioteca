namespace SistemaBiblioteca
{
    public class Usuario : Entidade
    {
        public string nome { get; set; } = "Novo Usuário";
        public string telefone { get; set; } = "";
        public string endereco { get; set; } = "";
        public string email { get; set; } = "";
        public bool banido { get; set; } = false;
    }
}