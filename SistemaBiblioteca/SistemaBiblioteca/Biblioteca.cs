namespace SistemaBiblioteca
{
    public class Biblioteca
    {
        public List<Livro> livros = new List<Livro>();
        public List<Usuario> usuarios = new List<Usuario>();
        public List<Emprestimo> emprestimos = new List<Emprestimo>();

        public void cadastrarLivro()
        {
            Livro novoLivro = new Livro();
            if (livros.Count == 0)
                novoLivro.id = 1;
            else
                novoLivro.id = livros.Max(q => q.id) + 1;

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine("---------- Adicionando novo Livro ----------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nDigite o nome do Autor: ");
            novoLivro.autor = Console.ReadLine();
            Console.Write("Digite o Título da Obra: ");
            novoLivro.titulo = Console.ReadLine();
            Console.Write("Digite a edição do volume: ");
            novoLivro.edicao = Console.ReadLine();
            Console.Write("Digite o ano de publicação: ");
            novoLivro.anoPublicacao = int.Parse(Console.ReadLine());
            Console.Clear();

            Console.BackgroundColor = ConsoleColor.Green;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.WriteLine(" -------- Informações de Localização --------");
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.Write("\nDigite o número do corredor: ");
            novoLivro.corredor = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da estante: ");
            novoLivro.estante = int.Parse(Console.ReadLine());
            Console.Write("Digite o número da prateleira: ");
            novoLivro.prateleira = int.Parse(Console.ReadLine());

            livros.Add(novoLivro);
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\nNovo Livro adicionado com sucesso!\n");
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine("Pressione qualquer tecla para retornar ao Menu...");
            Console.ReadKey();
        }
    }
}