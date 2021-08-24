namespace aula_3_programacao_orientada_objetos.atividade_3
{
    public class Livro
    {
        private string _autor;
        public string Autor => _autor;

        private int _ano;
        public int Ano => _ano;

        private string _nomeDoLivro;
        public string NomeDoLivro => _nomeDoLivro;

        private string _editora;
        public string Editora => _editora;

        public Livro(string autor, int ano, string nomeDoLivro, string editora) {
            this._autor = autor;
            this._ano = ano;
            this._nomeDoLivro = nomeDoLivro;
            this._editora = editora;
        }
        
    }
}