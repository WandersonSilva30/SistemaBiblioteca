namespace SistemaBiblioteca
{
    public class Livro : Entidade
    {
        public string titulo { get; set; } = "Novo Livro";
        public string autor { get; set; } = "Autor";
        public string edicao { get; set; } = "Primeira Edição";
        public int corredor { get; set; } = 1;
        public int estante { get; set; } = 1;
        public int prateleira { get; set; } = 1;
        public int anoPublicacao { get; set; }
        public bool disponivel { get; set; } = true;
        public bool destruido { get; set; } = false;
    }
}