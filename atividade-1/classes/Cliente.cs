class Cliente {
    private string _nome;
    public string Nome => _nome;

    private string _cpf;
    public string Cpf => _cpf; 

    public Cliente (string nome, string cpf) {
        this._nome = nome;
        this._cpf = cpf;
    }
}