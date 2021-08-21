class Produto {
    private string Descricao {get; set;}

    private double Preco {get; set;}

    private int Estoque {get; set;}

    private string Sku {get; set;}

    public Produto (string descricao, double preco, int estoque, string sku) {
        this.Descricao = descricao;
        this.Preco = preco;
        this.Estoque = estoque;
        this.Sku = sku;
    }

    public int RetornaEstoqueDisponivel(string sku) {
        var estoqueDisponivel = 0;
        if(sku == this.Sku) {
            estoqueDisponivel = this.Estoque;
        }
        return estoqueDisponivel;
    }
}