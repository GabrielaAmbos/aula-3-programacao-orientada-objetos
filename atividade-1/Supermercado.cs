using System;

class Supermercado {
 //   static void Main(string[] args) {
   //     ColocaEstoqueNoSupermercado();
  //      PedirDadosDoCliente();
        //VisualizarProdutos();



        

//    }

    static void ColocaEstoqueNoSupermercado() {
        Produto leite = new Produto("Leite UHT Integral Integral 1L", 6.99, 100, "a1b1c1d1e1f1g1");
        Produto azeite = new Produto("Azeite de Oliva 500ml", 22.9, 90, "225388400");
        Produto molhoTomate = new Produto("Molho de Tomate Tradicional", 2.39, 80, "225388900");

        
    }

    static void PedirDadosDoCliente() {
        Console.WriteLine("Bem-Vindo! \nInforme seu nome e seu cpf para continuar: \nNome: ");
        string nomeDoCliente = Console.ReadLine();
        Console.WriteLine("Cpf: ");
        string cpfDoCliente = Console.ReadLine();
        Cliente cliente = new Cliente(nomeDoCliente, cpfDoCliente);
    }

    public void VisualizarProdutos() {
        Console.WriteLine("Deseja visualizar os produtos disponiveis? \n1-Sim \n2-Nao");
        int opcao = Convert.ToInt32(Console.ReadLine());
        switch(opcao) {
            case 1:
                Console.WriteLine("As opções de produto são: \n");
                break;
            case 2: 

                break;

        }
    }
}