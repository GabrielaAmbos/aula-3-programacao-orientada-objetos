namespace aula_3_programacao_orientada_objetos.atividade_3
{
    public class FichaDeEmpretimo
    {
        private Livro _livro;
        private Cliente _cliente;

        private string _dataEmprestimo;

        private bool _estaDisponivelParaReserva;
        public bool EstaDisponivelParaReserva => _estaDisponivelParaReserva;
        public string DataEmprestimo => _dataEmprestimo;

        public FichaDeEmpretimo (Livro livro, Cliente cliente, string dataDeEmprestimo, bool estaDisponivelParaReserva) {
            this._livro = livro;
            this._cliente = cliente;
            this._dataEmprestimo = dataDeEmprestimo;
            this._estaDisponivelParaReserva = estaDisponivelParaReserva;
        }

        public void ReservarLivro(Livro livro) {

        }

        public void CadastrarNovoCliente(Cliente cliente) {

        }

        public void ExcluirCliente(string nomeDoCliente) {

        }

        public void ConsultarReservaDeLivro(string nomeDoLivro) {

        }

        
    }
}