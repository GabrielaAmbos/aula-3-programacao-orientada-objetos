namespace aula_3_programacao_orientada_objetos.atividade_3
{
    public class Cliente
    {
        private string _nome;
        public string Nome => _nome;

        private string _telefone;
        public string Telefone => _telefone;

        private string _endereco;
        public string Endereco => _endereco;

        public Cliente (string nome, string telefone, string endereco) {
            this._nome = nome;
            this._telefone = telefone;
            this._endereco = endereco;
        }
        
    }
}