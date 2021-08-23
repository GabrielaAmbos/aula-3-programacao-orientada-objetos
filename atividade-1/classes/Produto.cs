class Produto {
    private string _descricao;
    public string Descricao => _descricao;

    private double _preco;
    public double Preco => _preco;

    private int _estoque;
    public int Estoque => _estoque;

    private string _sku;
    public string Sku => _sku;

    public Produto (string descricao, double preco, int estoque, string sku) {
        this._descricao = descricao;
        this._preco = preco;
        this._estoque = estoque;
        this._sku = sku;
    }

}