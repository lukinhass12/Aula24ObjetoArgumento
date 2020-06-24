using System;

namespace Aula24ObjetoArgumento
{
    class Program
    {
        static void Main(string[] args)
        {
            Carrinho cart = new Carrinho();

            Produto p1 = new Produto(1, "The last of us", 200.00f);
            Produto p2 = new Produto(2, "Watch Dogs", 30.00f);
            Produto p3 = new Produto(3, "Dota 2", 0.00f);
            Produto p4 = new Produto(4, "Tomb Raider", 20.00f);
            Produto p5 = new Produto(5, "Far Cry Primal", 50.00f);
            
            cart.Adicionar(p1);
            cart.Adicionar(p2);
            cart.Adicionar(p3);
            cart.Adicionar(p4);
            cart.Adicionar(p5);

            cart.Deletar(p3);

            Produto prodAlterado = new Produto(4, "CyberPunk 2077", 150.00f);
            cart.Alterar(4, prodAlterado);

            cart.Ler();
            cart.MostrarTotal();
        }
    }
}
