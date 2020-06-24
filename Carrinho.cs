using System;
using System.Collections.Generic;

namespace Aula24ObjetoArgumento
{
    public class Carrinho
    {
        public Carrinho(float valorTotal) 
        {
            this.ValorTotal = valorTotal;
               
        }

        public Carrinho()
        {
        }

        public float ValorTotal { get; set; }
        List<Produto> carrinho = new List<Produto>();
        public void Adicionar(Produto _prod){
            carrinho.Add(_prod);
        }
        public void Deletar(Produto _p){
            carrinho.Remove(_p);
        }
        public void Ler(){
            foreach(Produto item in carrinho)
            System.Console.WriteLine($" {item.Nome} - R$ {item.Preco} Reais ");
        }
        public void Alterar(int _cod, Produto _ProdutoAlterado){
            carrinho.Find(z => z.Codigo == _cod).Nome = _ProdutoAlterado.Nome;
            carrinho.Find(z => z.Codigo == _cod).Preco = _ProdutoAlterado.Preco;
        }
        public void MostrarTotal(){
            foreach(Produto item in carrinho){
               ValorTotal += item.Preco;
            }
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine($"Valor total da compra: R$ {ValorTotal}" );
            Console.ResetColor();
        }


    }
}