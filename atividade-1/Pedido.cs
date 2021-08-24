class Pedido {
    private Produto _produto;
    public Produto Produto => _produto;

    private int _quantidade;
    public int Quantidade => _quantidade; 


    public void FazPedido(Produto produto, int quantidade) {
        this._produto = produto;
        this._quantidade = quantidade;
    }

}