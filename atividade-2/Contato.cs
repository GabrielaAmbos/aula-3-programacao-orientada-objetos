namespace aula_3_programacao_orientada_objetos.atividade_2
{
    public class Contato
    {
        private string _nome;
        public string Nome => _nome;

        private string _sobrenome;
        public string Sobrenome => _sobrenome;

        private string _numero;
        public string Numero => _numero;

        public Contato(string nome, string sobrenome, string numero)
        {
            this._nome = nome;
            this._sobrenome = sobrenome;
            this._numero = numero;
        }



    }
}