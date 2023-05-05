using System;

public class Produto
{
    private String Nome;        //Propriedades como privada, para atuar na própria classe
    private Decimal Preco;
    private Int32 Estoque;
    private Int32 EstoqueMinimo;

    public Produto() { }   //Construtor padrão

    public Produto(String nome, Decimal preco, Int32 estoque, Int32 estoqueMinimo)
    {
        this.Nome = nome;
        this.Preco = preco;
        this.Estoque = estoque;
        this.EstoqueMinimo = estoqueMinimo;
    }

    public Decimal calcularCapitallmobilizado()
    {
        return Preco * Estoque;
    }

    public Int32 reporEstoque(Int32 quantidade)
    {
        Estoque += quantidade;
        return Estoque;
    }
    public String tNome  //Metodo get para Nome, para a classe program puder chamar minha variavel "Nome".
    {
         get { return Nome; }
    }

  public Int32 tEstoque{
    get { return Estoque; }
  }

    public Int32 retirarEstoque(Int32 quantidade)
    {
        if (Estoque - quantidade < 0)
        {
            throw new ArgumentException("Quantidade de estoque insuficiente");
        }

        Estoque -= quantidade;

        if (Estoque <= EstoqueMinimo)
        {
            Console.WriteLine("Alerta: estoque abaixo do mínimo estipulado");
        }

        return Estoque;

      
    }
 }